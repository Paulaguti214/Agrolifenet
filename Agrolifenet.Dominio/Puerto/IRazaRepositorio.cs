using Agrolifenet.Dominio.Entidades;

namespace Agrolifenet.Dominio.Puerto
{
    public interface IRazaRepositorio
    {
        Task AgregarRaza(string Tipoderaza, DateTime FechadecreacionRaza, DateTime FechademodificacionRaza, bool EstadoRaza, int IdTipoanimal);
        Task<Raza> SeleccionarRaza(int IdRaza);
        Task EliminarRaza(int IdRaza);
        Task ActualizarRaza(int IdRaza, string Tipoderaza, DateTime FechademodificacionRaza, bool EstadoRaza, int IdTipoanimal);
    }
}
