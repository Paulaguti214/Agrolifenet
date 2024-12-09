using System.ComponentModel.DataAnnotations;

namespace Agrolifenet.FrontEnd.Modelos
{
    public class UsuarioDto
    {
        [Required(ErrorMessage = "el nombre es obligatorio")]
        public string NombreUsuario { get; set; } = string.Empty;
        [Required(ErrorMessage = "el apellido es obligatorio")]
        public string ApellidoUsuario { get; set; } = string.Empty;
        [Required(ErrorMessage = "el correo es obligatorio")]
        public string CorreoelectronicoUsuario { get; set; } = string.Empty;
        [Required(ErrorMessage = "el usuario es obligatorio")]
        [MinLength(5, ErrorMessage = "El minimo 5 caracaters para el Usuario")]
        public string Usuario { get; set; } = string.Empty;
        [Required(ErrorMessage = "la contrasenia es obligatorio")]
        public string Contrasenia { get; set; } = string.Empty;
    }
}
