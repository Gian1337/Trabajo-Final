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
    public class BLLEmpleado : IGestor<BEEmpleado>
    {
        MPPEmpleado oMPPEmpleado;
        public BLLEmpleado()
        {
            oMPPEmpleado = new MPPEmpleado();
        }
        public bool Borrar(BEEmpleado oBEEmpleado)
        {
            return oMPPEmpleado.Borrar(oBEEmpleado);
        }

        public bool Guardar(BEEmpleado oBEEmpleado)
        {
            return oMPPEmpleado.Guardar(oBEEmpleado);
        }

        public List<BEEmpleado> ListarTodo()
        {
            return oMPPEmpleado.ListarTodo();
        }

        public bool VerificarDatos(BEEmpleado oBEEmpleado)
        {
            return oMPPEmpleado.VerificarDatos(oBEEmpleado);
        }

        public string DesencriptarPassword(BEEmpleado oBEEmpleado)
        {
            return oMPPEmpleado.DesenscriptarPassword(oBEEmpleado);
        }
    }
}
