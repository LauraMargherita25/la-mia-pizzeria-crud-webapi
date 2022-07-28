using System.ComponentModel.DataAnnotations;

namespace la_mia_pizzeria_static.Validetors
{
    public class TextLengthAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationcontext)
        {
            string fieldValue = (string) value;

            if (fieldValue == null || fieldValue.Trim().IndexOf(" ") == -1)
            {
                return new ValidationResult("Il campo deve contenere almeno due parole");
            }

            return ValidationResult.Success;
        }
    }
}
