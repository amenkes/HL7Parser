using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using System.ComponentModel.DataAnnotations;
using HL7Data.Models.Types;
using static HL7Data.Classes.Attributes.CustomAttributes;

namespace HL7Data.Models.Fields
{
    public class ChannelCalibrationParameters : BaseField, IChannelCalibrationParameters
    {
        public override ElementDataType DataType => ElementDataType.CCP;

        [CombineOrder(Order = 1, Name = "CCP.1")]
        [MaxLength(6)]
        public decimal SensitivityCorrectionFactor { get; set; }

        [CombineOrder(Order = 2, Name = "CCP.2")]
        [MaxLength(6)]
        public decimal Baseline { get; set; }

        [CombineOrder(Order = 3, Name = "CCP.3")]
        [MaxLength(6)]
        public decimal TimeSkew { get; set; }
    }
}