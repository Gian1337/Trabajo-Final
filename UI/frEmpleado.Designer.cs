namespace UI
{
    partial class frEmpleado
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
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.listBoxOrdenesEmp = new System.Windows.Forms.ListBox();
            this.labelCantTrabajos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAsignar = new System.Windows.Forms.Button();
            this.dataGridViewEmpleados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(80)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1266, 90);
            this.label3.TabIndex = 16;
            this.label3.Text = "EMPLEADOS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.listBoxOrdenesEmp);
            this.groupBoxInfo.Controls.Add(this.labelCantTrabajos);
            this.groupBoxInfo.Controls.Add(this.label2);
            this.groupBoxInfo.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfo.Location = new System.Drawing.Point(531, 215);
            this.groupBoxInfo.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxInfo.Size = new System.Drawing.Size(636, 350);
            this.groupBoxInfo.TabIndex = 15;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Información del empleado";
            this.groupBoxInfo.Visible = false;
            // 
            // listBoxOrdenesEmp
            // 
            this.listBoxOrdenesEmp.FormattingEnabled = true;
            this.listBoxOrdenesEmp.ItemHeight = 17;
            this.listBoxOrdenesEmp.Location = new System.Drawing.Point(12, 70);
            this.listBoxOrdenesEmp.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxOrdenesEmp.Name = "listBoxOrdenesEmp";
            this.listBoxOrdenesEmp.Size = new System.Drawing.Size(615, 242);
            this.listBoxOrdenesEmp.TabIndex = 2;
            // 
            // labelCantTrabajos
            // 
            this.labelCantTrabajos.AutoSize = true;
            this.labelCantTrabajos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantTrabajos.Location = new System.Drawing.Point(199, 34);
            this.labelCantTrabajos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCantTrabajos.Name = "labelCantTrabajos";
            this.labelCantTrabajos.Size = new System.Drawing.Size(17, 20);
            this.labelCantTrabajos.TabIndex = 1;
            this.labelCantTrabajos.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Trabajos asignados:";
            // 
            // buttonAsignar
            // 
            this.buttonAsignar.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.buttonAsignar.Enabled = false;
            this.buttonAsignar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonAsignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAsignar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAsignar.Location = new System.Drawing.Point(767, 572);
            this.buttonAsignar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAsignar.Name = "buttonAsignar";
            this.buttonAsignar.Size = new System.Drawing.Size(207, 32);
            this.buttonAsignar.TabIndex = 14;
            this.buttonAsignar.Text = "Asignar orden";
            this.buttonAsignar.UseVisualStyleBackColor = true;
            this.buttonAsignar.Click += new System.EventHandler(this.buttonAsignar_Click);
            // 
            // dataGridViewEmpleados
            // 
            this.dataGridViewEmpleados.AllowUserToAddRows = false;
            this.dataGridViewEmpleados.AllowUserToDeleteRows = false;
            this.dataGridViewEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpleados.Location = new System.Drawing.Point(103, 215);
            this.dataGridViewEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewEmpleados.Name = "dataGridViewEmpleados";
            this.dataGridViewEmpleados.ReadOnly = true;
            this.dataGridViewEmpleados.RowHeadersWidth = 51;
            this.dataGridViewEmpleados.Size = new System.Drawing.Size(408, 389);
            this.dataGridViewEmpleados.TabIndex = 13;
            this.dataGridViewEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmpleados_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 193);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Empleados del sector de producción disponibles";
            // 
            // frEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 701);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.buttonAsignar);
            this.Controls.Add(this.dataGridViewEmpleados);
            this.Controls.Add(this.label1);
            this.Name = "frEmpleado";
            this.Text = "frEmpleado";
            this.Load += new System.EventHandler(this.frEmpleado_Load);
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.ListBox listBoxOrdenesEmp;
        private System.Windows.Forms.Label labelCantTrabajos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAsignar;
        private System.Windows.Forms.DataGridView dataGridViewEmpleados;
        private System.Windows.Forms.Label label1;
    }
}