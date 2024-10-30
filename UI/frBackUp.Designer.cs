namespace UI
{
    partial class frBackUp
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
            this.buttonCargarBackup = new System.Windows.Forms.Button();
            this.buttonCrearBackup = new System.Windows.Forms.Button();
            this.dataGridViewBackup = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBackup)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(80)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(954, 90);
            this.label2.TabIndex = 15;
            this.label2.Text = "BACKUPS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCargarBackup
            // 
            this.buttonCargarBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.buttonCargarBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCargarBackup.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCargarBackup.Location = new System.Drawing.Point(525, 439);
            this.buttonCargarBackup.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCargarBackup.Name = "buttonCargarBackup";
            this.buttonCargarBackup.Size = new System.Drawing.Size(204, 48);
            this.buttonCargarBackup.TabIndex = 14;
            this.buttonCargarBackup.Text = "Restaurar backup";
            this.buttonCargarBackup.UseVisualStyleBackColor = true;
            this.buttonCargarBackup.Click += new System.EventHandler(this.buttonCargarBackup_Click);
            // 
            // buttonCrearBackup
            // 
            this.buttonCrearBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonCrearBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCrearBackup.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrearBackup.Location = new System.Drawing.Point(737, 439);
            this.buttonCrearBackup.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCrearBackup.Name = "buttonCrearBackup";
            this.buttonCrearBackup.Size = new System.Drawing.Size(204, 48);
            this.buttonCrearBackup.TabIndex = 13;
            this.buttonCrearBackup.Text = "Crear backup";
            this.buttonCrearBackup.UseVisualStyleBackColor = true;
            this.buttonCrearBackup.Click += new System.EventHandler(this.buttonCrearBackup_Click);
            // 
            // dataGridViewBackup
            // 
            this.dataGridViewBackup.AllowUserToAddRows = false;
            this.dataGridViewBackup.AllowUserToDeleteRows = false;
            this.dataGridViewBackup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBackup.Location = new System.Drawing.Point(13, 117);
            this.dataGridViewBackup.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewBackup.Name = "dataGridViewBackup";
            this.dataGridViewBackup.ReadOnly = true;
            this.dataGridViewBackup.RowHeadersWidth = 51;
            this.dataGridViewBackup.Size = new System.Drawing.Size(928, 314);
            this.dataGridViewBackup.TabIndex = 12;
            this.dataGridViewBackup.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBackup_CellContentClick);
            // 
            // frBackUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 551);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCargarBackup);
            this.Controls.Add(this.buttonCrearBackup);
            this.Controls.Add(this.dataGridViewBackup);
            this.Name = "frBackUp";
            this.Text = "Módulo de Backup";
            this.Load += new System.EventHandler(this.frBackUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBackup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCargarBackup;
        private System.Windows.Forms.Button buttonCrearBackup;
        private System.Windows.Forms.DataGridView dataGridViewBackup;
    }
}