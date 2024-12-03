using Agrolifenet.Dominio.Dto;

namespace Agrolifenet.Dominio.Servicios
{
    public interface IHistorialClinicoServicio
    {
        Task AgregarHistorialClinico(
        bool estado,
        string vacunas,
        string tratamientos,
        string enfermedades,
        string resultadosExamenes,
        string infoDesparacitacion,
        int pesoAlNacer,
        int pesoActual,
        int gananciaPesoDiaria,
        string observaciones,
        string estadoSalud,
        decimal costoTratamiento,
        string seguimiento,
        int numeroPartos,
        int idGanado,
        int idUsuario,
        int idDatosReproduccion);


        Task ActualizarHistorialClinico(GuardarHistorialClinico actualizarHistorialClinico);

        Task<IEnumerable<HistorialClinicoDto>> ListarHistorialClinico(int IdGanado);

        Task<HistorialClinicoDto> SeleccionarHistorialClinico(int IdHistorialclinico);

        Task EliminarHistorialClinico(int IdHistorialclinico);
    }
}
