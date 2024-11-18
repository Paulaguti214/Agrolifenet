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
    }
}
