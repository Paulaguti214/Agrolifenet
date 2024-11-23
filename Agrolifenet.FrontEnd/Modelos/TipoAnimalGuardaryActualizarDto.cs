using System.ComponentModel.DataAnnotations;

namespace Agrolifenet.FrontEnd.Modelos
{
    public class TipoAnimalGuardaryActualizarDto
    {
        [Required(ErrorMessage = "El Tipo de animal es obligatorio")]
        public string TiposdeAnimal { get; set; } = default!;
        public bool EstadoTipoAnimal { get; set; }
        public int IdTipoAnimal { get; set; }
    }
}
