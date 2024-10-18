namespace Agrolifenet.Dominio.Entidades
{
    public class Raza
    {
        public int IdRaza { get; set; }
        public string TipodeRaza { get; set; }
        public DateTime FechadecreacionRaza { get; set; }
        public DateTime FechademodificacionRaza { get; set; }
        public bool EstadoRaza { get; set; }
        public int IdTipoAnimal { get; set; }

        public Raza(
            int idRaza,
            string tipodeRaza,
            DateTime fechadecreacionRaza,
            DateTime fechademodificacionRaza,
            bool estadoRaza,
            int idTipodeAnimal)
        {
            IdRaza = idRaza;
            TipodeRaza = tipodeRaza;
            FechadecreacionRaza = fechadecreacionRaza;
            FechademodificacionRaza = fechademodificacionRaza;
            EstadoRaza = estadoRaza;
            IdTipoAnimal = idTipodeAnimal;
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
        public Raza Buscar()
        {
            return new Raza(default, default!, default, default, default, default);
        }
        public List<Raza> Listar(Raza raza)
        {
            return new List<Raza>();
        }

    }
}
