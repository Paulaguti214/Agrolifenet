﻿using Agrolifenet.Dominio.Dto;
using Agrolifenet.Dominio.Puerto;
using Agrolifenet.Dominio.Servicios;

namespace Agrolifenet.Infraestructura.Servicios
{
    internal class HistorialClinicoServicio : IHistorialClinicoServicio
    {
        private readonly IHistorialClinicoRepositorio _historialClinicoRepositorio;

        public HistorialClinicoServicio(IHistorialClinicoRepositorio historialClinicoRepositorio)
        {
            _historialClinicoRepositorio = historialClinicoRepositorio;
        }

        public async Task ActualizarHistorialClinico(int idHistorialClinico, bool estado, string vacunas, string tratamientos, string enfermedades, string resultadosExamenes, string infoDesparacitacion, int pesoAlNacer, int pesoActual, int gananciaPesoDiaria, string observaciones, string estadoSalud, decimal costoTratamiento, string seguimiento, int numeroPartos, int idGanado, int idUsuario, int idDatosReproduccion)
        {
            var fechaActual = DateTime.Now;
            await _historialClinicoRepositorio.ActualizarHistorialClinico(idHistorialClinico, fechaActual, fechaActual, estado, vacunas, tratamientos, enfermedades, resultadosExamenes, infoDesparacitacion, pesoAlNacer, pesoActual, gananciaPesoDiaria, observaciones, estadoSalud, costoTratamiento, seguimiento, numeroPartos, idGanado, idUsuario, idDatosReproduccion);
        }

        public async Task AgregarHistorialClinico(bool estado, string vacunas, string tratamientos, string enfermedades, string resultadosExamenes, string infoDesparacitacion, int pesoAlNacer, int pesoActual, int gananciaPesoDiaria, string observaciones, string estadoSalud, decimal costoTratamiento, string seguimiento, int numeroPartos, int idGanado, int idUsuario, int idDatosReproduccion)
        {
            var fechaActual = DateTime.Now;
            await _historialClinicoRepositorio.AgregarHistorialClinico(fechaActual, fechaActual, estado, vacunas, tratamientos, enfermedades, resultadosExamenes, infoDesparacitacion, pesoAlNacer, pesoActual, gananciaPesoDiaria, observaciones, estadoSalud, costoTratamiento, seguimiento, numeroPartos, idGanado, idUsuario, idDatosReproduccion);
        }

        public async Task EliminarHistorialClinico(int IdHistorialclinico)
        {
            await _historialClinicoRepositorio.EliminarHistorialClinico(IdHistorialclinico);
        }

        public async Task<IEnumerable<HistorialClinicoDto>> ListarHistorialClinico(int IdGanado)
        {
            return await _historialClinicoRepositorio.ListarHistorialClinico(IdGanado);
        }

        public async Task<HistorialClinicoDto> SeleccionarHistorialClinico(int IdHistorialclinico)
        {
            return await _historialClinicoRepositorio.SeleccionarHistorialClinico(IdHistorialclinico);
        }
    }
}