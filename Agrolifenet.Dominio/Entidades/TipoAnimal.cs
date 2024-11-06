namespace Agrolifenet.Dominio.Entidades
{
    public class TipoAnimal
    {
        public int IdTipoAnimal { get; set; }
        public string TiposdeAnimal { get; set; }
        public DateTime FechadecreacionTipoAnimal { get; set; }
        public DateTime FechademodificacionTipoAnimal { get; set; }
        public bool EstadoTipoAnimal { get; set; }
        public TipoAnimal(
            int idTipoAnimal,
            string tiposdeAnimal,
            DateTime fechadecreacionTipoAnimal,
            DateTime fechademodificacionTipoAnimal,
            bool estadoTipoAnimal)
        {
            IdTipoAnimal = idTipoAnimal;
            TiposdeAnimal = tiposdeAnimal;
            FechadecreacionTipoAnimal = fechadecreacionTipoAnimal;
            FechademodificacionTipoAnimal = fechademodificacionTipoAnimal;
            EstadoTipoAnimal = estadoTipoAnimal;
        }  

       
    }
}

