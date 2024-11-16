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
    internal class TipodeparametroServicio : ITipodeparametroServicio
    {
        private readonly ITipodeparametroRepositorio _tipodeparametroRepositorio;
        public TipodeparametroServicio(ITipodeparametroRepositorio tipodeparametroRepositorio)
        {
            _tipodeparametroRepositorio = tipodeparametroRepositorio;
        }
        public async Task Agregar(string Tiposdeparametros, bool EstadoTipodeparametro)
        {
            var fechaActual = DateTime.Now;
            await _tipodeparametroRepositorio.AgregarAsync(Tiposdeparametros, fechaActual, fechaActual, EstadoTipodeparametro);
           

        }
        public Task<IEnumerable<TipodeParametro>> ListarTipodeparametro()
        {
            return _tipodeparametroRepositorio.ListarTipodeparametro();
        }
        public async  Task<TipodeParametro> SeleccionarTipodeparametro(int IdTipodeparametro)
        {
            return await _tipodeparametroRepositorio.SeleccionarTipodeparametro(IdTipodeparametro);
        }
        public async Task EliminarTipodeparametro(int IdTipodeparametro)
        {
            await _tipodeparametroRepositorio.EliminarTipodeparametro(IdTipodeparametro);
        }
        public async Task ActualizarTipodeparametro(int IdTipodeparametro, string Tiposdeparametros, bool EstadoTipodeparametro)
        {
            var fechaActual = DateTime.Now;
            await _tipodeparametroRepositorio.ActualizarTipodeparametro(IdTipodeparametro,Tiposdeparametros,fechaActual, EstadoTipodeparametro);
        }

        

       

      

       
    }
}
