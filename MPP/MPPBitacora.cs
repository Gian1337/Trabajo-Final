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
    public class MPPBitacora : IGestor<BEBitacora>
    {
        const string archivo = @".\DATA\Bitacora.xml";
        public bool Borrar(BEBitacora oBEBitacora)
        {
            try
            {
                XDocument docXML = XDocument.Load(archivo);

                var query = from e in docXML.Descendants("Bitacora")
                            where int.Parse(e.Attribute("BitacoraId").Value) == oBEBitacora.ID
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

        public int BitacoraID()
        {
            XDocument docXML = XDocument.Load(archivo);
            int ultimoId = docXML.Descendants("Bitacora")
               .Select(e => (int?)e.Attribute("BitacoraId"))
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

        public bool Guardar(BEBitacora oBEBitacora)
        {
            try
            {
                XDocument docXML = XDocument.Load(archivo);


                if (oBEBitacora.ID == 0)
                {
                    docXML.Element("Bitacoras").Add(new XElement("Bitacora",
                        new XAttribute("BitacoraId", BitacoraID()),
                        new XElement("Fecha", oBEBitacora.Fecha.ToString()),
                        new XElement("EmpleadoId", oBEBitacora.UsuarioEmpleado.ID),
                        new XElement("Evento", oBEBitacora.Evento)
                        ));

                    docXML.Save(archivo);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<BEBitacora> ListarTodo()
        {
            try
            {
                XDocument docXML = XDocument.Load(archivo);

                MPPEmpleado oMPPUsuario = new MPPEmpleado();

                var query = from e in docXML.Descendants("Bitacora")
                            select e;

                List<BEBitacora> listaBitacora = new List<BEBitacora>();
                foreach (XElement e in query)
                {
                    BEBitacora oBEBitacora = new BEBitacora();
                    oBEBitacora.ID = int.Parse(e.Attribute("BitacoraId").Value);
                    oBEBitacora.UsuarioEmpleado = oMPPUsuario.ListarTodo().Find(x => x.ID == int.Parse(e.Element("EmpleadoId").Value));
                    oBEBitacora.Fecha = DateTime.Parse(e.Element("Fecha").Value);
                    oBEBitacora.Evento = e.Element("Evento").Value;

                    listaBitacora.Add(oBEBitacora);
                }

                return listaBitacora;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
