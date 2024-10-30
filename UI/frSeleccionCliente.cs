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
    public partial class frSeleccionCliente : Form
    {
        public frSeleccionCliente()
        {
            InitializeComponent();

            this.dataGridViewClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            oBLLCliente = new BLLCliente();
            oBECliente = new BECliente();
            oBLLEstado = new BLLEstado();
            oBLLOrden = new BLLOrden();
        }

        public BEEmpleado UsuarioActual;
        public BEOrden oBEOrden;
        BLLOrden oBLLOrden;
        BLLCliente oBLLCliente;
        BECliente oBECliente;
        BLLEstado oBLLEstado;

        private void dataGridViewClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frSeleccionCliente_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDgvClientes();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void LoadDgvClientes()
        {
            this.dataGridViewClientes.DataSource = null;
            this.dataGridViewClientes.DataSource = oBLLCliente.ListarTodo();
        }

        private void buttonSelCliente_Click(object sender, EventArgs e)
        {
            try
            {
                // Se selecciona un cliente y se lo asigna al pedido
                oBECliente = (BECliente)this.dataGridViewClientes.CurrentRow.DataBoundItem;
                DialogResult dialog = MessageBox.Show($"Asignar pedido a {oBECliente.Nombre} {oBECliente.Apellido}", "Confirmación", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    oBEOrden.Cliente = oBECliente;
                    oBEOrden.Fecha = DateTime.Today;
                    oBEOrden.Estado = oBLLEstado.ActualizaEstado(oBEOrden);
                    oBEOrden.ImporteTotal = oBLLOrden.CalcularTotal(oBEOrden);

                    // Se abre un formulario para mostrar los detalles del pedido
                    frDetalleOrden form = new frDetalleOrden();
                    form.oBEOrden = oBEOrden;
                    form.UsuarioActual = UsuarioActual;
                    form.ShowDialog();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                //Formulario para registrar un nuevo cliente
                frGestorCliente form = new frGestorCliente();
                form.UsuarioActual = UsuarioActual;
                form.Show();
                form.FormClosing += actualizarDataGrid;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void actualizarDataGrid(object sender, FormClosingEventArgs e)
        {
            LoadDgvClientes();
        }
    }
}
