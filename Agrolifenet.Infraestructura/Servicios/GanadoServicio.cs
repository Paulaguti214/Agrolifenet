using Agrolifenet.Dominio.Entidades;
using Agrolifenet.Dominio.Puerto;
using Agrolifenet.Dominio.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrolifenet.Infraestructura.Servicios
{
    internal class GanadoServicio : IGanadoServicio
    {
        private readonly IGanadoRepositorio _ganadoRepositorio;
        public GanadoServicio(IGanadoRepositorio ganadoRepositorio)
        {
            _ganadoRepositorio = ganadoRepositorio;
        }
        public async Task AgregarGanado( bool EstadoGanado, int EdadGanado, string sexoGanado, string NumeridechipGanado, string ColorGanado, string LugardenacimientoGanado, int IdMadreGanado, int IdPadreGanado, int IdRaza)
        {
            var fechaActual = DateTime.Now;
            await _ganadoRepositorio.AgregarGanado(fechaActual, fechaActual, EstadoGanado, EdadGanado, sexoGanado, NumeridechipGanado, ColorGanado, LugardenacimientoGanado, IdMadreGanado, IdPadreGanado, IdRaza);
        }
        public async Task<Ganado> SeleccionarGanado(int IdGanado)
        {
            return await _ganadoRepositorio.SeleccionarGanado(IdGanado);
        }
        public async Task EliminarGanado(int IdGanado)
        {
            await _ganadoRepositorio.EliminarGanado(IdGanado);
        }

        public async Task ActualizarGanado(int IdGanado,  bool EstadoGanado, int EdadGanado, string sexoGanado, string NumeridechipGanado, string ColorGanado, string LugardenacimientoGanado, int IdMadreGanado, int IdPadreGanado, int IdRaza)
        {
            var fechaActual = DateTime.Now;
            await _ganadoRepositorio.ActualizarGanado(IdGanado, fechaActual, EstadoGanado, EdadGanado, sexoGanado, NumeridechipGanado, ColorGanado, LugardenacimientoGanado, IdMadreGanado, IdPadreGanado, IdRaza);
        }

      

       

      
    }
}
