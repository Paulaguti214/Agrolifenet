namespace Agrolifenet.Dominio.Entidades
{
    public class UsuarioTiposdeCargo
    {
        public int IdUsuarioTipodeCargo { get; set; }
        public int IdUsuario { get; set; }
        public int IdTiposdeCargo { get; set; }
        public UsuarioTiposdeCargo(
            int idUsuarioTipodeCargo,
            int idUsuario,
            int idTiposdeCargo)
        {
            IdUsuarioTipodeCargo = idUsuarioTipodeCargo;
            IdUsuario = idUsuario;
            IdTiposdeCargo = idTiposdeCargo;
        }
        public int Guardar()
        {
            return 0;
        }
        public bool Actualizar()
        {
            return false;
        }
        public bool Eliminar()
        {
            return true;
        }
        public UsuarioTiposdeCargo Buscar()
        {
            return new UsuarioTiposdeCargo(default, default, default);
        }
        public List<UsuarioTiposdeCargo> Listar(UsuarioTiposdeCargo usuarioTiposdeCargo)
        {
            return new List<UsuarioTiposdeCargo>();
        }
    }
}
