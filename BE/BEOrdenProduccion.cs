using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEOrdenProduccion : Entidad
    {
        #region Propiedades
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public int Cantidad { get; set; }
        public string Lote { get; set; } 

        public List<string> Pasos = new List<string>(); 

        public BEEmpleado Empleado = new BEEmpleado();

        public BEPedidoMateriaPrima PedidoMateriaPrima = new BEPedidoMateriaPrima();

        public BEMaterial Material { get; set; }

        #endregion
    }
}
