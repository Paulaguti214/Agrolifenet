namespace Agrolifenet.Dominio.Entidades
{
    public class DetalledeVenta
    {
        public int IdDetalledeVenta { get; set; }
        public DateTime FechadecreacionDetalledeVenta { get; set; }
        public DateTime FechademodificacionDetalledeVenta { get; set; }
        public bool EstadoDetalledeVenta { get; set; }
        public int IdVentas { get; set; }
        public int IdGanado { get; set; }
        public DetalledeVenta(
            int idDetalledeVenta,
            DateTime fechadecreaccionDetalledeVenta,
            DateTime fechademodificacionDetalledeVenta,
            bool estadoDetalledeVenta,
            int idVentas,
            int idGanado)
        {
            IdDetalledeVenta = idDetalledeVenta;
            FechadecreacionDetalledeVenta = fechadecreaccionDetalledeVenta;
            FechademodificacionDetalledeVenta = fechademodificacionDetalledeVenta;
            EstadoDetalledeVenta = estadoDetalledeVenta;
            IdVentas = idVentas;
            IdGanado = idGanado;
        }
        public int Guardar()
        {
            return 0;
        }
        public bool Actualizar()
        {
            return false;
        }
        public bool Eliminar()
        {
            return true;
        }
        public DetalledeVenta Buscar()
        {
            return new DetalledeVenta(default, default, default, default, default, default);
        }
        public List<DetalledeVenta> Listar(DetalledeVenta detalledeVenta)
        {
            return new List<DetalledeVenta>();
        }
    }
}
