namespace Agrolifenet.Dominio.Dto
{
    public class GuardarGanadoDto
    {
        public int IdGanado { get; set; }
        public bool EstadoGanado { get; set; }
        public DateTime FechadenacimientoGanado { get; set; }
        public int EdadGanado { get; set; }
        public string SexoGanado { get; set; } = default!;
        public string NumerodelchipGanado { get; set; } = default!;
        public string ColorGanado { get; set; } = default!;
        public string LugardenacimientoGanado { get; set; } = default!;
        public int? IdmadreGanado { get; set; } = default!;
        public int? IdpadreGanado { get; set; } = default!;
        public int IdRaza { get; set; }
        public int IdReproduccion { get; set; }
        public string EstadoNacido { get; set; } = default!;
        public string DescripcionNacimiento { get; set; } = default!;
        public int PesoNacido { get; set; } = default!;
    }
}
