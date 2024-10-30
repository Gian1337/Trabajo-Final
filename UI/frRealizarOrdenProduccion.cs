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
    public partial class frRealizarOrdenProduccion : Form
    {
        public frRealizarOrdenProduccion()
        {
            InitializeComponent();
            this.dataGridViewOrdenes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrdenes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            oBLLOrdenProduccion = new BLLOrdenProduccion();
            oBEOrdenProduccion = new BEOrdenProduccion();
            oBLLBitacora = new BLLBitacora();
        }

        public BEEmpleado Empleado;
        BLLOrdenProduccion oBLLOrdenProduccion;
        BEOrdenProduccion oBEOrdenProduccion;
        BLLBitacora oBLLBitacora;
        List<string> listaPasos = new List<string>();


        private void LoadDGVOrdenesEmpleado()
        {
            // Se cargan aquellas ordenes de produccion que hayan sido asignadas al empleado
            this.dataGridViewOrdenes.DataSource = null;
            this.dataGridViewOrdenes.DataSource = oBLLOrdenProduccion.ListarTodo().FindAll(x => x.Empleado != null && x.Empleado.ID == Empleado.ID);
        }

        private void frRealizarOrdenProduccion_Load(object sender, EventArgs e)
        {
            LoadDGVOrdenesEmpleado();
        }

        private void dataGridViewOrdenes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Se listan los detalles de la orden seleccionada, mostrando sus tareas
                oBEOrdenProduccion = (BEOrdenProduccion)this.dataGridViewOrdenes.CurrentRow.DataBoundItem;
                this.groupBoxDatos.Visible = true;
                this.labelFecha.Text = oBEOrdenProduccion.Fecha.ToString("dd/MM/yyyy");
                this.labelProducto.Text = oBEOrdenProduccion.Material.Nombre;
                if (oBEOrdenProduccion.Pasos.Count != 0)
                {
                    this.buttonFinalizarT.Enabled = true;
                    this.labelTarea.Text = oBEOrdenProduccion.Pasos.First();
                }
                else
                {
                    this.buttonFinalizarOrden.Enabled = true;
                    this.labelTarea.Text = "Has finalizado todos los pasos, ya puedes finalizar la orden";
                    this.buttonFinalizarT.Enabled = false;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void buttonFinalizarT_Click(object sender, EventArgs e)
        {
            try
            {
                // Finaliza una tarea y actualiza la tabla
                oBEOrdenProduccion.Pasos.RemoveAt(0);
                oBLLOrdenProduccion.Guardar(oBEOrdenProduccion);
                if (oBEOrdenProduccion.Pasos.Count == 0)
                {
                    MessageBox.Show("Finalizaste todas las tareas de la orden");
                    this.buttonFinalizarOrden.Enabled = true;
                    this.labelTarea.Text = "Has finalizado todas las tareas, ya puedes finalizar la orden";
                    this.buttonFinalizarT.Enabled = false;
                }
                else
                {
                    this.labelTarea.Text = oBEOrdenProduccion.Pasos.First();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void buttonFinalizarOrden_Click(object sender, EventArgs e)
        {
            try
            {
                // Se finaliza la orden de producción una vez se hayan cumplido las tareas
                oBLLOrdenProduccion.FinalizarOrdenProduccion(oBEOrdenProduccion);
                MessageBox.Show("Ha finalizado la orden de produccion!");
                oBLLBitacora.Log(Empleado, $"Orden de produccion finalizada N°{oBEOrdenProduccion.Numero}");
                LoadDGVOrdenesEmpleado();
                this.groupBoxDatos.Visible = false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
