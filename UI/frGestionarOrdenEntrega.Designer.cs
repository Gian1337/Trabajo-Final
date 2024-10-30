namespace UI
{
    partial class frGestionarOrdenEntrega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frGestionarOrdenEntrega));
            this.buttonIngresarCod = new System.Windows.Forms.Button();
            this.textBoxCod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonIngresarCod
            // 
            this.buttonIngresarCod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonIngresarCod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIngresarCod.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIngresarCod.Location = new System.Drawing.Point(173, 136);
            this.buttonIngresarCod.Margin = new System.Windows.Forms.Padding(4);
            this.buttonIngresarCod.Name = "buttonIngresarCod";
            this.buttonIngresarCod.Size = new System.Drawing.Size(145, 36);
            this.buttonIngresarCod.TabIndex = 5;
            this.buttonIngresarCod.Text = "VERIFICAR";
            this.buttonIngresarCod.UseVisualStyleBackColor = true;
            this.buttonIngresarCod.Click += new System.EventHandler(this.buttonIngresarCod_Click);
            // 
            // textBoxCod
            // 
            this.textBoxCod.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCod.Location = new System.Drawing.Point(67, 70);
            this.textBoxCod.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCod.Multiline = true;
            this.textBoxCod.Name = "textBoxCod";
            this.textBoxCod.Size = new System.Drawing.Size(368, 38);
            this.textBoxCod.TabIndex = 4;
            this.textBoxCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(135, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingresar código de entrega:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.textBoxCod);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonIngresarCod);
            this.panel1.Location = new System.Drawing.Point(159, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 226);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(332, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 95);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frGestionarOrdenEntrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frGestionarOrdenEntrega";
            this.Text = "Gestion Orden de Entrega";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonIngresarCod;
        private System.Windows.Forms.TextBox textBoxCod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}