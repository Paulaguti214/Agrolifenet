namespace Agrolifenet.Dominio.Dto
{
    public class DetalleFacturaDto
    {
        public string sexoGanado { get; set; } = string.Empty;
        public string NumeridechipGanado { get; set; } = string.Empty;
        public string Tiposdeanimal { get; set; } = string.Empty;
        public string Tipoderaza { get; set; } = string.Empty;
        public decimal Valor { get; set; }
    }
}
