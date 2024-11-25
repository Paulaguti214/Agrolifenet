using System.ComponentModel.DataAnnotations;

namespace Agrolifenet.FrontEnd.Modelos
{
    public class GanadoGuardaryActualizarDto
    {
        public int IdGanado { get; set; }
        public bool EstadoGanado { get; set; }
        public DateTime FechadenacimientoGanado { get; set; } = DateTime.Now;
        public int EdadGanado { get; set; }
        public string SexoGanado { get; set; }
        [Required(ErrorMessage = "El numero del chip es obligatorio")]
        public int? NumerodelchipGanado { get; set; }
        [Required(ErrorMessage = "El color del ganado es obligatorio")]
        public string ColorGanado { get; set; }
        public string LugardenacimientoGanado { get; set; }
        public int IdmadreGanado { get; set; }
        public int IdpadreGanado { get; set; }
        public int IdTipoAnimal { get; set; }
        public int IdRaza { get; set; }
    }
}
