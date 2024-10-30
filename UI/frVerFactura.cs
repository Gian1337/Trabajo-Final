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
using System.Drawing.Printing;
using System.IO;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace UI
{
    public partial class frVerFactura : Form
    {
        public frVerFactura()
        {
            InitializeComponent();
            oBLLOrden = new BLLOrden();
            oBLLFactura = new BLLFactura();
            this.dataGridViewMateriales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMateriales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMateriales.ReadOnly = true;
            this.dataGridViewMateriales.AllowUserToAddRows = false;
        }

        public BEOrden oBEOrden;
        BLLOrden oBLLOrden;
        BLLFactura oBLLFactura;

        private void frVerFactura_Load(object sender, EventArgs e)
        {
            if (oBEOrden.Factura.ID == 0)
            {
                GenerarFacturaPedido();
            }
            LoadDatosForm();
        }

        private void GenerarFacturaPedido()
        {
            try
            {
                BEFactura oBEFactura = new BEFactura();
                string fecha = DateTime.Now.ToString("dd/MM/yyyy");
                oBEFactura.Tipo = "C";
                oBEFactura.Fecha = DateTime.Parse(fecha);
                oBEFactura.Total = oBEOrden.ImporteTotal;

                oBLLFactura.Guardar(oBEFactura);
                oBEOrden.Factura = oBEFactura;
                oBLLOrden.Guardar(oBEOrden);
                oBEOrden = oBLLOrden.ListarTodo().Find(x => x.ID == oBEOrden.ID);

            }
            catch (Exception) { throw; }
        }

        private void LoadDatosForm()
        {
            try
            {
                this.labelNroFac.Text = oBEOrden.Factura.Numero.ToString();
                this.labelFechaEmision.Text = oBEOrden.Factura.Fecha.ToString("dd/MM/yyyy");
                this.labelRazonSocial.Text = "Gi-t";
                this.labelDomicilioComer.Text = "Pte Roca 2091";
                this.labelDni.Text = oBEOrden.Cliente.NroDocumento.ToString(); 
                this.labelNomYApe.Text = oBEOrden.Cliente.Nombre + " " + oBEOrden.Cliente.Apellido;
                this.labelDomicilio.Text = oBEOrden.Cliente.Direccion;
                this.labelSubTotal.Text = "$" + oBEOrden.listaMateriales.Sum(x => x.Cantidad * x.Precio).ToString();
                this.labelTotal.Text = "$" + oBEOrden.ImporteTotal.ToString();

                this.dataGridViewMateriales.DataSource = oBEOrden.listaMateriales;
                this.dataGridViewMateriales.Columns["Nombre"].FillWeight = 400;
                this.dataGridViewMateriales.Columns.Remove("Id");
                this.dataGridViewMateriales.Columns.Remove("Tipo");
                this.dataGridViewMateriales.Columns.Remove("Durabilidad");
                this.dataGridViewMateriales.Columns.Remove("Aislamiento");
                this.dataGridViewMateriales.Columns["Precio"].HeaderText = "Precio unitario";
                this.dataGridViewMateriales.ClearSelection();
            }
            catch (Exception) { throw; }
        }

        private void buttonGuardarFac_Click(object sender, EventArgs e)
        {
            try
            {
                // Realizamos un bitmap de la factura y la guardamos en PDF
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivos PDF|*.pdf";
                saveFileDialog.Title = "Guardar factura";
                saveFileDialog.FileName = $"Factura C {oBEOrden.Fecha.ToString("dd-MM-yyyy HH-mm-ss")}";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string directorioPdf = saveFileDialog.FileName;

                    try
                    {
                        System.Drawing.Rectangle rectanguloPanel = this.panel1.Bounds;
                        Bitmap bmap = new Bitmap(rectanguloPanel.Width, rectanguloPanel.Height);
                        using (Document documento = new Document(PageSize.A4, 0, 0, 0, 0))
                        {

                            PdfWriter pWriter = PdfWriter.GetInstance(documento, new FileStream(directorioPdf, FileMode.Create));
                            documento.Open();
                            PdfContentByte contentbyte = pWriter.DirectContent;
                            this.panel1.DrawToBitmap(bmap, new System.Drawing.Rectangle(0, 0, rectanguloPanel.Width, rectanguloPanel.Height));
                            iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance(bmap, BaseColor.WHITE);

                            float x = (documento.PageSize.Width - imagen.ScaledWidth) / 2;
                            float y = (documento.PageSize.Height - imagen.ScaledHeight) / 2;

                            imagen.SetAbsolutePosition(x, y);
                            documento.Add(imagen);

                            MessageBox.Show("Se ha guardado la factura correctamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            documento.Close();
                        }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void dataGridViewMateriales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridViewMateriales.ClearSelection();
        }
    }
}
