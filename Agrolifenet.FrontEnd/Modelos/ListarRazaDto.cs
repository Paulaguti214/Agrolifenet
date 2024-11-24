namespace Agrolifenet.FrontEnd.Modelos
{
    public class ListarRazaDto
    {
        public int IdRaza { get; set; }
        public string Tipoderaza { get; set; } = default!;
        public DateTime FechadecreacionRaza { get; set; }
        public DateTime FechademodificacionRaza { get; set; }
        public bool EstadoRaza { get; set; }
        public int IdTipoanimal { get; set; }
        public string TiposdeAnimal { get; set; } = default!;

    }
}
