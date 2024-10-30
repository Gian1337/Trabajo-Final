﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEBitacora : Entidad
    {
        public DateTime Fecha { get; set; }
        public string Evento { get; set; }
        public BEEmpleado UsuarioEmpleado { get; set; }
        public override string ToString()
        {
            return Fecha.ToString() + " " + Evento + " " + UsuarioEmpleado.ToString();
        }
    }
}
