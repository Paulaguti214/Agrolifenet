using System.ComponentModel.DataAnnotations;

namespace Agrolifenet.FrontEnd.Modelos
{
    public class Login
    {
        [Required(ErrorMessage = "El usuario es obligatorio")]
        [MinLength(5, ErrorMessage = "El minimo 5 caracaters para el Usuario")]
        public string Usuario { get; set; }=string.Empty;

        [Required(ErrorMessage = "La Contraseña es obligatorio")]       
        public string Contrasenia { get; set; } = string.Empty;
    };
}
