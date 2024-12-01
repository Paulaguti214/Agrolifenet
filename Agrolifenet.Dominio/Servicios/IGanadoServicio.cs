using Agrolifenet.Dominio.Dto;

namespace Agrolifenet.Dominio.Servicios
{
    public interface IGanadoServicio
    {

        Task AgregarGanado(bool EstadoGanado, int EdadGanado, string sexoGanado,
         string NumeridechipGanado, string ColorGanado, string LugardenacimientoGanado, int? IdMadreGanado, int? IdPadreGanado, int IdRaza, int IdReproduccion, string EstadoNacido, string DescripcionNacimiento, int PesoNacido);
        Task<GanadoDto> SeleccionarGanado(int IdGanado);
        Task EliminarGanado(int IdGanado);
        Task ActualizarGanado(int IdGanado, bool EstadoGanado, int EdadGanado, string sexoGanado,
         string NumeridechipGanado, string ColorGanado, string LugardenacimientoGanado, int? IdMadreGanado, int? IdPadreGanado, int IdRaza, int IdReproduccion, string EstadoNacido, string DescripcionNacimiento, int PesoNacido);
        Task<IEnumerable<GanadoDto>> ListarGanado();
    }
}
