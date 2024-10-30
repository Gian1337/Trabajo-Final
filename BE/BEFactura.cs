using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEFactura : Entidad
    {
        public string Numero { get; set; }
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; }
        public Double Total { get; set; }
    }
}
