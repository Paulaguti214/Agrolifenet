using System.ComponentModel.DataAnnotations;

namespace Agrolifenet.FrontEnd.Validadores
{
    public class FechaMaximaAttribute : ValidationAttribute
    {
        private readonly DateTime _fechaMaxima;

        public FechaMaximaAttribute(string? fechaMaxima = default!)
        {
            _fechaMaxima = fechaMaxima is null ? DateTime.Now : DateTime.Parse(fechaMaxima)!;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is DateTime dateValue)
            {
                if (dateValue > _fechaMaxima)
                {
                    return new ValidationResult($"La fecha no puede ser posterior a {_fechaMaxima.ToShortDateString()}.");
                }
            }
            return ValidationResult.Success!;
        }
    }
}
