namespace UI
{
    partial class frRealizarOrdenProduccion
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
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.labelProducto = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonFinalizarOrden = new System.Windows.Forms.Button();
            this.buttonFinalizarT = new System.Windows.Forms.Button();
            this.labelTarea = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewOrdenes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxDatos.SuspendLayout();
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
            this.label6.Size = new System.Drawing.Size(1199, 90);
            this.label6.TabIndex = 16;
            this.label6.Text = "REALIZAR ORDEN DE PRODUCCIÓN";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.Controls.Add(this.labelProducto);
            this.groupBoxDatos.Controls.Add(this.label5);
            this.groupBoxDatos.Controls.Add(this.buttonFinalizarOrden);
            this.groupBoxDatos.Controls.Add(this.buttonFinalizarT);
            this.groupBoxDatos.Controls.Add(this.labelTarea);
            this.groupBoxDatos.Controls.Add(this.label4);
            this.groupBoxDatos.Controls.Add(this.labelFecha);
            this.groupBoxDatos.Controls.Add(this.label3);
            this.groupBoxDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDatos.Location = new System.Drawing.Point(477, 237);
            this.groupBoxDatos.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxDatos.Size = new System.Drawing.Size(623, 303);
            this.groupBoxDatos.TabIndex = 15;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "Detalles de la orden";
            this.groupBoxDatos.Visible = false;
            // 
            // labelProducto
            // 
            this.labelProducto.AutoSize = true;
            this.labelProducto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProducto.Location = new System.Drawing.Point(341, 34);
            this.labelProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProducto.Name = "labelProducto";
            this.labelProducto.Size = new System.Drawing.Size(64, 20);
            this.labelProducto.TabIndex = 11;
            this.labelProducto.Text = "Material";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(264, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Material:";
            // 
            // buttonFinalizarOrden
            // 
            this.buttonFinalizarOrden.Enabled = false;
            this.buttonFinalizarOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFinalizarOrden.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFinalizarOrden.Location = new System.Drawing.Point(467, 244);
            this.buttonFinalizarOrden.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFinalizarOrden.Name = "buttonFinalizarOrden";
            this.buttonFinalizarOrden.Size = new System.Drawing.Size(139, 42);
            this.buttonFinalizarOrden.TabIndex = 9;
            this.buttonFinalizarOrden.Text = "Finalizar orden";
            this.buttonFinalizarOrden.UseVisualStyleBackColor = true;
            this.buttonFinalizarOrden.Click += new System.EventHandler(this.buttonFinalizarOrden_Click);
            // 
            // buttonFinalizarT
            // 
            this.buttonFinalizarT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFinalizarT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFinalizarT.Location = new System.Drawing.Point(12, 170);
            this.buttonFinalizarT.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFinalizarT.Name = "buttonFinalizarT";
            this.buttonFinalizarT.Size = new System.Drawing.Size(131, 28);
            this.buttonFinalizarT.TabIndex = 8;
            this.buttonFinalizarT.Text = "Finalizar tarea";
            this.buttonFinalizarT.UseVisualStyleBackColor = true;
            this.buttonFinalizarT.Click += new System.EventHandler(this.buttonFinalizarT_Click);
            // 
            // labelTarea
            // 
            this.labelTarea.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTarea.Location = new System.Drawing.Point(8, 110);
            this.labelTarea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTarea.Name = "labelTarea";
            this.labelTarea.Size = new System.Drawing.Size(564, 57);
            this.labelTarea.TabIndex = 7;
            this.labelTarea.Text = "Tarea";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tareas:";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(111, 34);
            this.labelFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(69, 20);
            this.labelFecha.TabIndex = 5;
            this.labelFecha.Text = "00/00/00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha limite:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 218);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Selecciona una orden para ver sus detalles y completarla";
            // 
            // dataGridViewOrdenes
            // 
            this.dataGridViewOrdenes.AllowUserToAddRows = false;
            this.dataGridViewOrdenes.AllowUserToDeleteRows = false;
            this.dataGridViewOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrdenes.Location = new System.Drawing.Point(105, 237);
            this.dataGridViewOrdenes.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewOrdenes.Name = "dataGridViewOrdenes";
            this.dataGridViewOrdenes.ReadOnly = true;
            this.dataGridViewOrdenes.RowHeadersWidth = 51;
            this.dataGridViewOrdenes.Size = new System.Drawing.Size(364, 303);
            this.dataGridViewOrdenes.TabIndex = 13;
            this.dataGridViewOrdenes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrdenes_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 198);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tus ordenes de produccion";
            // 
            // frRealizarOrdenProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 665);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBoxDatos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewOrdenes);
            this.Controls.Add(this.label1);
            this.Name = "frRealizarOrdenProduccion";
            this.Text = "Realizar Orden de Produccion";
            this.Load += new System.EventHandler(this.frRealizarOrdenProduccion_Load);
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrdenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.Label labelProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonFinalizarOrden;
        private System.Windows.Forms.Button buttonFinalizarT;
        private System.Windows.Forms.Label labelTarea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewOrdenes;
        private System.Windows.Forms.Label label1;
    }
}