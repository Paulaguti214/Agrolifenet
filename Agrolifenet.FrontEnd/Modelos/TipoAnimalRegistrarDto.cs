using System.ComponentModel.DataAnnotations;

namespace Agrolifenet.FrontEnd.Modelos
{
    public class TipoAnimalRegistrarDto
    {
        [Required(ErrorMessage = "El Tipo de animal es obligatorio")]
        public string TipoAnimal { get; set; } = string.Empty;
        public bool Estado { get; set; }
    }
}
