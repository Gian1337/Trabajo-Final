using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEPedidoMateriaPrima : Entidad
    {
        #region Propiedades
        public DateTime Fecha { get; set; }

        public List<BEMaterial> Materiales = new List<BEMaterial>();

        #endregion
    }
}
