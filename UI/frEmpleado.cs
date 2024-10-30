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
    public partial class frEmpleado : Form
    {
        public frEmpleado()
        {
            InitializeComponent();
            this.dataGridViewEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            oBLLUsuario = new BLLEmpleado();
            oBEUsuario = new BEEmpleado();
            oBLLOrdenProduccion = new BLLOrdenProduccion();
        }

        public BEEmpleado UsuarioEmpleado { get; set; }
        BEEmpleado oBEUsuario;
        BLLEmpleado oBLLUsuario;
        BLLOrdenProduccion oBLLOrdenProduccion;

        private void LoadDGVEmpleados()
        {
            // Se listan los empleados del area de produccion
            this.dataGridViewEmpleados.DataSource = null;
            this.dataGridViewEmpleados.DataSource = oBLLUsuario.ListarTodo().FindAll(x => x.Area == "Produccion" && x.Area != "");
            this.dataGridViewEmpleados.Columns.Remove("NombreUsuario");
            this.dataGridViewEmpleados.Columns.Remove("Password");
        }

        private void frEmpleado_Load(object sender, EventArgs e)
        {
            LoadDGVEmpleados();
        }

        private void dataGridViewEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                oBEUsuario = (BEEmpleado)this.dataGridViewEmpleados.CurrentRow.DataBoundItem;
                this.buttonAsignar.Enabled = true;
                this.groupBoxInfo.Visible = true;

                // Se listan las ordenes asignadas al empleado seleccionado
                List<BEOrdenProduccion> ListaOrdenesEmpleado = oBLLOrdenProduccion.ListarTodo();
                if (ListaOrdenesEmpleado != null)
                {
                    ListaOrdenesEmpleado = ListaOrdenesEmpleado.FindAll(x => x.Empleado != null && x.Empleado.ID == oBEUsuario.ID);
                    this.labelCantTrabajos.Text = ListaOrdenesEmpleado.Count.ToString();
                    listBoxOrdenesEmp.Items.Clear();
                    if (ListaOrdenesEmpleado != null)
                    {

                        foreach (BEOrdenProduccion orden in ListaOrdenesEmpleado)
                        {
                            this.listBoxOrdenesEmp.Items.Add($"Orden {orden.Numero} - Fecha {orden.Fecha.ToString("dd/MM/yyyy")} - Producto: {orden.Material.Nombre} ({orden.Cantidad} unidades)");
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void buttonAsignar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioEmpleado = oBEUsuario;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
