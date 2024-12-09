namespace Agrolifenet.FrontEnd.Modelos
{
    public class HistorialClinicoDto
    {
        public int IdGanado { get; set; }
        public string NumeroDeChipGanado { get; set; } = default!;
        public decimal PesoNacido { get; set; }
        public int IdHistorialClinico { get; set; }
        public DateTime FechaDeCreacionHistorialClinico { get; set; }
        public bool EstadoHistorialClinico { get; set; } = default!;
        public string VacunasHistorialClinico { get; set; } = default!;
        public string TratamientosHistorialClinico { get; set; } = default!;
        public string EnfermedadesHistorialClinico { get; set; } = default!;
        public string ResultadosDeExamenesHistorialClinico { get; set; } = default!;
        public string InformacionDesparacitacionHistorialClinico { get; set; } = default!;
        public int PesoAlNacerHistorialClinico { get; set; }
        public int PesoActualHistorialClinico { get; set; }
        public int GananciaDePesoDiariaHistorialClinico { get; set; }
        public string ObservacionesHistorialClinico { get; set; } = default!;
        public string EstadoDeSaludHistorialClinico { get; set; } = default!;
        public int CostoDelTratamientoHistorialClinico { get; set; }
        public string SeguimientoHistorialClinico { get; set; } = default!;
        public int NumeroDePartosHistorialClinico { get; set; }
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; } = default!;
        public string ApellidoUsuario { get; set; } = default!;
        public bool Enfermo { get; set; }
    }
}
