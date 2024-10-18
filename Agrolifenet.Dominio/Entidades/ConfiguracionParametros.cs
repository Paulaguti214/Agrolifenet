namespace Agrolifenet.Dominio.Entidades
{
    public class ConfiguracionParametros
    {
        public int IdConfiguracionParametros { get; set; }
        public DateTime FechadecreacionConfiguracionParametros { get; set; }
        public DateTime FechademodificacionConfiguracionParametros { get; set; }
        public bool EstadoConfiguracionPararmetros { get; set; }
        public string Tipodeparametro { get; set; }
        public string Descripciondelparametro { get; set; }
        public int Valordelparametro { get; set; }
        public int IdTipodeParametro { get; set; }


        public ConfiguracionParametros(
            int idConfiguracioParametros,
            DateTime fechadecreacionConfiguracionParametros,
            DateTime fechademodificacionConfiguracionParametros,
            bool estadoConfiguracionParametros,
            string tipodeparametro,
            string descripciondelparametro,
            int valordelparametro,
            int idTipodeParametro)
        {
            IdConfiguracionParametros = idConfiguracioParametros;
            FechadecreacionConfiguracionParametros = fechadecreacionConfiguracionParametros;
            FechademodificacionConfiguracionParametros = fechademodificacionConfiguracionParametros;
            EstadoConfiguracionPararmetros = estadoConfiguracionParametros;
            Tipodeparametro = tipodeparametro;
            Descripciondelparametro = descripciondelparametro;
            Valordelparametro = valordelparametro;
            IdTipodeParametro = idTipodeParametro;
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
        public ConfiguracionParametros Buscar()
        {
            return new(default, default, default, default, default!, default!, default, default);
        }
        public List<ConfiguracionParametros> Listar(ConfiguracionParametros configuracionParametros)
        {
            return new List<ConfiguracionParametros>();
        }

    }
}
