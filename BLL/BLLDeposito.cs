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
    public class BLLDeposito : IGestor<BEDeposito>
    {
        public BLLDeposito()
        {
            oMPPDeposito = new MPPDeposito();
        }

        MPPDeposito oMPPDeposito;
        public bool Borrar(BEDeposito oBEDeposito)
        {
            return oMPPDeposito.Borrar(oBEDeposito);
        }

        public bool Guardar(BEDeposito oBEDeposito)
        {
            return oMPPDeposito.Guardar(oBEDeposito);
        }

        public List<BEDeposito> ListarTodo()
        {
            return oMPPDeposito.ListarTodo();
        }

        public void UpdateStockDeposito(BEMaterial oBEMaterial)
        {
            oMPPDeposito.UpdateStockDeposito(oBEMaterial);
        }
    }
}
