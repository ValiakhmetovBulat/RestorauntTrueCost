using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace RestorauntTrueCost.Shared.Helpers.Validations
{
    public class EmailValidator : ValidationAttribute
    {
        public EmailValidator()
            : base("Email is not valid")
        {

        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return ValidationResult.Success;
            }

            Regex validateEmail = new Regex("^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$");
            var email = value.ToString();
            if (validateEmail.IsMatch(email))
            {
                return ValidationResult.Success;
            }
            else
            {
                var errorMessage = FormatErrorMessage(validationContext.DisplayName);
                return new ValidationResult(errorMessage);
            }
        }
    }
}
