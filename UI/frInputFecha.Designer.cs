namespace UI
{
    partial class frInputFecha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frInputFecha));
            this.buttonContinuar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelTexto = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonContinuar
            // 
            this.buttonContinuar.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.buttonContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContinuar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContinuar.Location = new System.Drawing.Point(154, 136);
            this.buttonContinuar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonContinuar.Name = "buttonContinuar";
            this.buttonContinuar.Size = new System.Drawing.Size(100, 28);
            this.buttonContinuar.TabIndex = 5;
            this.buttonContinuar.Text = "Continuar";
            this.buttonContinuar.UseVisualStyleBackColor = true;
            this.buttonContinuar.Click += new System.EventHandler(this.buttonContinuar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(17, 96);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(373, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // labelTexto
            // 
            this.labelTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTexto.Location = new System.Drawing.Point(26, 21);
            this.labelTexto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTexto.Name = "labelTexto";
            this.labelTexto.Size = new System.Drawing.Size(364, 58);
            this.labelTexto.TabIndex = 3;
            this.labelTexto.Text = "Texto";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.buttonContinuar);
            this.panel1.Controls.Add(this.labelTexto);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Location = new System.Drawing.Point(203, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 188);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(341, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frInputFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frInputFecha";
            this.Text = "Input Fecha";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonContinuar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.Label labelTexto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}