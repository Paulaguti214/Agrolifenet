﻿using Agrolifenet.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrolifenet.Dominio.Servicios
{
    public interface IGanadoServicio
    {

        Task AgregarGanado( bool EstadoGanado, int EdadGanado, string sexoGanado,
         string NumeridechipGanado, string ColorGanado, string LugardenacimientoGanado, int IdMadreGanado, int IdPadreGanado, int IdRaza);
        Task<Ganado> SeleccionarGanado(int IdGanado);
        Task EliminarGanado(int IdGanado);
        Task ActualizarGanado(int IdGanado, bool EstadoGanado, int EdadGanado, string sexoGanado,
         string NumeridechipGanado, string ColorGanado, string LugardenacimientoGanado, int IdMadreGanado, int IdPadreGanado, int IdRaza);
    }
}