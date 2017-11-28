using System;
using System.ComponentModel.DataAnnotations;

namespace LostintheWoods.Models.Validations
{
    public class DoubleAttributes: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            try 
            {
                Convert.ToDouble(value);
                return ValidationResult.Success;
            }
            catch (Exception)
            {
                return new ValidationResult("Needs to be a number");
            }
        }
    }
}