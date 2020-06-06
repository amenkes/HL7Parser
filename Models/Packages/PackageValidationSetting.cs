using HL7Data.Contracts.Packages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Packages
{
    public class PackageValidationSetting : IPackageValidationSetting
    {
        public bool IgnoreAllValidations { get; set; } = false;
        public ValidationSetting MinimumLength { get; set; } = ValidationSetting.Ignore;
        public ValidationSetting MaximumLength { get; set; } = ValidationSetting.TruncateOrFill;
        public ValidationSetting RequiredField { get; set; } = ValidationSetting.ThrowException;
        public ValidationSetting TableValueLookup { get; set; } = ValidationSetting.Ignore;
    }
}
