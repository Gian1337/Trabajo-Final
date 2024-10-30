using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frInputFecha : Form
    {
        public frInputFecha()
        {
            InitializeComponent();
            this.FormClosing += VerificarFecha;
        }

        public DateTime fecha = new DateTime();

        private void buttonContinuar_Click(object sender, EventArgs e)
        {
            try
            {
                fecha = dateTimePicker1.Value;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void VerificarFecha(object sender, FormClosingEventArgs e)
        {
            if (dateTimePicker1.Value < DateTime.Now)
            {
                MessageBox.Show("Por favor, ingrese una fecha", "Alerta fecha requerida");
                e.Cancel = true;
            }
        }
    }
}
