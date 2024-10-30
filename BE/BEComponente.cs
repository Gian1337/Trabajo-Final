using Abstraccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public abstract class BEComponente : Entidad
    {
        #region PROPIEDADES

        //Clase abstracta que define la interfaz para todos los objetos en la composición (componentes compuestos e individuales)
        public string Nombre { get; set; }

        public bool isRol { get; set; }

        #endregion

        #region CONSTRUCTOR
        public BEComponente(string pNombre)
        {
            Nombre = pNombre;
        }
        #endregion

        public abstract IList<BEComponente> ObtenerHijos();

        public abstract void AgregarHijo(BEComponente oBEComponente);

        public override string ToString()
        {
            return Nombre;
        }
    }
}
