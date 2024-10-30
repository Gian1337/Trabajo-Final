using BLL;
using BE;
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
    public partial class frGenerarOrdenEntrega : Form
    {
        public frGenerarOrdenEntrega()
        {
            InitializeComponent();
            this.dataGridViewOrdenes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrdenes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            oBLLOrden = new BLLOrden();
            oBEOrden = new BEOrden();
            oBLLEntrega = new BLLEntrega();
            oBLLEstado = new BLLEstado();
            oBLLBitacora = new BLLBitacora();
        }

        public BEEmpleado UsuarioActual;
        BEEntrega oBEEntrega;
        BLLEntrega oBLLEntrega;
        BEOrden oBEOrden;
        BLLOrden oBLLOrden;
        BLLEstado oBLLEstado;
        BLLBitacora oBLLBitacora;

        private void frGenerarOrdenEntrega_Load(object sender, EventArgs e)
        {
            LoadDGVOrdenesListas();
        }

        private void LoadDGVOrdenesListas()
        {
            try
            {
                // Listo todos las ordenes listas para entregar
                this.dataGridViewOrdenes.DataSource = null;
                this.dataGridViewOrdenes.DataSource = oBLLOrden.ListarTodo().FindAll(x => x.Estado.Tipo == "Listo para distribuir"); //TODO: Revisar
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void buttonSelecOrden_Click(object sender, EventArgs e)
        {
            try
            {
                // Tomo el pedido y muestro los detalles
                oBEEntrega = new BEEntrega();
                oBEOrden = (BEOrden)this.dataGridViewOrdenes.CurrentRow.DataBoundItem;
                frDetalleOrden form = new frDetalleOrden();
                form.buttonConfirmar.Visible = true;
                form.buttonAceptar.Visible = false;
                form.buttonCancelar.Visible = false;
                form.oBEOrden = oBEOrden;
                DialogResult formDialog = form.ShowDialog();
                if (formDialog == DialogResult.Yes)
                {
                    oBEEntrega.Orden = oBEOrden;
                    oBEEntrega.Fecha = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy"));
                    MostrarDetallesOrden();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void MostrarDetallesOrden()
        {
            try
            {
                string Detalle = "DETALLES DE ORDEN DE ENTREGA\n" +
                    $"ORDEN N°: {oBEEntrega.Orden.Numero}\n" +
                    $"CLIENTE: {oBEEntrega.Orden.Cliente.Nombre} {oBEEntrega.Orden.Cliente.Apellido} DNI: {oBEEntrega.Orden.Cliente.NroDocumento}\n" +
                    $"DIRECCION DE ENTREGA: {oBEEntrega.Orden.Cliente.DireccionEntrega}\n" +
                    $"FECHA DE GENERACIÓN DE ORDEN: {oBEEntrega.Fecha}\n";
                DialogResult dialog = MessageBox.Show(Detalle, "Info", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    oBEEntrega.Codigo = GenerarCodigoEntrega();
                    if (oBLLEntrega.Guardar(oBEEntrega) == true)
                    {
                        MessageBox.Show($"Se ha generado la orden de entrega con el codigo de entrega {oBEEntrega.Codigo}", "Orden de Entrega", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        oBLLBitacora.Log(UsuarioActual, $"Se genero la orden de entrega N°{oBEEntrega.ID}");
                        ActualizarEstadoPedido(oBEEntrega.Orden);
                    }
                }
            }
            catch (Exception ex) { throw ex; }
        }
        private void ActualizarEstadoPedido(BEOrden orden)
        {
            try
            {
                orden.Estado = oBLLEstado.ActualizaEstado(orden);
                oBLLOrden.Guardar(orden);
                LoadDGVOrdenesListas();
            }
            catch (Exception) { throw; }
        }

        public string GenerarCodigoEntrega()
        {
            try
            {
                Guid unicoGuid = Guid.NewGuid();
                byte[] bytes = unicoGuid.ToByteArray();
                string codigoUnico = BitConverter.ToString(bytes).Replace("-", "").Substring(0, 10);
                return codigoUnico;
            }
            catch (Exception) { throw; }
        }
    }
}
