namespace UI
{
    partial class frGenerarOrdenEntrega
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
            this.dataGridViewOrdenes = new System.Windows.Forms.DataGridView();
            this.buttonSelecOrden = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrdenes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOrdenes
            // 
            this.dataGridViewOrdenes.AllowUserToAddRows = false;
            this.dataGridViewOrdenes.AllowUserToDeleteRows = false;
            this.dataGridViewOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrdenes.Location = new System.Drawing.Point(52, 117);
            this.dataGridViewOrdenes.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewOrdenes.Name = "dataGridViewOrdenes";
            this.dataGridViewOrdenes.ReadOnly = true;
            this.dataGridViewOrdenes.RowHeadersWidth = 51;
            this.dataGridViewOrdenes.Size = new System.Drawing.Size(463, 409);
            this.dataGridViewOrdenes.TabIndex = 3;
            // 
            // buttonSelecOrden
            // 
            this.buttonSelecOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelecOrden.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelecOrden.Location = new System.Drawing.Point(205, 543);
            this.buttonSelecOrden.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSelecOrden.Name = "buttonSelecOrden";
            this.buttonSelecOrden.Size = new System.Drawing.Size(155, 44);
            this.buttonSelecOrden.TabIndex = 4;
            this.buttonSelecOrden.Text = "Seleccionar orden";
            this.buttonSelecOrden.UseVisualStyleBackColor = true;
            this.buttonSelecOrden.Click += new System.EventHandler(this.buttonSelecOrden_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(80)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(568, 90);
            this.label2.TabIndex = 12;
            this.label2.Text = "ORDENES A ENTREGAR";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frGenerarOrdenEntrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 611);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewOrdenes);
            this.Controls.Add(this.buttonSelecOrden);
            this.Name = "frGenerarOrdenEntrega";
            this.Text = "frGenerarOrdenEntrega";
            this.Load += new System.EventHandler(this.frGenerarOrdenEntrega_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrdenes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOrdenes;
        private System.Windows.Forms.Button buttonSelecOrden;
        private System.Windows.Forms.Label label2;
    }
}