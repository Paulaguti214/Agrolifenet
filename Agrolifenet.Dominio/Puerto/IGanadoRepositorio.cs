using Agrolifenet.Dominio.Dto;

namespace Agrolifenet.Dominio.Puerto
{
    public interface IGanadoRepositorio
    {
        Task AgregarGanado(DateTime FechadecreacionGanado, DateTime FechademodificacionGanado, bool EstadoGanado, int EdadGanado, string sexoGanado,
         string NumeridechipGanado, string ColorGanado, string LugardenacimientoGanado, int? IdMadreGanado, int? IdPadreGanado, int IdRaza);
        Task<GanadoDto> SeleccionarGanado(int IdGanado);
        Task EliminarGanado(int IdGanado);
        Task ActualizarGanado(int IdGanado, DateTime FechademodificacionGanado, bool EstadoGanado, int EdadGanado, string sexoGanado,
         string NumeridechipGanado, string ColorGanado, string LugardenacimientoGanado, int? IdMadreGanado, int? IdPadreGanado, int IdRaza);
        Task<IEnumerable<GanadoDto>> ListarGanado();
    }
}
