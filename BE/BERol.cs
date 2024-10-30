using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BERol : BEComponente 
    {
        //Clase que representa objetos compuestos que poseen componentes hijos.

        private List<BEComponente> _Permisos;

        public BERol(string pNombre) : base(pNombre)
        {
            _Permisos = new List<BEComponente>();
        }

        public override void AgregarHijo(BEComponente oBEComponente)
        {
            _Permisos.Add(oBEComponente);
        }

        public override IList<BEComponente> ObtenerHijos()
        {
            return _Permisos;
        }
    }
}
