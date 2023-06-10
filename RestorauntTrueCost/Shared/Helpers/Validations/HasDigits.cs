using System.ComponentModel.DataAnnotations;

namespace RestorauntTrueCost.Shared.Helpers.Validations
{
    public class HasDigits : ValidationAttribute
    {
        private int _amountOfDigits;

        public HasDigits(int amountOfDigits = 1)
            : base("{0} must contatin at least " + amountOfDigits + (amountOfDigits == 1 ? " digit" : " digits"))
        {
            _amountOfDigits = amountOfDigits;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            int countDigits = 0;

            if (value == null)
            {
                return ValidationResult.Success;
            }

            var textValue = value.ToString();

            foreach (var i in textValue)
            {
                if (Char.IsDigit(i))
                {
                    countDigits++;
                }
            }

            if (countDigits >= _amountOfDigits)
            {
                return ValidationResult.Success;
            }

            var errorMessage = FormatErrorMessage(validationContext.DisplayName);
            return new ValidationResult(errorMessage);
        }
    }
}
