namespace Agrolifenet.Dominio.Entidades
{
    public class TiposdeCargo
    {
        public int IdTiposdeCargo { get; set; }
        public string TipodeCargo { get; set; }
        public DateTime FechadecreacionTiposdeCargo { get; set; }
        public DateTime FechademodificacionTiposdeCargo { get; set; }
        public bool EstadoTiposdeCargo { get; set; }
        public TiposdeCargo(
            int idTiposdecargo,
            string tipodeCargo,
            DateTime fechadecreacionTiposdeCargo,
            DateTime fechademodificacionTiposdeCargo,
            bool estadoTiposdeCargo)
        {
            IdTiposdeCargo = idTiposdecargo;
            TipodeCargo = tipodeCargo;
            FechadecreacionTiposdeCargo = fechadecreacionTiposdeCargo;
            FechademodificacionTiposdeCargo = fechadecreacionTiposdeCargo;
            EstadoTiposdeCargo = estadoTiposdeCargo;
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
            return false;
        }
        public TiposdeCargo Buscar()
        {
            return new TiposdeCargo(default, default!, default, default, default);
        }
        public List<TiposdeCargo> Listar(TiposdeCargo tiposdeCargo)
        {
            return new List<TiposdeCargo>();
        }


    }
}
