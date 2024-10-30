namespace UI
{
    partial class frPedidoMaterial
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
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.dataGridViewMatSelec = new System.Windows.Forms.DataGridView();
            this.buttonGenerar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAgregarMat = new System.Windows.Forms.Button();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.comboBoxMateriales = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatSelec)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(80)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1083, 74);
            this.label4.TabIndex = 18;
            this.label4.Text = "GENERAR PEDIDO DE MATERIAL";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Enabled = false;
            this.buttonEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Location = new System.Drawing.Point(935, 309);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(133, 28);
            this.buttonEliminar.TabIndex = 17;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // dataGridViewMatSelec
            // 
            this.dataGridViewMatSelec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatSelec.Location = new System.Drawing.Point(618, 103);
            this.dataGridViewMatSelec.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewMatSelec.Name = "dataGridViewMatSelec";
            this.dataGridViewMatSelec.RowHeadersWidth = 51;
            this.dataGridViewMatSelec.Size = new System.Drawing.Size(451, 198);
            this.dataGridViewMatSelec.TabIndex = 16;
            this.dataGridViewMatSelec.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMatSelec_CellContentClick);
            // 
            // buttonGenerar
            // 
            this.buttonGenerar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerar.Location = new System.Drawing.Point(6, 309);
            this.buttonGenerar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGenerar.Name = "buttonGenerar";
            this.buttonGenerar.Size = new System.Drawing.Size(215, 28);
            this.buttonGenerar.TabIndex = 15;
            this.buttonGenerar.Text = "Generar";
            this.buttonGenerar.UseVisualStyleBackColor = true;
            this.buttonGenerar.Click += new System.EventHandler(this.buttonGenerar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAgregarMat);
            this.groupBox1.Controls.Add(this.textBoxCantidad);
            this.groupBox1.Controls.Add(this.comboBoxMateriales);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 105);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(604, 116);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Complete los campos";
            // 
            // buttonAgregarMat
            // 
            this.buttonAgregarMat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonAgregarMat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregarMat.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarMat.Location = new System.Drawing.Point(485, 68);
            this.buttonAgregarMat.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAgregarMat.Name = "buttonAgregarMat";
            this.buttonAgregarMat.Size = new System.Drawing.Size(111, 28);
            this.buttonAgregarMat.TabIndex = 8;
            this.buttonAgregarMat.Text = "Agregar";
            this.buttonAgregarMat.UseVisualStyleBackColor = true;
            this.buttonAgregarMat.Click += new System.EventHandler(this.buttonAgregarMat_Click);
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(485, 21);
            this.textBoxCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(109, 22);
            this.textBoxCantidad.TabIndex = 5;
            // 
            // comboBoxMateriales
            // 
            this.comboBoxMateriales.DisplayMember = "Hola";
            this.comboBoxMateriales.FormattingEnabled = true;
            this.comboBoxMateriales.Location = new System.Drawing.Point(143, 21);
            this.comboBoxMateriales.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxMateriales.Name = "comboBoxMateriales";
            this.comboBoxMateriales.Size = new System.Drawing.Size(213, 24);
            this.comboBoxMateriales.TabIndex = 4;
            this.comboBoxMateriales.SelectedIndexChanged += new System.EventHandler(this.comboBoxMateriales_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(409, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Unidades:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Material a solicitar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 226);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ingrese la fecha limite entrega:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 246);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(312, 22);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // frPedidoMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 392);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.dataGridViewMatSelec);
            this.Controls.Add(this.buttonGenerar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "frPedidoMaterial";
            this.Text = "frPedidoMaterial";
            this.Load += new System.EventHandler(this.frPedidoMaterial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatSelec)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.DataGridView dataGridViewMatSelec;
        private System.Windows.Forms.Button buttonGenerar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAgregarMat;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.ComboBox comboBoxMateriales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}