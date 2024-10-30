namespace UI
{
    partial class frGenerarOrdenProduccion
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
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxTareas = new System.Windows.Forms.ListBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTareas = new System.Windows.Forms.TextBox();
            this.buttonGenerarOrden = new System.Windows.Forms.Button();
            this.dataGridViewMateriales = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMateriales)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(80)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1066, 90);
            this.label4.TabIndex = 16;
            this.label4.Text = "GENERAR ORDEN DE PRODUCCIÓN";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxTareas);
            this.groupBox1.Controls.Add(this.buttonAgregar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxTareas);
            this.groupBox1.Location = new System.Drawing.Point(549, 189);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(447, 390);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // listBoxTareas
            // 
            this.listBoxTareas.FormattingEnabled = true;
            this.listBoxTareas.ItemHeight = 16;
            this.listBoxTareas.Location = new System.Drawing.Point(20, 258);
            this.listBoxTareas.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxTareas.Name = "listBoxTareas";
            this.listBoxTareas.Size = new System.Drawing.Size(417, 116);
            this.listBoxTareas.TabIndex = 5;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregar.Location = new System.Drawing.Point(339, 201);
            this.buttonAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(100, 28);
            this.buttonAgregar.TabIndex = 7;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese las tareas a realizar en la orden seleccionada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 239);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tareas asignadas";
            // 
            // textBoxTareas
            // 
            this.textBoxTareas.Location = new System.Drawing.Point(20, 41);
            this.textBoxTareas.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTareas.Multiline = true;
            this.textBoxTareas.Name = "textBoxTareas";
            this.textBoxTareas.Size = new System.Drawing.Size(417, 152);
            this.textBoxTareas.TabIndex = 4;
            // 
            // buttonGenerarOrden
            // 
            this.buttonGenerarOrden.Enabled = false;
            this.buttonGenerarOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerarOrden.Location = new System.Drawing.Point(192, 558);
            this.buttonGenerarOrden.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGenerarOrden.Name = "buttonGenerarOrden";
            this.buttonGenerarOrden.Size = new System.Drawing.Size(221, 28);
            this.buttonGenerarOrden.TabIndex = 14;
            this.buttonGenerarOrden.Text = "Generar orden de producción";
            this.buttonGenerarOrden.UseVisualStyleBackColor = true;
            this.buttonGenerarOrden.Click += new System.EventHandler(this.buttonGenerarOrden_Click);
            // 
            // dataGridViewMateriales
            // 
            this.dataGridViewMateriales.AllowUserToAddRows = false;
            this.dataGridViewMateriales.AllowUserToDeleteRows = false;
            this.dataGridViewMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMateriales.Location = new System.Drawing.Point(65, 196);
            this.dataGridViewMateriales.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewMateriales.Name = "dataGridViewMateriales";
            this.dataGridViewMateriales.ReadOnly = true;
            this.dataGridViewMateriales.RowHeadersWidth = 51;
            this.dataGridViewMateriales.Size = new System.Drawing.Size(476, 356);
            this.dataGridViewMateriales.TabIndex = 13;
            this.dataGridViewMateriales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMateriales_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 173);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Materiales sin stock";
            // 
            // frGenerarOrdenProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 654);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonGenerarOrden);
            this.Controls.Add(this.dataGridViewMateriales);
            this.Controls.Add(this.label1);
            this.Name = "frGenerarOrdenProduccion";
            this.Text = "Generación de Orden de Produccion";
            this.Load += new System.EventHandler(this.frGenerarOrdenProduccion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMateriales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxTareas;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTareas;
        private System.Windows.Forms.Button buttonGenerarOrden;
        private System.Windows.Forms.DataGridView dataGridViewMateriales;
        private System.Windows.Forms.Label label1;
    }
}