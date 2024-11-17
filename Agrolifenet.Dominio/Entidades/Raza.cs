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
    }
}
