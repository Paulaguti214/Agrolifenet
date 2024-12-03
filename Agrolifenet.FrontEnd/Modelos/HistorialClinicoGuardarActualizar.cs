using System.ComponentModel.DataAnnotations;

namespace Agrolifenet.FrontEnd.Modelos
{
    public class HistorialClinicoGuardarActualizar
    {
        public int IdHistorialClinico { get; set; }
        public bool EstadoHistorialClinico { get; set; }
        [Required(ErrorMessage = "la informacion es obligatoria")]
        public string VacunaHistorialClinico { get; set; } = default!;
        [Required(ErrorMessage = "la informacion es obligatoria")]
        public string TratamientoHistorialClinico { get; set; } = default!;
        [Required(ErrorMessage = "la informacion es obligatoria")]
        public string EnfermedadesHistorialClinico { get; set; } = default!;
        [Required(ErrorMessage = "la informacion es obligatoria")]
        public string ResultadodeExamenesHistorialClinico { get; set; } = default!;
        [Required(ErrorMessage = "la informacion es obligatoria")]
        public string InformaciondesparacitacionHistorialClinico { get; set; } = default!;
        [Required(ErrorMessage = "la informacion es obligatoria")]
        public int PesoalnacerHistorialClinico { get; set; }
        [Required(ErrorMessage = "la informacion es obligatoria")]
        [Range(1, int.MaxValue, ErrorMessage = "El peso tiene que ser mayor a 0")]
        public int? PesoactualHistorialClinico { get; set; }
        public int GananciadepesodiariaHistorialClinico { get; set; }
        [Required(ErrorMessage = "la informacion es obligatoria")]
        public string ObservacionesHistorialClinico { get; set; } = default!;
        [Required(ErrorMessage = "la informacion es obligatoria")]
        public string EstadodesaludHistorialClinico { get; set; } = default!;
        [Required(ErrorMessage = "la informacion es obligatoria")]
        [Range(1, int.MaxValue, ErrorMessage = "El costo tiene que ser mayor a 0")]
        public int CostodeltratamientoHistorialClinico { get; set; }
        [Required(ErrorMessage = "la informacion es obligatoria")]
        public string SeguimientoHistorialClinico { get; set; } = default!;
        public int NumerodepartosHistorialClinico { get; set; }
        [Required(ErrorMessage = "la informacion es obligatoria")]
        [Range(1, int.MaxValue, ErrorMessage = "seleccionar ganado")]
        public int? IdGanado { get; set; }
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; } = default!;
    }
}
