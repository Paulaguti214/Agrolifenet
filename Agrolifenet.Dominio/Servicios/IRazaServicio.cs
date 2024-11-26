using Agrolifenet.Dominio.Dto;
using Agrolifenet.Dominio.Entidades;

namespace Agrolifenet.Dominio.Servicios
{
    public interface IRazaServicio
    {
        Task AgregarRaza(string Tipoderaza, bool EstadoRaza, int IdTipoanimal);
        Task<RazaTipoAnimalDto> SeleccionarRaza(int IdRaza);
        Task<IEnumerable<ListarRazaDto>> ListarRaza();
        Task EliminarRaza(int IdRaza);
        Task ActualizarRaza(int IdRaza, string Tipoderaza, bool EstadoRaza, int IdTipoanimal);
    }
}
