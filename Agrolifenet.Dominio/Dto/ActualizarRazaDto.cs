﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrolifenet.Dominio.Dto
{
    public  class ActualizarRazaDto
    {
        public int  IdRaza { get; set; }
        public string Tipoderaza { get; set; }
        public bool EstadoRaza { get; set; }
        public int  IdTipoanimal { get; set; }
    }
}