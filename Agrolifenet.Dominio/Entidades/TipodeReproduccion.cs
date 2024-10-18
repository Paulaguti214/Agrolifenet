namespace Agrolifenet.Dominio.Entidades
{
    public class TipodeReproduccion
    {
        public int IdTipodeReproduccion { get; set; }
        public string TiposdeReproduccion { get; set; }
        public bool EstadoTipodeReproduccion { get; set; }
        public DateTime FechadecreacionTipodeReproduccion { get; set; }
        public DateTime FechademodificacionTipodeReproduccion { get; set; }

        public TipodeReproduccion(
            int idTipodeReproduccion,
            string tiposdeReproduccion,
            bool estadoTipodeReproduccion,
            DateTime fechadecreacionTipodeReproduccion,
            DateTime fechademodificacionTipodeReproduccion)
        {
            IdTipodeReproduccion = idTipodeReproduccion;
            TiposdeReproduccion = tiposdeReproduccion;
            EstadoTipodeReproduccion = estadoTipodeReproduccion;
            FechadecreacionTipodeReproduccion = fechadecreacionTipodeReproduccion;
            FechademodificacionTipodeReproduccion = fechademodificacionTipodeReproduccion;
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
        public TipodeReproduccion Buscar()
        {
            return new TipodeReproduccion(default,default!,default,default,default);
        }
        public List <TipodeReproduccion> Listar (TipodeReproduccion tipodeReproduccion)
        {
            return new List<TipodeReproduccion>();
        }

    }
}
