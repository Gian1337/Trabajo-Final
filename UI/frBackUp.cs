using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frBackUp : Form
    {
        public frBackUp()
        {
            InitializeComponent();
            this.dataGridViewBackup.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBackup.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            oBLLBitacora = new BLLBitacora();
            oBEBitacora = new BEBitacora();
        }

        BLLBitacora oBLLBitacora;
        BEBitacora oBEBitacora;
        public BEEmpleado UsuarioActual;

        private void frBackUp_Load(object sender, EventArgs e)
        {
            LoadDGVBackUp();
        }

        private void LoadDGVBackUp()
        {
            try
            {
                // Carga de la bitacora - Backups
                this.dataGridViewBackup.DataSource = null;
                this.dataGridViewBackup.DataSource = oBLLBitacora.ListarTodo().FindAll(x => x.Evento.Contains("BACKUP DEL SISTEMA") == true);
                dataGridViewBackup.CellFormatting += DataGridView_CellFormatting;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void DataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // metodo para que las columnas correspondientes al usuario muestren el nombre de usuario
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewBackup.Columns["UsuarioEmpleado"].Index)
            {
                BEBitacora bitacora = dataGridViewBackup.Rows[e.RowIndex].DataBoundItem as BEBitacora;
                if (bitacora != null && bitacora.UsuarioEmpleado != null)
                {
                    e.Value = bitacora.UsuarioEmpleado.NombreUsuario;
                    e.FormattingApplied = true;
                }
            }
        }

        private void buttonCrearBackup_Click(object sender, EventArgs e)
        {
            DoBackUp();
        }

        private void DoBackUp()
        {
            try
            {
                // Se registran las rutas de destino y completan los datos para realizar el backup
                string carpetaData = @".\DATA";
                string carpetaBackup = @".\Backup";
                string fecha = "Backup-" + DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss");
                string carpetaBackup2 = Path.Combine(carpetaBackup, fecha);
                oBLLBitacora.Log(UsuarioActual, "BACKUP DEL SISTEMA");

                if (!Directory.Exists(carpetaBackup))
                {
                    // Si no existe la carpeta backup, se crea
                    Directory.CreateDirectory(carpetaBackup);
                }
                if (!Directory.Exists(carpetaBackup2))
                {
                    // Dentro de la carpeta principal se crea la carpeta de un backup en concreto
                    Directory.CreateDirectory(carpetaBackup2);
                }

                string[] archivosXML = Directory.GetFiles(carpetaData, "*.xml");

                foreach (string archivo in archivosXML)
                {
                    string nombreArchivo = Path.GetFileName(archivo);

                    //Lista de nombres exactos de archivos a excluir del backup
                    string[] archivosExcluidos = { "Bitacora", "Estado", "Permiso", "Permiso_Permiso" };

                    //Verificar si el nombre del archivo no está en la lista de nombres excluidos
                    if (!archivosExcluidos.Any(nombre => nombreArchivo.Equals(nombre, StringComparison.OrdinalIgnoreCase)))
                    {
                        string archivoDestino = Path.Combine(carpetaBackup2, nombreArchivo);
                        File.Copy(archivo, archivoDestino, true);
                    }
                }
                MessageBox.Show("Backup realizado!", "Backup",MessageBoxButtons.OK,MessageBoxIcon.Information);
                LoadDGVBackUp();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void dataGridViewBackup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                oBEBitacora = (BEBitacora)this.dataGridViewBackup.CurrentRow.DataBoundItem;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void buttonCargarBackup_Click(object sender, EventArgs e)
        {
            try
            {
                string carpetaRaiz = Directory.GetCurrentDirectory();
                string carpetaData = Path.Combine(Directory.GetCurrentDirectory(), "DATA");
                string carpetaBackup = Path.Combine(Directory.GetCurrentDirectory(), "Backup");

                // pasamos la fecha del objeto bitacora al formato guardado en las carpetas backup
                string directorio = $"Backup-{oBEBitacora.Fecha.ToString("dd-MM-yyyy-HH-mm-ss")}";
                
                MessageBox.Show(directorio);
                string carpetaBackupArchivos = Path.Combine(carpetaBackup, directorio);
                DirectoryInfo directorioInfo = new DirectoryInfo(carpetaBackupArchivos);
                if (directorioInfo.Exists)
                {
                    string[] archivosXML = Directory.GetFiles(carpetaBackupArchivos, "*.xml");

                    foreach (string archivo in archivosXML)
                    {
                        //Si el backup existe, se copian los XML (sacando los que tienen 'Bitacora') desde la carpeta backup a la de data
                        if (!archivo.Contains("Bitacora"))
                        {
                            string nombreArchivo = Path.GetFileName(archivo);
                            string archivoDestino = Path.Combine(carpetaData, nombreArchivo);
                            File.Copy(archivo, archivoDestino, true);
                        }
                    }
                    MessageBox.Show("Backup realizado con exito!", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    oBLLBitacora.Log(UsuarioActual, $"Restore Backup {oBEBitacora.Fecha}");
                }
                else
                {
                    MessageBox.Show($"El directorio de BACKUP {carpetaBackupArchivos} no existe", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

                throw ex; 
            }
        }
    }
}
