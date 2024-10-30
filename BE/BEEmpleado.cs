using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEEmpleado : Entidad
    {
        #region Propiedades
        public string NombreUsuario { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Area { get; set; }

        public List<BEComponente> listaPermisos = new List<BEComponente>();

        #endregion

        #region Constructores
        public BEEmpleado() { }
        public BEEmpleado(int id, string nombreUsuario, string password, string nombre, string apellido, string area)
        {
            ID = id;
            NombreUsuario = nombreUsuario;
            Password = password;
            Nombre = nombre;
            Apellido = apellido;
            Area = area;
        }

        #endregion
    }
}
