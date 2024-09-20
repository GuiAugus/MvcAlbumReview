using System.ComponentModel.DataAnnotations;

namespace MvcAlbumReview.Validations
{
    public class RatingValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is decimal rating)
            {
                if (rating < 0 || rating > 10)
                {
                    return new ValidationResult("Rating must be between 0 and 10.");
                }
                return ValidationResult.Success;
            }

            return new ValidationResult("Invalid Rating value.");
        }
    }
}