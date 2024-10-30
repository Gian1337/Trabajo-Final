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
    public class MPPPedidoMateriaPrima : IGestor<BEPedidoMateriaPrima>
    {
        const string archivo = @".\DATA\PedidoMateriaPrima.xml";
        const string archivo2 = @".\DATA\PedidoMateriaPrima_Material.xml";
        const string archivo3 = @".\DATA\Deposito_Material.xml";
        public bool Borrar(BEPedidoMateriaPrima oBEPedidoMateriaPrima)
        {
            try
            {
                XDocument docXML = XDocument.Load(archivo);

                var query = from e in docXML.Descendants("PedidoMateriaPrima")
                            where int.Parse(e.Attribute("PedidoMateriaPrimaId").Value) == oBEPedidoMateriaPrima.ID
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

        public int PedidoMateriaPrimaId()
        {
            XDocument docXml = XDocument.Load(archivo);

            int ultimoId = docXml.Descendants("PedidoMateriaPrima")
                .Select(e => (int?)e.Attribute("PedidoMateriaPrimaId"))
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
        public bool Guardar(BEPedidoMateriaPrima oBEPedidoMateriaPrima)
        {
            try
            {
                XDocument docXML = XDocument.Load(archivo);
                XDocument docXML2 = XDocument.Load(archivo2);

                if (oBEPedidoMateriaPrima.ID == 0)
                {
                    oBEPedidoMateriaPrima.ID = PedidoMateriaPrimaId();
                    docXML.Element("PedidosMateriaPrima").Add(new XElement("PedidoMateriaPrima",
                        new XAttribute("PedidoMateriaPrimaId", oBEPedidoMateriaPrima.ID),
                        new XElement("Fecha", oBEPedidoMateriaPrima.Fecha.ToString())
                        ));

                    foreach (BEMaterial mat in oBEPedidoMateriaPrima.Materiales)
                    {
                        docXML2.Element("PedidoMateriasPrimas_Materiales").Add(new XElement("PedidoMateriaPrima_Material",
                            new XElement("PedidoMateriaPrimaId", oBEPedidoMateriaPrima.ID),
                            new XElement("MaterialId", mat.ID),
                            new XElement("Cantidad", mat.Cantidad)
                            ));
                    }

                    docXML.Save(archivo);
                    docXML2.Save(archivo2);
                    return true;
                }
                else
                {
                    var query = from e in docXML.Descendants("PedidoMateriaPrima")
                                where e.Attribute("PedidoMaterialId").Value == oBEPedidoMateriaPrima.ID.ToString().Trim()
                                select e;
                    foreach (XElement e in query)
                    {
                        e.Element("Fecha").Value = oBEPedidoMateriaPrima.Fecha.ToString();
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

        public List<BEPedidoMateriaPrima> ListarTodo()
        {
            try
            {
                XDocument docXML = XDocument.Load(archivo);
                XDocument docXML2 = XDocument.Load(archivo2);
                MPPMaterial oMPPMaterial = new MPPMaterial();

                var query = from e in docXML.Descendants("PedidoMateriaPrima")
                            select e;

                List<BEPedidoMateriaPrima> listaPedidosMateriaPrima = new List<BEPedidoMateriaPrima>();
                foreach (XElement e in query)
                {
                    BEPedidoMateriaPrima oBEPedidoMateriaPrima = new BEPedidoMateriaPrima();
                    oBEPedidoMateriaPrima.ID = int.Parse(e.Attribute("PedidoMateriaPrimaId").Value);
                    oBEPedidoMateriaPrima.Fecha = DateTime.Parse(e.Element("Fecha").Value);
                    var query2 = from p in docXML2.Descendants("PedidoMateriaPrima_Material")
                                 where p.Element("PedidoMateriaPrimaId")?.Value == oBEPedidoMateriaPrima.ID.ToString()
                                 select p;

                    foreach (XElement e2 in query2)
                    {
                        BEMaterial oBEMaterial = new BEMaterial();
                        oBEMaterial = oMPPMaterial.ListarTodo().Find(x => x.ID == int.Parse(e2.Element("MaterialId").Value));
                        oBEMaterial.Cantidad = int.Parse(e2.Element("Cantidad").Value);
                        oBEPedidoMateriaPrima.Materiales.Add(oBEMaterial);
                    }

                    listaPedidosMateriaPrima.Add(oBEPedidoMateriaPrima);
                }

                return listaPedidosMateriaPrima;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void FinalizarPedidoMateriaPrima(BEPedidoMateriaPrima oBEPedidoMateriaPrima)
        {
            XDocument docXML = XDocument.Load(archivo);
            XDocument docXML2 = XDocument.Load(archivo2);
            XDocument docXML3 = XDocument.Load(archivo3);

            var query = from e in docXML.Descendants("PedidoMateriaPrima")
                        where e.Attribute("PedidoMateriaPrimaId").Value == oBEPedidoMateriaPrima.ID.ToString()
                        select e;

            query.Remove();

            foreach (BEMaterial material in oBEPedidoMateriaPrima.Materiales)
            {
                var query2 = from p in docXML2.Descendants("PedidoMateriaPrima_Material")
                             where p.Element("PedidoMateriaPrimaId").Value == oBEPedidoMateriaPrima.ID.ToString()
                             where p.Element("MaterialId").Value == material.ID.ToString()
                             select p;

                query2.Remove();
                docXML2.Save(archivo2);

                var query3 = from p in docXML3.Descendants("Deposito_Material")
                             where p.Element("MaterialId").Value == material.ID.ToString()
                             select p;
                foreach (XElement e in query3)
                {
                    e.Element("Cantidad").Value = material.Cantidad.ToString();
                    e.Element("Lote").Value = DateTime.Now.ToString("yyMMdd");
                }
            }
            docXML.Save(archivo);
            docXML3.Save(archivo3);
        }
    }
}
