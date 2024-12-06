using System.ComponentModel.DataAnnotations;

namespace Agrolifenet.FrontEnd.Modelos
{
    public class TipodeCargoGuardarActualizarDto
    {

        public int idTiposdecargo { get; set; }

        [Required(ErrorMessage = "El Tipo de Cargo es obligatorio")]
        public string tipodeCargo { get; set; }

        public bool estadoTiposdeCargo { get; set; }

    }
}
