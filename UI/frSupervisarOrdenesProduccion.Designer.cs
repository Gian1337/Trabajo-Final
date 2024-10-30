namespace UI
{
    partial class frSupervisarOrdenesProduccion
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
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxDetallesOrden = new System.Windows.Forms.GroupBox();
            this.labelCant = new System.Windows.Forms.Label();
            this.labelMat = new System.Windows.Forms.Label();
            this.labelProd = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSeleccionarOrden = new System.Windows.Forms.Button();
            this.dataGridViewOrdenes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxDetallesOrden.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrdenes)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(80)))));
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1115, 90);
            this.label6.TabIndex = 16;
            this.label6.Text = "SUPERVISAR ORDENES DE PRODUCCIÓN";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxDetallesOrden
            // 
            this.groupBoxDetallesOrden.Controls.Add(this.labelCant);
            this.groupBoxDetallesOrden.Controls.Add(this.labelMat);
            this.groupBoxDetallesOrden.Controls.Add(this.labelProd);
            this.groupBoxDetallesOrden.Controls.Add(this.labelFecha);
            this.groupBoxDetallesOrden.Controls.Add(this.label5);
            this.groupBoxDetallesOrden.Controls.Add(this.label4);
            this.groupBoxDetallesOrden.Controls.Add(this.label3);
            this.groupBoxDetallesOrden.Controls.Add(this.label2);
            this.groupBoxDetallesOrden.Location = new System.Drawing.Point(611, 211);
            this.groupBoxDetallesOrden.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxDetallesOrden.Name = "groupBoxDetallesOrden";
            this.groupBoxDetallesOrden.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxDetallesOrden.Size = new System.Drawing.Size(456, 263);
            this.groupBoxDetallesOrden.TabIndex = 15;
            this.groupBoxDetallesOrden.TabStop = false;
            this.groupBoxDetallesOrden.Text = "Detalles";
            this.groupBoxDetallesOrden.Visible = false;
            // 
            // labelCant
            // 
            this.labelCant.AutoSize = true;
            this.labelCant.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCant.Location = new System.Drawing.Point(21, 212);
            this.labelCant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCant.Name = "labelCant";
            this.labelCant.Size = new System.Drawing.Size(83, 23);
            this.labelCant.TabIndex = 7;
            this.labelCant.Text = "Cantidad:";
            // 
            // labelMat
            // 
            this.labelMat.AutoSize = true;
            this.labelMat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMat.Location = new System.Drawing.Point(21, 160);
            this.labelMat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMat.Name = "labelMat";
            this.labelMat.Size = new System.Drawing.Size(102, 23);
            this.labelMat.TabIndex = 6;
            this.labelMat.Text = "Durabilidad:";
            // 
            // labelProd
            // 
            this.labelProd.AutoSize = true;
            this.labelProd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProd.Location = new System.Drawing.Point(16, 105);
            this.labelProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProd.Name = "labelProd";
            this.labelProd.Size = new System.Drawing.Size(76, 23);
            this.labelProd.TabIndex = 5;
            this.labelProd.Text = "Material:";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(16, 52);
            this.labelFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(58, 23);
            this.labelFecha.TabIndex = 4;
            this.labelFecha.Text = "Fecha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 191);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Unidades:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Durabilidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Material a fabricar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha:";
            // 
            // buttonSeleccionarOrden
            // 
            this.buttonSeleccionarOrden.Enabled = false;
            this.buttonSeleccionarOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSeleccionarOrden.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeleccionarOrden.Location = new System.Drawing.Point(767, 499);
            this.buttonSeleccionarOrden.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSeleccionarOrden.Name = "buttonSeleccionarOrden";
            this.buttonSeleccionarOrden.Size = new System.Drawing.Size(168, 49);
            this.buttonSeleccionarOrden.TabIndex = 14;
            this.buttonSeleccionarOrden.Text = "Seleccionar orden";
            this.buttonSeleccionarOrden.UseVisualStyleBackColor = true;
            this.buttonSeleccionarOrden.Click += new System.EventHandler(this.buttonSeleccionarOrden_Click);
            // 
            // dataGridViewOrdenes
            // 
            this.dataGridViewOrdenes.AllowUserToAddRows = false;
            this.dataGridViewOrdenes.AllowUserToDeleteRows = false;
            this.dataGridViewOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrdenes.Location = new System.Drawing.Point(39, 211);
            this.dataGridViewOrdenes.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewOrdenes.Name = "dataGridViewOrdenes";
            this.dataGridViewOrdenes.ReadOnly = true;
            this.dataGridViewOrdenes.RowHeadersWidth = 51;
            this.dataGridViewOrdenes.Size = new System.Drawing.Size(564, 364);
            this.dataGridViewOrdenes.TabIndex = 13;
            this.dataGridViewOrdenes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrdenes_CellContentClick);
            this.dataGridViewOrdenes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewOrdenes_CellFormatting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 188);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ordenes de producción sin asignar";
            // 
            // frSupervisarOrdenesProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 662);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBoxDetallesOrden);
            this.Controls.Add(this.buttonSeleccionarOrden);
            this.Controls.Add(this.dataGridViewOrdenes);
            this.Controls.Add(this.label1);
            this.Name = "frSupervisarOrdenesProduccion";
            this.Text = "Supervisión Ordenes de Produccion";
            this.Load += new System.EventHandler(this.frSupervisarOrdenesProduccion_Load);
            this.groupBoxDetallesOrden.ResumeLayout(false);
            this.groupBoxDetallesOrden.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrdenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBoxDetallesOrden;
        private System.Windows.Forms.Label labelCant;
        private System.Windows.Forms.Label labelMat;
        private System.Windows.Forms.Label labelProd;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSeleccionarOrden;
        private System.Windows.Forms.DataGridView dataGridViewOrdenes;
        private System.Windows.Forms.Label label1;
    }
}