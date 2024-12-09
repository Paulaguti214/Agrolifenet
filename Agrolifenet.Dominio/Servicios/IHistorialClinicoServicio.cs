using Agrolifenet.Dominio.Dto;
using Agrolifenet.Dominio.Entidades;

namespace Agrolifenet.Dominio.Servicios
{
    public interface IHistorialClinicoServicio
    {
        Task AgregarHistorialClinico(GuardarHistorialClinico guardarHistorialClinico);

        Task ActualizarHistorialClinico(GuardarHistorialClinico actualizarHistorialClinico);

        Task<IEnumerable<HistorialClinicoDto>> ListarHistorialClinico(int IdGanado);

        Task<HistorialClinicoDto> SeleccionarHistorialClinico(int IdHistorialclinico);

        Task EliminarHistorialClinico(int IdHistorialclinico);
        Task<IEnumerable<HistorialClinico>> ListarHistorialClinicoGeneral();

    }
}
