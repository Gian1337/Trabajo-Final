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
    public class BLLFactura : IGestor<BEFactura>
    {
        public BLLFactura()
        {
            oMPPFactura = new MPPFactura();
        }

        MPPFactura oMPPFactura;
        public bool Borrar(BEFactura oBEFactura)
        {
            return oMPPFactura.Borrar(oBEFactura);
        }

        public bool Guardar(BEFactura oBEFactura)
        {
            return oMPPFactura.Guardar(oBEFactura);
        }

        public List<BEFactura> ListarTodo()
        {
            return oMPPFactura.ListarTodo();
        }
    }
}
