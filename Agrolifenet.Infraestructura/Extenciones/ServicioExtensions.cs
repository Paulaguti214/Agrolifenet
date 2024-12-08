using Agrolifenet.Dominio.Servicios;
using Agrolifenet.Infraestructura.Adaptador;
using Agrolifenet.Infraestructura.Servicios;
using DinkToPdf;
using DinkToPdf.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace Agrolifenet.Infraestructura.Extenciones
{
    public static class ServicioExtensions
    {
        public static IServiceCollection AgregarServiciosDominio(this IServiceCollection svc)
        {
            svc.AddScoped<ITipoAnimalServicio, TipoAnimalServicio>();
            svc.AddScoped<IUsurioServicio, UsuarioServicio>();
            svc.AddScoped<ITipodecargoServicio, TipodecargoServicio>();
            svc.AddScoped<ITipodereproduccionServicio, TipodereproduccionServicio>();
            svc.AddScoped<ITipodeparametroServicio, TipodeparametroServicio>();
            svc.AddScoped<ITemadeconsultaServicio, TemadeconsultaServicio>();
            svc.AddScoped<IGanadoServicio, GanadoServicio>();
            svc.AddScoped<IVentaServicio, VentaServicio>();
            svc.AddScoped<IRazaServicio, RazaServicio>();
            svc.AddScoped<IUsuarioTiposdeCargoServicio, UsuarioTiposdeCargoServicio>();
            svc.AddScoped<IHistorialClinicoServicio, HistorialClinicoServicio>();
            svc.AddScoped<IDetalleVentaServicio, DetalleVentaServicio>();
            svc.AddScoped<IDetalleTemaServicio, DetalleTemaServicio>();
            svc.AddScoped<IDatosdeReproduccionServicio, DatosdeReproduccionServicio>();
            svc.AddScoped<IConfiguracionParametrosServicio, ConfiguracionParametrosServicio>();
            svc.AddScoped<IFacturaServicio, FacturaServicio>();

            svc.AddSingleton(typeof(IConverter), new SynchronizedConverter(new PdfTools()));
            return svc;
        }
    }
}
