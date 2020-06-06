using HL7Data.Classes.ExtensionMethods;
using HL7Data.Classes.Helpers;
using HL7Data.Contracts.Base;
using HL7Data.Models.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using static HL7Data.Classes.Attributes.CustomAttributes;

namespace HL7Data.Classes.Conversion
{
    internal static class ConversionMethods
    {
        private static async Task<IReadOnlyCollection<IPropertyValidation>> ConvertPropertyInfoToValidationModelsAsync(IElement element)
        {
            return element == null
                ? null
                : await ConvertPropertyInfosToValidationModels(element, element.GetType().GetAllProperties());
        }

        internal static async Task<IReadOnlyCollection<IPropertyValidation>> ConvertPropertyInfosToValidationModels(
            IElement element, IEnumerable<PropertyInfo> propertyInfos)
        {
            var list = new Collection<IPropertyValidation>();

            foreach (var property in propertyInfos)
            {
                var model = new PropertyValidationModel
                {
                    IsCollection = IsCollection(element, property),
                    IsIgnored = IsIgnored(property),
                    IsRequired = IsRequired(property),
                    MaxLength = GetMaxLength(property),
                    MinLength = GetMinLength(property),
                    Name = property.Name,
                    Order = GetOrder(property),
                    PropertyInfo = property,
                    ReferenceElement = element,
                    GenericReferenceElement = element.GenericReferenceElement,
                    Type = property.PropertyType,
                    Value = property.GetValue(element, null)
                };

                list.Add(model);
            }
            return await Task.FromResult(new ReadOnlyCollection<IPropertyValidation>(list).OrderBy(λ => λ.Order ?? 0).ToList());
        }

        internal static bool IsCollection(object item, PropertyInfo propertyInfo)
        {
            var collectionType = typeof(ICollection<>);
            var isCollection = propertyInfo.PropertyType.IsGenericType && collectionType.IsAssignableFrom(propertyInfo.PropertyType.GetGenericTypeDefinition()) ||
                        propertyInfo.PropertyType.GetInterfaces().Any(λ => λ.IsGenericType && λ.GetGenericTypeDefinition() == collectionType);
            return isCollection;
        }

        private static bool IsIgnored(MemberInfo property)
        {
            return Attribute.IsDefined(property, typeof(IgnoreForPopulateAttribute));
        }

        private static bool IsRequired(MemberInfo property)
        {
            return Attribute.IsDefined(property, typeof(RequiredAttribute));
        }

        internal static int? GetMaxLength(MemberInfo property)
        {
            return Attribute.IsDefined(property, typeof(MaxLengthAttribute))
                ? ((MaxLengthAttribute) property.GetCustomAttribute(typeof(MaxLengthAttribute))).Length
                : (int?) null;
        }

        private static int? GetMinLength(MemberInfo property)
        {
            return Attribute.IsDefined(property, typeof(MinLengthAttribute))
                ? ((MinLengthAttribute) property.GetCustomAttribute(typeof(MinLengthAttribute))).Length
                : (int?) null;
        }

        private static int? GetOrder(MemberInfo property)
        {
            return Attribute.IsDefined(property, typeof(CombineOrderAttribute))
                ? ((CombineOrderAttribute) property.GetCustomAttribute(typeof(CombineOrderAttribute))).Order
                : (int?) null;
        }

        //internal static async Task<ICollection<string>> BuildOrderedCollection(IElement item)
        //{
        //    return await BuildOrderedCollection((object) item);
        //}

        //internal static async Task<ICollection<string>> BuildOrderedCollection(IGenericRootItem item)
        //{
        //    return await BuildOrderedCollection((object) item);
        //}

        internal static async Task<ICollection<string>> BuildOrderedCollection(IElement item)
        {
            if (item == null) return null;

            var orderedDataModels = await ConvertPropertyInfoToValidationModelsAsync(item);
            var orderedData = new ReadOnlyCollection<IPropertyValidation>(orderedDataModels.FilterNoOrder().FilterIgnored().ToList());

            if (!await ValidationMethods.ValidateObject(orderedData)) return null;

            var collection = new Collection<string>();

            // Add required and optional values based on Build Order

            foreach (var dataModel in orderedData)
            {
                if (!dataModel.IsRequired && dataModel.Value == null) continue;
                if (dataModel.IsCollection && dataModel.GetType() == typeof(Collection<string>))
                {
                    var value = (Collection<string>) dataModel.Value;
                    collection.Add(value.ToRepeatString());
                }
                else
                {
                    collection.Add(dataModel.Value.ToString());
                }
            }
            return collection;
        }

        // Only to be used during reflection to create concrete object to fill values, then cast back to interface
        // so that the actual class instance is irrelevant. Otherwise, there could be the wrong class being used.
        internal static dynamic GetConcreteClassFromInterface(PropertyInfo propertyInfo)
        {
            if (!propertyInfo.PropertyType.IsInterface) return null; // limit to interfaces
            // get first concrete class that implements the interface.
            // It will be cast back to interface, so it doesn't matter which class
            // Must ignore System.Object or it will be selected as the first match!
            var anyImplementedClass =
                GetTypesFromInterface(propertyInfo.PropertyType.Assembly, propertyInfo.PropertyType).FirstOrDefault();
            if (anyImplementedClass == null) return null;

            var instance = Activator.CreateInstance(anyImplementedClass);
            return instance;
        }

        internal static dynamic GetConcreteClassFromInterface(Type interfaceType)
        {
            if (!interfaceType.IsInterface) return null;
            var anyImplementedClass =
                GetTypesFromInterface(interfaceType.Assembly, interfaceType.UnderlyingSystemType).FirstOrDefault();
            if (anyImplementedClass == null) return null;
            var instance = Activator.CreateInstance(anyImplementedClass);
            return instance;
        }

        private static IEnumerable<Type> GetTypesFromInterface(Assembly assembly, Type interfaceType)
        {
            return assembly.GetLoadableTypes()
                .Where(interfaceType.IsAssignableFrom)
                .Where(λ => !λ.IsAbstract && !λ.IsInterface).AsEnumerable();
        }
    }
}