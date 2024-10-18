namespace Agrolifenet.Dominio.Entidades
{
    public class Ventas
    {
        public int IdVentas { get; set; }
        public DateTime FechadecreacionVentas { get; set; }
        public DateTime FechademodificacionVentas { get; set; }
        public bool EstadoVentas { get; set; }
        public DateTime FechadeVenta { get; set; }
        public string NombredelcompradorVentas { get; set; }
        public int IdentificaciondelcompradorVentas { get; set; }
        public int TelefonodelcompradorVentas { get; set; }
        public int PreciodeVenta { get; set; }
        public string MetododepagoVentas { get; set; }
        public string DestinoVentas { get; set; }
        public string CondicionesdeVentas { get; set; }
        public string EstadodelanimalVentas { get; set; }
        public string ObservacionVentas { get; set; }
        public int IdUsuario { get; set; }
        public Ventas(
            int idVentas,
            DateTime fechadecreacionVentas,
            DateTime fechademodificacionVentas,
            bool estadoVentas,
            DateTime fechadeVenta,
            string nombredelcompradorVentas,
            int identificaciondelcompradorVentas,
            int telefonodelcompradorVentas,
            int preciodeVentas,
            string metododepagoVentas,
            string destinoVentas,
            string condicionesdeVentas,
            string estadodelanimalVentas,
            string observacionesVentas,
            int idUsuario)
        {
            IdVentas = idVentas;
            FechadecreacionVentas = fechadecreacionVentas;
            FechademodificacionVentas = fechademodificacionVentas;
            EstadoVentas = estadoVentas; 
            FechadeVenta = fechadeVenta; 
            NombredelcompradorVentas = nombredelcompradorVentas; 
            IdentificaciondelcompradorVentas = identificaciondelcompradorVentas; 
            TelefonodelcompradorVentas = telefonodelcompradorVentas;
            PreciodeVenta = preciodeVentas; 
            MetododepagoVentas = metododepagoVentas;
            DestinoVentas = destinoVentas;
            CondicionesdeVentas = condicionesdeVentas; 
            EstadodelanimalVentas = estadodelanimalVentas;
            ObservacionVentas = observacionesVentas; 
            IdUsuario = idUsuario;
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
        public Ventas Buscar()
        {
            return new(
                default, 
                default,
                default,
                default, 
                default, 
                default!, 
                default, 
                default, 
                default, 
                default!, 
                default!, 
                default!, 
                default!, 
                default!, 
                default);
        }
        public List <Ventas> Listar (Ventas ventas)
        {
            return new List<Ventas>();
        }
    }
}
