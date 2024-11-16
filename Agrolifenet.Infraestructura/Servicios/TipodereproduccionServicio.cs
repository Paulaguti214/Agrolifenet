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
    internal class TipodereproduccionServicio : ITipodereproduccionServicio
    {
        private readonly ITipodereproduccionRepositorio _tipodereproduccionRepositorio;
        public TipodereproduccionServicio(ITipodereproduccionRepositorio tipodereproduccionRepositorio)
        {
            _tipodereproduccionRepositorio = tipodereproduccionRepositorio;
        }
        public async Task Agregar(string Tiposdereproduccion, bool EstadoTipodereproduccion)
        {
            var fechaActual = DateTime.Now;
            await _tipodereproduccionRepositorio.AgregarAsync(Tiposdereproduccion, EstadoTipodereproduccion, fechaActual,fechaActual);
        }
        public async Task<IEnumerable<TipodeReproduccion>> Listartipodereproduccion()
        {
            return await _tipodereproduccionRepositorio.ListarTipodereproduccion();
        }
        public async Task<TipodeReproduccion> SeleccionarTipodereproduccion(int IdTipodereproduccion)
        {
            return await _tipodereproduccionRepositorio.SeleccionarTipodereproduccion(IdTipodereproduccion);
        }
        public async Task EliminarTipodereproduccion(int IdTipodereproduccion)
        {
            await _tipodereproduccionRepositorio.EliminarTipodereproduccion(IdTipodereproduccion);
        }

        public async Task ActualizarTipodereproduccion(int IdTipodereproduccion, string Tiposdereproduccion, bool EstadoTipodereproduccion)
        {
            var fechaActual = DateTime.Now;
            await _tipodereproduccionRepositorio.ActualizarTipodereproduccion(IdTipodereproduccion, Tiposdereproduccion, EstadoTipodereproduccion, fechaActual);
        }

       

       

       

       
    }
}
