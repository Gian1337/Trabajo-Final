using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;

namespace UI
{
    public partial class frLogs : Form
    {
        public frLogs()
        {
            InitializeComponent();
            oBLLBitacora = new BLLBitacora();
        }

        BLLBitacora oBLLBitacora;

        private void LoadLogs()
        {
            try
            {
                foreach (BEBitacora b in oBLLBitacora.ListarTodo().OrderByDescending(x => x.Fecha).ToList())
                {
                    if(b.UsuarioEmpleado != null)
                    {
                        listBoxLogs.Items.Add($"{b.Fecha} - {b.Evento} - Actor: {b.UsuarioEmpleado.NombreUsuario}");
                    }
                    else
                    {
                        listBoxLogs.Items.Add($"{b.Fecha} - {b.Evento} - Actor: Usuario eliminado");
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void listBoxLogs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frLogs_Load(object sender, EventArgs e)
        {
            LoadLogs();
        }
    }
}
