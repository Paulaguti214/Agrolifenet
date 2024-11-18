namespace Agrolifenet.Dominio.Entidades
{
    public class HistorialClinico
    {
        public int IdHistorialClinico { get; set; }
        public DateTime FechadecreacionHistorialClinico { get; set; }
        public DateTime FechademodificacionHistorialClinico { get; set; }
        public bool EstadoHistorialClinico { get; set; }
        public string VacunaHistorialClinico { get; set; }
        public string TratamientoHistorialClinico { get; set; }
        public string EnfermedadesHistorialClinico { get; set; }
        public string ResultadodeExamenesHistorialClinico { get; set; }
        public string InformaciondesparacitacionHistorialClinico { get; set; }
        public int PesoalnacerHistorialClinico { get; set; }
        public int PesoactualHistorialClinico { get; set; }
        public int GananciadepesodiariaHistorialClinico { get; set; }
        public string ObservacionesHistorialClinico { get; set; }
        public string EstadodesaludHistorialClinico { get; set; }
        public int CostodeltratamientoHistorialClinico { get; set; }
        public int SeguimientoHistorialClinico { get; set; }
        public int NumerodepartosHistorialClinico { get; set; }
        public int IdGanado { get; set; }
        public int IdUsuario { get; set; }
        public int IdDatosdeReproduccion { get; set; }
    }
}
