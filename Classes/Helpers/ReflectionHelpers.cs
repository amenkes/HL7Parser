using HL7Data.Classes.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using static HL7Data.Classes.Attributes.CustomAttributes;

namespace HL7Data.Classes.Helpers
{
    internal static class ReflectionHelpers
    {
        internal static dynamic ConvertValue(this object obj, Type type)
        {
            if (obj == null || type == null) return null;
            try
            {
                var result = Convert.ChangeType(obj, type);
                return result;
            }
            catch
            {
                return obj;
            }
        }
#if Unused
        internal static dynamic ConvertValue(this string data, Type type)
        {
            if (data == null || type == null) return null;
            return ConvertValue((object)data, type);
        }

        internal static string ExtractValueFromDefaultStringPositionAttribute(
                                    DefaultStringPositionAttribute attribute, string data)
        {
            Ensure.ArgumentNotNull(nameof(attribute), attribute);
            Ensure.ArgumentNotNullOrEmptyString(nameof(data), data);

            if (attribute.IsFixedLength)
            {
                if (attribute.StartIndex + attribute.Length > data.Length) return null; // TODO: Throw Exception?
                return data.Substring(attribute.StartIndex, attribute.Length);
            }

            //TODO : When variable length / multiple items
            return null;
        }
#endif
        internal static async Task<ICollection<PropertyInfo>> GetCombineOrderAttributePropertiesAsync(
            Type type, ICollection<PropertyInfo> exceptionList = null)
        {
            Ensure.ArgumentNotNull(nameof(type), type);

            return await Task.FromResult(type.PropertiesWithAttribute<CombineOrderAttribute>()
                .Except(exceptionList ?? new List<PropertyInfo>()).ToList());
        }
#if Unused
        internal static async Task<ICollection<PropertyInfo>> GetDefaultStringPositionAttributePropertiesAsync(Type type)
        {
            Ensure.ArgumentNotNull(nameof(type), type);

            return await Task.FromResult(type.PropertiesWithAttribute<DefaultStringPositionAttribute>()
                .FilterWriteable().ToList());
        }
#endif
        internal static async Task<int> GetIgnoreCount(IElement element)
        {
            Ensure.ArgumentNotNull(nameof(element), element);

            var type = element.GetType();
            var ignoreItems = type.PropertiesWithAttribute<IgnoreForPopulateAttribute>();
            var subset = ignoreItems.FilterWithOrder();
            var count = subset?.Count() ?? 0;

            if (element is ISegment) // since type is the first field on line, but is really not the property to set
                count += 1;

            return await Task.FromResult(count);
        }

        internal static bool HasInterface(object obj, Type type)
        {
            return obj != null && type != null && HasInterface(obj.GetType(), type);
        }

        internal static bool HasInterface(Type objecType, Type interfaceType)
        {
            return objecType != null && interfaceType != null &&
                   objecType.GetInterfaces().Where(λ => λ.IsGenericType)
                       .Any(λ => λ.GetGenericTypeDefinition() == interfaceType);
        }
    }
}