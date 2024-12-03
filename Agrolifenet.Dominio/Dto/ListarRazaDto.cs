namespace Agrolifenet.Dominio.Dto
{
    public class ListarRazaDto
    {
        public int IdRaza { get; set; }
        public string Tipoderaza { get; set; } = string.Empty;
        public bool EstadoRaza { get; set; }
        public string TiposdeAnimal { get; set; } = string.Empty;
        public int IdTipoanimal { get; set; }
        public DateTime FechadecreacionRaza { get; set; }
        public DateTime FechademodificacionRaza { get; set; }
    }
}
