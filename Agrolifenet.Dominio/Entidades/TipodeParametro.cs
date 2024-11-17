namespace Agrolifenet.Dominio.Entidades
{
    public class TipodeParametro
    {
        public int IdTipodeParametro { get; set; }
        public string TiposdeParametros { get; set; }
        public DateTime FechadecreacionTipodeParametro { get; set; }
        public DateTime FechademodificacionTipodeParametro { get; set; }
        public bool EstadoTipodeParametro { get; set; }

    //    public TipodeParametro(
    //        int idTipodeParametro,
    //        string tiposdeParametros,
    //        DateTime fechadecreacionTipodeParametro,
    //        DateTime fechademodificacionTipodeParametro,
    //        bool estadoTipodeParametro)
    //    {
    //        IdTipodeParametro = idTipodeParametro;
    //        TiposdeParametros = tiposdeParametros;
    //        FechadecreacionTipodeParametro = fechadecreacionTipodeParametro;
    //        FechademodificacionTipodeParametro = fechademodificacionTipodeParametro;
    //        EstadoTipodeParametro = estadoTipodeParametro;
    //    }

    //    public int Guardar()
    //    {
    //        return 0;
    //    }
    //    public bool Actualizar()
    //    {
    //        return true;
    //    }
    //    public bool Eliminar()
    //    {
    //        return false;
    //    }
    //    public TipodeParametro Buscar()
    //    {
    //        return new(default, default!, default, default, default);
    //    }
    //    public List<TipodeParametro> Listar(TipodeParametro tipodeParametro)
    //    {
    //        return new List<TipodeParametro>();
    //    }

    }
}
