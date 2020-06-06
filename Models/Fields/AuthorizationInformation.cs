using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;
using System.ComponentModel.DataAnnotations;
using static HL7Data.Classes.Attributes.CustomAttributes;
namespace HL7Data.Models.Fields
{
    public class AuthorizationInformation : BaseField, IAuthorizationInformation
    {
        public override ElementDataType DataType => ElementDataType.AUI;
        [CombineOrder(Order = 1, Name = "AUI.1")]
        [MaxLength(30)]
        public string AuthorizationNumber { get; set; }

        [CombineOrder(Order = 2, Name = "AUI.2")]
        [MaxLength(8)]
        public IDate Date { get; set; }

        [CombineOrder(Order = 3, Name = "AUI.3")]
        [MaxLength(199)]
        public string AuthorizationSource { get; set; }
    }

}