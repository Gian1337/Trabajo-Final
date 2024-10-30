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
    public class MPPDeposito : IGestor<BEDeposito>
    {

        const string archivo = @".\DATA\Deposito.xml";
        const string archivo2 = @".\DATA\Deposito_Material.xml";
        public bool Borrar(BEDeposito oBEDeposito)
        {
            try
            {
                XDocument docXML = XDocument.Load(archivo);

                var query = from e in docXML.Descendants("Deposito")
                            where int.Parse(e.Attribute("DepositoId").Value) == oBEDeposito.ID
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

        public int AlmacenId()
        {
            XDocument docXml = XDocument.Load(archivo);

            int ultimoId = docXml.Descendants("Deposito")
                .Select(e => (int?)e.Attribute("DepositoId"))
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

        public bool Guardar(BEDeposito oBEDeposito)
        {
            try
            {
                XDocument docXML = XDocument.Load(archivo);

                if (oBEDeposito.ID == 0)
                {
                    docXML.Element("Depositos").Add(new XElement("Deposito",
                        new XAttribute("DepositoId", AlmacenId()),
                        new XElement("Almacen", oBEDeposito.Almacen.Trim()),
                        new XElement("Estanteria", oBEDeposito.Estanteria.Trim()),
                        new XElement("Ubicacion", oBEDeposito.Ubicacion.Trim())
                        ));

                    docXML.Save(archivo);
                    return true;
                }
                else
                {
                    var query = from e in docXML.Descendants("Deposito")
                                where e.Attribute("DepositoId").Value == oBEDeposito.ID.ToString().Trim()
                                select e;
                    foreach (XElement e in query)
                    {
                        e.Element("Almacen").Value = oBEDeposito.Almacen.Trim();
                        e.Element("Estanteria").Value = oBEDeposito.Estanteria.Trim();
                        e.Element("Ubicacion").Value = oBEDeposito.Ubicacion.Trim();
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

        public List<BEDeposito> ListarTodo()
        {
            try
            {
                XDocument docXML = XDocument.Load(archivo);

                var query = from e in docXML.Descendants("Almacen")
                            select e;

                List<BEDeposito> listaAlmacenes = new List<BEDeposito>();
                foreach (XElement e in query)
                {
                    BEDeposito oBEDeposito= new BEDeposito();
                    oBEDeposito.ID = int.Parse(e.Attribute("AlmacenId").Value);
                    oBEDeposito.Almacen = e.Element("Almacen").Value;
                    oBEDeposito.Estanteria = e.Element("Estanteria").Value;
                    oBEDeposito.Ubicacion = e.Element("Ubicacion").Value;

                    listaAlmacenes.Add(oBEDeposito);
                }

                return listaAlmacenes;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void UpdateStockDeposito(BEMaterial oBEMaterial)
        {
            try
            {
                XDocument docXML = XDocument.Load(archivo2);
                var query = from e in docXML.Descendants("Deposito_Material")
                            where e.Element("MaterialId").Value == oBEMaterial.ID.ToString()
                            select e;

                foreach (XElement e in query)
                {
                    e.Element("Cantidad").Value = (int.Parse(e.Element("Cantidad").Value) - oBEMaterial.Cantidad).ToString();
                }
                docXML.Save(archivo2);
            }
            catch (Exception) { throw; }
        }
    }
}
