namespace UI
{
    partial class frGenerarFactura
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
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dataGridViewOrdenes = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrdenes)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(80)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(0, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(614, 90);
            this.label2.TabIndex = 15;
            this.label2.Text = "ORDENES REALIZADAS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(192, 97);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(182, 21);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Listar pedidos con factura";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dataGridViewOrdenes
            // 
            this.dataGridViewOrdenes.AllowUserToAddRows = false;
            this.dataGridViewOrdenes.AllowUserToDeleteRows = false;
            this.dataGridViewOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrdenes.Location = new System.Drawing.Point(41, 126);
            this.dataGridViewOrdenes.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewOrdenes.Name = "dataGridViewOrdenes";
            this.dataGridViewOrdenes.ReadOnly = true;
            this.dataGridViewOrdenes.RowHeadersWidth = 51;
            this.dataGridViewOrdenes.Size = new System.Drawing.Size(520, 390);
            this.dataGridViewOrdenes.TabIndex = 12;
            this.dataGridViewOrdenes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrdenes_CellContentClick);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(221, 533);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 42);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frGenerarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 602);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dataGridViewOrdenes);
            this.Name = "frGenerarFactura";
            this.Text = "Generar Factura";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frGenerarFactura_FormClosed);
            this.Load += new System.EventHandler(this.frGenerarFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrdenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView dataGridViewOrdenes;
        private System.Windows.Forms.Button button1;
    }
}