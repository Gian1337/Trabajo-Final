namespace UI
{
    partial class frDetalleOrden
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
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelFecha = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewMateriales = new System.Windows.Forms.DataGridView();
            this.labelSubTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMateriales)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.buttonConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmar.Location = new System.Drawing.Point(542, 531);
            this.buttonConfirmar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(148, 28);
            this.buttonConfirmar.TabIndex = 7;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Visible = false;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(23, 531);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(100, 28);
            this.buttonCancelar.TabIndex = 6;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAceptar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAceptar.Location = new System.Drawing.Point(131, 531);
            this.buttonAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(100, 28);
            this.buttonAceptar.TabIndex = 5;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.labelFecha);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelTotal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dataGridViewMateriales);
            this.groupBox1.Controls.Add(this.labelSubTotal);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(667, 511);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DETALLES DE LA ORDEN";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(468, 52);
            this.labelFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(114, 28);
            this.labelFecha.TabIndex = 10;
            this.labelFecha.Text = "DD/MM/YY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(240, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fecha de emision: ";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(160, 457);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(72, 28);
            this.labelTotal.TabIndex = 8;
            this.labelTotal.Text = "00000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 457);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Total (IVA):";
            // 
            // dataGridViewMateriales
            // 
            this.dataGridViewMateriales.AllowUserToAddRows = false;
            this.dataGridViewMateriales.AllowUserToDeleteRows = false;
            this.dataGridViewMateriales.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMateriales.Location = new System.Drawing.Point(13, 80);
            this.dataGridViewMateriales.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewMateriales.Name = "dataGridViewMateriales";
            this.dataGridViewMateriales.ReadOnly = true;
            this.dataGridViewMateriales.RowHeadersWidth = 51;
            this.dataGridViewMateriales.Size = new System.Drawing.Size(645, 298);
            this.dataGridViewMateriales.TabIndex = 6;
            // 
            // labelSubTotal
            // 
            this.labelSubTotal.AutoSize = true;
            this.labelSubTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubTotal.Location = new System.Drawing.Point(160, 396);
            this.labelSubTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSubTotal.Name = "labelSubTotal";
            this.labelSubTotal.Size = new System.Drawing.Size(67, 28);
            this.labelSubTotal.TabIndex = 4;
            this.labelSubTotal.Text = "00000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 396);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 28);
            this.label7.TabIndex = 2;
            this.label7.Text = "Sub total:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Material";
            // 
            // frDetalleOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 579);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frDetalleOrden";
            this.Text = "Detalles de la Orden";
            this.Load += new System.EventHandler(this.frDetalleOrden_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMateriales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button buttonConfirmar;
        public System.Windows.Forms.Button buttonCancelar;
        public System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewMateriales;
        private System.Windows.Forms.Label labelSubTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
    }
}