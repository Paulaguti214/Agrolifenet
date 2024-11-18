namespace Agrolifenet.Dominio.Entidades
{
    public class DetalledeTema
    {
        public int IdDetalledeTema { get; set; }
        public DateTime FechadecreacionDetalledeConsulta { get; set; }
        public DateTime FechademodificacionDetalledeConsulta { get; set; }
        public bool EstadoDetalledeTema { get; set; }
        public int IdTemadeConsulta { get; set; }
    }
}
