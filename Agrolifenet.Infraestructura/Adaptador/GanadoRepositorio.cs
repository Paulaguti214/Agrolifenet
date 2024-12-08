﻿using Agrolifenet.Dominio.Dto;
using Agrolifenet.Dominio.Entidades;
using Agrolifenet.Dominio.Puerto;
using Agrolifenet.Infraestructura.Adaptador.BaseRepositorio;
using System.Data;

namespace Agrolifenet.Infraestructura.Adaptador
{
    public class GanadoRepositorio : Repositorio<Ganado>, IGanadoRepositorio
    {
        private readonly string NombreProcedimientoGuardarGanado = "InsertarGanado";
        private readonly string NombreProcedimientoSeleccionarGanado = "BuscarGanado";
        private readonly string NombreProcedimientoEliminarGanado = "EliminarGanado";
        private readonly string NombreProcedimientoActualizarGanado = "ActualizarGanado";
        private readonly string NombreProcedimientoListarGanado = "ListarGanado";


        public GanadoRepositorio(IDbConnection baseDeDatos) : base(baseDeDatos) { }

        public async Task AgregarGanado(DateTime FechadecreacionGanado, DateTime FechademodificacionGanado, bool EstadoGanado, int EdadGanado, string sexoGanado, string NumeridechipGanado, string ColorGanado, string LugardenacimientoGanado, int? IdMadreGanado, int? IdPadreGanado, int IdRaza, int IdReproduccion, string EstadoNacido, string DescripcionNacimiento, int PesoNacido)
        {
            await AgregarAsync(NombreProcedimientoGuardarGanado, new
            {
                FechadecreacionGanado,
                FechademodificacionGanado,
                EstadoGanado,
                EdadGanado,
                sexoGanado,
                NumeridechipGanado,
                ColorGanado,
                LugardenacimientoGanado,
                IdMadreGanado,
                IdPadreGanado,
                IdRaza,
                IdReproduccion,
                EstadoNacido,
                DescripcionNacimiento,
                PesoNacido
            });
        }
        public async Task<GanadoDto> SeleccionarGanado(int? IdGanado, string? numeroChip)
        {
            return await SeleccionarAsync<GanadoDto>(NombreProcedimientoSeleccionarGanado, new
            {
                IdGanado,
                numeroChip
            });
        }
        public async Task EliminarGanado(int IdGanado)
        {
            await EliminarAsync(NombreProcedimientoEliminarGanado, new
            {
                IdGanado
            });
        }
        public async Task ActualizarGanado(int IdGanado, DateTime FechademodificacionGanado, bool EstadoGanado, int EdadGanado, string sexoGanado, string NumeridechipGanado, string ColorGanado, string LugardenacimientoGanado, int? IdMadreGanado, int? IdPadreGanado, int IdRaza, int IdReproduccion, string EstadoNacido, string DescripcionNacimiento, int PesoNacido)
        {
            await ActualizarAsync(NombreProcedimientoActualizarGanado, new
            {
                IdGanado,
                FechademodificacionGanado,
                EstadoGanado,
                EdadGanado,
                sexoGanado,
                NumeridechipGanado,
                ColorGanado,
                LugardenacimientoGanado,
                IdMadreGanado,
                IdPadreGanado,
                IdRaza,
                IdReproduccion,
                EstadoNacido,
                DescripcionNacimiento,
                PesoNacido
            });
        }

        public async Task<IEnumerable<GanadoDto>> ListarGanado()
        {
            return await ListarAsync<GanadoDto>(NombreProcedimientoListarGanado);
        }
    }
}
