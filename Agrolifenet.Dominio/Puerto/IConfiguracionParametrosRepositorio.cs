namespace Agrolifenet.Dominio.Puerto
{
    public interface IConfiguracionParametrosRepositorio
    {
        Task AgregarConfiguracionParametros(
            DateTime FechadecreacionConfiguraciondeparametros,
            DateTime FechademodificacionConfiguraciondeparametros,
            bool EstadoConfiguraciondeparametros,
            string Tipodelparametro,
            string Descripciondelparamtero,
            int Valordelparametro,
            int IdTipodeParametro
        );

        Task EliminarConfiguracionParametros(int IdConfiguraciondeparametros);

        Task ActualizarConfiguracionParametros(
            int IdConfiguraciondeparametros,
            DateTime FechadecreacionConfiguraciondeparametros,
            DateTime FechademodificacionConfiguraciondeparametros,
            bool EstadoConfiguraciondeparametros,
            string Tipodelparametro,
            string Descripciondelparamtero,
            int Valordelparametro,
            int IdTipodeParametro
        );
    }
}
