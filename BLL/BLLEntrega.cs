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
    public class BLLEntrega : IGestor<BEEntrega>

    {
        public BLLEntrega()
        {
            oMPPEntrega = new MPPEntrega();
        }

        MPPEntrega oMPPEntrega;
        public bool Borrar(BEEntrega oBEEntrega)
        {
            return oMPPEntrega.Borrar(oBEEntrega);
        }

        public bool Guardar(BEEntrega oBEEntrega)
        {
            return oMPPEntrega.Guardar(oBEEntrega);
        }

        public List<BEEntrega> ListarTodo()
        {
            return oMPPEntrega.ListarTodo();
        }
        

        public BEEntrega BuscarOrdenEntregaPorCodigo(string codigo)
        {
            return oMPPEntrega.BuscarOrdenEntregaPorCodigo(codigo);
        }
        
        public void GestionarOrdenEntrega(BEEntrega oBEEntrega)
        {
            oMPPEntrega.GestionarOrdenEntrega(oBEEntrega);
        }

    }
}
