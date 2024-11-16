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
    internal class TemadeconsultaServicio : ITemadeconsultaServicio
    {
        private readonly ITemadeconsultaRepositorio _temadeconsultaRepositorio;
        public TemadeconsultaServicio(ITemadeconsultaRepositorio temadeconsultaRepositorio)
        {
            _temadeconsultaRepositorio = temadeconsultaRepositorio;
        }
        public async Task AgregarTemadeconsulta(bool EstadoTemadeconsulta, string Temasdeconsulta)
        {
            var fechaActual = DateTime.Now;
            await _temadeconsultaRepositorio.AgregarTemadeconsulta(fechaActual, fechaActual, EstadoTemadeconsulta, Temasdeconsulta);
        }
        public async Task<IEnumerable<TemadeConsulta>> ListarTemadeconsulta()
        {
            return await _temadeconsultaRepositorio.ListarTemadeconsulta();
        }
        public async Task<TemadeConsulta> SeleccionTemadeconsulta(int IdTemadeconsulta)
        {
            return await _temadeconsultaRepositorio.SeleccionTemadeconsulta(IdTemadeconsulta);
        }
        public async Task EliminarTemadeconsulta(int IdTemadeconsulta)
        {
            await _temadeconsultaRepositorio.EliminarTemadeconsulta(IdTemadeconsulta);
        }

        public async Task ActualizarTemadeconsulta(int IdTemadeconsulta, bool EstadoTemadeconsulta, string Temasdeconsulta)
        {
            var fechaActual = DateTime.Now;
            await _temadeconsultaRepositorio.ActualizarTemadeconsulta(IdTemadeconsulta, fechaActual, EstadoTemadeconsulta, Temasdeconsulta);
        }

      

        

        

       
    }
}
