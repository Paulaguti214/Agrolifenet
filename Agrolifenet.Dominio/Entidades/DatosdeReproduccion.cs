namespace Agrolifenet.Dominio.Entidades
{
    public class DatosdeReproduccion
    {
        public int IdDatosdeReproduccion { get; set; }
        public int IdTipodeReproduccion { get; set; }
        public int IdReproducctorDatosdeReproduccion { get; set; }
        public string ResultadodelaReproduccion { get; set; }
        public string ObservacionesDatosdeReproduccion { get; set; }
        public bool EstadoDatosdeReproduccion { get; set; }
        public DateTime FechadelprocesodeReproduccion { get; set; }
        public DateTime FechadecreaccionDatosdeReproduccion { get; set; }
        public DateTime FechademodificacionDatosdeReproduccion { get; set; }
        public DatosdeReproduccion(
            int idDatosdeReproduccion,
            int idTipodeReproduccion,
            int idReproductorDatosdeReproduccion,
            string resultadodelaReproduccion,
            string observacionesDatosdeReproduccion,
            bool estadoDatosdeReproduccion,
            DateTime fechadelprocesodeReproduccion,
            DateTime fechadecreacionDatosdeReproduccion,
            DateTime fechademodificacionDatosdeReproduccion)
        {
            IdDatosdeReproduccion = idTipodeReproduccion;
            IdTipodeReproduccion = idTipodeReproduccion;
            IdReproducctorDatosdeReproduccion = idReproductorDatosdeReproduccion;
            ResultadodelaReproduccion = resultadodelaReproduccion;
            ObservacionesDatosdeReproduccion = observacionesDatosdeReproduccion;
            EstadoDatosdeReproduccion = estadoDatosdeReproduccion;
            FechadelprocesodeReproduccion = fechadelprocesodeReproduccion;
            FechadecreaccionDatosdeReproduccion = fechadecreacionDatosdeReproduccion;
            FechademodificacionDatosdeReproduccion = fechademodificacionDatosdeReproduccion;
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
            return false;
        }
        public DatosdeReproduccion Buscar()
        {
            return new DatosdeReproduccion(default, default, default, default!, default!, default, default, default, default);
        }
        public List<DatosdeReproduccion> Listar(DatosdeReproduccion datosdeReproduccion)
        {
            return new List<DatosdeReproduccion>();
        }

    }
}
