using System.ComponentModel.DataAnnotations;

namespace RestorauntTrueCost.Shared.Helpers.Validations
{
    public class HasUpper : ValidationAttribute
    {
        private int _amountOfUppers;

        public HasUpper(int amountOfUppers = 1)
            : base("{0} must contatin at least " + amountOfUppers + " upper " + (amountOfUppers == 1 ? " letter" : " letters"))
        {
            _amountOfUppers = amountOfUppers;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            int countUppers = 0;

            if (value == null)
            {
                return ValidationResult.Success;
            }

            var textValue = value.ToString();

            foreach (var i in textValue)
            {
                if (Char.IsUpper(i))
                {
                    countUppers++;
                }
            }

            if (countUppers >= _amountOfUppers)
            {
                return ValidationResult.Success;
            }

            var errorMessage = FormatErrorMessage(validationContext.DisplayName);
            return new ValidationResult(errorMessage);
        }
    }
}
