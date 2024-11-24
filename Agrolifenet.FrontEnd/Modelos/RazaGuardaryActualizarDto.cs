using System.ComponentModel.DataAnnotations;

namespace Agrolifenet.FrontEnd.Modelos
{
    public class RazaGuardaryActualizarDto
    {
        public int IdRaza { get; set; }
        public string Tipoderaza { get; set; } = default!;
        public bool EstadoRaza { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "El Tipo de animal es obligatorio")]
        public int IdTipoanimal { get; set; }
        public string TiposdeAnimal { get; set; } = default!;

    }
}
