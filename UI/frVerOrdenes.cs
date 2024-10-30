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
    public partial class frVerOrdenes : Form
    {
        public frVerOrdenes()
        {
            InitializeComponent();
            oBLLOrden = new BLLOrden();
            oBEOrden = new BEOrden();
        }

        BEOrden oBEOrden;
        BLLOrden oBLLOrden;

        private void frVerOrdenes_Load(object sender, EventArgs e)
        {
            LoadDGVOrdenes();
        }

        private void LoadDGVOrdenes()
        {
            this.dataGridViewOrdenes.DataSource = null;
            this.dataGridViewOrdenes.DataSource = oBLLOrden.ListarTodo().OrderByDescending(x => x.Fecha).ToList();
            this.dataGridViewOrdenes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewOrdenes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dataGridViewOrdenes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                oBEOrden = (BEOrden)this.dataGridViewOrdenes.CurrentRow.DataBoundItem;
                this.groupBoxDetalles.Visible = true;
                this.labelNumPedido.Text = oBEOrden.Numero;
                this.labelFechaPedido.Text = oBEOrden.Fecha.ToString("dd/MM/yyyy");
                this.labelClientePedido.Text = oBEOrden.Cliente.Nombre + " " + oBEOrden.Cliente.Apellido;
                this.dataGridViewMateriales.DataSource = null;
                this.dataGridViewMateriales.DataSource = oBEOrden.listaMateriales;
                this.dataGridViewMateriales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                this.dataGridViewMateriales.ReadOnly = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
