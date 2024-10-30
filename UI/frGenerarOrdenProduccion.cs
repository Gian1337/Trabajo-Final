using BE;
using BLL;
using Microsoft.VisualBasic;
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
    public partial class frGenerarOrdenProduccion : Form
    {
        public frGenerarOrdenProduccion()
        {
            InitializeComponent();
            this.dataGridViewMateriales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMateriales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            oBLLMaterial = new BLLMaterial();
            oBEMaterial = new BEMaterial();
            oBLLOrdenProduccion = new BLLOrdenProduccion();
            oBLLBitacora = new BLLBitacora();
        }

        public BEEmpleado UsuarioActual;
        List<string> listaPasos = new List<string>();
        BLLMaterial oBLLMaterial;
        BEMaterial oBEMaterial;
        BEOrdenProduccion oBEOrdenProduccion;
        BLLOrdenProduccion oBLLOrdenProduccion;
        BLLBitacora oBLLBitacora;

        private void LoadDGVMateriales()
        {
            // Listo los materiales sin stock
            List<BEMaterial> listaMaterialesSinStock = oBLLMaterial.ListarTodo().FindAll(x => x.Cantidad == 0 &&  !oBLLOrdenProduccion.ListarTodo().Exists(y => y.Material.ID == x.ID));
            this.dataGridViewMateriales.DataSource = null;
            this.dataGridViewMateriales.DataSource = listaMaterialesSinStock;
        }

        private void frGenerarOrdenProduccion_Load(object sender, EventArgs e)
        {
            LoadDGVMateriales();
        }

        private void dataGridViewMateriales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                oBEMaterial = (BEMaterial)this.dataGridViewMateriales.CurrentRow.DataBoundItem;
                this.buttonGenerarOrden.Enabled = true;
                this.groupBox1.Visible = true;
                this.textBoxTareas.Text = String.Empty;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void buttonGenerarOrden_Click(object sender, EventArgs e)
        {
            try
            {
                // Genero la orden de preducción del material seleccionado
                DialogResult dialog = MessageBox.Show($"¿Desea generar una orden de produccion para el producto {oBEMaterial.Nombre}?", "Alerta", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    oBEOrdenProduccion = new BEOrdenProduccion();
                    oBEOrdenProduccion.Fecha = DateTime.Now;
                    oBEOrdenProduccion.Cantidad = int.Parse(Interaction.InputBox("Ingrese la cantidad que desea producir: ", "Cantidad", DefaultResponse: "10"));
                    oBEOrdenProduccion.Lote = DateTime.Now.ToString("yyMMdd");
                    oBEOrdenProduccion.Pasos = listaPasos;
                    oBEOrdenProduccion.Material = oBEMaterial;
                    oBLLOrdenProduccion.Guardar(oBEOrdenProduccion);
                    MessageBox.Show("Se ha generado la orden exitosamente!");
                    oBLLBitacora.Log(UsuarioActual, $"Orden de produccion N°{oBEOrdenProduccion.ID} generada");
                    listaPasos.Clear();
                    actualizarListBoxTareas();
                    LoadDGVMateriales();
                    this.buttonGenerarOrden.Enabled = false;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Agrego una tarea a la orden de produccion
                if (!string.IsNullOrEmpty(textBoxTareas.Text))
                {
                    listaPasos.Add(textBoxTareas.Text + "-");
                    actualizarListBoxTareas();
                    this.textBoxTareas.Clear();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void actualizarListBoxTareas()
        {
            try
            {
                string textoTareas = "";
                foreach (string t in listaPasos)
                {
                    textoTareas += t;
                }
                this.listBoxTareas.Items.Clear();
                this.listBoxTareas.Items.AddRange(textoTareas.Split('-'));
            }
            catch (Exception) { throw; }
        }
    }
}
