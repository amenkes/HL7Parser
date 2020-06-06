using HL7Data.Classes.Conversion;
using HL7Data.Classes.ExtensionMethods;
using HL7Data.Classes.Helpers;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Models.Base;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using static HL7Data.Classes.Attributes.CustomAttributes;

namespace HL7Data.Services.Parsing
{
    internal static class ParsingService
    {
        /// <summary>
        ///     Executes the code to copy from Children in Generic elements into property values in concrete classes/objects
        /// </summary>
        /// <param name="element">The element (segment, field, etc) to update from the generic equivalent</param>
        /// <param name="truncate">
        ///     Whether to truncate text (default) where it exceeds max length of property. Otherwise, throw
        ///     error
        /// </param>
        /// <returns>Nothing. Populates (public) properties via reflection.</returns>
        internal static async Task PopulateDataAsync(IElement element, bool truncate = true)
        {
            if (element?.GenericReferenceElement == null) return;
            if (element is IPackage) return; // already handled
            await UpdateElements(element);
        }

        private static async Task UpdateElements(IElement element)
        {
            Ensure.ArgumentNotNull(nameof(element), element);

            var orderedPropertiesArray = await GetOrderedFilteredPropertyInfos(element);
            var models = await ConversionMethods.ConvertPropertyInfosToValidationModels(element, orderedPropertiesArray);
            await ProcessModels(element, models);
        }

        private static async Task ProcessModels(IElement element, IReadOnlyCollection<IPropertyValidation> propertyValidationModels)
        {
            var modelsArray = propertyValidationModels?.ToArray();

            var arrayOffset = await ReflectionHelpers.GetIgnoreCount(element);
            for (var i = 0; i < modelsArray?.Length; i++)
            {
                var model = modelsArray[i];
                var genericRootItem = element.GenericReferenceElement;

                var referenceDataArray = await GetChildren(genericRootItem);

                if (referenceDataArray == null) return; // all of same time, so return rather than continue
                if (i + arrayOffset >= referenceDataArray.Count) continue;
                var referencefGenericElement = referenceDataArray[i + arrayOffset];
                if (referencefGenericElement == null) continue;

                var castRepeat = referencefGenericElement as IHasGenericRepeatedItems;
                if (model.IsCollection && castRepeat?.GenericRepeatedItem != null)
                {
                    model.GenericReferenceElement = castRepeat.GenericRepeatedItem;
                    model.Value = castRepeat.GenericRepeatedItem.Children.ToList();
                }
                else
                {
                    model.Value = referencefGenericElement.Value;
                }

                HandleValidations(model);

                referencefGenericElement.ReferenceElement = element;
                if (!model.PropertyInfo.CanWrite) continue;

                model.GenericReferenceElement = referencefGenericElement;
                UpdatePropertyValues(element, model);
            }
        }

        private static async Task<IList<IGenericRootItem>> GetChildren(IGenericRootItem genericRootItem)
        {
            var childType = genericRootItem.GetType();
            // if first one fails, they all fail, so return rather than continue
            if (!ReflectionHelpers.HasInterface(childType, typeof(IHasChildren<>))) return null;
            var castChild = genericRootItem.ConvertValue(typeof(IHasChildren<>));
            var childItems = castChild.Children;
            if (childItems == null) return null;
            var rootItemList = new List<IGenericRootItem>();
            foreach (var childItem in childItems)
            {
                var child = childItem as IGenericRootItem;
                if (child != null)
                    rootItemList.Add(child);
            }
            return await Task.FromResult(rootItemList);
        }

        private static void HandleValidations(IPropertyValidation propertyValidationModel)
        {
            if (propertyValidationModel.Value != null && propertyValidationModel.MaxLength != null)
                if (propertyValidationModel.Value.ToString().Length > propertyValidationModel.MaxLength)
                    propertyValidationModel.Value = propertyValidationModel.Value.ToString().Substring(0, (int)propertyValidationModel.MaxLength);
        }

        private static async Task<PropertyInfo[]> GetOrderedFilteredPropertyInfos(IElement element)
        {
            var type = element.GetType();
            var orderedProperties = await ReflectionHelpers.GetCombineOrderAttributePropertiesAsync(type);
            var orderedPropertiesArray = orderedProperties.FilterIgnored()
                .OrderBy(λ => λ.GetCustomAttribute<CombineOrderAttribute>().Order).ToArray();
            return await Task.FromResult(orderedPropertiesArray);
        }

        internal static void UpdateReferences(IElement element, IGenericRootItem genericRootItem, bool forceUpdate = false)
        {
            if (element == null) return;
            if (element.GenericReferenceElement != null && !forceUpdate) return;
            element.GenericReferenceElement = genericRootItem;
            if (genericRootItem == null) return;
            genericRootItem.ReferenceElement = element;
        }

        private static void UpdatePropertyValues(object instance, IPropertyValidation propertyValidationModel)
        {
            Ensure.ArgumentNotNull(nameof(instance), instance);
            Ensure.ArgumentNotNull(nameof(propertyValidationModel), propertyValidationModel);

            // Check for collection first
            if (propertyValidationModel.IsCollection)
            {
                UpdateCollectionPropertyValues(instance, propertyValidationModel);
                return;
            }

            if (typeof(bool) == propertyValidationModel.PropertyInfo.PropertyType)
            {
                UpdateBoolPropertyValue(instance, propertyValidationModel);
                return;
            }
            if (propertyValidationModel.PropertyInfo.PropertyType.IsSimpleType())
            {
                UpdateSimpleTypePropertyValue(instance, propertyValidationModel);
                return;
            }
            if (typeof(Guid) == propertyValidationModel.PropertyInfo.PropertyType)
            {
                UpdateGuidPropertyValue(instance, propertyValidationModel);
                return;
            }
            if (typeof(DateTime) == propertyValidationModel.PropertyInfo.PropertyType)
            {
                UpdateDateTimePropertyValue(instance, propertyValidationModel);
                return;
            }

            // Property is probably interface.
            UpdateInterfacePropertyValue(instance, propertyValidationModel);
        }

        private static void UpdateBoolPropertyValue(object instance, IPropertyValidation propertyValidationModel)
        {
            UpdatePropertyValue(instance, propertyValidationModel.PropertyInfo, propertyValidationModel.Value.ToString().ToBoolean());
        }

        private static void UpdateCollectionPropertyValues(object instance, IPropertyValidation propertyValidationModel)
        {
            try
            {
                var collectionItem = propertyValidationModel.PropertyInfo.PropertyType.GetGenericArguments();
                var collectionType = collectionItem[0];
                var subtype = collectionType.UnderlyingSystemType;

                var listType = typeof(List<>);
                var constructedListType = listType.MakeGenericType(subtype);
                //var constructedType = ConversionMethods.GetConcreteClassFromInterface(Subtype);

                var instanceChild = (IList)Activator.CreateInstance(constructedListType);
                var data = propertyValidationModel.Value;

                // data is the list of Generic item (Field, Component, Subcomponenet, etc)
                // need too loop through each item, set each class, then assign the List<T> to the element/instance
                if (data is IList)
                {
                    var dataList = data as IList<IGenericRootItem>;
                    if (dataList != null)
                        foreach (var genericRootItem in dataList)
                            UpdateRepeatedItemList(instanceChild, subtype, genericRootItem);
                }
                else
                {
                    //This is a list of items, but only 1 item
                    if (ReflectionHelpers.HasInterface(propertyValidationModel.GenericReferenceElement, typeof(IHasChildren<>)))
                        UpdateRepeatedItemList(instanceChild, subtype, propertyValidationModel.GenericReferenceElement);
                }
                UpdatePropertyValue(instance, propertyValidationModel.PropertyInfo, instanceChild);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private static void UpdateRepeatedItemList(IList list, Type subtype, IGenericRootItem genericRootItem)
        {
            var constructedType = ConversionMethods.GetConcreteClassFromInterface(subtype);
            var element = constructedType as IElement;
            if (element == null) return;
            UpdateReferences(element, genericRootItem);
            list.Add(element);
        }

        private static void UpdateDateTimePropertyValue(object instance, IPropertyValidation propertyValidationModel)
        {
            var convertedValue = propertyValidationModel.GenericReferenceElement.Source.ToDateTimeFromFormat();
            UpdatePropertyValue(instance, propertyValidationModel.PropertyInfo, convertedValue);
        }

        private static void UpdateGuidPropertyValue(object instance, IPropertyValidation propertyValidationModel)
        {
            var convertedValue = new Guid(propertyValidationModel.GenericReferenceElement.Source);
            UpdatePropertyValue(instance, propertyValidationModel.PropertyInfo, convertedValue);
        }

        private static void UpdateInterfacePropertyValue(object instance, IPropertyValidation propertyValidationModel)
        {
            if (!propertyValidationModel.PropertyInfo.PropertyType.IsInterface) return;
            var anyClassImplementingInterface = ConversionMethods.GetConcreteClassFromInterface(propertyValidationModel.PropertyInfo);

            var anyClassAsElement = anyClassImplementingInterface as BaseElement;
            if (anyClassAsElement == null) return;

            UpdateReferences(anyClassAsElement, propertyValidationModel.GenericReferenceElement);
            propertyValidationModel.PropertyInfo.SetValue(instance, anyClassImplementingInterface);
        }

        private static void UpdateSimpleTypePropertyValue(object instance, IPropertyValidation propertyValidationModel)
        {
            if (string.IsNullOrEmpty(propertyValidationModel.Value.ToString()))
                UpdateStringPropertyValue(instance, propertyValidationModel);
            else
                UpdatePropertyValue(instance, propertyValidationModel.PropertyInfo, propertyValidationModel.Value);
        }

        private static void UpdateStringPropertyValue(object instance, IPropertyValidation propertyValidationModel)
        {
            object value = null;
            if (propertyValidationModel.PropertyInfo.PropertyType.IsValueType)
                value = Activator.CreateInstance(propertyValidationModel.PropertyInfo.PropertyType);
            propertyValidationModel.PropertyInfo.SetValue(instance, Convert.ChangeType(
                value, propertyValidationModel.PropertyInfo.PropertyType), null);
        }

        private static void UpdatePropertyValue(object instance, PropertyInfo propertyInfo, object value)
        {
            Ensure.ArgumentNotNull(nameof(instance), instance);
            Ensure.ArgumentNotNull(nameof(propertyInfo), propertyInfo);

            if (value == null) return;

            if (propertyInfo.PropertyType.IsSimpleType())
                propertyInfo.SetValue(instance, value);
            else if (propertyInfo.PropertyType.IsConvertible(value))
                try
                {
                    propertyInfo.SetValue(instance, Convert.ChangeType(value, propertyInfo.PropertyType), null);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            else
                try
                {
                    propertyInfo.SetValue(instance, value);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
        }

#if NotUsed
        private static IEnumerable<Exception> ValidateDataModel(IPropertyValidation dataModel)
        {
            var list = new List<Exception>();
            var required = ValidateDataModelRequired(dataModel);
            if (required != null)
                list.Add(required);

            var maxLength = ValidateDataModelMaxLength(dataModel);
            if (maxLength != null)
                list.Add(maxLength);

            var minLength = ValidateDataModelMinLength(dataModel);
            if (maxLength != null)
                list.Add(minLength);

            return list;
        }

        private static ApplicationExceptions.RequiredFieldIsNullException ValidateDataModelRequired(IPropertyValidation dataModel)
        {
            return dataModel.IsRequired && dataModel.Value == null ? new ApplicationExceptions.RequiredFieldIsNullException(dataModel.Name) : null;
        }

        private static ApplicationExceptions.MaximumLengthExceededException ValidateDataModelMaxLength(IPropertyValidation dataModel)
        {
            return dataModel.MaxLength != null && dataModel.Value?.ToString().Length > dataModel.MaxLength ? new ApplicationExceptions.MaximumLengthExceededException($"{dataModel.Name}:{dataModel.MaxLength}({dataModel.Value?.ToString().Length})") : null;
        }

        private static ApplicationExceptions.MinimumLengthNotReachedException ValidateDataModelMinLength(IPropertyValidation dataModel)
        {
            return dataModel.MinLength != null && dataModel.Value?.ToString().Length < dataModel.MinLength ? new ApplicationExceptions.MinimumLengthNotReachedException($"{dataModel.Name}:{dataModel.MinLength}({dataModel.Value?.ToString().Length})") : null;
        }
#endif
    }
}