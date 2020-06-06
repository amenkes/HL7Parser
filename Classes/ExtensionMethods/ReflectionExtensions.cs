using HL7Data.Classes.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace HL7Data.Classes.ExtensionMethods
{
    internal static class ReflectionExtensions
    {
        internal static IEnumerable<PropertyInfo> GetAllProperties(this Type type)
        {
            Ensure.ArgumentNotNull(nameof(type), type);
            return type.GetProperties(BindingFlags.Instance | BindingFlags.Public);
        }

        internal static IEnumerable<PropertyInfo> PropertiesWithAttribute<T>(this Type type) where T : Attribute
        {
            Ensure.ArgumentNotNull(nameof(type), type);
            return type.GetProperties().Where(λ => Attribute.IsDefined(λ, typeof(T)));
        }

        internal static PropertyInfo GetPropertyInfoByName(this ICollection<PropertyInfo> propertyCollection,
            string propertyName)
        {
            Ensure.ArgumentNotNull(nameof(propertyCollection), propertyCollection);
            Ensure.ArgumentNotNullOrEmptyString(nameof(propertyName), propertyName);

            return propertyCollection.FirstOrDefault(
                λ => propertyName.Equals(λ.Name, StringComparison.CurrentCultureIgnoreCase));
        }

        //TODO: break up into smaller methods doing individual tasks
        internal static IDictionary<string, ICollection<string>> PropertyNamesWithAttribute<T>(
            this Type type, string filterByPropertyName = null, object filteredPropertyValue = null,
            bool ignoreMissingProperty = true) where T : Attribute
        {
            Ensure.ArgumentNotNull(nameof(type), type);

            var props = type.PropertiesWithAttribute<T>().ToList();

            var filteredProps = new List<PropertyInfo>();
            if (string.IsNullOrWhiteSpace(filterByPropertyName))
                filteredProps = props;
            else
                foreach (var propertyInfo in props)
                {
                    var value = propertyInfo.GetCustomAttributeNamedArgumentValueByName(filterByPropertyName);
                    if (ignoreMissingProperty)
                    {
                        if (value == null)
                            filteredProps.Add(propertyInfo);
                    }
                    else
                    {
                        if (value != filteredPropertyValue)
                            filteredProps.Add(propertyInfo);
                    }
                }

            var list = new Dictionary<string, ICollection<string>>();
            foreach (var propertyInfo in filteredProps)
            {
                var name = propertyInfo.Name;
                var subList = new Collection<string>();
                var attrs = propertyInfo.CustomAttributes.Where(λ => λ.AttributeType == typeof(T)).ToList();
                var constructorArgs = attrs.Select(λ => λ.ConstructorArguments).ToList();
                foreach (var argList in constructorArgs)
                foreach (var argument in argList)
                {
                    var itemList = (ReadOnlyCollection<CustomAttributeTypedArgument>) argument.Value;
                    if (itemList.Count > 0)
                        foreach (var item in itemList)
                            subList.Add((string) item.Value);
                }
                list.Add(name, subList);
            }
            return list;
        }

        //TODO: Revisit. Might be simpler. .GetProperty(item)?.GetValue(propertyValue, null)
        internal static IReadOnlyCollection<CustomAttributeNamedArgument> GetCustomAttributeNamedArguments(
            this PropertyInfo propertyInfo)
        {
            Ensure.ArgumentNotNull(nameof(propertyInfo), propertyInfo);

            var results = propertyInfo.CustomAttributes.Select(λ => λ.NamedArguments).ToList();
            var resultList = new List<CustomAttributeNamedArgument>();
            foreach (var result in results)
                resultList.AddRange(result);
            return new ReadOnlyCollection<CustomAttributeNamedArgument>(resultList);
        }

        internal static object GetCustomAttributeNamedArgumentValueByName(this PropertyInfo propertyInfo, string name)
        {
            Ensure.ArgumentNotNull(nameof(propertyInfo), propertyInfo);
            Ensure.ArgumentNotNullOrEmptyString(nameof(name), name);

            if (string.IsNullOrWhiteSpace(name))
                return null;

            var result = propertyInfo.GetCustomAttributeNamedArguments()
                .FirstOrDefault(λ => λ.MemberName.Equals(name, StringComparison.CurrentCultureIgnoreCase));

            return result.TypedValue.Value;
        }

        internal static ICollection<CustomAttributeNamedArgument> GetCustomAttributesByNameFiltered(
            this PropertyInfo propertyInfo, string name, object value = null)
        {
            Ensure.ArgumentNotNull(nameof(propertyInfo), propertyInfo);

            var result = new Collection<CustomAttributeNamedArgument>();
            var namedArgList = propertyInfo.CustomAttributes.Select(λ => λ.NamedArguments).ToList();

            foreach (var argList in namedArgList)
            foreach (var arg in argList)
                if (arg.MemberName.Equals(name, StringComparison.CurrentCultureIgnoreCase))
                    if (value == null)
                    {
                        result.Add(arg);
                    }
                    else
                    {
                        if (arg.TypedValue.Value.Equals(value))
                            result.Add(arg);
                    }
            return result;
        }

        internal static bool IsDateTimeOffset(this Type type)
        {
            Ensure.ArgumentNotNull(nameof(type), type);

            return type == typeof(DateTimeOffset) || type == typeof(DateTimeOffset?);
        }

        internal static bool IsEnumeration(this Type type)
        {
            Ensure.ArgumentNotNull(nameof(type), type);

            return type.IsEnum;
        }

        internal static bool IsNullable(this Type type)
        {
            Ensure.ArgumentNotNull(nameof(type), type);

            return type.GetTypeInfo().IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>);
        }

        internal static Type GetTypeInfo(this Type type)
        {
            Ensure.ArgumentNotNull(nameof(type), type);

            return type;
        }

        internal static string GetMaxLengthString(this PropertyInfo propertyInfo, string value)
        {
            var maxlengthAttr = propertyInfo.GetCustomAttribute<MaxLengthAttribute>();
            return maxlengthAttr == null || maxlengthAttr.Length < value.Length
                ? value
                : value.Substring(0, maxlengthAttr.Length);
        }

        internal static bool IsSimpleType(this Type type)
        {
            return type != typeof(DateTime) && type != typeof(Guid) && (type.IsPrimitive || type.IsValueType || type == typeof(string));
        }

        internal static IEnumerable<Type> GetLoadableTypes(this Assembly assembly)
        {
            Ensure.ArgumentNotNull(nameof(assembly), assembly);

            try
            {
                return assembly.GetTypes();
            }
            catch (ReflectionTypeLoadException e)
            {
                return e.Types.Where(λ => λ != null);
            }
        }

        internal static bool IsConvertible(this Type conversionType, object value)
        {
            if (conversionType == null || value == null)
                return false;

            var convertible = value as IConvertible;
            return convertible != null;
        }
    }
}