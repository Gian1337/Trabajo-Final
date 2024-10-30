using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frGestorPermisos : Form
    {
        public frGestorPermisos()
        {
            InitializeComponent();
            oBLLUsuario = new BLLEmpleado();
            oBEUsuario = new BEEmpleado();
            oBLLPermiso = new BLLPermiso();
            oBLLBitacora = new BLLBitacora();
        }

        public BEEmpleado UsuarioActual;
        BEEmpleado oBEUsuario;
        BLLEmpleado oBLLUsuario;
        BLLPermiso oBLLPermiso;
        BLLBitacora oBLLBitacora;

        private void frGestorPermisos_Load(object sender, EventArgs e)
        {
            this.Shown += Form_Shown;
        }

        private void Form_Shown(object sender, EventArgs e)
        {
            LoadDGUsuarios();
            LoadDGRoles();
            LoadTreeViewPermisos();
            LoadTreeViewPermisosIndividuales();
        }
        private void LoadTreeViewPermisos()
        {
            try
            {
                // Carga los tree view con los diferentes roles y permisos
                treeView1.CheckBoxes = true;
                treeView1.Nodes.Clear();
                foreach (BERol padre in oBLLPermiso.ListarRoles())
                {
                    TreeNode nodoPadre = new TreeNode(padre.Nombre);
                    nodoPadre.Tag = padre;
                    foreach (BEPermiso hijo in padre.ObtenerHijos())
                    {
                        TreeNode nodoHijo = new TreeNode(hijo.Nombre);
                        nodoHijo.Tag = hijo;
                        nodoPadre.Nodes.Add(nodoHijo);
                    }
                    treeView1.Nodes.Add(nodoPadre);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void LoadTreeViewPermisosIndividuales()
        {
            try
            {
                treeView2.Nodes.Clear();
                List<BEComponente> permisos = oBLLPermiso.ListarPermisosIndividuales();

                foreach (BEComponente permiso in permisos)
                {
                    TreeNode node = new TreeNode(permiso.Nombre);
                    node.Tag = permiso;
                    treeView2.Nodes.Add(node);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los permisos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*
        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (oBEUsuario == null || dataGridViewUsuarios.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, seleccione un usuario antes de asignar roles o permisos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Node.Checked = !e.Node.Checked; // Revierte el check
                    return;
                }

                // Al darle check a un rol o permiso este se le añade al usuario
                if (e.Node.Nodes.Count != 0)
                {
                    BERol Rol = (BERol)e.Node.Tag;
                    MarcarPermisosHijos(e.Node, e.Node.Checked);
                    AsignarQuitarPermiso(Rol, "Rol", e.Node.Checked);
                }
                else
                {
                    BEPermiso Permiso = (BEPermiso)e.Node.Tag;
                    AsignarQuitarPermiso(Permiso, "Permiso", e.Node.Checked);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        */
        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            try
            {
           
                if (e.Node.Nodes.Count != 0) // Es un nodo padre (Rol)
                {
                    if (e.Node.Tag is BERol rol)
                    {
                        MarcarPermisosHijos(e.Node, e.Node.Checked);
                        AsignarQuitarPermiso(rol, "Rol", e.Node.Checked);
                    }
                    else
                    {
                        throw new InvalidOperationException("El nodo padre no contiene un objeto BERol válido.");
                    }
                }
                else // Es un nodo hijo (Permiso individual)
                {
                    if (e.Node.Tag is BEPermiso permiso)
                    {
                        AsignarQuitarPermiso(permiso, "Permiso", e.Node.Checked);
                    }
                    else if (e.Node.Tag is BERol rol) // Manejar el caso en que un rol no tenga hijos
                    {
                        AsignarQuitarPermiso(rol, "Rol", e.Node.Checked);
                    }
                    else
                    {
                        throw new InvalidOperationException("El nodo no contiene un objeto válido de tipo BEPermiso o BERol.");
                    }
                }

                // Actualizar la vista de permisos del usuario
                LoadTreeViewPermisosUsuario();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al asignar/quitar permiso: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Node.Checked = !e.Node.Checked; // Revertir el check en caso de error

                // Registrar el error en la bitácora
                oBLLBitacora.Log(UsuarioActual, $"Error al asignar/quitar permiso: {ex.Message}");
            }
        }
        private void MarcarPermisosHijos(TreeNode nodoPadre, bool check)
        {
            treeView1.AfterCheck -= treeView1_AfterCheck;
            foreach (TreeNode nodoHijo in nodoPadre.Nodes)
            {
                nodoHijo.Checked = check;

            }
            treeView1.AfterCheck += treeView1_AfterCheck;
        }

        private void AsignarQuitarPermiso(BEComponente oBEComponente, string Tipo, bool Asignar)
        {
            try
            {
                if (Asignar == true)
                {
                    if (Tipo == "Rol")
                    {
                        BERol Rol = (BERol)oBEComponente;
                        oBEUsuario = (BEEmpleado)this.dataGridViewUsuarios.CurrentRow.DataBoundItem;
                        if (oBLLPermiso.AsignarPermisoUsuario(oBEUsuario, Rol) == true)
                        {
                            oBEUsuario.listaPermisos = oBLLPermiso.ListarPermisosUsuario(oBEUsuario);
                            LoadTreeViewPermisosUsuario();
                            oBLLBitacora.Log(UsuarioActual, $"Rol {Rol.Nombre} asignado al usuario {oBEUsuario.NombreUsuario}");
                        }
                    }
                    else
                    {
                        BEPermiso permisoIndividual = (BEPermiso)oBEComponente;
                        oBEUsuario = (BEEmpleado)this.dataGridViewUsuarios.CurrentRow.DataBoundItem;
                        if (oBLLPermiso.AsignarPermisoUsuario(oBEUsuario, permisoIndividual) == true)
                        {
                            oBEUsuario.listaPermisos = oBLLPermiso.ListarPermisosUsuario(oBEUsuario);
                            LoadTreeViewPermisosUsuario();
                            oBLLBitacora.Log(UsuarioActual, $"Permiso {permisoIndividual.Nombre} asignado al usuario {oBEUsuario.NombreUsuario}");
                        }
                    }

                }
                else
                {
                    oBEUsuario = (BEEmpleado)this.dataGridViewUsuarios.CurrentRow.DataBoundItem;
                    if (oBLLPermiso.BorrarPermisoUsuario(oBEUsuario, oBEComponente) == true)
                    {
                        oBEUsuario.listaPermisos = oBLLPermiso.ListarPermisosUsuario(oBEUsuario);
                        LoadTreeViewPermisosUsuario();
                        oBLLBitacora.Log(UsuarioActual, $"Permiso {oBEComponente.Nombre} retirado al usuario {oBEUsuario.NombreUsuario}");
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void LoadTreeViewPermisosUsuario()
        {
            treeView1.AfterCheck -= treeView1_AfterCheck;
            LimpiarChecksTreeView();
            foreach (TreeNode nodoPadre in treeView1.Nodes)
            {
                BEComponente permisoNodo = (BEComponente)nodoPadre.Tag;
                if (oBEUsuario.listaPermisos.Exists(x => x.ID == permisoNodo.ID))
                {
                    if (nodoPadre.Nodes != null)
                    {
                        BERol rol = (BERol)nodoPadre.Tag;
                        nodoPadre.Checked = true;
                        foreach (TreeNode nodoHijo in nodoPadre.Nodes)
                        {
                            nodoHijo.Checked = true;
                        }
                    }
                }
                else
                {
                    foreach (TreeNode nodoHijo in nodoPadre.Nodes)
                    {
                        if (oBEUsuario.listaPermisos.Any(x => x.Nombre == nodoHijo.Text))
                        {
                            nodoHijo.Checked = true;
                        }
                    }
                }
            }
            treeView1.AfterCheck += treeView1_AfterCheck;
        }

        private void LimpiarChecksTreeView()
        {
            foreach (TreeNode nodo in treeView1.Nodes)
            {
                nodo.Checked = false;
                if (nodo.Nodes != null)
                {
                    foreach (TreeNode nodoHijo in nodo.Nodes)
                    {
                        nodoHijo.Checked = false;
                    }
                }
            }
        }

        public void configDGVs(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is DataGridView)
                {
                    ((DataGridView)c).SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    ((DataGridView)c).AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                }
                configDGVs(c);
            }
        }

        public void LoadDGUsuarios()
        {
            try
            {
                // Listar y mostrar todos los usuarios excepto el usuario con el mismo ID con el que ingresé.
                this.dataGridViewUsuarios.DataSource = oBLLUsuario.ListarTodo().FindAll(x => x.ID != UsuarioActual.ID);
                this.dataGridViewUsuarios.Columns.Remove("Password");
                this.dataGridViewUsuarios.Columns.Remove("Area");
                this.dataGridViewUsuarios.Columns.Remove("Id");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void LoadDGRoles()
        {
            try
            {
                this.dataGridViewRoles.DataSource = oBLLPermiso.ListarRoles();
                this.dataGridViewRoles.Columns.Remove("isRol");
                this.dataGridViewRoles.Columns.Remove("ID");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void dataGridViewUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // mostrar roles del usuario
                oBEUsuario = (BEEmpleado)this.dataGridViewUsuarios.CurrentRow.DataBoundItem;
                oBEUsuario.listaPermisos = oBLLPermiso.ListarPermisosUsuario(oBEUsuario);
                LoadTreeViewPermisosUsuario();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnAgregarRol_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtAgregarRol.Text))
                {
                    MessageBox.Show("El nombre del rol no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                BERol nuevoRol = new BERol(txtAgregarRol.Text);
                nuevoRol.isRol = true;

                if (oBLLPermiso.Guardar(nuevoRol))
                {
                    MessageBox.Show("Rol agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDGRoles();
                    LoadTreeViewPermisos();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnEliminarRol_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewRoles.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, seleccione un rol para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                BERol rolSeleccionado = (BERol)dataGridViewRoles.SelectedRows[0].DataBoundItem;

                DialogResult resultado = MessageBox.Show($"¿Está seguro que desea eliminar el rol '{rolSeleccionado.Nombre}'?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(resultado == DialogResult.Yes)
                {
                    if (oBLLPermiso.Borrar(rolSeleccionado))
                    {
                        MessageBox.Show("Rol eliminado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDGRoles();
                        LoadTreeViewPermisos();

                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el rol.");
                    }
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void btnAgregarPermiso_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewRoles.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, seleccione un rol antes de agregar un permiso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                BERol rolSeleccionado = (BERol)dataGridViewRoles.SelectedRows[0].DataBoundItem;

                if (treeView2.SelectedNode == null || !(treeView2.SelectedNode.Tag is BEPermiso))
                {
                    MessageBox.Show("Por favor, seleccione un permiso individual del TreeView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                BEPermiso permisoSeleccionado = (BEPermiso)treeView2.SelectedNode.Tag;

                if (oBLLPermiso.AsignarPermisoARol(rolSeleccionado, permisoSeleccionado))
                {
                    MessageBox.Show($"Permiso '{permisoSeleccionado.Nombre}' asignado al rol '{rolSeleccionado.Nombre}' exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Actualizar la vista de permisos en el TreeView (reflejar el cambio)
                    LoadTreeViewPermisos();
                }
                else
                {
                    MessageBox.Show("Error al asignar el permiso al rol.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnEliminarPermiso_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewRoles.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, seleccione un rol antes de eliminar un permiso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                BERol rolSeleccionado = (BERol)dataGridViewRoles.SelectedRows[0].DataBoundItem;

                if (treeView2.SelectedNode == null || !(treeView2.SelectedNode.Tag is BEPermiso))
                {
                    MessageBox.Show("Por favor, seleccione un permiso individual del TreeView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                BEPermiso permisoSeleccionado = (BEPermiso)treeView2.SelectedNode.Tag;

                // Lógica para eliminar el permiso del rol
                if (oBLLPermiso.EliminarPermisodeRol(rolSeleccionado, permisoSeleccionado))
                {
                    MessageBox.Show($"Permiso '{permisoSeleccionado.Nombre}' eliminado del rol '{rolSeleccionado.Nombre}' exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Actualizar la vista de permisos en el TreeView (reflejar el cambio)
                    LoadTreeViewPermisos();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el permiso del rol.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
