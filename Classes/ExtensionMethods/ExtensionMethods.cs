using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using static HL7Data.Classes.Attributes.CustomAttributes;

namespace HL7Data.Classes.ExtensionMethods
{
    internal static class ExtensionMethods
    {
        private static readonly ICollection<string> PositiveList = new Collection<string> { "Y", "Yes", "T", "True", "1", "OK", "Okey Dokey", "Sure" };

        /// <summary>
        /// Takes the right N characters from a string
        /// </summary>
        /// <param name="data">The input string</param>
        /// <param name="length">How many characters to get (from the end of the string)</param>
        /// <returns></returns>
        internal static string Right(this string data, int length)
        {
            return data == null ? null : data.Length < length ? data : data.Substring(data.Length - length, length);
        }

        internal static string ToMessageDateTime(this DateTime dateTime)
        {
            return dateTime.ToString(Constants.ApplicationConstants.Defaults.DateTimeFormatString);
        }

        internal static string ToCombinedString(this ICollection<string> collection)
        {
            return collection.ToSeparatorString(string.Empty);
        }

        internal static string ToComponentSeparatorString(this ICollection<string> collection)
        {
            return collection.ToSeparatorString(
                Configuration.Configuration.ConfigurationData.Instance.ParsingData.EncodingCharacters.ComponentSeparator);
        }

        internal static string ToFieldSeparatorString(this ICollection<string> collection)
        {
            return collection.ToSeparatorString(
                Configuration.Configuration.ConfigurationData.Instance.ParsingData.FieldSeparator);
        }

        internal static string ToRepeatString(this ICollection<string> collection)
        {
            return collection.ToSeparatorString(
                Configuration.Configuration.ConfigurationData.Instance.ParsingData.EncodingCharacters.RepetitionSeparator);
        }

        internal static string ToSeparatorString(this ICollection<string> collection, string separator = null)
        {
            if (collection == null || !collection.Any()) return string.Empty;
            return string.Join(separator ??
                               Configuration.Configuration.ConfigurationData.Instance.ParsingData.FieldSeparator, collection);
        }

        internal static string[] ToSeparatorArray(
            this string data, string separator, StringSplitOptions options = StringSplitOptions.None)
        {
            var result = data.Split(new[] {separator}, options);
            if (result.Length == 0) return result;

            var trimmedArray = new string[result.Length];
            Parallel.For(0, result.Length, λ => trimmedArray[λ] = result[λ].Trim());
            return trimmedArray;
        }

        internal static ICollection<string> ToSeparatorCollection(
            this string data, string separator, StringSplitOptions options = StringSplitOptions.None)
        {
            return new Collection<string>(data.ToSeparatorArray(separator, options));
        }

        internal static T FirstDictionaryEntry<T>(this IDictionary<int, T> dictionary) where T : class
        {
            return dictionary.FirstOrDefault(λ => λ.Key == 1).Value;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1804:RemoveUnusedLocals", MessageId = "unused")]
        internal static T ToEnum<T>(this string value, bool ignoreCase = true,
            object defaultObjectInsteadOfException = null)
        {
            try
            {
                var unused = (T) Enum.Parse(typeof(T), value, ignoreCase);
            }
            catch (Exception e)
            {
                if (defaultObjectInsteadOfException != null)
                    return (T) defaultObjectInsteadOfException;
                Console.WriteLine(e);
                throw;
            }
            return (T) Enum.Parse(typeof(T), value, ignoreCase);
        }

        internal static IGenericRootItem GetElementByPosition(this IList<IGenericRootItem> elements, int position)
        {
            if (elements == null) return null;
            var children = elements;
            if (position == 0 || position > children.Count) return elements.FirstOrDefault(); //TODO: Throw exception?
            var itemAtPosition = elements[position];
            return itemAtPosition;
        }

        internal static IEnumerable<PropertyInfo> FilterWriteable(this IEnumerable<PropertyInfo> propertyInfoList)
        {
            return propertyInfoList.Where(λ => λ.CanWrite).ToList();
        }

        internal static IEnumerable<PropertyInfo> FilterNoOrder(this IEnumerable<PropertyInfo> propertyInfoList)
        {
            return propertyInfoList.Where(λ => λ.GetCustomAttribute<CombineOrderAttribute>()?.Order != 0).ToList();
        }

        internal static IEnumerable<PropertyInfo> FilterWithOrder(this IEnumerable<PropertyInfo> propertyInfoList)
        {
            return propertyInfoList.Where(λ => λ.GetCustomAttribute<CombineOrderAttribute>()?.Order > 0).ToList();
        }

        internal static IEnumerable<IPropertyValidation> FilterNoOrder(this IEnumerable<IPropertyValidation> propertyModels)
        {
            return propertyModels.Where(λ => λ.Order != null && λ.Order != 0).ToList();
        }

        /// <summary>
        /// Filters out properties from propertyvalidation model where the property has the attribute [IgnoreForPopulateAttribute]
        /// </summary>
        /// <param name="propertyInfoList">List of Propertyinfo items</param>
        /// <returns>A subset of the original list</returns>
        internal static IEnumerable<PropertyInfo> FilterIgnored(this IEnumerable<PropertyInfo> propertyInfoList)
        {
            return propertyInfoList.Where(λ => !λ.IsDefined(typeof(IgnoreForPopulateAttribute)) || !λ.GetCustomAttribute<IgnoreForPopulateAttribute>().IsIgnored).ToList();
        }

        /// <summary>
        /// Filters out properties from propertyvalidation model where the property has the attribute [IgnoreForPopulateAttribute]
        /// </summary>
        /// <param name="propertyModels"></param>
        /// <returns>A subset of the original list</returns>
        internal static IEnumerable<IPropertyValidation> FilterIgnored(this IEnumerable<IPropertyValidation> propertyModels)
        {
            return propertyModels.Where(λ => !λ.IsIgnored).ToList();
        }

        /// <summary>
        /// Splits a string into pieces by a subset of "chunksize"
        /// </summary>
        /// <param name="input">The input string</param>
        /// <param name="chunkSize">The subset size in which to break the string</param>
        /// <returns>A list of strings broken by each piece/chunk</returns>
        /// <example>"abcdef".Split(2) would return a list of 3 items: "ab", "cd", "ef"</example>
        /// <example>"abcdef".Split(3) would return a list of 2 items: "abc", "def"</example>
        internal static IList<string> Split(this string input, int chunkSize)
        {
            return Enumerable.Range(0, input.Length / chunkSize).Select(λ => input.Substring(λ * chunkSize, chunkSize)).ToList();
        }

        // Assumes all strings can be converted. Used by date/time in string format to date/time
        internal static int[] ToIntArray(this string[] inputArray)
        {
            var output = new int[inputArray.Length];
            Parallel.For(0, inputArray.Length, λ => { output[λ] = Convert.ToInt32(inputArray[λ]); });
            return output;
        }

        /// <summary>
        /// Converts a string of various lengths to the closest possible match of date and/or date/time
        /// </summary>
        /// <param name="input">A string with at least 6 numbers</param>
        /// <returns>A DateTime value based on the input string</returns>
        internal static DateTime ToDateTimeFromFormat(this string input)
        {
            if (input == null || input.Length < 6) return DateTime.Now;
            if (input.Length == 6)
            {
                var pieces = input.Split(2).ToArray().ToIntArray();
                return new DateTime(pieces[0], pieces[1], pieces[2]);
            }

            var year = Convert.ToInt32(input.Substring(0, 4));
            var rest = input.Substring(4, input.Length - 4).Split(2).ToArray().ToIntArray();

            var result = new DateTime(year, rest[0], rest[1], 0, 0, 0, 0);
            if (rest.Length > 2)
                result = result.AddHours(rest[2]);
            if (rest.Length > 3)
                result = result.AddMinutes(rest[3]);
            if (rest.Length > 4)
                result = result.AddSeconds(rest[4]);
            if (rest.Length > 5)
                result = result.AddMilliseconds(rest[5]);
            return result;
        }

        /// <summary>
        /// Checks a predefined list of "True" values and will return true if anything matches
        /// </summary>
        /// <param name="input">any string value</param>
        /// <returns>bool: match in list exists</returns>
        public static bool ToBoolean(this string input)
        {
            return input != null && PositiveList.Any(λ => λ.Equals(input, StringComparison.OrdinalIgnoreCase));
        }

        /// <summary>
        /// Extension method for IList to support AddRange rather than passing List as parameter
        /// </summary>
        /// <typeparam name="T">Generic type</typeparam>
        /// <param name="iList">The IList of items</param>
        /// <param name="listOfValues">The range of values to add</param>
        /// <returns>The updated list</returns>
        /// <remarks>Simply casts to List, does the .AddRange() and returns back the interface</remarks>
        public static IList<T> AddRange<T>(this IList<T> iList, IList<T> listOfValues)
        {
            var list = iList as List<T> ?? new List<T>();
            list.AddRange(listOfValues);
            return list;
        }
    }

}