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
    public class BLLPermiso : BLLComponente, IGestor<BEComponente>
    {
        MPPPermiso oMPPPermiso;

        public BLLPermiso()
        {
            oMPPPermiso = new MPPPermiso();
        }
        public override void AgregarHijo(BEComponente oBEComponente)
        {
            throw new NotImplementedException();
        }

        public override bool Borrar(BEComponente obj)
        {
            return oMPPPermiso.Borrar(obj);
        }

        public override bool Guardar(BEComponente obj)
        {
           return oMPPPermiso.Guardar(obj);
        }

        public override List<BEComponente> ListarTodo()
        {
            throw new NotImplementedException();
        }

        public List<BEComponente> ListarRoles()
        {
            return oMPPPermiso.ListarRoles();
        }

        public List<BEComponente> ListarPermisosIndividuales()
        {
            return oMPPPermiso.ListarPermisosIndividuales();
        }

        public override IList<BEComponente> ObtenerHijos(BEComponente oBEComponente)
        {
            throw new NotImplementedException();
        }

        public List<BEComponente> ListarPermisosUsuario(BEEmpleado oBEEmpleado)
        {
            return oMPPPermiso.ListarPermisosUsuario(oBEEmpleado);
        }
        public bool AsignarPermisoUsuario(BEEmpleado oBEEmpleado, BEComponente oBEPermiso)
        {
            return oMPPPermiso.AsignarPermisoUsuario(oBEEmpleado, oBEPermiso);
        }
        public bool BorrarPermisoUsuario(BEEmpleado oBEEmpleado, BEComponente oBEComponente)
        {
            return oMPPPermiso.BorrarPermisoUsuario(oBEEmpleado, oBEComponente);
        }

        public bool AsignarPermisoARol(BERol rol, BEPermiso permiso)
        {
            return oMPPPermiso.AsignarPermisoARol(rol, permiso);
        }

        public bool EliminarPermisodeRol(BERol rol, BEPermiso permiso)
        {
            return oMPPPermiso.EliminarPermisodeRol(rol, permiso);
        }
    }
}
