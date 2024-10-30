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
    public class BLLMaterial : IGestor<BEMaterial>
    {
        public BLLMaterial()
        {
            oMPPMaterial = new MPPMaterial();
        }

        MPPMaterial oMPPMaterial;
        public bool Borrar(BEMaterial oBEMaterial)
        {
            return oMPPMaterial.Borrar(oBEMaterial);
        }

        public bool Guardar(BEMaterial oBEMaterial)
        {
            return oMPPMaterial.Guardar(oBEMaterial);
        }

        public List<BEMaterial> ListarTodo()
        {
           return oMPPMaterial.ListarTodo();
        }

        //TODO: AGREGAR MÉTODO A DIAGRAMA
        public List<BEMaterial> ListaMaterialesCantidadVendida()
        {
            return oMPPMaterial.ListaMaterialesCantidadVendida();
        }
    }
}
