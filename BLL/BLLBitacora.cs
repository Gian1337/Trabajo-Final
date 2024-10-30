using Abstraccion;
using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPP;

namespace BLL
{
    public class BLLBitacora : IGestor<BEBitacora>
    {
        MPPBitacora oMPPBitacora;
        public BLLBitacora()
        {
            oMPPBitacora = new MPPBitacora();
        }
        public bool Borrar(BEBitacora oBEBitacora)
        {
            return oMPPBitacora.Borrar(oBEBitacora);
        }

        public bool Guardar(BEBitacora oBEBitacora)
        {
            return oMPPBitacora.Guardar(oBEBitacora);
        }

        public List<BEBitacora> ListarTodo()
        {
            return oMPPBitacora.ListarTodo();
        }

        public void Log(BEEmpleado pUsuario, string Evento)
        {
            // Registración de un evento en la bitacora
            BEBitacora oBEBitacora = new BEBitacora();
            BLLBitacora oBLLBitacora = new BLLBitacora();
            oBEBitacora.Fecha = DateTime.Now;
            oBEBitacora.Evento = Evento;
            oBEBitacora.UsuarioEmpleado = pUsuario;
            oBLLBitacora.Guardar(oBEBitacora);
        }
    }
}
