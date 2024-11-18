namespace Agrolifenet.Dominio.Servicios
{
    public interface IConfiguracionParametrosServicio
    {
        Task AgregarConfiguracionParametros(
           bool EstadoConfiguraciondeparametros,
           string Tipodelparametro,
           string Descripciondelparamtero,
           int Valordelparametro,
           int IdTipodeParametro
       );

        Task EliminarConfiguracionParametros(int IdConfiguraciondeparametros);

        Task ActualizarConfiguracionParametros(
            int IdConfiguraciondeparametros,
            bool EstadoConfiguraciondeparametros,
            string Tipodelparametro,
            string Descripciondelparamtero,
            int Valordelparametro,
            int IdTipodeParametro
        );
    }
}
