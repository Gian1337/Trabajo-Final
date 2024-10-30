using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEMaterial : Entidad
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Durabilidad { get; set; }
        public string Aislamiento { get; set; }
        public string Tipo { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }

        public override string ToString()
        {
            return this.Nombre;
        }
    }
}
