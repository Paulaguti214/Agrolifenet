namespace Agrolifenet.Dominio.Puerto
{
    public interface IUsuarioTiposdeCargoRepositorio
    {
        Task AgregarUsuarioTiposdeCargo(int IdUsuario, int IdTiposdecargo);
        Task ActualizarUsuarioTiposdeCargo(int IdUsuarioTiposdecargo, int IdTiposdecargo);
    }
}
