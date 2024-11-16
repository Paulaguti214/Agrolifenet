﻿using Agrolifenet.Dominio.Servicios;
using Agrolifenet.Infraestructura.Servicios;
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

            return svc;
        }
    }
}
