namespace UI
{
    partial class frSeleccionCliente
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
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.buttonSelCliente = new System.Windows.Forms.Button();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistrar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrar.Location = new System.Drawing.Point(238, 452);
            this.buttonRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(188, 46);
            this.buttonRegistrar.TabIndex = 8;
            this.buttonRegistrar.Text = "Registrar clientes";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // buttonSelCliente
            // 
            this.buttonSelCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelCliente.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelCliente.Location = new System.Drawing.Point(19, 452);
            this.buttonSelCliente.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSelCliente.Name = "buttonSelCliente";
            this.buttonSelCliente.Size = new System.Drawing.Size(188, 46);
            this.buttonSelCliente.TabIndex = 7;
            this.buttonSelCliente.Text = "Seleccionar";
            this.buttonSelCliente.UseVisualStyleBackColor = true;
            this.buttonSelCliente.Click += new System.EventHandler(this.buttonSelCliente_Click);
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.AllowUserToAddRows = false;
            this.dataGridViewClientes.AllowUserToDeleteRows = false;
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Location = new System.Drawing.Point(19, 44);
            this.dataGridViewClientes.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.ReadOnly = true;
            this.dataGridViewClientes.RowHeadersWidth = 51;
            this.dataGridViewClientes.Size = new System.Drawing.Size(807, 400);
            this.dataGridViewClientes.TabIndex = 6;
            this.dataGridViewClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClientes_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seleccione un cliente";
            // 
            // frSeleccionCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 512);
            this.Controls.Add(this.buttonRegistrar);
            this.Controls.Add(this.buttonSelCliente);
            this.Controls.Add(this.dataGridViewClientes);
            this.Controls.Add(this.label1);
            this.Name = "frSeleccionCliente";
            this.Text = "Seleccion Cliente";
            this.Load += new System.EventHandler(this.frSeleccionCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.Button buttonSelCliente;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.Label label1;
    }
}