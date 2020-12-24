using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asuma
{
    public partial class PruebaFTP : Form
    {
        FTPClient ftp;
        User usuario;
        Event evento;
        string carpeta;
        string seleccionado;
        List<String> subdirectorios;

        public PruebaFTP(User usuario, Event evento, string carpeta)
        {
            InitializeComponent();
            this.evento = evento;
            this.carpeta = carpeta;
            this.usuario = usuario;
            if (evento.EventCreator == usuario.Username)
            {
                bEliminar.Visible = true;
                bSubir.Visible = true;
            }
            else
            {
                bEliminar.Visible = false;
                bSubir.Visible = false;
            }
            ftp = new FTPClient("ftp://25.35.182.85:12975/eventos/" + evento.ID + "/files/" + carpeta + "/", "Prueba", "");
            this.subdirectorios = ftp.FTPSubdirectories("");

        }

        private void PruebaFTP_Load(object sender, EventArgs e)
        {
            //Selector de archivos
             List<string> archivos = ftp.DirectoryListing();
             foreach (string directorio in subdirectorios)
             {
                 archivos.Remove(directorio);
             }

            var result = archivos.Select(s => new { Nombre = s , Tamaño = Commons.LongToBytesMagnitude(ftp.GetFileDownloadSize(s)) }).ToList();
            dataGridView1.DataSource = result;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MostrarSeleccionado();
            
            //Selector de carpetas
             /* var result = subdirectorios.Select(s => new { Carpeta = s }).ToList();
            dataGridView1.DataSource = result;*/
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    string u = (string)dataGridView1.SelectedRows[0].Cells[0].Value;

                    seleccionado = u;
                    MostrarSeleccionado();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message);
                }
            }
        }
        private void MostrarSeleccionado()
        {
            if (seleccionado == null)
            {
                bArchivo.Text = "";
              
                dataGridView1.ClearSelection();
                dataGridView1.Update();
                dataGridView1.Refresh();

            }
            else
            {
                bArchivo.Text = seleccionado;
                
                dataGridView1.Update();
                dataGridView1.Refresh();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (seleccionado != null)
            {
                ftp.Download(seleccionado, Properties.Settings.Default.RutaDescarga/*"C:\\Universidad\\Descargas\\"*/ + seleccionado);
                MessageBox.Show("El programa ha terminado de descargar " + seleccionado + " correctamente.");
                MostrarSeleccionado();
            }
            else
            {
                MessageBox.Show("Seleccione antes un archivo que descargar.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            char[] separadores = { '\\' };
            ftp.UploadFile(openFileDialog1.FileName, "/" + openFileDialog1.FileName.Split(separadores)[openFileDialog1.FileName.Split(separadores).Length-1]);
            dataGridView1.DataSource = ftp.DirectoryListing();

            MessageBox.Show("Se ha subido correctamente el archivo " + openFileDialog1.FileName.Split(separadores)[openFileDialog1.FileName.Split(separadores).Length - 1]);

            List<string> archivos = ftp.DirectoryListing();
            var result = archivos.Select(s => new { Nombre = s, Tamaño = Commons.LongToBytesMagnitude(ftp.GetFileDownloadSize(s)) }).ToList();
            dataGridView1.DataSource = result;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (seleccionado != null)
            {
                ftp.DeleteFileFromServer(seleccionado);
                MessageBox.Show("El programa ha eliminado " + seleccionado);
                List<string> archivos = ftp.DirectoryListing();
                foreach (string directorio in subdirectorios)
                {
                    archivos.Remove(directorio);
                }

                var result = archivos.Select(s => new { Nombre = s, Tamaño = Commons.LongToBytesMagnitude(ftp.GetFileDownloadSize(s)) }).ToList();
                dataGridView1.DataSource = result;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                seleccionado = null;
                MostrarSeleccionado();
            }
            else
            {
                MessageBox.Show("Seleccione antes un archivo que descargar.");
            }
        }


    }
}
