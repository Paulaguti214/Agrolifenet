namespace Agrolifenet.Dominio.Entidades
{
    public class TemadeConsulta
    {
        public int IdTemadeConsulta { get; set; }
        public string TemasdeConsulta { get; set; }
        public bool EstadoTemadeConsulta { get; set; }
        public DateTime FechadecreacionTemadeConsulta { get; set; }
        public DateTime FechademodificacionTemadeConsulta { get; set; }
        public TemadeConsulta(
            int idTemadeConsulta,
            string temasdeConsulta,
            bool estadoTemadeConsulta,
            DateTime fechadecreacionTemadeConsulta,
            DateTime fechademodificacionTemasdeConsulta)
        {
            IdTemadeConsulta = idTemadeConsulta;
            TemasdeConsulta = temasdeConsulta;
            EstadoTemadeConsulta = estadoTemadeConsulta;
            FechadecreacionTemadeConsulta = fechadecreacionTemadeConsulta;
            FechademodificacionTemadeConsulta = fechademodificacionTemasdeConsulta;
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
        public TemadeConsulta Buscar()
        {
            return new TemadeConsulta(default,default,default,default,default);
        }
        public List<TemadeConsulta> Listar (TemadeConsulta temadeConsulta)
        {
            return new List<TemadeConsulta>();
        }
    }
}
