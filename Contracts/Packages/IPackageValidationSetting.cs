using HL7Data.Models.Types;

namespace HL7Data.Contracts.Packages
{
    public interface IPackageValidationSetting
    {
        bool IgnoreAllValidations { get; set; }
        ValidationSetting MaximumLength { get; set; }
        ValidationSetting MinimumLength { get; set; }
        ValidationSetting RequiredField { get; set; }
        ValidationSetting TableValueLookup { get; set; }
    }
}