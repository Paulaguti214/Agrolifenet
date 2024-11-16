using Agrolifenet.Dominio.Entidades;
using Agrolifenet.Dominio.Puerto;
using Agrolifenet.Dominio.Servicios;
using Agrolifenet.Infraestructura.Adaptador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrolifenet.Infraestructura.Servicios
{
    internal class TipodecargoServicio : ITipodecargoServicio
    {
        private readonly ITipodecargoRepositorio _tipodecargoRepositorio;
        public TipodecargoServicio(ITipodecargoRepositorio tipodecargoRepositorio)
        {
            _tipodecargoRepositorio = tipodecargoRepositorio;
        }
        public async Task Agregar(string tipodecargo, bool estadoTiposdecargo)
        {
            var fechaActual = DateTime.Now;
            await _tipodecargoRepositorio.AgregarAsync(tipodecargo, fechaActual, fechaActual, estadoTiposdecargo);
        }
        public Task<IEnumerable<TiposdeCargo>> ListarTiposdecargo()
        {
            return _tipodecargoRepositorio.ListarTiposdecargo();
        }
        public async Task<TiposdeCargo> SeleccionarTiposdecargo(int idTiposdecargo)
        {
            return await _tipodecargoRepositorio.SeleccionarTiposdecargo(idTiposdecargo);
        }
        public async Task EliminarTiposdecargo(int idTiposdecargo)
        {
            await _tipodecargoRepositorio.EliminarTiposdecargo(idTiposdecargo);
        }
        public async Task ActualizarTiposdecargo(int idTiposdecargo, string tipodecargo, bool estadoTiposdecargo)
        {
            var fechaActual = DateTime.Now;
            await _tipodecargoRepositorio.ActualizarTiposdecargo(idTiposdecargo, tipodecargo,fechaActual, estadoTiposdecargo);
        }

  

       

    

      
    }
}
