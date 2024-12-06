namespace Agrolifenet.FrontEnd.Modelos
{
    public class TipodeCargoListarDto
    {
        public int idTiposdecargo { get; set; }
        public string tipodeCargo { get; set; }
        public DateTime FechadecreacionTiposdeCargo { get; set; }
        public DateTime FechademodificacionTiposdeCargo { get; set; }

        public bool estadoTiposdeCargo { get; set; }
    }
}
