using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEPermiso : BEComponente
    {   

        //Permisos individuales (hojas)
        //Elemento básico que no tiene subelementos. Hacen todo el trabajo
        public BEPermiso(string pNombre) : base(pNombre)
        {

        }
        public override void AgregarHijo(BEComponente oBEComponente)
        {
            throw new NotImplementedException();
        }

        public override IList<BEComponente> ObtenerHijos()
        {
            throw new NotImplementedException();
        }
    }
}
