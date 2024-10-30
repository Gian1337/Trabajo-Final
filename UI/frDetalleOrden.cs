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
    public partial class frDetalleOrden : Form
    {
        public frDetalleOrden()
        {
            InitializeComponent();
            this.dataGridViewMateriales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.AcceptButton = buttonAceptar;
            this.AcceptButton.DialogResult = DialogResult.OK;
            this.CancelButton = buttonCancelar;
            oBLLOrden = new BLLOrden();
            oBLLEstado = new BLLEstado();
            oBLLDeposito = new BLLDeposito();
            oBLLBitacora = new BLLBitacora();
        }

        public BEEmpleado UsuarioActual;
        public BEOrden oBEOrden;
        BLLOrden oBLLOrden;
        BLLEstado oBLLEstado;
        BLLDeposito oBLLDeposito;
        BLLBitacora oBLLBitacora;

        private void frDetalleOrden_Load(object sender, EventArgs e)
        {
            LoadDGV();
            LoadDatosOrden();
        }

        private void LoadDatosOrden()
        {
            try
            {
                // mostramos los detalles de la orden
                this.labelFecha.Text = oBEOrden.Fecha.ToShortDateString();
                double subtotal = oBEOrden.listaMateriales.Sum(x => x.Cantidad * x.Precio);
                this.labelSubTotal.Text = "$" + subtotal.ToString();
                this.labelTotal.Text = "$" + oBEOrden.ImporteTotal.ToString();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void LoadDGV()
        {
            try
            {
                this.dataGridViewMateriales.DataSource = oBEOrden.listaMateriales;
                this.dataGridViewMateriales.Columns.Remove("ID");
                this.dataGridViewMateriales.Columns.Remove("Codigo");
                this.dataGridViewMateriales.Columns.Remove("Durabilidad");
                this.dataGridViewMateriales.Columns.Remove("Aislamiento");
                this.dataGridViewMateriales.Columns.Remove("Tipo");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                // actualizamos el estado de la orden ya realizada y lo guardamos
                oBEOrden.Estado = oBLLEstado.ActualizaEstado(oBEOrden);
                if (oBLLOrden.Guardar(oBEOrden) == true)
                {
                    foreach (BEMaterial m in oBEOrden.listaMateriales)
                    {
                        oBLLDeposito.UpdateStockDeposito(m);
                    }
                    MessageBox.Show("Se ha registrado la orden correctamente", "Detalles de la Orden", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    oBLLBitacora.Log(UsuarioActual, $"Nueva orden N°{oBEOrden.Numero} registrado");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Orden cancelada", "Detalles de la Orden", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
