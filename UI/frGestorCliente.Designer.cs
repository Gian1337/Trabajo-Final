namespace UI
{
    partial class frGestorCliente
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
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxDatosC = new System.Windows.Forms.GroupBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxRS = new System.Windows.Forms.TextBox();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxDirE = new System.Windows.Forms.TextBox();
            this.textBoxTdni = new System.Windows.Forms.TextBox();
            this.textBoxDir = new System.Windows.Forms.TextBox();
            this.textBoxNdni = new System.Windows.Forms.TextBox();
            this.textBoxApel = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.groupBoxDatosC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.buttonNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNuevo.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNuevo.Location = new System.Drawing.Point(484, 712);
            this.buttonNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(141, 33);
            this.buttonNuevo.TabIndex = 28;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.UseVisualStyleBackColor = true;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuardar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.Location = new System.Drawing.Point(174, 712);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(141, 33);
            this.buttonGuardar.TabIndex = 27;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(80)))));
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(811, 90);
            this.label11.TabIndex = 30;
            this.label11.Text = " CLIENTES";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Enabled = false;
            this.buttonBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBorrar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBorrar.Location = new System.Drawing.Point(633, 711);
            this.buttonBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(141, 34);
            this.buttonBorrar.TabIndex = 29;
            this.buttonBorrar.Text = "Borrar";
            this.buttonBorrar.UseVisualStyleBackColor = true;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 31);
            this.label1.TabIndex = 26;
            this.label1.Text = "Clientes registrados";
            // 
            // groupBoxDatosC
            // 
            this.groupBoxDatosC.Controls.Add(this.textBoxNom);
            this.groupBoxDatosC.Controls.Add(this.textBoxRS);
            this.groupBoxDatosC.Controls.Add(this.textBoxTel);
            this.groupBoxDatosC.Controls.Add(this.textBoxEmail);
            this.groupBoxDatosC.Controls.Add(this.textBoxDirE);
            this.groupBoxDatosC.Controls.Add(this.textBoxTdni);
            this.groupBoxDatosC.Controls.Add(this.textBoxDir);
            this.groupBoxDatosC.Controls.Add(this.textBoxNdni);
            this.groupBoxDatosC.Controls.Add(this.textBoxApel);
            this.groupBoxDatosC.Controls.Add(this.label10);
            this.groupBoxDatosC.Controls.Add(this.label9);
            this.groupBoxDatosC.Controls.Add(this.label8);
            this.groupBoxDatosC.Controls.Add(this.label7);
            this.groupBoxDatosC.Controls.Add(this.label6);
            this.groupBoxDatosC.Controls.Add(this.label5);
            this.groupBoxDatosC.Controls.Add(this.label4);
            this.groupBoxDatosC.Controls.Add(this.label3);
            this.groupBoxDatosC.Controls.Add(this.label2);
            this.groupBoxDatosC.Location = new System.Drawing.Point(13, 171);
            this.groupBoxDatosC.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxDatosC.Name = "groupBoxDatosC";
            this.groupBoxDatosC.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxDatosC.Size = new System.Drawing.Size(302, 519);
            this.groupBoxDatosC.TabIndex = 25;
            this.groupBoxDatosC.TabStop = false;
            this.groupBoxDatosC.Text = "Datos del cliente:";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNom.Location = new System.Drawing.Point(12, 54);
            this.textBoxNom.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(228, 25);
            this.textBoxNom.TabIndex = 19;
            // 
            // textBoxRS
            // 
            this.textBoxRS.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRS.Location = new System.Drawing.Point(12, 390);
            this.textBoxRS.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRS.Name = "textBoxRS";
            this.textBoxRS.Size = new System.Drawing.Size(228, 25);
            this.textBoxRS.TabIndex = 17;
            // 
            // textBoxTel
            // 
            this.textBoxTel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTel.Location = new System.Drawing.Point(12, 342);
            this.textBoxTel.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(228, 25);
            this.textBoxTel.TabIndex = 16;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(12, 294);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(228, 25);
            this.textBoxEmail.TabIndex = 15;
            // 
            // textBoxDirE
            // 
            this.textBoxDirE.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDirE.Location = new System.Drawing.Point(12, 246);
            this.textBoxDirE.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDirE.Name = "textBoxDirE";
            this.textBoxDirE.Size = new System.Drawing.Size(228, 25);
            this.textBoxDirE.TabIndex = 14;
            // 
            // textBoxTdni
            // 
            this.textBoxTdni.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTdni.Location = new System.Drawing.Point(12, 440);
            this.textBoxTdni.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTdni.Name = "textBoxTdni";
            this.textBoxTdni.Size = new System.Drawing.Size(228, 25);
            this.textBoxTdni.TabIndex = 13;
            // 
            // textBoxDir
            // 
            this.textBoxDir.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDir.Location = new System.Drawing.Point(12, 198);
            this.textBoxDir.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDir.Name = "textBoxDir";
            this.textBoxDir.Size = new System.Drawing.Size(228, 25);
            this.textBoxDir.TabIndex = 12;
            // 
            // textBoxNdni
            // 
            this.textBoxNdni.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNdni.Location = new System.Drawing.Point(12, 150);
            this.textBoxNdni.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNdni.Name = "textBoxNdni";
            this.textBoxNdni.Size = new System.Drawing.Size(228, 25);
            this.textBoxNdni.TabIndex = 11;
            // 
            // textBoxApel
            // 
            this.textBoxApel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApel.Location = new System.Drawing.Point(12, 102);
            this.textBoxApel.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxApel.Name = "textBoxApel";
            this.textBoxApel.Size = new System.Drawing.Size(228, 25);
            this.textBoxApel.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 370);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Razon social";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 322);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Telefono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 274);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 226);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Direccion de entrega";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 178);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 419);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tipo de documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Numero de documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // buttonModificar
            // 
            this.buttonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificar.Location = new System.Drawing.Point(20, 711);
            this.buttonModificar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(141, 34);
            this.buttonModificar.TabIndex = 20;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.AllowUserToAddRows = false;
            this.dataGridViewClientes.AllowUserToDeleteRows = false;
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Location = new System.Drawing.Point(323, 177);
            this.dataGridViewClientes.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.ReadOnly = true;
            this.dataGridViewClientes.RowHeadersWidth = 51;
            this.dataGridViewClientes.Size = new System.Drawing.Size(451, 513);
            this.dataGridViewClientes.TabIndex = 24;
            this.dataGridViewClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClientes_CellContentClick);
            // 
            // frGestorCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 831);
            this.Controls.Add(this.buttonNuevo);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxDatosC);
            this.Controls.Add(this.dataGridViewClientes);
            this.Name = "frGestorCliente";
            this.Text = "Área Clientes";
            this.Load += new System.EventHandler(this.frGestorCliente_Load);
            this.groupBoxDatosC.ResumeLayout(false);
            this.groupBoxDatosC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxDatosC;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxRS;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxDirE;
        private System.Windows.Forms.TextBox textBoxTdni;
        private System.Windows.Forms.TextBox textBoxDir;
        private System.Windows.Forms.TextBox textBoxNdni;
        private System.Windows.Forms.TextBox textBoxApel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
    }
}