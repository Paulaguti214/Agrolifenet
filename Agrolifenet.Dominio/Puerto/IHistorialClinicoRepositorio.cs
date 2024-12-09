using Agrolifenet.Dominio.Dto;
using Agrolifenet.Dominio.Entidades;

namespace Agrolifenet.Dominio.Puerto
{
    public interface IHistorialClinicoRepositorio
    {
        Task AgregarHistorialClinico(HistorialClinico historialClinico);
        Task ActualizarHistorialClinico(HistorialClinico historialClinico);
        Task<IEnumerable<HistorialClinicoDto>> ListarHistorialClinico(int IdGanado);
        Task<HistorialClinicoDto> SeleccionarHistorialClinico(int IdHistorialclinico);
        Task EliminarHistorialClinico(int IdHistorialclinico);
        Task<IEnumerable<HistorialClinico>> ListarHistorialClinicoGeneral();

    }
}
