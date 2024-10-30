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
    public class BLLPedidoMateriaPrima : IGestor<BEPedidoMateriaPrima>
    {
        public BLLPedidoMateriaPrima()
        {
            oMPPPedidoMateriaPrima = new MPPPedidoMateriaPrima();
        }

        MPPPedidoMateriaPrima oMPPPedidoMateriaPrima;
        public bool Borrar(BEPedidoMateriaPrima oBEPedidoMateriaPrima)
        {
            return oMPPPedidoMateriaPrima.Borrar(oBEPedidoMateriaPrima);
        }

        public bool Guardar(BEPedidoMateriaPrima oBEPedidoMateriaPrima)
        {
            return oMPPPedidoMateriaPrima.Guardar(oBEPedidoMateriaPrima);
        }

        public List<BEPedidoMateriaPrima> ListarTodo()
        {
            return oMPPPedidoMateriaPrima.ListarTodo();
        }

        //TODO: Agregar METODO a diagrama de clases
        public void FinalizarPedidoMateriaPrima(BEPedidoMateriaPrima oBEPedidoMateriaPrima)
        {
            oMPPPedidoMateriaPrima.FinalizarPedidoMateriaPrima(oBEPedidoMateriaPrima);
        }
    }
}
