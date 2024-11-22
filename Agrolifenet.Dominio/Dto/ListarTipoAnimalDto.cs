using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrolifenet.Dominio.Dto
{
    public class ListarTipoAnimalDto
    {
        public int IdTipoAnimal { get; set; }
        public string TiposdeAnimal { get; set; }
        public DateTime FechadecreacionTipoAnimal { get; set; }
        public DateTime FechademodificacionTipoAnimal { get; set; }
        public bool EstadoTipoAnimal { get; set; }
    }
}
