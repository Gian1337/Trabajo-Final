using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BECliente : Entidad
    {
        #region Propiedades
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NroDocumento { get; set; }
        public string TipoDocumento { get; set; }
        public string Direccion { get; set; }
        public string DireccionEntrega { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string RazonSocial { get; set; }

        #endregion
    }
}
