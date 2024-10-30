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
    public class MPPOrden : IGestor<BEOrden>
    {
        const string archivo = @".\DATA\Orden.xml";
        const string archivo2 = @".\DATA\Orden_Material.xml";
        public bool Borrar(BEOrden oBEOrden)
        {
            try
            {
                XDocument docXML = XDocument.Load(archivo);

                var query = from e in docXML.Descendants("Orden")
                            where int.Parse(e.Attribute("OrdenId").Value) == oBEOrden.ID
                            select e;

                query.Remove();
                docXML.Save(archivo);

                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int OrdenId()
        {
            XDocument docXML = XDocument.Load(archivo);

            int ultimoId = docXML.Descendants("Orden")
                .Select(e => (int?)e.Attribute("OrdenId"))
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
        public bool Guardar(BEOrden oBEOrden)
        {
            try
            {
                XDocument docXML = XDocument.Load(archivo);
                XDocument docXML2 = XDocument.Load(archivo2);

                if (oBEOrden.ID == 0)
                {
                    oBEOrden.ID = OrdenId();
                    docXML.Element("Ordenes").Add(new XElement("Orden",
                        new XAttribute("OrdenId", oBEOrden.ID.ToString()),
                        new XElement("NumeroOrden", "O" + oBEOrden.ID.ToString()),
                        new XElement("ClienteId", oBEOrden.Cliente.ID.ToString()),
                        new XElement("Fecha", oBEOrden.Fecha.ToString()),
                        new XElement("ImporteTotal", oBEOrden.ImporteTotal.ToString()),
                        new XElement("EstadoId", oBEOrden.Estado.ID.ToString()),
                        new XElement("FacturaId", oBEOrden.Factura.ID.ToString())
                        ));

                    // carga de todos los productos del pedido
                    foreach (BEMaterial material in oBEOrden.listaMateriales)
                    {
                        docXML2.Element("Ordenes_Materiales").Add(new XElement("Orden_Material",
                            new XElement("OrdenId", oBEOrden.ID.ToString()),
                            new XElement("MaterialId", material.ID.ToString()),
                            new XElement("Cantidad", material.Cantidad.ToString()),
                            new XElement("Precio", material.Precio)
                            ));
                    }

                    docXML.Save(archivo);
                    docXML2.Save(archivo2);
                    return true;
                }
                else
                {
                    var query = from e in docXML.Descendants("Orden")
                                where e.Attribute("OrdenId").Value == oBEOrden.ID.ToString().Trim()
                                select e;
                    foreach (XElement e in query)
                    {
                        e.Element("NumeroOrden").Value = oBEOrden.Numero.ToString();
                        e.Element("ClienteId").Value = oBEOrden.Cliente.ID.ToString();
                        e.Element("Fecha").Value = oBEOrden.Fecha.ToString();
                        e.Element("ImporteTotal").Value = oBEOrden.ImporteTotal.ToString();
                        e.Element("EstadoId").Value = oBEOrden.Estado.ID.ToString(); 
                        e.Element("FacturaId").Value = oBEOrden.Factura.ID.ToString();
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

        
         
        public List<BEOrden> ListarTodo()
        {
            try
            {
                XDocument docXML = XDocument.Load(archivo);
                MPPCliente oMPPCliente = new MPPCliente(); // para listar los clientes y traerlos de manera simple
                MPPEstado oMPPEstado = new MPPEstado();
                MPPFactura oMPPFacturaCompra = new MPPFactura();

                var query = from e in docXML.Descendants("Orden")
                            select e;

                List<BEOrden> listaOrdenes = new List<BEOrden>();
                foreach (XElement e in query)
                {
                    BEOrden oBEOrden = new BEOrden();
                    oBEOrden.ID = int.Parse(e.Attribute("OrdenId").Value);
                    oBEOrden.Numero = e.Element("NumeroOrden").Value.ToString();
                    oBEOrden.Cliente = oMPPCliente.ListarTodo().Find(x => x.ID == int.Parse(e.Element("ClienteId").Value));
                    oBEOrden.Fecha = DateTime.Parse(e.Element("Fecha").Value);
                    oBEOrden.ImporteTotal = double.Parse(e.Element("ImporteTotal").Value);
                    oBEOrden.Estado = oMPPEstado.ListarTodo().Find(x => x.ID == int.Parse(e.Element("EstadoId").Value));
                    oBEOrden.Factura = oMPPFacturaCompra.ListarTodo().Find(x => x.ID == int.Parse(e.Element("FacturaId").Value));
                    if (oBEOrden.Factura == null)
                    {
                        oBEOrden.Factura = new BEFactura();
                    }
                    oBEOrden.listaMateriales = ListarMaterialesOrden(oBEOrden);
                    listaOrdenes.Add(oBEOrden);
                }

                return listaOrdenes;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<BEMaterial> ListarMaterialesOrden(BEOrden oBEOrden)
        {
            try
            {
                List<BEMaterial> ListaMaterialesOrden = new List<BEMaterial>();
                List<BEMaterial> ListaMateriales = new List<BEMaterial>();
                XDocument docXML = XDocument.Load(archivo2);
                MPPMaterial oMPPMaterial = new MPPMaterial();

                var query = from p in docXML.Descendants("Orden_Material")
                            where p.Element("OrdenId").Value == oBEOrden.ID.ToString()
                            select p;

                ListaMateriales = oMPPMaterial.ListarTodo();
                foreach (XElement p in query)
                {
                    BEMaterial oBEMaterial = ListaMateriales.Find(x => x.ID == int.Parse(p.Element("MaterialId").Value));
                    oBEMaterial.Cantidad = int.Parse(p.Element("Cantidad").Value);
                    ListaMaterialesOrden.Add(oBEMaterial);
                }
                return ListaMaterialesOrden;
            }
            catch (Exception ex) { throw ex; }
        }



    }
}
