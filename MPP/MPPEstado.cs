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
    public class MPPEstado : IGestor<BEEstado>
    {
        const string archivo = @".\DATA\Estado.xml";
        public bool Borrar(BEEstado oBEEstado)
        {
            try
            {
                XDocument docXML = XDocument.Load(archivo);

                var query = from e in docXML.Descendants("Estado")
                            where int.Parse(e.Attribute("EstadoId").Value) == oBEEstado.ID
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

        public int EstadoId()
        {
            XDocument docXML = XDocument.Load(archivo);

            
            int ultimoId = docXML.Descendants("Deposito")
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
        public bool Guardar(BEEstado oBEEstado)
        {
            try
            {
                XDocument docXML = XDocument.Load(archivo);

                if (oBEEstado.ID == 0)
                {
                    docXML.Element("Entregas").Add(new XElement("Entrega",
                        new XAttribute("EntregaId", EstadoId()),
                        new XElement("Fecha", oBEEstado.Tipo.ToString())
                        ));

                    docXML.Save(archivo);
                    return true;
                }
                else
                {
                    var query = from e in docXML.Descendants("Estado")
                                where e.Attribute("EstadoId").Value == oBEEstado.ID.ToString().Trim()
                                select e;

                    foreach (XElement e in query)
                    {
                        e.Element("Tipo").Value = oBEEstado.Tipo.ToString();
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

        public List<BEEstado> ListarTodo()
        {
            try
            {
                XDocument docXML = XDocument.Load(archivo);

                var query = from e in docXML.Descendants("Estado")
                            select e;

                List<BEEstado> listaEstados = new List<BEEstado>();
                foreach (XElement e in query)
                {
                    BEEstado oBEEstado = new BEEstado();
                    oBEEstado.ID = int.Parse(e.Attribute("EstadoId").Value);
                    oBEEstado.Tipo = e.Element("Tipo").Value.ToString();
                    listaEstados.Add(oBEEstado);
                }

                return listaEstados;
            }
            catch (Exception ex) { throw ex; }
        }

        public BEEstado ActualizaEstado(BEOrden oBEOrden)
        {
            if (oBEOrden.Estado == null)
            {
                return ListarTodo().First();
            }
            else
            {
                BEEstado oBEEstado = ListarTodo().Find(x => x.ID == oBEOrden.Estado.ID);
                if (oBEEstado != null)
                {
                    return oBEEstado;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
