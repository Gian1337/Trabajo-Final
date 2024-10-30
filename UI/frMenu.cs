using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;

namespace UI
{
    public partial class frMenu : Form
    {
        public frMenu()
        {
            InitializeComponent();
            oBLLPermiso = new BLLPermiso();
            oBEEmpleadoUser = new BEEmpleado();

        }
        public BEEmpleado oBEEmpleadoUser;
        BLLPermiso oBLLPermiso;

        private void frMenu_Load(object sender, EventArgs e)
        {
            
            oBEEmpleadoUser.listaPermisos = oBLLPermiso.ListarPermisosUsuario(oBEEmpleadoUser);
            CargarToolStripPorPermisos();
        }
        
        public void CargarToolStripPorPermisos()
        {
            List<string> listaPermisos = new List<string>();

            foreach (BEComponente c in oBEEmpleadoUser.listaPermisos)
            {
                if (c is BERol)
                {
                    foreach (BEComponente permiso in c.ObtenerHijos())
                    {
                        listaPermisos.Add(permiso.Nombre);
                    }
                }
                else
                {
                    listaPermisos.Add(c.Nombre);
                }
            }

            // cargamos los botones de acuerdo a los permisos
            foreach (ToolStripDropDownItem i in toolStripMenu.Items)
            {
                bool tienePermisos = false;
                foreach (ToolStripMenuItem t in i.DropDownItems)
                {
                    if (t is ToolStripMenuItem)
                    {
                        if (listaPermisos.Contains(t.Text.ToString()))
                        {
                            t.Visible = true;
                            tienePermisos = true;
                        }
                        else
                        {
                            t.Visible = false;
                        }
                    }
                }
                if (!tienePermisos)
                {
                    i.Visible = false;
                }
                else
                {
                    i.Visible = true;
                }
            }

            toolStripArchivo.Visible = true;
            // Habilito para que se vean todos los items del item Archivo
            foreach (ToolStripMenuItem c in toolStripArchivo.DropDownItems)
            {
                c.Visible = true;
            }
        }
        
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.Application.Exit();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frBackUp form = new frBackUp();
                form.MdiParent = this;
                form.UsuarioActual = this.oBEEmpleadoUser;
                form.Show();
                

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frLogin form = new frLogin();
                form.Show();
                form.FormClosing += loginCerrar;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void loginCerrar(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void logsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frLogs form = new frLogs();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void gestorDePermisosDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frGestorPermisos form = new frGestorPermisos();
                form.MdiParent = this;
                form.UsuarioActual = oBEEmpleadoUser;
                form.Show();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void gestorDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frGestorUserEmpleado form = new frGestorUserEmpleado();
                form.MdiParent = this;
                form.UsuarioActual = this.oBEEmpleadoUser;
                form.Show();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void gestionarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frGestorCliente form = new frGestorCliente();
                form.UsuarioActual = oBEEmpleadoUser;
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void tomarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frGestionarOrden form = new frGestionarOrden();
                form.MdiParent = this;
                form.UsuarioActual = oBEEmpleadoUser;
                form.Show();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void generarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frGenerarFactura form = new frGenerarFactura();
                form.MdiParent = this;
                form.Show();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void generarOrdenDeEntregaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frGenerarOrdenEntrega form = new frGenerarOrdenEntrega();
                form.MdiParent = this;
                form.UsuarioActual = oBEEmpleadoUser;
                form.Show();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void verOrdenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frVerOrdenes form = new frVerOrdenes();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void cumplirOrdenDeEntregaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frGestionarOrdenEntrega form = new frGestionarOrdenEntrega();
                form.MdiParent = this;
                form.UsuarioActual = oBEEmpleadoUser;
                form.Show();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void informaciónDeNegocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frDashboard form = new frDashboard();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void supervisarOrdenesDeProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frSupervisarOrdenesProduccion form = new frSupervisarOrdenesProduccion();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void generarOrdenDeProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frGenerarOrdenProduccion form = new frGenerarOrdenProduccion();
                form.MdiParent = this;
                form.UsuarioActual = oBEEmpleadoUser;
                form.Show();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void cumplirOrdenDeProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frRealizarOrdenProduccion form = new frRealizarOrdenProduccion();
                form.MdiParent = this;
                form.Empleado = oBEEmpleadoUser;
                form.Show();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
