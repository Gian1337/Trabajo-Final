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
    public class MPPMaterial : IGestor<BEMaterial>
    {
        const string archivo = @".\DATA\Material.xml";
        const string archivo2 = @".\DATA\Deposito_Material.xml";
        const string archivo3 = @".\DATA\Orden_Material.xml";
        public bool Borrar(BEMaterial oBEMaterial)
        {
            try
            {
                XDocument docXML = XDocument.Load(archivo);

                var query = from e in docXML.Descendants("Material")
                            where int.Parse(e.Attribute("MaterialId").Value) == oBEMaterial.ID
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

        public int MaterialId()
        {
            XDocument docXML = XDocument.Load(archivo);

            int ultimoId = docXML.Descendants("Material")
                .Select(e => (int?)e.Attribute("MaterialId"))
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

        public bool Guardar(BEMaterial oBEMaterial)
        {
            try
            {
                XDocument docXML = XDocument.Load(archivo);

                if (oBEMaterial.ID == 0)
                {
                    docXML.Element("Materiales").Add(new XElement("Material",
                        new XAttribute("DepositoId", MaterialId()),
                        new XElement("Codigo", oBEMaterial.Codigo.ToString()),
                        new XElement("Durabilidad", oBEMaterial.Durabilidad),
                        new XElement("Aislamiento", oBEMaterial.Aislamiento),
                        new XElement("Nombre", oBEMaterial.Nombre),
                        new XElement("Precio", oBEMaterial.Precio.ToString()),
                        new XElement("Tipo", oBEMaterial.Tipo)
                        ));

                    docXML.Save(archivo);
                    return true;
                }
                else
                {
                    var query = from e in docXML.Descendants("Material")
                                where e.Attribute("MaterialId").Value == oBEMaterial.ID.ToString().Trim()
                                select e;
                    foreach (XElement e in query)
                    {
                        e.Element("Durabilidad").Value = oBEMaterial.Durabilidad.Trim();
                        e.Element("Aislamiento").Value = oBEMaterial.Aislamiento.Trim();
                        e.Element("Nombre").Value = oBEMaterial.Nombre.Trim();
                        e.Element("Precio").Value = oBEMaterial.Precio.ToString();
                        e.Element("Tipo").Value = oBEMaterial.Tipo.ToString();
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

        public List<BEMaterial> ListarTodo()
        {
            try
            {
                XDocument docXML = XDocument.Load(archivo);
                XDocument docXML2 = XDocument.Load(archivo2);

                var query = from e in docXML.Descendants("Material")
                            select e;


                List<BEMaterial> listaMateriales = new List<BEMaterial>();
                foreach (XElement e in query)
                {
                    BEMaterial oBEMaterial = new BEMaterial();
                    oBEMaterial.ID = int.Parse(e.Attribute("MaterialId").Value);
                    oBEMaterial.Durabilidad = e.Element("Durabilidad").Value;
                    oBEMaterial.Codigo = e.Element("Codigo").Value;
                    oBEMaterial.Nombre = e.Element("Nombre").Value;
                    oBEMaterial.Aislamiento = e.Element("Aislamiento").Value;
                    oBEMaterial.Precio = double.Parse(e.Element("Precio").Value);
                    oBEMaterial.Tipo = e.Element("Tipo").Value;

                    var queryStock = from elem in docXML2.Descendants("Deposito_Material")
                                     where elem.Element("MaterialId").Value == oBEMaterial.ID.ToString()
                                     select elem;
                    foreach (XElement cant in queryStock)
                    {
                        if (int.Parse(cant.Element("Cantidad").Value) == 0)
                        {
                            oBEMaterial.Cantidad += 0;
                        }
                        else
                        {
                            oBEMaterial.Cantidad += int.Parse(cant.Element("Cantidad").Value);
                        }
                    }

                    listaMateriales.Add(oBEMaterial);
                }

                return listaMateriales;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<BEMaterial> ListaMaterialesCantidadVendida()
        {
            try
            {
                XDocument docXML = XDocument.Load(archivo3);
                var materialesOrdenados = docXML.Descendants("Orden_Material")
                    .GroupBy(ordenMaterial => (int)ordenMaterial.Element("MaterialId"))
                    .OrderByDescending(grupo => grupo.Sum(x => int.Parse(x.Element("Cantidad").Value)))
                    .Select(grupo => new
                    {
                        MaterialId = grupo.Key,
                        CantidadVendido = grupo.Sum(x => int.Parse(x.Element("Cantidad").Value))
                    });

                List<BEMaterial> ListaMateriales = new List<BEMaterial>();
                foreach (var material in materialesOrdenados)
                {
                    BEMaterial oBEMaterial = new BEMaterial();
                    oBEMaterial = ListarTodo().Find(x => x.ID == material.MaterialId);
                    oBEMaterial.Cantidad = material.CantidadVendido;
                    ListaMateriales.Add(oBEMaterial);
                }
                return ListaMateriales;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
