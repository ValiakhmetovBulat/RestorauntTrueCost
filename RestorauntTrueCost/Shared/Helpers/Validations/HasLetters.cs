using System.ComponentModel.DataAnnotations;

namespace RestorauntTrueCost.Shared.Helpers.Validations
{
    public class HasLetters : ValidationAttribute
    {
        private int _amountOfLetters;

        public HasLetters(int amountOfLetters = 1)
            : base("{0} must contatin at least " + amountOfLetters + (amountOfLetters == 1 ? " letter" : " letters"))
        {
            _amountOfLetters = amountOfLetters;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            int countLetters = 0;

            if (value == null)
            {
                return ValidationResult.Success;
            }

            var textValue = value.ToString();

            foreach (var i in textValue)
            {
                if (Char.IsLetter(i))
                {
                    countLetters++;
                }
            }

            if (countLetters >= _amountOfLetters)
            {
                return ValidationResult.Success;
            }

            var errorMessage = FormatErrorMessage(validationContext.DisplayName);
            return new ValidationResult(errorMessage);
        }
    }
}
