using System;
using System.Collections.Generic;

namespace HL7Data.Classes.Attributes
{
    public static class CustomAttributes
    {
        [AttributeUsage(AttributeTargets.Property)]
        public sealed class CombineOrderAttribute : Attribute
        {
            public int Order { get; set; }
            public string Name { get; set; }
        }

        [AttributeUsage(AttributeTargets.Property)]
        public sealed class RestrictToLookupAttribute : Attribute
        {
            public int TableId { get; set; }
            public bool IsStrictMatch { get; set; } = true;
            public ICollection<string> PartialMatchPrefixes { get; set; } = new List<string>();
        }

        [AttributeUsage(AttributeTargets.Property)]
        public sealed class DefaultStringPositionAttribute : Attribute
        {
            public bool IsFixedLength { get; set; } = false;
            public int Length { get; set; } = -1;
            public int StartIndex { get; set; }
        }

        [AttributeUsage(AttributeTargets.Property)]
        public sealed class IgnoreForPopulateAttribute : Attribute
        {
            public bool IsIgnored { get; set; } = true;
        }

        /// <summary>
        /// HL7 Standard documentation (Chapter 2 – Control, Section 2.5.3.4 )
        /// </summary>
        [AttributeUsage(AttributeTargets.Property)]
        public sealed class UsageOptionAttribute : Attribute
        {
            public PropertyUsage Usage { get; set; } = PropertyUsage.Optional;
            public enum PropertyUsage
            {
                Optional, // O
                Required, // R
                Conditional, // C - conditional on the trigger event or on some other field(s).
                NotUsed, // X
                BackwardsCompatibility, // B - left in for backward compatibility with previous versions of HL7
                Withdrawn // W
            }
        }
    }
}