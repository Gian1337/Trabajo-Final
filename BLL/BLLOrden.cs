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
    public class BLLOrden : IGestor<BEOrden>
    {
        public BLLOrden()
        {
            oMPPOrden = new MPPOrden();
        }

        MPPOrden oMPPOrden;
        public bool Borrar(BEOrden oBEOrden)
        {
            return oMPPOrden.Borrar(oBEOrden);
        }

        public bool Guardar(BEOrden oBEOrden)
        {
            return oMPPOrden.Guardar(oBEOrden);
        }

        public List<BEOrden> ListarTodo() 
        {
            return oMPPOrden.ListarTodo();
        }

        public double CalcularTotal(BEOrden oBEOrden)
        {
            double total = 0;
            foreach (BEMaterial mat in oBEOrden.listaMateriales)
            {
                total += mat.Cantidad * mat.Precio;
            }
            total += total * 0.21;
            return total;
        }

        public double CalcularImporte(BEOrden oBEOrden)
        {
            return oBEOrden.listaMateriales.Sum(x => x.Precio * x.Cantidad);
        }
    }
}
