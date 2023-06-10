using System.ComponentModel.DataAnnotations;

namespace RestorauntTrueCost.Shared.Helpers.Validations
{
    public class EqualsString : ValidationAttribute
    {
        private string _str;

        public EqualsString(string str)
            : base("{0} must be equal to " + str)
        {
            _str = str;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return ValidationResult.Success;
            }

            if (value is string str)
            {
                return ValidationResult.Success;
            }

            var errorMessage = FormatErrorMessage(validationContext.DisplayName);
            return new ValidationResult(errorMessage);
        }
    }
}
