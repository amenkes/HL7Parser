using HL7Data.Contracts.Base;

namespace HL7Data.Contracts.Fields
{
    public interface IChannelCalibrationParameters : IBaseField
    {
        decimal SensitivityCorrectionFactor { get; set; }
        decimal Baseline { get; set; }
        decimal TimeSkew { get; set; }
    }
}