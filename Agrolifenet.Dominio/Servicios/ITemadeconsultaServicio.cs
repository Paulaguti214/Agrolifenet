using Agrolifenet.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrolifenet.Dominio.Servicios
{
    public interface ITemadeconsultaServicio
    {
        Task AgregarTemadeconsulta( bool EstadoTemadeconsulta, string Temasdeconsulta);
        Task<IEnumerable<TemadeConsulta>> ListarTemadeconsulta();
        Task<TemadeConsulta> SeleccionTemadeconsulta(int IdTemadeconsulta);
        Task EliminarTemadeconsulta(int IdTemadeconsulta);
        Task ActualizarTemadeconsulta(int IdTemadeconsulta, bool EstadoTemadeconsulta, string Temasdeconsulta);
    }
}
