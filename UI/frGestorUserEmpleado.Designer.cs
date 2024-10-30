namespace UI
{
    partial class frGestorUserEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frGestorUserEmpleado));
            this.label7 = new System.Windows.Forms.Label();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxArea = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.textBoxPass2 = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxNomUser = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(80)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1078, 90);
            this.label7.TabIndex = 18;
            this.label7.Text = "GESTIONAR EMPLEADOS";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Enabled = false;
            this.buttonBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBorrar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBorrar.Location = new System.Drawing.Point(453, 588);
            this.buttonBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(128, 28);
            this.buttonBorrar.TabIndex = 17;
            this.buttonBorrar.Text = "Borrar";
            this.buttonBorrar.UseVisualStyleBackColor = true;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // dataGridViewUsuarios
            // 
            this.dataGridViewUsuarios.AllowUserToAddRows = false;
            this.dataGridViewUsuarios.AllowUserToDeleteRows = false;
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(453, 125);
            this.dataGridViewUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            this.dataGridViewUsuarios.ReadOnly = true;
            this.dataGridViewUsuarios.RowHeadersWidth = 51;
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(552, 455);
            this.dataGridViewUsuarios.TabIndex = 16;
            this.dataGridViewUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsuarios_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShow);
            this.groupBox1.Controls.Add(this.textBoxArea);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.buttonNuevo);
            this.groupBox1.Controls.Add(this.buttonModificar);
            this.groupBox1.Controls.Add(this.buttonRegistrar);
            this.groupBox1.Controls.Add(this.textBoxPass2);
            this.groupBox1.Controls.Add(this.textBoxPass);
            this.groupBox1.Controls.Add(this.textBoxNomUser);
            this.groupBox1.Controls.Add(this.textBoxApellido);
            this.groupBox1.Controls.Add(this.textBoxNombre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(36, 116);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(409, 464);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // textBoxArea
            // 
            this.textBoxArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxArea.Location = new System.Drawing.Point(12, 346);
            this.textBoxArea.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxArea.Name = "textBoxArea";
            this.textBoxArea.Size = new System.Drawing.Size(231, 26);
            this.textBoxArea.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 324);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Área";
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Enabled = false;
            this.buttonNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNuevo.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNuevo.Location = new System.Drawing.Point(75, 393);
            this.buttonNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(128, 28);
            this.buttonNuevo.TabIndex = 13;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.UseVisualStyleBackColor = true;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Enabled = false;
            this.buttonModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.buttonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificar.Location = new System.Drawing.Point(140, 428);
            this.buttonModificar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(128, 28);
            this.buttonModificar.TabIndex = 11;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistrar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrar.Location = new System.Drawing.Point(4, 428);
            this.buttonRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(128, 28);
            this.buttonRegistrar.TabIndex = 10;
            this.buttonRegistrar.Text = "Registrar";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // textBoxPass2
            // 
            this.textBoxPass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPass2.Location = new System.Drawing.Point(12, 289);
            this.textBoxPass2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPass2.Name = "textBoxPass2";
            this.textBoxPass2.Size = new System.Drawing.Size(231, 26);
            this.textBoxPass2.TabIndex = 9;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPass.Location = new System.Drawing.Point(12, 231);
            this.textBoxPass.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(231, 26);
            this.textBoxPass.TabIndex = 8;
            // 
            // textBoxNomUser
            // 
            this.textBoxNomUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNomUser.Location = new System.Drawing.Point(12, 172);
            this.textBoxNomUser.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNomUser.Name = "textBoxNomUser";
            this.textBoxNomUser.Size = new System.Drawing.Size(231, 26);
            this.textBoxNomUser.TabIndex = 7;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApellido.Location = new System.Drawing.Point(12, 112);
            this.textBoxApellido.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(231, 26);
            this.textBoxApellido.TabIndex = 6;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(12, 50);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(231, 26);
            this.textBoxNombre.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 267);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Repita la contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre de usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // btnShow
            // 
            this.btnShow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShow.BackgroundImage")));
            this.btnShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnShow.Location = new System.Drawing.Point(269, 223);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(53, 45);
            this.btnShow.TabIndex = 16;
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // frGestorUserEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 630);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.dataGridViewUsuarios);
            this.Controls.Add(this.groupBox1);
            this.Name = "frGestorUserEmpleado";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.frGestorUserEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxArea;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.TextBox textBoxPass2;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox textBoxNomUser;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShow;
    }
}