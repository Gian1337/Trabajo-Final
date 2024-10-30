using BE;
using BLL;
using System;
using Microsoft.VisualBasic;
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
    public partial class frGestionarOrden : Form
    {
        public frGestionarOrden()
        {
            InitializeComponent();
            this.dataGridViewMateriales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMateriales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewCarrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            oBEOrden = new BEOrden();
            oBEMaterial = new BEMaterial();
            oBLLMaterial = new BLLMaterial();
            oBLLOrden = new BLLOrden();
        }

        public BEEmpleado UsuarioActual;
        BEOrden oBEOrden;
        BEMaterial oBEMaterial;
        BLLMaterial oBLLMaterial;
        BLLOrden oBLLOrden;
        List<BEMaterial> ListaMateriales = new List<BEMaterial>();


        private void LoadMaterialesDisponibles()
        {
            try
            {
                this.dataGridViewMateriales.DataSource = null;
                this.dataGridViewMateriales.DataSource = ListaMateriales;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        private void frGestionarOrden_Load(object sender, EventArgs e)
        {
            ListaMateriales = oBLLMaterial.ListarTodo();
            LoadMaterialesDisponibles();
        
        }

        private void dataGridViewMateriales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                oBEMaterial = (BEMaterial)this.dataGridViewMateriales.CurrentRow.DataBoundItem;

                this.groupBoxDetalleProd.Visible = true;
                this.labelNomProd.Text = oBEMaterial.Nombre;
                this.labelDescProd.Text = oBEMaterial.Durabilidad;
                this.labelMatProd.Text = "Aislamiento: " + oBEMaterial.Aislamiento;
                this.labelTipoProd.Text = "Tipo: " + oBEMaterial.Tipo;
                this.labelPrecioProd.Text = $"${oBEMaterial.Precio}";

                if (oBEMaterial.Cantidad != 0)
                {
                    this.labelCantProd.Text = "Stock disponible: " + oBEMaterial.Cantidad;
                }
                else
                {
                    this.labelCantProd.Text = "Sin stock";
                }
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

                oBEMaterial = (BEMaterial)this.dataGridViewMateriales.CurrentRow.DataBoundItem;
                if (oBEMaterial.Cantidad != 0)
                {
                    int cantidad = 0;
                    string numero = Interaction.InputBox("Ingrese la cantidad: ", DefaultResponse: "0");
                    if (string.IsNullOrEmpty(numero))
                    {
                        return;
                    }
                    if (int.TryParse(numero, out cantidad))
                    {
                        if (cantidad <= oBEMaterial.Cantidad && cantidad > 0)
                        {
                            // instancio el producto que va al carrito con sus datos
                            BEMaterial oBEMatCarrito = new BEMaterial();
                            oBEMatCarrito.ID = oBEMaterial.ID;
                            oBEMatCarrito.Codigo = oBEMaterial.Codigo;
                            oBEMatCarrito.Nombre = oBEMaterial.Nombre;
                            oBEMatCarrito.Durabilidad = oBEMaterial.Durabilidad;
                            oBEMatCarrito.Aislamiento = oBEMaterial.Aislamiento;
                            oBEMatCarrito.Precio = oBEMaterial.Precio;
                            oBEMatCarrito.Tipo = oBEMaterial.Tipo;
                            oBEMatCarrito.Cantidad = cantidad;

                            // actualizo el stock provisorio del producto
                            oBEMaterial.Cantidad -= cantidad;

                            if (oBEOrden.listaMateriales.Count != 0 && oBEOrden.listaMateriales.Exists(x => x.ID == oBEMatCarrito.ID))
                            {
                                // si ya hay algo en el carro verificamos que no se repitan y actualizamos su cantidad
                                oBEOrden.listaMateriales.Find(x => x.ID == oBEMatCarrito.ID).Cantidad += cantidad;
                            }
                            else
                            {
                                oBEOrden.listaMateriales.Add(oBEMatCarrito);
                            }
                            MessageBox.Show("Se ha agregado el material al carrito");
                            ActualizarDetalles();
                        }
                        else
                        {
                            if (cantidad >= oBEMaterial.Cantidad)
                            {
                                MessageBox.Show("La cantidad solicitada excede el stock del producto");
                            }
                            else
                            {
                                MessageBox.Show("La cantidad solicitada es incorrecta");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Especifique la cantidad en numeros");
                    }

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void ActualizarDetalles()
        {
            try
            {
                this.dataGridViewMateriales.Refresh();
                this.groupBoxDetalleProd.Visible = false;
                this.labelProdCarrito.Text = "Carrito: " + oBEOrden.listaMateriales.Count();
                this.dataGridViewCarrito.DataSource = null;
                this.dataGridViewCarrito.DataSource = oBEOrden.listaMateriales;
                this.labelImporte.Text = "IMPORTE TOTAL: $" + oBLLOrden.CalcularImporte(oBEOrden);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void buttonEliminarMat_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewCarrito.SelectedCells.Count > 0)
                {
                    if (this.dataGridViewCarrito.CurrentRow != null && this.dataGridViewCarrito.CurrentRow.DataBoundItem != null)
                    {
                        BEMaterial oBEMaterialEliminar = (BEMaterial)this.dataGridViewCarrito.CurrentRow.DataBoundItem;
                        DialogResult dialog = MessageBox.Show("¿Desea remover el material del carrito?", "Alerta", MessageBoxButtons.YesNo);
                        if (dialog == DialogResult.Yes)
                        {
                            oBEOrden.listaMateriales.Remove(oBEOrden.listaMateriales.Find(x => x.ID == oBEMaterialEliminar.ID));
                            ListaMateriales.Find(x => x.ID == oBEMaterialEliminar.ID).Cantidad += oBEMaterialEliminar.Cantidad;
                            ActualizarDetalles();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void buttonContinuar_Click(object sender, EventArgs e)
        {
            try
            {
                //Abre detalles y se selecciona al cliente
                if (oBEOrden.listaMateriales.Count != 0)
                {
                    string detallesPedido = "MATERIALES CARGADOS: \n";
                    double subtotal = 0;
                    foreach (BEMaterial m in oBEOrden.listaMateriales)
                    {
                        detallesPedido += $"{m.Cantidad}           {m.Nombre}           ${m.Precio}\n";
                        subtotal += m.Cantidad * m.Precio;
                    }
                    detallesPedido += "\nSUBTOTAL: " + "$" + subtotal + "\n¿Confirma los materiales del carrito?";
                    DialogResult dialog = MessageBox.Show(detallesPedido, "DETALLES DEL CARRITO", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        
                        frSeleccionCliente form = new frSeleccionCliente();
                        form.oBEOrden = oBEOrden;
                        form.UsuarioActual = UsuarioActual;
                        form.ShowDialog();
                        this.Close();
                        
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Debe cargar al menos un producto para continuar");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        private void frGestionarOrden_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (oBEOrden.Estado.ID == 2)
                {
                    frGestionarOrden newForm = new frGestionarOrden();
                    newForm.Show();
                    newForm.UsuarioActual = UsuarioActual;
                    newForm.MdiParent = this.Parent.FindForm();

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
