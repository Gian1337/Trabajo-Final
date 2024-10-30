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
    public partial class frGestionarOrdenEntrega : Form
    {
        public frGestionarOrdenEntrega()
        {
            InitializeComponent();
            oBLLEntrega = new BLLEntrega();
            oBLLOrden = new BLLOrden();
            oBLLEstado = new BLLEstado();
            oBLLBitacora = new BLLBitacora();
        }

        public BEEmpleado UsuarioActual;
        BLLEntrega oBLLEntrega;
        BLLOrden oBLLOrden;
        BLLEstado oBLLEstado;
        BLLBitacora oBLLBitacora;

        private void buttonIngresarCod_Click(object sender, EventArgs e)
        {
            try
            {
                // Se ingresa el codigo y se busca la orden mostrandose sus datos y finalizandola
                if (textBoxCod.Text != "")
                {
                    BEEntrega oBEEntrega = oBLLEntrega.BuscarOrdenEntregaPorCodigo(textBoxCod.Text);
                    if (oBEEntrega != null)
                    {
                        MessageBox.Show("Se ha encontrado la orden");
                        string Detalle = "DETALLES DE ORDEN DE ENTREGA\n" +
                            $"PEDIDO N°: {oBEEntrega.Orden.Numero}\n" +
                            $"CLIENTE: {oBEEntrega.Orden.Cliente.Nombre} {oBEEntrega.Orden.Cliente.Apellido} DNI: {oBEEntrega.Orden.Cliente.NroDocumento}\n" +
                            $"DIRECCION DE ENTREGA: {oBEEntrega.Orden.Cliente.DireccionEntrega}\n" +
                            $"FECHA DE GENERACIÓN DE ORDEN: {oBEEntrega.Fecha}\n\n" +
                            $"PRODUCTOS:\n";
                        foreach (BEMaterial m in oBEEntrega.Orden.listaMateriales)
                        {
                            Detalle += $"{m.Cantidad}x          {m.Nombre}\n";
                        }
                        DialogResult dialog = MessageBox.Show(Detalle, "Info", MessageBoxButtons.YesNo);
                        if (dialog == DialogResult.Yes)
                        {
                            oBLLEntrega.GestionarOrdenEntrega(oBEEntrega); 
                            oBEEntrega.Orden.Estado = oBLLEstado.ActualizaEstado(oBEEntrega.Orden);
                            if (oBLLOrden.Guardar(oBEEntrega.Orden) == true) //TODO: Revisar por qué llega un estado NULL
                            {
                                MessageBox.Show("La entrega ha sido finalizada con exito");
                                oBLLBitacora.Log(UsuarioActual, $"Orden de entrega n°{oBEEntrega.ID} cumplida");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Error al guardar la orden");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("El codigo ingresado es incorrecto o ya se ha finalizado la orden de entrega");
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
