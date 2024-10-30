using Agrolifenet.Dominio.Entidades;
using Agrolifenet.Dominio.Puerto;
using Agrolifenet.Infraestructura.Adaptador.BaseRepositorio;
using System.Data;

namespace Agrolifenet.Infraestructura.Adaptador
{
    public class TipoAnimalRepositorio : Repositorio<TipoAnimal>, ITipoAnimalRepositorio
    {
        private readonly string NombreProcedimientoGuardar = "GuardarTipoAnimal";

        public TipoAnimalRepositorio(IDbConnection baseDeDatos) : base(baseDeDatos) { }

        public async Task AgregarAsync(string tipoAnimal)
        {
            await AgregarAsync(NombreProcedimientoGuardar, new { tipoAnimal });
        }
    }
}
