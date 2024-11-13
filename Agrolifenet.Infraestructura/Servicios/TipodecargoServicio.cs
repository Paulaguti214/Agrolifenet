using Agrolifenet.Dominio.Puerto.BaseRepositorio;
using Agrolifenet.Dominio.Servicios;
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
        public async Task Agregar(string tipodecargo,  bool estadoTiposdecargo)
        {
            var fechaActual = DateTime.Now;
            await _tipodecargoRepositorio.AgregarAsync(tipodecargo, fechaActual, fechaActual, estadoTiposdecargo); 
        }
        public
    }
}
