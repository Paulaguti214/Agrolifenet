namespace Agrolifenet.Dominio.Dto
{
    public class GanadoDto
    {
        public int IdGanado { get; set; }
        public int IdTipoanimal { get; set; }
        public string Tiposdeanimal { get; set; } = default!;
        public int IdRaza { get; set; }
        public string Tipoderaza { get; set; } = default!;
        public bool EstadoGanado { get; set; }
        public int EdadGanado { get; set; }
        public string SexoGanado { get; set; } = default!;
        public string NumerodelchipGanado { get; set; } = default!;
        public string ColorGanado { get; set; } = default!;
        public string LugardenacimientoGanado { get; set; } = default!;
        public string NumeridechipGanadoPadre { get; set; } = default!;
        public string? NumerodelchipPadre { get; set; }
        public string? NumerodelchipMadre { get; set; }
        public int? IdmadreGanado { get; set; }
        public int? IdpadreGanado { get; set; }
        public int? IdReproduccion { get; set; }
        public string? TiposReproduccion { get; set; }
        public string? EstadoNacido { get; set; }
        public string? DescripcionNacimiento { get; set; }
        public int? PesoNacido { get; set; }
    }
}
