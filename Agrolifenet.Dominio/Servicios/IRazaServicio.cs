﻿using Agrolifenet.Dominio.Dto;

namespace Agrolifenet.Dominio.Servicios
{
    public interface IRazaServicio
    {
        Task AgregarRaza(string Tipoderaza, bool EstadoRaza, int IdTipoanimal);
        Task<RazaTipoAnimalDto> SeleccionarRaza(int IdRaza);
        Task EliminarRaza(int IdRaza);
        Task ActualizarRaza(int IdRaza, string Tipoderaza, bool EstadoRaza, int IdTipoanimal);
    }
}