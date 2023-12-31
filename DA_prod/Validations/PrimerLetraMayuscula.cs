﻿using System.ComponentModel.DataAnnotations;

namespace DA_prod.Validations
{
    public class PrimerLetraMayuscula : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()))
            {
                return ValidationResult.Success;
            }

            string primeraLetra = value.ToString()[0].ToString();
            if (primeraLetra != primeraLetra.ToUpper())
            {
                return new ValidationResult("La primera letra debe ser mayuscula " + validationContext.DisplayName);
            }

            return ValidationResult.Success;
        }
    }
}
