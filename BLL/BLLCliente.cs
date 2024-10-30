﻿using Abstraccion;
using BE;
using MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLCliente : IGestor<BECliente>
    {
        public BLLCliente()
        {
            oMPPCliente = new MPPCliente();
        }

        MPPCliente oMPPCliente;
        public bool Borrar(BECliente oBECliente)
        {
            return oMPPCliente.Borrar(oBECliente);
        }

        public bool Guardar(BECliente oBECliente)
        {
            return oMPPCliente.Guardar(oBECliente);
        }

        public List<BECliente> ListarTodo()
        {
            return oMPPCliente.ListarTodo();
        }
    }
}
