namespace UI
{
    partial class frVerOrdenes
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
            this.groupBoxDetalles = new System.Windows.Forms.GroupBox();
            this.labelClientePedido = new System.Windows.Forms.Label();
            this.labelFechaPedido = new System.Windows.Forms.Label();
            this.labelNumPedido = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewMateriales = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewOrdenes = new System.Windows.Forms.DataGridView();
            this.groupBoxDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMateriales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrdenes)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(80)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(2, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(998, 75);
            this.label6.TabIndex = 14;
            this.label6.Text = "ORDENES PROCESADAS";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxDetalles
            // 
            this.groupBoxDetalles.Controls.Add(this.labelClientePedido);
            this.groupBoxDetalles.Controls.Add(this.labelFechaPedido);
            this.groupBoxDetalles.Controls.Add(this.labelNumPedido);
            this.groupBoxDetalles.Controls.Add(this.label5);
            this.groupBoxDetalles.Controls.Add(this.dataGridViewMateriales);
            this.groupBoxDetalles.Controls.Add(this.label4);
            this.groupBoxDetalles.Controls.Add(this.label3);
            this.groupBoxDetalles.Controls.Add(this.label2);
            this.groupBoxDetalles.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDetalles.Location = new System.Drawing.Point(470, 173);
            this.groupBoxDetalles.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxDetalles.Name = "groupBoxDetalles";
            this.groupBoxDetalles.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxDetalles.Size = new System.Drawing.Size(481, 361);
            this.groupBoxDetalles.TabIndex = 13;
            this.groupBoxDetalles.TabStop = false;
            this.groupBoxDetalles.Text = "Detalles de la orden";
            this.groupBoxDetalles.Visible = false;
            // 
            // labelClientePedido
            // 
            this.labelClientePedido.AutoSize = true;
            this.labelClientePedido.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientePedido.Location = new System.Drawing.Point(95, 80);
            this.labelClientePedido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClientePedido.Name = "labelClientePedido";
            this.labelClientePedido.Size = new System.Drawing.Size(43, 17);
            this.labelClientePedido.TabIndex = 7;
            this.labelClientePedido.Text = "label8";
            // 
            // labelFechaPedido
            // 
            this.labelFechaPedido.AutoSize = true;
            this.labelFechaPedido.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaPedido.Location = new System.Drawing.Point(328, 37);
            this.labelFechaPedido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFechaPedido.Name = "labelFechaPedido";
            this.labelFechaPedido.Size = new System.Drawing.Size(43, 17);
            this.labelFechaPedido.TabIndex = 6;
            this.labelFechaPedido.Text = "label7";
            // 
            // labelNumPedido
            // 
            this.labelNumPedido.AutoSize = true;
            this.labelNumPedido.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumPedido.Location = new System.Drawing.Point(123, 36);
            this.labelNumPedido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumPedido.Name = "labelNumPedido";
            this.labelNumPedido.Size = new System.Drawing.Size(43, 17);
            this.labelNumPedido.TabIndex = 5;
            this.labelNumPedido.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Materiales";
            // 
            // dataGridViewMateriales
            // 
            this.dataGridViewMateriales.AllowUserToAddRows = false;
            this.dataGridViewMateriales.AllowUserToDeleteRows = false;
            this.dataGridViewMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMateriales.Location = new System.Drawing.Point(12, 142);
            this.dataGridViewMateriales.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewMateriales.Name = "dataGridViewMateriales";
            this.dataGridViewMateriales.ReadOnly = true;
            this.dataGridViewMateriales.RowHeadersWidth = 51;
            this.dataGridViewMateriales.Size = new System.Drawing.Size(461, 212);
            this.dataGridViewMateriales.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(253, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Orden N°:";
            // 
            // dataGridViewOrdenes
            // 
            this.dataGridViewOrdenes.AllowUserToAddRows = false;
            this.dataGridViewOrdenes.AllowUserToDeleteRows = false;
            this.dataGridViewOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrdenes.Location = new System.Drawing.Point(52, 173);
            this.dataGridViewOrdenes.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewOrdenes.Name = "dataGridViewOrdenes";
            this.dataGridViewOrdenes.ReadOnly = true;
            this.dataGridViewOrdenes.RowHeadersWidth = 51;
            this.dataGridViewOrdenes.Size = new System.Drawing.Size(409, 361);
            this.dataGridViewOrdenes.TabIndex = 12;
            this.dataGridViewOrdenes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrdenes_CellContentClick);
            // 
            // frVerOrdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 592);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBoxDetalles);
            this.Controls.Add(this.dataGridViewOrdenes);
            this.Name = "frVerOrdenes";
            this.Text = "frVerOrdenes";
            this.Load += new System.EventHandler(this.frVerOrdenes_Load);
            this.groupBoxDetalles.ResumeLayout(false);
            this.groupBoxDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMateriales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrdenes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBoxDetalles;
        private System.Windows.Forms.Label labelClientePedido;
        private System.Windows.Forms.Label labelFechaPedido;
        private System.Windows.Forms.Label labelNumPedido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewMateriales;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewOrdenes;
    }
}