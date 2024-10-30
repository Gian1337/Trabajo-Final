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
    public class MPPOrdenProduccion : IGestor<BEOrdenProduccion>
    {
        const string archivo = @".\DATA\OrdenProduccion.xml";
        const string archivo2 = @".\DATA\OrdenProduccion_Material.xml";
        const string archivo3 = @".\DATA\Deposito_Material.xml";

        public bool Borrar(BEOrdenProduccion oBEOrdenProduccion)
        {
            try
            {
                XDocument docXML = XDocument.Load(archivo);

                var query = from e in docXML.Descendants("OrdenProduccion")
                            where int.Parse(e.Attribute("OrdenProduccionId").Value) == oBEOrdenProduccion.ID
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

        public int OrdenMaterialId()
        {
            XDocument docXml = XDocument.Load(archivo);

            int ultimoId = docXml.Descendants("OrdenProduccion")
                .Select(e => (int?)e.Attribute("OrdenProduccionId"))
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

        public int OrdenProduccion_MaterialesId()
        {
            XDocument docXml = XDocument.Load(archivo);

            int ultimoId = docXml.Descendants("OrdenProduccion_Materiales")
                .Select(e => (int?)e.Attribute("OrdenProduccion_MaterialId"))
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
        public bool Guardar(BEOrdenProduccion oBEOrdenProduccion)
        {
            try
            {
                XDocument docXml = XDocument.Load(archivo);

                if (oBEOrdenProduccion.ID == 0)
                {
                    oBEOrdenProduccion.ID = OrdenMaterialId();
                    docXml.Element("OrdenesProduccion").Add(new XElement("OrdenProduccion",
                        new XAttribute("OrdenProduccionId", oBEOrdenProduccion.ID),
                        new XElement("Numero", oBEOrdenProduccion.ID),
                        new XElement("Fecha", oBEOrdenProduccion.Fecha.ToString()),
                        new XElement("Cantidad", oBEOrdenProduccion.Cantidad.ToString()),
                        new XElement("Lote", oBEOrdenProduccion.Lote),
                        new XElement("Pasos", oBEOrdenProduccion.Pasos),
                        new XElement("PedidoMaterialId", oBEOrdenProduccion.PedidoMateriaPrima.ID.ToString()),
                        new XElement("EmpleadoId", oBEOrdenProduccion.Empleado.ID.ToString())
                        ));

                    // OrdenProduccion_Material
                    XDocument docXml2 = XDocument.Load(archivo2);
                    docXml2.Element("OrdenesProduccion_Materiales").Add(new XElement("OrdenProduccion_Material",
                        new XAttribute("OrdenProduccion_MaterialId", OrdenProduccion_MaterialesId()),
                        new XElement("OrdenMaterialId", OrdenMaterialId()),
                        new XElement("MaterialId", oBEOrdenProduccion.Material.ID),
                        new XElement("Cantidad", oBEOrdenProduccion.Cantidad)
                        ));

                    docXml2.Save(archivo2);
                    docXml.Save(archivo);
                    return true;
                }
                else
                {
                    var query = from e in docXml.Descendants("OrdenProduccion")
                                where e.Attribute("OrdenProduccionId").Value == oBEOrdenProduccion.ID.ToString()
                                select e;
                    foreach (XElement e in query)
                    {
                        e.Element("Numero").Value = oBEOrdenProduccion.Numero.ToString();
                        e.Element("Fecha").Value = oBEOrdenProduccion.Fecha.ToString();
                        e.Element("Cantidad").Value = oBEOrdenProduccion.Cantidad.ToString();
                        e.Element("Lote").Value = oBEOrdenProduccion.Lote;
                        //e.Element("PedidoMaterialId").Value = (oBEOrdenProduccion.PedidoMateriaPrima != null) ? oBEOrdenProduccion.PedidoMateriaPrima.ID.ToString() : "0";
                        e.Element("EmpleadoId").Value = (oBEOrdenProduccion.Empleado != null) ? oBEOrdenProduccion.Empleado.ID.ToString() : "0";
                        e.Element("Pasos").Value = String.Empty;
                        foreach (string pasos in oBEOrdenProduccion.Pasos)
                        {
                            e.Element("Pasos").Value += $"{pasos}-";
                        }

                    }
                    docXml.Save(archivo);
                    return true;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<BEOrdenProduccion> ListarTodo()
        {
            try
            {
                XDocument docXML = XDocument.Load(archivo);
                XDocument docXML2 = XDocument.Load(archivo2);
                MPPMaterial oMPPMaterial = new MPPMaterial();
                MPPPedidoMateriaPrima oMPPPedidoMateriaPrima = new MPPPedidoMateriaPrima();
                MPPEmpleado oMPPEmpleado = new MPPEmpleado();

                var query = from e in docXML.Descendants("OrdenProduccion")
                            select e;

                List<BEOrdenProduccion> listaBEOrdenProducciones = new List<BEOrdenProduccion>();
                foreach (XElement e in query)
                {
                    BEOrdenProduccion oBEOrdenProduccion = new BEOrdenProduccion();
                    oBEOrdenProduccion.ID = int.Parse(e.Attribute("OrdenProduccionId").Value);
                    oBEOrdenProduccion.Numero = int.Parse(e.Element("Numero").Value);
                    oBEOrdenProduccion.Fecha = DateTime.Parse(e.Element("Fecha").Value);
                    oBEOrdenProduccion.Cantidad = int.Parse(e.Element("Cantidad").Value);
                    oBEOrdenProduccion.Lote = e.Element("Lote").Value;
                    BEPedidoMateriaPrima oBEPedidoMaterial = oMPPPedidoMateriaPrima.ListarTodo().FirstOrDefault(x => x.ID == int.Parse(e.Element("PedidoMateriaPrimaId").Value));
                    oBEOrdenProduccion.PedidoMateriaPrima = oBEPedidoMaterial;

                    BEEmpleado oBEEmpleado = oMPPEmpleado.ListarTodo().FirstOrDefault(x => x.ID == int.Parse(e.Element("EmpleadoId").Value));
                    oBEOrdenProduccion.Empleado = oBEEmpleado;
                    string[] pasos = e.Element("Pasos").Value.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string t in pasos)
                    {
                        oBEOrdenProduccion.Pasos.Add(t);
                    }
                    var query2 = from e2 in docXML2.Descendants("OrdenProduccion_Material")
                                 where e2.Element("OrdenMaterialId").Value == oBEOrdenProduccion.ID.ToString() //TODO: Revisar elemento
                                 select e2;
                    foreach (XElement e2 in query2)
                    {
                        oBEOrdenProduccion.Material = oMPPMaterial.ListarTodo().Find(x => x.ID == int.Parse(e2.Element("MaterialId").Value));
                    }

                    listaBEOrdenProducciones.Add(oBEOrdenProduccion);
                }

                return listaBEOrdenProducciones;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool CalcularStockMateriaPrima(BEOrdenProduccion oBEOrdenProduccion)
        {
            try
            {
                XDocument docXML = XDocument.Load(@".\DATA\Material.xml");
                XDocument docXML2 = XDocument.Load(@".\DATA\Deposito_Material.xml");

                // Búsqueda del componente del cual está fabricado.
                var query = from p in docXML.Descendants("Material")
                            where p.Element("Nombre").Value == oBEOrdenProduccion.Material.Nombre
                            select p;

                foreach (XElement e in query)
                {
                    var query2 = from a in docXML2.Descendants("Deposito_Material")
                                 where int.Parse(a.Element("MaterialId").Value) == int.Parse(e.Attribute("MaterialId").Value)
                                 select a;
                    foreach (XElement e2 in query2)
                    {
                        if (int.Parse(e2.Element("Cantidad").Value) >= oBEOrdenProduccion.Cantidad)
                        {
                            return true;
                        }
                    }
                }
                return false;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void AsignarEmpleadoOrdenProduccion(BEOrdenProduccion oBEOrdenProduccion)
        {
            try
            {
                XDocument docXml = XDocument.Load(archivo);

                var query = from e in docXml.Descendants("OrdenProduccion")
                            where e.Attribute("OrdenProduccionId").Value == oBEOrdenProduccion.ID.ToString()
                            select e;

                foreach (XElement e in query)
                {
                    e.Element("EmpleadoId").Value = oBEOrdenProduccion.Empleado.ID.ToString();
                }

                docXml.Save(archivo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void FinalizarOrdenProduccion(BEOrdenProduccion oBEOrdenProduccion)
        {
            try
            {
                // removemos la orden ya finalizada
                XDocument docXML = XDocument.Load(archivo);

                var query = from e in docXML.Descendants("OrdenProduccion")
                            where e.Attribute("OrdenProduccionId").Value == oBEOrdenProduccion.ID.ToString()
                            select e;

                query.Remove();
                docXML.Save(archivo);

                XDocument docXML2 = XDocument.Load(archivo2);

                var query2 = from e in docXML2.Descendants("OrdenProduccion_Material")
                             where e.Element("OrdenMaterialId").Value == oBEOrdenProduccion.ID.ToString()
                             select e;
                query2.Remove();
                docXML2.Save(archivo2);

                XDocument docXMLDeposito = XDocument.Load(archivo3);
                var query3 = from e in docXMLDeposito.Descendants("Deposito_Material")
                             where e.Element("MaterialId").Value == oBEOrdenProduccion.Material.ID.ToString()
                             select e;
                foreach (XElement e in query3)
                {
                    e.Element("Cantidad").Value = oBEOrdenProduccion.Cantidad.ToString();
                    e.Element("Lote").Value = oBEOrdenProduccion.Lote.ToString();
                }


                MPPMaterial oMPPMaterial = new MPPMaterial();
                BEMaterial material = oMPPMaterial.ListarTodo().Find(x => x.Nombre == oBEOrdenProduccion.Material.Nombre);

                var query4 = from e in docXMLDeposito.Descendants("Deposito_Material")
                             where e.Element("MaterialId").Value == material.ID.ToString()
                             select e;
                foreach (XElement e in query4)
                {
                    int cantidad = int.Parse(e.Element("Cantidad").Value) - oBEOrdenProduccion.Cantidad;
                    e.Element("Cantidad").Value = cantidad.ToString();
                }
                docXMLDeposito.Save(archivo3);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
