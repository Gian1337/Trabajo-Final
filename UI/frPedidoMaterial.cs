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
    public partial class frPedidoMaterial : Form
    {
        public frPedidoMaterial()
        {
            InitializeComponent();
            this.dataGridViewMatSelec.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMatSelec.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            oBLLPedidoMateriaPrima = new BLLPedidoMateriaPrima();
            oBLLMaterial = new BLLMaterial();
            oBEMaterial = new BEMaterial();
            oBLLOrdenProduccion = new BLLOrdenProduccion();
        }

        public BEOrdenProduccion oBEOrdenProduccion;
        List<BEMaterial> listaMateriales = new List<BEMaterial>();
        BLLOrdenProduccion oBLLOrdenProduccion;
        BLLPedidoMateriaPrima oBLLPedidoMateriaPrima;
        BLLMaterial oBLLMaterial;
        BEMaterial oBEMaterial;
        BEMaterial oBEMaterialSeleccionado;

        private void buttonGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                // Tomo los datos ingresados y genero un pedido de material
                DateTime FechaLimite = DateTime.Parse(dateTimePicker1.Value.ToString("dd/MM/yyyy"));
                if (listaMateriales.Count > 0 && FechaLimite >= DateTime.Now)
                {
                    BEPedidoMateriaPrima oBEPedidoMateriaPrima = new BEPedidoMateriaPrima();
                    oBEPedidoMateriaPrima.Fecha = FechaLimite;
                    oBEPedidoMateriaPrima.Materiales = listaMateriales;
                    oBLLPedidoMateriaPrima.Guardar(oBEPedidoMateriaPrima);
                    oBEPedidoMateriaPrima = oBLLPedidoMateriaPrima.ListarTodo().Last();
                    oBEOrdenProduccion.PedidoMateriaPrima = oBEPedidoMateriaPrima;
                    oBLLOrdenProduccion.Guardar(oBEOrdenProduccion);
                    MessageBox.Show("Se ha generado el pedido de material para la orden de produccion seleccionada");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hay datos faltantes o la fecha es incorrecta");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void LoadComboMateriales()
        {
            try
            {
                // Cargo la lista de materiales para la producción
                List<BEMaterial> materiales = oBLLMaterial.ListarTodo().FindAll(x => x.Tipo == "Metálico" || x.Tipo == "Plástico" || x.Tipo == "Mineral"); //TODO: Check
                foreach (BEMaterial m in materiales)
                {
                    m.Cantidad = 0;
                }
                this.comboBoxMateriales.DataSource = materiales;
                this.comboBoxMateriales.DisplayMember = "Nombre";
                this.comboBoxMateriales.ValueMember = "Id";
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void comboBoxMateriales_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                oBEMaterial = (BEMaterial)this.comboBoxMateriales.SelectedItem;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void buttonAgregarMat_Click(object sender, EventArgs e)
        {
            try
            {
                // Agrego un material con sus cantidades a la orden
                if (textBoxCantidad.Text != "" && int.TryParse(textBoxCantidad.Text, out int cantidad))
                {
                    oBEMaterial.Cantidad += cantidad;
                    if (listaMateriales.Exists(x => x.ID == oBEMaterial.ID))
                    {
                        listaMateriales.Find(x => x.ID == oBEMaterial.ID).Cantidad = oBEMaterial.Cantidad;
                    }
                    else
                    {
                        listaMateriales.Add(oBEMaterial);
                    }
                    this.comboBoxMateriales.SelectedIndex = 0;
                    this.textBoxCantidad.Text = String.Empty;
                    ActualizarDGVMateriales();
                }
                else
                {
                    MessageBox.Show("Ingrese una cantidad");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void ActualizarDGVMateriales()
        {
            this.dataGridViewMatSelec.DataSource = null;
            this.dataGridViewMatSelec.DataSource = listaMateriales;
        }

        private void dataGridViewMatSelec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            oBEMaterialSeleccionado = (BEMaterial)this.dataGridViewMatSelec.CurrentRow.DataBoundItem;
            this.buttonEliminar.Enabled = true;
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                listaMateriales.Remove(oBEMaterialSeleccionado);
                ActualizarDGVMateriales();
                this.buttonEliminar.Enabled = false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void frPedidoMaterial_Load(object sender, EventArgs e)
        {
            LoadComboMateriales();
        }
    }
}
