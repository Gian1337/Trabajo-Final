using Abstraccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Xml.Linq;
using Servicio;

namespace MPP
{
    public class MPPEmpleado : IGestor<BEEmpleado>
    {
        const string archivo = @".\DATA\Empleado.xml";
        const string archivo2 = @".\DATA\Empleado_Permiso.xml";
        public bool Borrar(BEEmpleado oBEEmpleado)
        {
            try
            {
                XDocument docXML = XDocument.Load(archivo);
                var query = from e in docXML.Descendants("Empleado")
                            where e.Attribute("EmpleadoId").Value == oBEEmpleado.ID.ToString()
                            select e;
                query.Remove();

                XDocument docXML2 = XDocument.Load(archivo2);
                var query2 = from e in docXML2.Descendants("Empleado_Permiso")
                             where e.Element("EmpleadoId").Value == oBEEmpleado.ID.ToString()
                             select e;
                query2.Remove();

                docXML.Save(archivo);
                docXML2.Save(archivo2);

                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int UsuarioId()
        {
            try
            {
                XDocument docXML = XDocument.Load(archivo);

                int ultimoId = docXML.Descendants("Empleado")
                    .Select(e => (int?)e.Attribute("EmpleadoId"))
                    .Max() ?? 0;

                if (ultimoId == 0)
                {
                    ultimoId = 1;
                }
                else
                {
                    ultimoId++;
                }
                return ultimoId;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool Guardar(BEEmpleado oBEEmpleado)
        {
            try
            {
                XDocument docXML = XDocument.Load(archivo);

                if (oBEEmpleado.ID == 0)
                {
                    docXML.Element("Empleados").Add(new XElement("Empleado",
                    new XAttribute("EmpleadoId", UsuarioId()),
                    new XElement("NombreUsuario", oBEEmpleado.NombreUsuario.Trim()),
                    new XElement("Password", Seguridad.EncriptarMD5(oBEEmpleado.Password.Trim())),
                    new XElement("Nombre", oBEEmpleado.Nombre.Trim()),
                    new XElement("Apellido", oBEEmpleado.Apellido.Trim()),
                    new XElement("Area", oBEEmpleado.Area.Trim())
                    ));

                    docXML.Save(archivo);
                    return true;
                }
                else
                {
                    var query = from e in docXML.Descendants("Empleado")
                                where e.Attribute("EmpleadoId").Value == oBEEmpleado.ID.ToString().Trim()
                                select e;
                    foreach (XElement e in query)
                    {
                        e.Element("NombreUsuario").Value = oBEEmpleado.NombreUsuario.Trim();
                        e.Element("Password").Value = Seguridad.EncriptarMD5(oBEEmpleado.Password.Trim());
                        e.Element("Nombre").Value = oBEEmpleado.Nombre.Trim();
                        e.Element("Apellido").Value = oBEEmpleado.Apellido.Trim();
                        e.Element("Area").Value = oBEEmpleado.Area.Trim();
                    }
                    docXML.Save(archivo);
                    return true;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<BEEmpleado> ListarTodo()
        {
            try
            {
                XDocument docXML = XDocument.Load(archivo);

                var query = from e in docXML.Descendants("Empleado")
                            select e;

                List<BEEmpleado> listaEmpleados = new List<BEEmpleado>();
                foreach (XElement e in query)
                {
                    BEEmpleado oBEEmpleado = new BEEmpleado();
                    oBEEmpleado.ID = int.Parse(e.Attribute("EmpleadoId").Value);
                    oBEEmpleado.NombreUsuario = e.Element("NombreUsuario").Value;
                    oBEEmpleado.Nombre = e.Element("Nombre").Value;
                    oBEEmpleado.Apellido = e.Element("Apellido").Value;
                    oBEEmpleado.Password = e.Element("Password").Value;
                    oBEEmpleado.Area = e.Element("Area").Value;
                    listaEmpleados.Add(oBEEmpleado);
                }

                return listaEmpleados;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool VerificarDatos(BEEmpleado oBEEmpleado)
        {
            try
            {
                XElement xml = XElement.Load(archivo);

                var query = from e in xml.Descendants("Empleado")
                            where e.Element("NombreUsuario").Value.Trim() == oBEEmpleado.NombreUsuario.Trim()
                            where e.Element("Password").Value.Trim() == Seguridad.EncriptarMD5(oBEEmpleado.Password.Trim())
                            select e;

                if (query.Any() == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex) { throw ex; }
        }
        public string DesenscriptarPassword(BEEmpleado oBEEmpleado)
        {
            return Seguridad.DesencriptarMD5(ListarTodo().Find(x => x.ID == oBEEmpleado.ID).Password);
        }
    }
}
