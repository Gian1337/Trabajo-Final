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
    public class MPPEntrega : IGestor<BEEntrega>
    {   
        const string archivo = @".\DATA\Entrega.xml";
        const string archivo2 = @".\DATA\Entrega_Material.xml";
        public bool Borrar(BEEntrega oBEEntrega)
        {
            try
            {
                XDocument docXML = XDocument.Load(archivo);

                var query = from e in docXML.Descendants("Entrega")
                            where int.Parse(e.Attribute("EntregaId").Value) == oBEEntrega.ID
                            select e;

                query.Remove();
                docXML.Save(archivo);

                return true;
            }
            catch (Exception ex) { throw ex; }
        }

        public int EntregaId()
        {
            XDocument docXML = XDocument.Load(archivo);

            int ultimoId = docXML.Descendants("Entrega")
                .Select(e => (int?)e.Attribute("EntregaId"))
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

        public bool Guardar(BEEntrega oBEEntrega)
        {
            try
            {
                XDocument docXML = XDocument.Load(archivo);
                XDocument docXML2 = XDocument.Load(archivo2);

                if (oBEEntrega.ID == 0)
                {
                    oBEEntrega.ID = EntregaId();
                    docXML.Element("Entregas").Add(new XElement("Entrega",
                        new XAttribute("EntregaId", oBEEntrega.ID.ToString()),
                        new XElement("Fecha", oBEEntrega.Fecha.ToString()),
                        new XElement("Codigo", oBEEntrega.Codigo),
                        new XElement("Estado", "Espera"),
                        new XElement("OrdenId", oBEEntrega.Orden.ID.ToString())
                        ));
                    foreach (BEMaterial p in oBEEntrega.Orden.listaMateriales)
                    {
                        docXML2.Element("Entregas_Materiales").Add(new XElement("Entrega_Materiales",
                            new XElement("EntregaId", oBEEntrega.ID.ToString()),
                            new XElement("MaterialId", p.ID.ToString()),
                            new XElement("Cantidad", p.Cantidad.ToString())
                            ));
                    }
                    docXML.Save(archivo);
                    docXML2.Save(archivo2);
                    return true;
                }
                else
                {
                    var query = from e in docXML.Descendants("Entrega")
                                where e.Attribute("EntregaId").Value == oBEEntrega.ID.ToString().Trim()
                                select e;
                    foreach (XElement e in query)
                    {
                        e.Element("Fecha").Value = oBEEntrega.Fecha.ToString();
                    }
                    docXML.Save(archivo);
                    return true;
                }
            }
            catch (Exception ex) { 

                throw ex;
            }
        }

        public List<BEEntrega> ListarTodo()
        {
            try
            {
                XDocument docXML = XDocument.Load(archivo);

                var query = from e in docXML.Descendants("Entrega")
                            select e;

                List<BEEntrega> listaEntregas = new List<BEEntrega>();
                foreach (XElement e in query)
                {
                    BEEntrega oBEEntrega = new BEEntrega();
                    oBEEntrega.ID = int.Parse(e.Attribute("EntregaId").Value);
                    oBEEntrega.Fecha = DateTime.Parse(e.Element("Fecha").ToString());
                    oBEEntrega.Estado = e.Element("Estado").Value;

                    listaEntregas.Add(oBEEntrega);
                }

                return listaEntregas;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        
        public BEEntrega BuscarOrdenEntregaPorCodigo(string codigo)
        {
            try
            {
                
                XDocument docXML = XDocument.Load(archivo);
                MPPOrden oMPPOrden = new MPPOrden();

                var query = from e in docXML.Descendants("Entrega")
                            where e.Element("Codigo").Value == codigo
                            where e.Element("Estado").Value == "Espera"
                            select new BEEntrega()
                            {
                                ID = int.Parse(e.Attribute("EntregaId").Value),
                                Fecha = DateTime.Parse(e.Element("Fecha").Value),
                                Codigo = e.Element("Codigo").Value,
                                Estado = e.Element("Estado").Value,
                                Orden = oMPPOrden.ListarTodo().Find(x => x.ID == int.Parse(e.Element("OrdenId").Value))
                            };
                return query.FirstOrDefault();
            }
            catch (Exception ex) { throw ex; }
        }
        
        

        public void GestionarOrdenEntrega(BEEntrega oBEEntrega)
        {
            try
            {
                if (oBEEntrega.ID != 0)
                {
                    XDocument docXml = XDocument.Load(archivo);
                    var query = from e in docXml.Descendants("Entrega")
                                where e.Attribute("EntregaId").Value == oBEEntrega.ID.ToString().Trim()
                                select e;
                    foreach (XElement e in query)
                    {
                        // Set nuevo estado
                        e.Element("Estado").Value = "Finalizado";
                    }
                    docXml.Save(archivo);
                }
            }
           catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
