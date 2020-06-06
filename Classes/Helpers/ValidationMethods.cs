using HL7Data.Contracts.Base;
using HL7Data.Exceptions.ApplicationExceptions;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HL7Data.Classes.Helpers
{
    internal static class ValidationMethods
    {
        #region Validation via Reflection and Properties / PropertyInfo

        internal static async Task<bool> ValidateObject(IReadOnlyCollection<IPropertyValidation> validationModels)
        {
            // Check Required Properties for null and for min/max lengths
            if (!ValidateRequiredProperties(validationModels))
                throw new ApplicationExceptions.RequiredFieldIsNullException();

            if (!ValidateMinimumLengthProperties(validationModels))
                throw new ApplicationExceptions.MinimumLengthNotReachedException();

            if (!ValidateMaximumLengthProperties(validationModels))
                throw new ApplicationExceptions.MinimumLengthNotReachedException();

            return await Task.FromResult(true); // If no error thrown, should be good to continue
        }

        internal static bool ValidateRequiredProperties(IReadOnlyCollection<IPropertyValidation> validationModels)
        {
            if (validationModels == null) return false;
            var errorList = validationModels.Where(λ => λ.IsRequired &&
                                                        (λ.Value == null ||
                                                         λ.IsCollection && ((ICollection) λ.Value).Count == 0))
                .ToList();
            if (errorList.Any())
                throw new ApplicationExceptions.RequiredFieldIsNullException(string.Join(",",
                    errorList.Select(λ => λ.Name)));

            return true;
        }

        internal static bool ValidateMinimumLengthProperties(IReadOnlyCollection<IPropertyValidation> validationModels)
        {
            if (validationModels == null) return false;
            var errorList = validationModels
                .Where(λ => λ.MinLength != null &&
                            (λ.MinLength > λ.Value?.ToString().Length || λ.Value == null && λ.IsRequired)).ToList();
            var collectionList =
                validationModels.Where(λ => λ.IsCollection && (λ.IsRequired && λ.Value == null || λ.MinLength != null));
            foreach (var propertyValidationModel in collectionList)
            {
                var list = propertyValidationModel.Value as ICollection;
                if (list == null || list.Count == 0)
                    errorList.Add(propertyValidationModel);
                else
                    foreach (var item in list)
                        if (item.ToString().Length < propertyValidationModel.MinLength)
                            errorList.Add(propertyValidationModel);
            }

            if (errorList.Any())
                throw new ApplicationExceptions.MinimumLengthNotReachedException(string.Join(",",
                    errorList.Select(λ => λ.Name)));

            return true;
        }

        internal static bool ValidateMaximumLengthProperties(IReadOnlyCollection<IPropertyValidation> validationModels)
        {
            if (validationModels == null) return false;
            var errorList = validationModels
                .Where(λ => λ.MaxLength != null &&
                            (λ.MaxLength < λ.Value?.ToString().Length || λ.Value == null && λ.IsRequired)).ToList();
            var collectionList =
                validationModels.Where(λ => λ.IsCollection && (λ.IsRequired && λ.Value == null || λ.MaxLength != null));
            foreach (var propertyValidationModel in collectionList)
            {
                var list = propertyValidationModel.Value as ICollection;
                if (list == null || list.Count == 0)
                    errorList.Add(propertyValidationModel);
                else
                    foreach (var item in list)
                        if (item.ToString().Length > propertyValidationModel.MaxLength)
                            errorList.Add(propertyValidationModel);
            }

            if (errorList.Any())
                throw new ApplicationExceptions.MaximumLengthExceededException(string.Join(",",
                    errorList.Select(λ => λ.Name)));

            return true;
        }

        #endregion Validation via Reflection and Properties / PropertyInfo
    }
}