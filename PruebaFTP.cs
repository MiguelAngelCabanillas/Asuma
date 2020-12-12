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
        string seleccionado;

        public PruebaFTP()
        {
            InitializeComponent();
            ftp = new FTPClient("ftp://25.35.182.85:12975/", "Prueba", "");
        }

        private void PruebaFTP_Load(object sender, EventArgs e)
        {
            List<string> archivos = ftp.DirectoryListing();
            var result = archivos.Select(s => new { value = s }).ToList();
            dataGridView1.DataSource = result;
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
            ftp.Download(seleccionado, Properties.Settings.Default.RutaDescarga/*"C:\\Universidad\\Descargas\\"*/ + seleccionado);
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

            List<string> archivos = ftp.DirectoryListing();
            var result = archivos.Select(s => new { value = s }).ToList();
            dataGridView1.DataSource = result;
        }


    }
}
