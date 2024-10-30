using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEEntrega : Entidad
    {
        #region Propiedades
        public DateTime Fecha { get; set; }
        public string Codigo { get; set; }
        public string Estado { get; set; }
        public BEOrden Orden { get; set; }
        #endregion
    }
}
