namespace Agrolifenet.Dominio.Dto
{
    public class GuardarGanadoDto
    {
        public int IdGanado { get; set; }
        public bool EstadoGanado { get; set; }
        public DateTime FechadenacimientoGanado { get; set; }
        public int EdadGanado { get; set; }
        public string SexoGanado { get; set; }
        public string NumerodelchipGanado { get; set; }
        public string ColorGanado { get; set; }
        public string LugardenacimientoGanado { get; set; }
        public int IdmadreGanado { get; set; }
        public int IdpadreGanado { get; set; }
        public int IdRaza { get; set; }
    }
}
