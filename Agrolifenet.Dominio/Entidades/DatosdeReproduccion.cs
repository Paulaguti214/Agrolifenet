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

    }
}
