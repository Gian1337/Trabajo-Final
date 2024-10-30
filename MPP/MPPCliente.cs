using Abstraccion;
using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MPP
{
    public class MPPCliente : IGestor<BECliente>
    {
        const string archivo = @".\DATA\Cliente.xml";
        const string archivo2 = @".\DATA\Orden.xml";
        public bool Borrar(BECliente oBECliente)
        {
            try
            {
                XDocument docXML = XDocument.Load(archivo2);

                int cantidadVentas = docXML.Descendants("Orden").Count(orden => (int)orden.Element("ClienteId") == oBECliente.ID);


                if (cantidadVentas == 0)
                {
                    // CLIENTE SIN ORDENES
                    XDocument docXML2 = XDocument.Load(archivo);

                    var query = from e in docXML2.Descendants("Cliente")
                                where int.Parse(e.Attribute("ClienteId").Value) == oBECliente.ID
                                select e;

                    query.Remove();
                    docXML2.Save(archivo);
                    return true;
                }
                else
                {
                    // CLIENTE CON ORDENES
                    return false;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int ClienteId()
        {
            XDocument docXML = XDocument.Load(archivo);
            
            int ultimoId = docXML.Descendants("Cliente")
                .Select(e => (int?)e.Attribute("ClienteId"))
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

        public bool Guardar(BECliente oBECliente)
        {
            try
            {
                XDocument docXML = XDocument.Load(archivo);

                if(oBECliente.ID == 0)
                {
                    docXML.Element("Clientes").Add(new XElement("Cliente",
                        new XAttribute("ClienteId", ClienteId()),
                        new XElement("Nombre", oBECliente.Nombre.Trim()),
                        new XElement("Apellido", oBECliente.Apellido.Trim()),
                        new XElement("NroDocumento", oBECliente.NroDocumento.Trim()),
                        new XElement("TipoDocumento", oBECliente.TipoDocumento.Trim()),
                        new XElement("Direccion", oBECliente.Direccion.Trim()),
                        new XElement("DireccionEntrega", oBECliente.DireccionEntrega.Trim()),
                        new XElement("Email", oBECliente.Email.Trim()),
                        new XElement("Telefono", oBECliente.Telefono.Trim()),
                        new XElement("RazonSocial", oBECliente.RazonSocial.Trim())
                        ));

                    docXML.Save(archivo);
                    return true;
                }
                else
                {
                    var query = from e in docXML.Descendants("Cliente")
                                where e.Attribute("ClienteId").Value == oBECliente.ID.ToString().Trim()
                                select e;
                    foreach (XElement e in query)
                    {
                        e.Element("Nombre").Value = oBECliente.Nombre.Trim();
                        e.Element("Apellido").Value = oBECliente.Apellido.Trim();
                        e.Element("NroDocumento").Value = oBECliente.NroDocumento.Trim();
                        e.Element("TipoDocumento").Value = oBECliente.TipoDocumento.Trim();
                        e.Element("Direccion").Value = oBECliente.Direccion.Trim();
                        e.Element("DireccionEntrega").Value = oBECliente.DireccionEntrega.Trim();
                        e.Element("Email").Value = oBECliente.Email.Trim();
                        e.Element("Telefono").Value = oBECliente.Telefono.Trim();
                        e.Element("RazonSocial").Value = oBECliente.RazonSocial.Trim();
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

        public List<BECliente> ListarTodo()
        {
            try
            {
                XDocument docXML = XDocument.Load(archivo);

                var query = from e in docXML.Descendants("Cliente")
                            select e;

                List<BECliente> listaClientes = new List<BECliente>();
                foreach (XElement e in query)
                {
                    BECliente oBECliente = new BECliente();
                    oBECliente.ID = int.Parse(e.Attribute("ClienteId").Value);
                    oBECliente.Nombre = e.Element("Nombre").Value;
                    oBECliente.Apellido = e.Element("Apellido").Value;
                    oBECliente.NroDocumento = e.Element("NroDocumento").Value;
                    oBECliente.TipoDocumento = e.Element("TipoDocumento").Value;
                    oBECliente.Direccion = e.Element("Direccion").Value;
                    oBECliente.DireccionEntrega = e.Element("DireccionEntrega").Value;
                    oBECliente.Email = e.Element("Email").Value;
                    oBECliente.Telefono = e.Element("Telefono").Value;
                    oBECliente.RazonSocial = e.Element("RazonSocial").Value;

                    listaClientes.Add(oBECliente);
                }

                return listaClientes;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
