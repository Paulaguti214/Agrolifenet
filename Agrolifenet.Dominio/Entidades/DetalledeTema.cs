namespace Agrolifenet.Dominio.Entidades
{
    public class DetalledeTema
    {
        public int IdDetalledeTema { get; set; }
        public DateTime FechadecreacionDetalledeConsulta { get; set; }
        public DateTime FechademodificacionDetalledeConsulta { get; set; }
        public bool EstadoDetalledeTema { get; set; }
        public int IdTemadeConsulta { get; set; }
        public DetalledeTema(
            int idDetalledeTema,
            DateTime fechadecreacionDetalledeConsulta,
            DateTime fechademodificacionDetalledeConsulta,
            bool estadoDetalledeConsulta,
            int idTemadeConsulta)
        {
            IdDetalledeTema = idDetalledeTema;
            FechadecreacionDetalledeConsulta = fechadecreacionDetalledeConsulta;
            FechademodificacionDetalledeConsulta = fechademodificacionDetalledeConsulta;
            EstadoDetalledeTema = estadoDetalledeConsulta;
            IdTemadeConsulta = idTemadeConsulta;
        }
        public int Guardar()
        {
            return 0;
        }
        public bool Actualizar()
        {
            return false;
        }
        public bool Elimar()
        {
            return true;
        }
        public DetalledeTema Buscar()
        {
            return new DetalledeTema(default, default, default, default, default);
        }
        public List<DetalledeTema> Listar(DetalledeTema detalledeTema)
        {
            return new List<DetalledeTema>();
        }
    }
}
