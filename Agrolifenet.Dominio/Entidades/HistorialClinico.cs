namespace Agrolifenet.Dominio.Entidades
{
    public class HistorialClinico
    {
        public int IdHistorialClinico { get; set; }
        public DateTime FechadecreacionHistorialClinico { get; set; }
        public DateTime FechademodificacionHistorialClinico { get; set; }
        public bool EstadoHistorialClinico { get; set; }
        public string VacunaHistorialClinico { get; set; } = string.Empty;
        public string TratamientoHistorialClinico { get; set; } = string.Empty;
        public string EnfermedadesHistorialClinico { get; set; } = string.Empty;
        public string ResultadodeExamenesHistorialClinico { get; set; } = string.Empty;
        public string InformaciondesparacitacionHistorialClinico { get; set; } = string.Empty;
        public int PesoalnacerHistorialClinico { get; set; }
        public int PesoactualHistorialClinico { get; set; }
        public int GananciadepesodiariaHistorialClinico { get; set; }
        public string ObservacionesHistorialClinico { get; set; } = string.Empty;
        public string EstadodesaludHistorialClinico { get; set; } = string.Empty;
        public int CostodeltratamientoHistorialClinico { get; set; }
        public string SeguimientoHistorialClinico { get; set; } = string.Empty;
        public int NumerodepartosHistorialClinico { get; set; }
        public int IdGanado { get; set; }
        public int IdUsuario { get; set; }
        public int IdDatosdeReproduccion { get; set; }
        public bool Enfermo { get; set; }
    }
}
