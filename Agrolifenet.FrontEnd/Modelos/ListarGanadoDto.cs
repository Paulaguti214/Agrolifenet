namespace Agrolifenet.FrontEnd.Modelos
{
    public class ListarGanadoDto
    {
        public int IdGanado { get; set; }
        public int IdTipoanimal { get; set; }
        public string Tiposdeanimal { get; set; }
        public int IdRaza { get; set; }
        public string Tipoderaza { get; set; }
        public string EstadoGanado { get; set; }
        public int EdadGanado { get; set; }
        public string SexoGanado { get; set; }
        public string NumeridechipGanado { get; set; }
        public string ColorGanado { get; set; }
        public string LugardenacimientoGanado { get; set; }
        public string NumeridechipGanadoPadre { get; set; }
        public string NumeridechipGanadoMadre { get; set; }
    }
}
