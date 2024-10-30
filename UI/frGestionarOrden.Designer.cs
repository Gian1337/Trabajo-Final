namespace UI
{
    partial class frGestionarOrden
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frGestionarOrden));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonContinuar = new System.Windows.Forms.Button();
            this.labelImporte = new System.Windows.Forms.Label();
            this.buttonEliminarMat = new System.Windows.Forms.Button();
            this.dataGridViewCarrito = new System.Windows.Forms.DataGridView();
            this.labelProdCarrito = new System.Windows.Forms.Label();
            this.groupBoxDetalleProd = new System.Windows.Forms.GroupBox();
            this.labelPrecioProd = new System.Windows.Forms.Label();
            this.labelCantProd = new System.Windows.Forms.Label();
            this.buttonAgregarMat = new System.Windows.Forms.Button();
            this.labelTipoProd = new System.Windows.Forms.Label();
            this.labelMatProd = new System.Windows.Forms.Label();
            this.labelDescProd = new System.Windows.Forms.Label();
            this.labelNomProd = new System.Windows.Forms.Label();
            this.dataGridViewMateriales = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarrito)).BeginInit();
            this.groupBoxDetalleProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMateriales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 471);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 31);
            this.label3.TabIndex = 21;
            this.label3.Text = "Carrito";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(80)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(4, -6);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1189, 90);
            this.label2.TabIndex = 20;
            this.label2.Text = "ORDEN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonContinuar
            // 
            this.buttonContinuar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContinuar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContinuar.Location = new System.Drawing.Point(571, 769);
            this.buttonContinuar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonContinuar.Name = "buttonContinuar";
            this.buttonContinuar.Size = new System.Drawing.Size(164, 39);
            this.buttonContinuar.TabIndex = 19;
            this.buttonContinuar.Text = "Continuar";
            this.buttonContinuar.UseVisualStyleBackColor = true;
            this.buttonContinuar.Click += new System.EventHandler(this.buttonContinuar_Click);
            // 
            // labelImporte
            // 
            this.labelImporte.AutoSize = true;
            this.labelImporte.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImporte.Location = new System.Drawing.Point(580, 551);
            this.labelImporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelImporte.Name = "labelImporte";
            this.labelImporte.Size = new System.Drawing.Size(117, 23);
            this.labelImporte.TabIndex = 15;
            this.labelImporte.Text = "Sub total:";
            // 
            // buttonEliminarMat
            // 
            this.buttonEliminarMat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonEliminarMat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminarMat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarMat.Location = new System.Drawing.Point(571, 710);
            this.buttonEliminarMat.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEliminarMat.Name = "buttonEliminarMat";
            this.buttonEliminarMat.Size = new System.Drawing.Size(164, 39);
            this.buttonEliminarMat.TabIndex = 16;
            this.buttonEliminarMat.Text = "Eliminar articulo";
            this.buttonEliminarMat.UseVisualStyleBackColor = true;
            this.buttonEliminarMat.Click += new System.EventHandler(this.buttonEliminarMat_Click);
            // 
            // dataGridViewCarrito
            // 
            this.dataGridViewCarrito.AllowUserToAddRows = false;
            this.dataGridViewCarrito.AllowUserToDeleteRows = false;
            this.dataGridViewCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCarrito.Location = new System.Drawing.Point(18, 506);
            this.dataGridViewCarrito.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewCarrito.Name = "dataGridViewCarrito";
            this.dataGridViewCarrito.ReadOnly = true;
            this.dataGridViewCarrito.RowHeadersWidth = 51;
            this.dataGridViewCarrito.Size = new System.Drawing.Size(535, 302);
            this.dataGridViewCarrito.TabIndex = 18;
            // 
            // labelProdCarrito
            // 
            this.labelProdCarrito.AutoSize = true;
            this.labelProdCarrito.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProdCarrito.Location = new System.Drawing.Point(580, 506);
            this.labelProdCarrito.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProdCarrito.Name = "labelProdCarrito";
            this.labelProdCarrito.Size = new System.Drawing.Size(135, 23);
            this.labelProdCarrito.TabIndex = 17;
            this.labelProdCarrito.Text = "Articulos: 0";
            // 
            // groupBoxDetalleProd
            // 
            this.groupBoxDetalleProd.Controls.Add(this.labelPrecioProd);
            this.groupBoxDetalleProd.Controls.Add(this.labelCantProd);
            this.groupBoxDetalleProd.Controls.Add(this.buttonAgregarMat);
            this.groupBoxDetalleProd.Controls.Add(this.labelTipoProd);
            this.groupBoxDetalleProd.Controls.Add(this.labelMatProd);
            this.groupBoxDetalleProd.Controls.Add(this.labelDescProd);
            this.groupBoxDetalleProd.Controls.Add(this.labelNomProd);
            this.groupBoxDetalleProd.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDetalleProd.Location = new System.Drawing.Point(637, 117);
            this.groupBoxDetalleProd.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxDetalleProd.Name = "groupBoxDetalleProd";
            this.groupBoxDetalleProd.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxDetalleProd.Size = new System.Drawing.Size(531, 314);
            this.groupBoxDetalleProd.TabIndex = 14;
            this.groupBoxDetalleProd.TabStop = false;
            this.groupBoxDetalleProd.Text = "Detalles";
            this.groupBoxDetalleProd.Visible = false;
            // 
            // labelPrecioProd
            // 
            this.labelPrecioProd.AutoSize = true;
            this.labelPrecioProd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioProd.Location = new System.Drawing.Point(235, 190);
            this.labelPrecioProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrecioProd.Name = "labelPrecioProd";
            this.labelPrecioProd.Size = new System.Drawing.Size(77, 28);
            this.labelPrecioProd.TabIndex = 6;
            this.labelPrecioProd.Text = "PRECIO";
            // 
            // labelCantProd
            // 
            this.labelCantProd.AutoSize = true;
            this.labelCantProd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantProd.Location = new System.Drawing.Point(163, 268);
            this.labelCantProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCantProd.Name = "labelCantProd";
            this.labelCantProd.Size = new System.Drawing.Size(50, 23);
            this.labelCantProd.TabIndex = 5;
            this.labelCantProd.Text = "Stock";
            // 
            // buttonAgregarMat
            // 
            this.buttonAgregarMat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonAgregarMat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregarMat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarMat.Location = new System.Drawing.Point(167, 222);
            this.buttonAgregarMat.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAgregarMat.Name = "buttonAgregarMat";
            this.buttonAgregarMat.Size = new System.Drawing.Size(216, 42);
            this.buttonAgregarMat.TabIndex = 4;
            this.buttonAgregarMat.Text = "Añadir articulo";
            this.buttonAgregarMat.UseVisualStyleBackColor = true;
            this.buttonAgregarMat.Click += new System.EventHandler(this.buttonAgregarMat_Click);
            // 
            // labelTipoProd
            // 
            this.labelTipoProd.AutoSize = true;
            this.labelTipoProd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoProd.Location = new System.Drawing.Point(33, 151);
            this.labelTipoProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTipoProd.Name = "labelTipoProd";
            this.labelTipoProd.Size = new System.Drawing.Size(51, 28);
            this.labelTipoProd.TabIndex = 3;
            this.labelTipoProd.Text = "Tipo";
            // 
            // labelMatProd
            // 
            this.labelMatProd.AutoSize = true;
            this.labelMatProd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatProd.Location = new System.Drawing.Point(33, 112);
            this.labelMatProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMatProd.Name = "labelMatProd";
            this.labelMatProd.Size = new System.Drawing.Size(84, 28);
            this.labelMatProd.TabIndex = 2;
            this.labelMatProd.Text = "Material";
            // 
            // labelDescProd
            // 
            this.labelDescProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDescProd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescProd.Location = new System.Drawing.Point(33, 65);
            this.labelDescProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescProd.Name = "labelDescProd";
            this.labelDescProd.Size = new System.Drawing.Size(453, 47);
            this.labelDescProd.TabIndex = 1;
            this.labelDescProd.Text = "Descripcion material";
            // 
            // labelNomProd
            // 
            this.labelNomProd.AutoSize = true;
            this.labelNomProd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomProd.Location = new System.Drawing.Point(8, 20);
            this.labelNomProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNomProd.Name = "labelNomProd";
            this.labelNomProd.Size = new System.Drawing.Size(187, 28);
            this.labelNomProd.TabIndex = 0;
            this.labelNomProd.Text = "NOMBRE MATERIAL";
            // 
            // dataGridViewMateriales
            // 
            this.dataGridViewMateriales.AllowUserToAddRows = false;
            this.dataGridViewMateriales.AllowUserToDeleteRows = false;
            this.dataGridViewMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMateriales.Location = new System.Drawing.Point(13, 129);
            this.dataGridViewMateriales.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewMateriales.Name = "dataGridViewMateriales";
            this.dataGridViewMateriales.ReadOnly = true;
            this.dataGridViewMateriales.RowHeadersWidth = 51;
            this.dataGridViewMateriales.Size = new System.Drawing.Size(535, 302);
            this.dataGridViewMateriales.TabIndex = 13;
            this.dataGridViewMateriales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMateriales_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Lista de materiales";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(19, 470);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 29);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(12, 96);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 29);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // frGestionarOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 830);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonContinuar);
            this.Controls.Add(this.labelImporte);
            this.Controls.Add(this.buttonEliminarMat);
            this.Controls.Add(this.dataGridViewCarrito);
            this.Controls.Add(this.labelProdCarrito);
            this.Controls.Add(this.groupBoxDetalleProd);
            this.Controls.Add(this.dataGridViewMateriales);
            this.Controls.Add(this.label1);
            this.Name = "frGestionarOrden";
            this.Text = "Gestionar Orden";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frGestionarOrden_FormClosing);
            this.Load += new System.EventHandler(this.frGestionarOrden_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarrito)).EndInit();
            this.groupBoxDetalleProd.ResumeLayout(false);
            this.groupBoxDetalleProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMateriales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonContinuar;
        private System.Windows.Forms.Label labelImporte;
        private System.Windows.Forms.Button buttonEliminarMat;
        private System.Windows.Forms.DataGridView dataGridViewCarrito;
        private System.Windows.Forms.Label labelProdCarrito;
        private System.Windows.Forms.GroupBox groupBoxDetalleProd;
        private System.Windows.Forms.Label labelPrecioProd;
        private System.Windows.Forms.Label labelCantProd;
        private System.Windows.Forms.Button buttonAgregarMat;
        private System.Windows.Forms.Label labelTipoProd;
        private System.Windows.Forms.Label labelMatProd;
        private System.Windows.Forms.Label labelDescProd;
        private System.Windows.Forms.Label labelNomProd;
        private System.Windows.Forms.DataGridView dataGridViewMateriales;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}