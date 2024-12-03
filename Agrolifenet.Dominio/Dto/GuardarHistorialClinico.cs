namespace Agrolifenet.Dominio.Dto
{
    public class GuardarHistorialClinico
    {
        public int IdHistorialClinico { get; set; }
        public bool EstadoHistorialClinico { get; set; }
        public string VacunaHistorialClinico { get; set; } = default!;
        public string TratamientoHistorialClinico { get; set; } = default!;
        public string EnfermedadesHistorialClinico { get; set; } = default!;
        public string ResultadodeExamenesHistorialClinico { get; set; } = default!;
        public string InformaciondesparacitacionHistorialClinico { get; set; } = default!;
        public int PesoalnacerHistorialClinico { get; set; }
        public int PesoactualHistorialClinico { get; set; }
        public int GananciadepesodiariaHistorialClinico { get; set; }
        public string ObservacionesHistorialClinico { get; set; } = default!;
        public string EstadodesaludHistorialClinico { get; set; } = default!;
        public int CostodeltratamientoHistorialClinico { get; set; }
        public string SeguimientoHistorialClinico { get; set; } = default!;
        public int NumerodepartosHistorialClinico { get; set; }
        public int IdGanado { get; set; }
        public int IdUsuario { get; set; }
        public int IdDatosdeReproduccion { get; set; }
    }
}
