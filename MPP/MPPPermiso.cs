using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using Abstraccion;
using System.Xml.Linq;

namespace MPP
{
    public class MPPPermiso : IGestor<BEComponente>
    {
        const string archivo = @".\DATA\Permiso.xml"; 
        const string archivo2 = @".\DATA\Permiso_Permiso.xml";
        const string archivo3 = @".\DATA\Empleado_Permiso.xml";
        public bool Borrar(BEComponente oBEComponente)
        {
            try
            {
                XDocument docXML = XDocument.Load(archivo);

                var query = from e in docXML.Descendants("Permiso")
                            where int.Parse(e.Attribute("PermisoId").Value) == oBEComponente.ID
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

        public int PermisoId()
        {
            XDocument docXML = XDocument.Load(archivo);

            int ultimoId = docXML.Descendants("Permiso")
                .Select(e => (int?)e.Attribute("PermisoId"))
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

        public bool Guardar(BEComponente oBEComponente)
        {
            try
            {
                XDocument docXML = XDocument.Load(archivo);

                if (oBEComponente.ID == 0)
                {
                    docXML.Element("Permisos").Add(new XElement("Permiso",
                            new XAttribute("PermisoId", PermisoId()),
                            new XElement("Nombre", oBEComponente.Nombre),
                            new XElement("Rol", oBEComponente.isRol.ToString())
                            ));

                    docXML.Save(archivo);
                    return true;
                }
                else
                {
                    var query = from e in docXML.Descendants("Permiso")
                                where e.Attribute("PermisoId").Value == oBEComponente.ID.ToString().Trim()
                                select e;
                    foreach (XElement e in query)
                    {
                        e.Element("Nombre").Value = oBEComponente.Nombre;
                        e.Element("Rol").Value = oBEComponente.isRol.ToString();
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

        public List<BEComponente> ListarTodo()
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<BEComponente> ListarRoles()
        {
            try
            {
                XDocument docXML = XDocument.Load(archivo);
                XDocument docXML2 = XDocument.Load(archivo2);
                List<BEComponente> listaRoles = new List<BEComponente>();
                List<BEComponente> listaPermisos = new List<BEComponente>();

                var permiso = from r in docXML.Descendants("Permiso")
                              select r;

                foreach (XElement r in permiso)
                {
                    if ((bool)r.Element("Rol") == true)
                    {
                        BEComponente BERol = new BERol(
                            pNombre: r.Element("Nombre").Value
                            );
                        BERol.ID = int.Parse(r.Attribute("PermisoId").Value);
                        listaRoles.Add(BERol);
                    }
                    else
                    {
                        BEComponente BEPermiso = new BEPermiso(
                            pNombre: r.Element("Nombre").Value
                            );
                        BEPermiso.ID = int.Parse(r.Attribute("PermisoId").Value);
                        listaPermisos.Add(BEPermiso);
                    }
                }

                foreach (BEComponente rol in listaRoles)
                {
                    var rolperm = from rp in docXML2.Descendants("Permiso_Permiso")
                                  where int.Parse(rp.Element("PermisoPadreId").Value) == rol.ID
                                  select int.Parse(rp.Element("PermisoHijoId").Value);
                    foreach (int rp in rolperm)
                    {
                        rol.AgregarHijo(listaPermisos.Find(x => x.ID == rp));
                    }
                }

                return listaRoles;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<BEComponente> ListarPermisosIndividuales()
        {
            try
            {
                XDocument docXML = XDocument.Load(archivo);
                List<BEComponente> listaPermisos = new List<BEComponente>();

                var permisos = from r in docXML.Descendants("Permiso")
                               where (bool)r.Element("Rol") == false
                               select r;

                foreach (XElement r in permisos)
                {
                    BEComponente BEPermiso = new BEPermiso(
                        pNombre: r.Element("Nombre").Value
                        );
                    BEPermiso.ID = int.Parse(r.Attribute("PermisoId").Value);
                    listaPermisos.Add(BEPermiso);
                }

                return listaPermisos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<BEComponente> ListarPermisosUsuario(BEEmpleado oBEEmpleado)
        {
            try
            {
                List<BEComponente> listaPermisos = ListarRoles();
                XDocument docXML = XDocument.Load(archivo3);

                var query = from p in docXML.Descendants("Empleado_Permiso")
                            where int.Parse(p.Element("EmpleadoId").Value) == oBEEmpleado.ID
                            select int.Parse(p.Element("PermisoId").Value);
                List<BEComponente> listaPermisosUsuario = new List<BEComponente>();
                foreach (int Idp in query)
                {
                    if (listaPermisos.Exists(x => x.ID == Idp))
                    {
                        listaPermisosUsuario.Add(listaPermisos.Find(x => x.ID == Idp));
                    }
                    else
                    {
                        foreach (BEComponente c in listaPermisos)
                        {
                            if (c.ObtenerHijos().ToList().Exists(x => x.ID == Idp) && !listaPermisosUsuario.Exists(x => x.ID == Idp))
                            {
                                listaPermisosUsuario.Add(c.ObtenerHijos().First(x => x.ID == Idp));
                            }
                        }
                    }
                }
                return listaPermisosUsuario;
            }
            catch (Exception ex)
            {

                throw new ApplicationException("Error al listar los permisos del usuario", ex);
            }
        }

        public bool AsignarPermisoUsuario(BEEmpleado oBEEmpleado, BEComponente oBEPermiso)
        {
            try
            {
                XDocument docXML = XDocument.Load(archivo3);
                docXML.Element("Empleado_Permisos").Add(new XElement("Empleado_Permiso",
                        new XElement("EmpleadoId", oBEEmpleado.ID.ToString()),
                        new XElement("PermisoId", oBEPermiso.ID.ToString())
                        ));
                docXML.Save(archivo3);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public bool BorrarPermisoUsuario(BEEmpleado oBEEmpleado, BEComponente oBEComponente)
        {
            try
            {
                XDocument docXML = XDocument.Load(archivo3);

                var query = from e in docXML.Descendants("Empleado_Permiso")
                            where int.Parse(e.Element("EmpleadoId").Value) == oBEEmpleado.ID
                            where int.Parse(e.Element("PermisoId").Value) == oBEComponente.ID
                            select e;

                query.Remove();
                docXML.Save(archivo3);

                return true;
            }
            catch (Exception ex) { throw ex; }
        }

        public bool AsignarPermisoARol(BERol rol, BEPermiso permiso)
        {
            try
            {
                
                XDocument docXML = XDocument.Load(archivo2);

                // Verificar si ya existe la relación
                var existeRelacion = (from p in docXML.Descendants("Permiso_Permiso")
                                      where int.Parse(p.Element("PermisoPadreId").Value) == rol.ID
                                      && int.Parse(p.Element("PermisoHijoId").Value) == permiso.ID
                                      select p).Any();

                // Si no existe la relación, agregarla
                if (!existeRelacion)
                {
                    docXML.Element("Permisos_Permisos").Add(new XElement("Permiso_Permiso",
                        new XElement("PermisoPadreId", rol.ID),
                        new XElement("PermisoHijoId", permiso.ID)
                    ));

                   
                    docXML.Save(archivo2);
                    return true;
                }

                
                return false;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al asignar permiso al rol", ex);
            }
        }

        public bool EliminarPermisodeRol(BERol rol, BEPermiso permiso)
        {
            try
            {
                XDocument docXML = XDocument.Load(archivo2);

                // Buscar la relación entre el rol y el permiso
                var relacion = (from p in docXML.Descendants("Permiso_Permiso")
                                where int.Parse(p.Element("PermisoPadreId").Value) == rol.ID
                                && int.Parse(p.Element("PermisoHijoId").Value) == permiso.ID
                                select p).FirstOrDefault();

                // Si la relación existe, eliminarla
                if (relacion != null)
                {
                    relacion.Remove();

                    // Guardar los cambios en el archivo XML
                    docXML.Save(archivo2);
                    return true;
                }

                
                return false;
            
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
