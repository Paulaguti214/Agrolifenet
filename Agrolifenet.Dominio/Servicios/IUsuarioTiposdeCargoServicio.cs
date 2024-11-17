namespace Agrolifenet.Dominio.Servicios
{
    public interface IUsuarioTiposdeCargoServicio
    {
        Task AgregarUsuarioTiposdeCargo(int IdUsuario, int IdTiposdecargo);
        Task ActualizarUsuarioTiposdeCargo(int IdUsuarioTiposdecargo, int IdTiposdecargo);
    }
}
