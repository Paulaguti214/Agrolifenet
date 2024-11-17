namespace Agrolifenet.Dominio.Entidades
{
    public class Ganado
    {
        public int IdGanado { get; set; }
        public DateTime FechadecreacionGanado { get; set; }
        public DateTime FechademodificacionGanado { get; set; }
        public bool EstadoGanado { get; set; }
        public DateTime FechadenacimientoGanado { get; set; }
        public int EdadGanado { get; set; }
        public string SexoGanado { get; set; }
        public int NumerodelchipGanado { get; set; }
        public string ColorGanado { get; set; }
        public string LugardenacimientoGanado { get; set; }
        public int IdmadreGanado { get; set; }
        public int IdpadreGanado { get; set; }
        public int IdRaza { get; set; }

        //public Ganado(
        //    int idGanado,
        //    DateTime fechadecreacionGanado,
        //    DateTime fechademodificacionGanado,
        //    bool estadoGanado,
        //    DateTime fechadenacimientoGanado,
        //    int edadGanado,
        //    string sexoGanado,
        //    int numerodelchipGanado,
        //    string colorGanado,
        //    string lugardenacimientoGanado,
        //    int idmadreGanado,
        //    int idpadreGanado,
        //    int idRaza)
        //{
        //    IdGanado = idGanado;
        //    FechadecreacionGanado = fechadecreacionGanado;
        //    FechademodificacionGanado = fechademodificacionGanado;
        //    EstadoGanado = estadoGanado;
        //    FechadenacimientoGanado = fechadenacimientoGanado;
        //    EdadGanado = edadGanado;
        //    SexoGanado = sexoGanado;
        //    NumerodelchipGanado = numerodelchipGanado;
        //    ColorGanado = colorGanado;
        //    LugardenacimientoGanado = lugardenacimientoGanado;
        //    IdmadreGanado = idmadreGanado;
        //    IdpadreGanado = idpadreGanado;
        //    IdRaza = idRaza;
        //}
        //public int Guardar()
        //{
        //    return 0;
        //}
        //public bool Actualizar()
        //{
        //    return false;
        //}
        //public bool Eliminar()
        //{
        //    return false;
        //}
        //public Ganado Buscar()
        //{
        //    return new Ganado(
        //        default, default,
        //        default, default,
        //        default, default,
        //        default!, default,
        //        default!, default!,
        //        default, default, default);
        //}
        //public List<Ganado> Listar(Ganado ganado)
        //{
        //    return new List<Ganado>();
        //}
    }
}
