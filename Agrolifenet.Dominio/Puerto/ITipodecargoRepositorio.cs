﻿using Agrolifenet.Dominio.Entidades;
using Agrolifenet.Dominio.Puerto.BaseRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrolifenet.Dominio.Puerto
{
    public interface ITipodecargoRepositorio : IRepositorio<TiposdeCargo>
    {
        Task AgregarAsync(string tipodecargo, DateTime fechadecreacionTiposdecargo, DateTime fechademodificacionTiposdecargo,
            bool estadoTiposdecargo);
        Task<IEnumerable<TiposdeCargo>> ListarTiposdecargo();
        Task<TiposdeCargo> SeleccionarTiposdecargo(int idTiposdecargo);

        Task EliminarTiposdecargo(int idTiposdecargo);

        Task ActualizarTiposdecargo(int idTiposdecargo, string tipodecargo,  DateTime fechademodificacionTiposdecargo,
            bool estadoTiposdecargo);
    }
}