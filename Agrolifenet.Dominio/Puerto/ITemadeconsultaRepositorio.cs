using Agrolifenet.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrolifenet.Dominio.Puerto
{
    public  interface ITemadeconsultaRepositorio
    {
        Task AgregarTemadeconsulta(DateTime FechadecreacionTemadeconsulta, DateTime FechademodificacionTemadeconsulta, bool EstadoTemadeconsulta, string Temasdeconsulta);
        Task<IEnumerable<TemadeConsulta>> ListarTemadeconsulta();
        Task<TemadeConsulta> SeleccionTemadeconsulta(int IdTemadeconsulta);
        Task EliminarTemadeconsulta(int IdTemadeconsulta);
        Task ActualizarTemadeconsulta(int IdTemadeconsulta, DateTime FechademodificacionTemadeconsulta, bool EstadoTemadeconsulta, string Temasdeconsulta);
    }
}
