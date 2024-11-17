using Agrolifenet.Dominio.Dto;
using Agrolifenet.Dominio.Puerto;
using Agrolifenet.Dominio.Servicios;

namespace Agrolifenet.Infraestructura.Servicios
{
    public class RazaServicio : IRazaServicio
    {
        private readonly IRazaRepositorio _razaRepositorio;

        public RazaServicio(IRazaRepositorio razaRepositorio)
        {
            _razaRepositorio = razaRepositorio;
        }

        public async Task ActualizarRaza(int IdRaza, string Tipoderaza, bool EstadoRaza, int IdTipoanimal)
        {
            var FechaActualizacion = DateTime.Now;

            await _razaRepositorio.ActualizarRaza(IdRaza, Tipoderaza, FechaActualizacion, EstadoRaza, IdTipoanimal);
        }

        public async Task AgregarRaza(string Tipoderaza, bool EstadoRaza, int IdTipoanimal)
        {
            var fechaActual = DateTime.Now;
            await _razaRepositorio.AgregarRaza(Tipoderaza, fechaActual, fechaActual, EstadoRaza, IdTipoanimal);
        }

        public async Task EliminarRaza(int IdRaza)
        {
            await _razaRepositorio.EliminarRaza(IdRaza);
        }

        public async Task<RazaTipoAnimalDto> SeleccionarRaza(int IdRaza)
        {
            return await _razaRepositorio.SeleccionarRaza(IdRaza);
        }
    }
}
