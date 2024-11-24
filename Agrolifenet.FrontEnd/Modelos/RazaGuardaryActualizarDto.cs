namespace Agrolifenet.FrontEnd.Modelos
{
    public class RazaGuardaryActualizarDto
    {
        public int IdRaza { get; set; }
        public string Tipoderaza { get; set; } = default!;
        public bool EstadoRaza { get; set; }
        public int IdTipoanimal { get; set; }
        public string TiposdeAnimal { get; set; } = default!;

    }
}
