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
    public class MPPFactura : IGestor<BEFactura>
    {
        const string archivo = @".\DATA\Factura.xml";
        public bool Borrar(BEFactura oBEFactura)
        {
            try
            {
                XDocument docXML = XDocument.Load(archivo);

                var query = from e in docXML.Descendants("Factura")
                            where int.Parse(e.Attribute("FacturaId").Value) == oBEFactura.ID
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

        public int FacturaCompraId()
        {
            XDocument docXml = XDocument.Load(archivo);

            int ultimoId = docXml.Descendants("Factura")
                .Select(e => (int?)e.Attribute("FacturaId"))
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

        public bool Guardar(BEFactura oBEFactura)
        {
            try
            {
                XDocument docXML = XDocument.Load(archivo);

                if (oBEFactura.ID == 0)
                {
                    oBEFactura.ID = FacturaCompraId();
                    docXML.Element("Facturas").Add(new XElement("Factura",
                        new XAttribute("FacturaId", oBEFactura.ID.ToString()),
                        new XElement("NumeroFactura", oBEFactura.ID.ToString()),
                        new XElement("Fecha", oBEFactura.Fecha.ToString()),
                        new XElement("TipoFactura", oBEFactura.Tipo),
                        new XElement("Total", oBEFactura.Total.ToString())
                        ));

                    docXML.Save(archivo);
                    return true;
                }
                else
                {
                    var query = from e in docXML.Descendants("Factura")
                                where e.Attribute("FacturaId").Value == oBEFactura.ID.ToString().Trim()
                                select e;
                    foreach (XElement e in query)
                    {
                        e.Element("NumeroFactura").Value = oBEFactura.Numero;
                        e.Element("Fecha").Value = oBEFactura.Fecha.ToString();
                        e.Element("TipoFactura").Value = oBEFactura.Tipo.ToString();
                        e.Element("Total").Value = oBEFactura.Total.ToString();
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

        public List<BEFactura> ListarTodo()
        {
            try
            {
                XDocument docXML = XDocument.Load(archivo);

                var query = from e in docXML.Descendants("Factura")
                            select e;

                List<BEFactura> listaFacturaCompras = new List<BEFactura>();
                foreach (XElement e in query)
                {
                    BEFactura oBEFacturaCompra = new BEFactura();
                    oBEFacturaCompra.ID = int.Parse(e.Attribute("FacturaId").Value);
                    oBEFacturaCompra.Numero = e.Element("NumeroFactura").Value;
                    oBEFacturaCompra.Fecha = DateTime.Parse(e.Element("Fecha").Value);
                    oBEFacturaCompra.Tipo = e.Element("TipoFactura").Value;
                    oBEFacturaCompra.Total = double.Parse(e.Element("Total").Value);
                    listaFacturaCompras.Add(oBEFacturaCompra);
                }

                return listaFacturaCompras;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
