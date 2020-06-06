using HL7Data.Classes.Helpers;
using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using System.ComponentModel.DataAnnotations;
using static HL7Data.Classes.Attributes.CustomAttributes;
using static HL7Data.Constants;

namespace HL7Data.Models.Fields
{
    public class EncodingCharacters : BaseElement, IEncodingCharacters
    {
        public EncodingCharacters()
        {
        }

        public EncodingCharacters(string input)
        {
            Ensure.ArgumentNotNullOrEmptyString(nameof(input), input);

            if (input.Length != 4) return;
            ComponentSeparator = input.Substring(0, 1);
            RepetitionSeparator = input.Substring(1, 1);
            EscapeCharacter = input.Substring(2, 1);
            SubcomponentSeparator = input.Substring(3, 1);
        }

        [Required]
        [CombineOrder(Order = 1)]
        [MinLength(1)]
        [MaxLength(1)]
        [DefaultStringPosition(IsFixedLength = true, StartIndex = 0, Length = 1)]
        public string ComponentSeparator { get; set; } = ApplicationConstants.Defaults.ComponentSeparator;

        [Required]
        [CombineOrder(Order = 3)]
        [MinLength(1)]
        [MaxLength(1)]
        [DefaultStringPosition(IsFixedLength = true, StartIndex = 2, Length = 1)]
        public string EscapeCharacter { get; set; } = ApplicationConstants.Defaults.EscapeCharacter;

        [Required]
        [CombineOrder(Order = 2)]
        [MinLength(1)]
        [MaxLength(1)]
        [DefaultStringPosition(IsFixedLength = true, StartIndex = 1, Length = 1)]
        public string RepetitionSeparator { get; set; } = ApplicationConstants.Defaults.RepetitionSeparator;

        [Required]
        [CombineOrder(Order = 4)]
        [MinLength(1)]
        [MaxLength(1)]
        [DefaultStringPosition(IsFixedLength = true, StartIndex = 3, Length = 1)]
        public string SubcomponentSeparator { get; set; } = ApplicationConstants.Defaults.SubcomponentSeparator;

        public override string ToString()
        {
            return $"{ComponentSeparator}{RepetitionSeparator}{EscapeCharacter}{SubcomponentSeparator}";
        }
    }
}