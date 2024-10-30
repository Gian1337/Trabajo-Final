using Abstraccion;
using BE;
using MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLEstado : IGestor<BEEstado>
    {
        public BLLEstado()
        {
            oMPPEstado = new MPPEstado();
        }

        MPPEstado oMPPEstado;
        public bool Borrar(BEEstado obj)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BEEstado obj)
        {
            throw new NotImplementedException();
        }

        public List<BEEstado> ListarTodo()
        {
            return oMPPEstado.ListarTodo();
        }
        public BEEstado ActualizaEstado(BEOrden oBEOrden)
        {
            return oMPPEstado.ActualizaEstado(oBEOrden);
        }
    }
}
