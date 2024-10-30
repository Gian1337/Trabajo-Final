namespace UI
{
    partial class frGestorPermisos
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewRoles = new System.Windows.Forms.DataGridView();
            this.btnAgregarRol = new System.Windows.Forms.Button();
            this.txtAgregarRol = new System.Windows.Forms.TextBox();
            this.btnEliminarRol = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.btnAgregarPermiso = new System.Windows.Forms.Button();
            this.btnEliminarPermiso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(80)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1540, 78);
            this.label3.TabIndex = 17;
            this.label3.Text = "PERMISOS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(533, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 31);
            this.label2.TabIndex = 16;
            this.label2.Text = "Permisos";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(419, 115);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(329, 331);
            this.treeView1.TabIndex = 15;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Usuarios";
            // 
            // dataGridViewUsuarios
            // 
            this.dataGridViewUsuarios.AllowUserToAddRows = false;
            this.dataGridViewUsuarios.AllowUserToDeleteRows = false;
            this.dataGridViewUsuarios.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(50, 115);
            this.dataGridViewUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            this.dataGridViewUsuarios.ReadOnly = true;
            this.dataGridViewUsuarios.RowHeadersWidth = 51;
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(331, 332);
            this.dataGridViewUsuarios.TabIndex = 14;
            this.dataGridViewUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsuarios_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(938, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 31);
            this.label4.TabIndex = 18;
            this.label4.Text = "Roles";
            // 
            // dataGridViewRoles
            // 
            this.dataGridViewRoles.AllowUserToAddRows = false;
            this.dataGridViewRoles.AllowUserToDeleteRows = false;
            this.dataGridViewRoles.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoles.Location = new System.Drawing.Point(810, 115);
            this.dataGridViewRoles.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewRoles.Name = "dataGridViewRoles";
            this.dataGridViewRoles.ReadOnly = true;
            this.dataGridViewRoles.RowHeadersWidth = 51;
            this.dataGridViewRoles.Size = new System.Drawing.Size(331, 332);
            this.dataGridViewRoles.TabIndex = 19;
            // 
            // btnAgregarRol
            // 
            this.btnAgregarRol.Location = new System.Drawing.Point(810, 465);
            this.btnAgregarRol.Name = "btnAgregarRol";
            this.btnAgregarRol.Size = new System.Drawing.Size(116, 33);
            this.btnAgregarRol.TabIndex = 20;
            this.btnAgregarRol.Text = "Agregar rol";
            this.btnAgregarRol.UseVisualStyleBackColor = true;
            this.btnAgregarRol.Click += new System.EventHandler(this.btnAgregarRol_Click);
            // 
            // txtAgregarRol
            // 
            this.txtAgregarRol.Location = new System.Drawing.Point(933, 475);
            this.txtAgregarRol.Name = "txtAgregarRol";
            this.txtAgregarRol.Size = new System.Drawing.Size(128, 22);
            this.txtAgregarRol.TabIndex = 21;
            // 
            // btnEliminarRol
            // 
            this.btnEliminarRol.Location = new System.Drawing.Point(810, 504);
            this.btnEliminarRol.Name = "btnEliminarRol";
            this.btnEliminarRol.Size = new System.Drawing.Size(116, 33);
            this.btnEliminarRol.TabIndex = 22;
            this.btnEliminarRol.Text = "Eliminar rol";
            this.btnEliminarRol.UseVisualStyleBackColor = true;
            this.btnEliminarRol.Click += new System.EventHandler(this.btnEliminarRol_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1245, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 31);
            this.label5.TabIndex = 24;
            this.label5.Text = "Permisos individuales";
            // 
            // treeView2
            // 
            this.treeView2.Location = new System.Drawing.Point(1198, 116);
            this.treeView2.Margin = new System.Windows.Forms.Padding(4);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(329, 331);
            this.treeView2.TabIndex = 23;
            this.treeView2.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView2_AfterSelect);
            // 
            // btnAgregarPermiso
            // 
            this.btnAgregarPermiso.Location = new System.Drawing.Point(1198, 470);
            this.btnAgregarPermiso.Name = "btnAgregarPermiso";
            this.btnAgregarPermiso.Size = new System.Drawing.Size(132, 34);
            this.btnAgregarPermiso.TabIndex = 25;
            this.btnAgregarPermiso.Text = "Agregar permiso ";
            this.btnAgregarPermiso.UseVisualStyleBackColor = true;
            this.btnAgregarPermiso.Click += new System.EventHandler(this.btnAgregarPermiso_Click);
            // 
            // btnEliminarPermiso
            // 
            this.btnEliminarPermiso.Location = new System.Drawing.Point(1198, 510);
            this.btnEliminarPermiso.Name = "btnEliminarPermiso";
            this.btnEliminarPermiso.Size = new System.Drawing.Size(132, 34);
            this.btnEliminarPermiso.TabIndex = 26;
            this.btnEliminarPermiso.Text = "Eliminar permiso";
            this.btnEliminarPermiso.UseVisualStyleBackColor = true;
            this.btnEliminarPermiso.Click += new System.EventHandler(this.btnEliminarPermiso_Click);
            // 
            // frGestorPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 639);
            this.Controls.Add(this.btnEliminarPermiso);
            this.Controls.Add(this.btnAgregarPermiso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.btnEliminarRol);
            this.Controls.Add(this.txtAgregarRol);
            this.Controls.Add(this.btnAgregarRol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewRoles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewUsuarios);
            this.Name = "frGestorPermisos";
            this.Text = "Módulo de Permisos";
            this.Load += new System.EventHandler(this.frGestorPermisos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewRoles;
        private System.Windows.Forms.Button btnAgregarRol;
        private System.Windows.Forms.TextBox txtAgregarRol;
        private System.Windows.Forms.Button btnEliminarRol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.Button btnAgregarPermiso;
        private System.Windows.Forms.Button btnEliminarPermiso;
    }
}