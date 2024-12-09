namespace Agrolifenet.Dominio.Entidades
{

    public class Usuario
    {
        public int IdUsuario { get; set; }
        public int? IdentificacionUsuario { get; set; }
        public string NombreUsuario { get; set; } = string.Empty;
        public string ApellidoUsuario { get; set; } = string.Empty;
        public DateTime? FechadenacimientoUsuario { get; set; }
        public string CorreoelectronicoUsuario { get; set; } = string.Empty;
        public string NumerotelefonicoUsuario { get; set; } = string.Empty;
        public bool EstadoUsuario { get; set; }
        public DateTime FechadecreacionUsuario { get; set; }
        public DateTime Fechademodificacion { get; set; }
        public bool BloqueoUsuario { get; set; }
        public string UsuarioAsigando { get; set; } = string.Empty;
        public string Contrasenia { get; set; } = string.Empty;
    }
}