using System.ComponentModel.DataAnnotations;

namespace RestorauntTrueCost.Shared.Helpers.Validations
{
    public class HasLower : ValidationAttribute
    {
        private int _amountOfLowers;

        public HasLower(int amountOfLowers = 1)
            : base("{0} must contatin at least " + amountOfLowers + " lower " + (amountOfLowers == 1 ? " letter" : " letters"))
        {
            _amountOfLowers = amountOfLowers;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            int countLowers = 0;

            if (value == null)
            {
                return ValidationResult.Success;
            }

            var textValue = value.ToString();

            foreach (var i in textValue)
            {
                if (Char.IsLower(i))
                {
                    countLowers++;
                }
            }

            if (countLowers >= _amountOfLowers)
            {
                return ValidationResult.Success;
            }

            var errorMessage = FormatErrorMessage(validationContext.DisplayName);
            return new ValidationResult(errorMessage);
        }
    }
}
