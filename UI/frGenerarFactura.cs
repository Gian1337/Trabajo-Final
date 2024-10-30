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
    public partial class frGenerarFactura : Form
    {
        public frGenerarFactura()
        {
            InitializeComponent();
            this.dataGridViewOrdenes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrdenes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            oBEOrden = new BEOrden();
            oBLLOrden = new BLLOrden();
        }

        BEOrden oBEOrden;
        BLLOrden oBLLOrden;

        private void frGenerarFactura_Load(object sender, EventArgs e)
        {
            LoadDGVOrdenesSinFactura();
        }

        private void LoadDGVOrdenesSinFactura()
        {
            try
            {
                this.dataGridViewOrdenes.DataSource = null;
                this.dataGridViewOrdenes.DataSource = oBLLOrden.ListarTodo().FindAll(x => x.Factura.ID == 0);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void dataGridViewOrdenes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                oBEOrden = (BEOrden)this.dataGridViewOrdenes.CurrentRow.DataBoundItem;
                this.button1.Enabled = true;
                if (oBEOrden.Factura.ID == 0)
                {
                    this.button1.Text = "Generar factura";
                }
                else
                {
                    this.button1.Text = "Ver factura";
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        private void frGenerarFactura_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                
                LoadDGVOrdenesSinFactura();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked == true)
                {
                    //Carga de ordenes CON factura
                    this.dataGridViewOrdenes.DataSource = null;
                    this.dataGridViewOrdenes.DataSource = oBLLOrden.ListarTodo().FindAll(x => x.Factura.ID != 0);
                }
                else
                {
                    //Carga de ordenes SIN factura
                    LoadDGVOrdenesSinFactura();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Muestro los detalles de la factura en otro formulario
                frVerFactura form = new frVerFactura();
                form.oBEOrden = oBEOrden;
                form.Show();
                form.FormClosed += frGenerarFactura_FormClosed;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
