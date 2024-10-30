using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEOrden : Entidad
    {
        #region Propiedades
        public string Numero { get; set; }
        public DateTime Fecha { get; set; }
        public double ImporteTotal { get; set; }

        public BECliente Cliente = new BECliente();

        public BEFactura Factura = new BEFactura();

        public BEEstado Estado = new BEEstado();

        public List<BEMaterial> listaMateriales = new List<BEMaterial>();
        #endregion
    }
}
