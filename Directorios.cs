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
    public partial class Directorios : Form
    {
        FTPClient ftp;
        Event evento;
        User usuario;
        string seleccionado;
        List<String> subdirectorios;

        public Directorios(Event evento, User usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.evento = evento;
            if (evento.EventCreator == usuario.Username)
            {
                bCrear.Visible = true;
                tCrear.Visible = true;
                bBorrar.Visible = true;
            }
            else
            {
                bCrear.Visible = false;
                tCrear.Visible = false;
                bBorrar.Visible = false;
            }
            ftp = new FTPClient("ftp://25.35.182.85:12975/eventos/" + evento.ID + "/files/", "Prueba", "");
            this.subdirectorios = ftp.FTPSubdirectories("");
        }

        private void PruebaFTP_Load(object sender, EventArgs e)
        {
            //Selector de archivos
             /*List<string> archivos = ftp.DirectoryListing();
            var result = archivos.Select(s => new { Nombre = s , Tamaño = Commons.LongToBytesMagnitude(ftp.GetFileDownloadSize(s)) }).ToList();
            dataGridView1.DataSource = result;*/
            
            //Selector de carpetas
            var result = subdirectorios.Select(s => new { Carpeta = s.Replace('_', ' ')}).ToList();
            dataGridView1.DataSource = result;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MostrarSeleccionado();
           
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
                tCrear.Text = "";
              
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
                PruebaFTP archivos = new PruebaFTP(this.usuario, this.evento, seleccionado.Replace(' ', '_'));
                archivos.Owner = this;
                this.Visible = false;
                archivos.ShowDialog();
                this.Visible = true;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una carpeta");
            }

        }



        private void bVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bCrear_Click(object sender, EventArgs e)
        {
            if (tCrear.Text != "")
            {
                FTPClient ftp = new FTPClient("ftp://25.35.182.85:12975/eventos/" + evento.ID + "/files/", "Prueba", "");
                try
                {
                    ftp.MakeFtpDirectory(tCrear.Text.Replace(' ', '_'));
                    subdirectorios = ftp.FTPSubdirectories("");
                    var result = subdirectorios.Select(s => new { Carpeta = s.Replace('_', ' ') }).ToList();
                    dataGridView1.DataSource = result;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    MostrarSeleccionado();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("La carpeta ya se encuentra creada");
                }
            }
            else
            {
                MessageBox.Show("No se puede crear una carpeta sin nombre");
            }
        }

        private void bBorrar_Click(object sender, EventArgs e)
        {
            if (bArchivo.Text != "")
            {
                FTPClient ftp = new FTPClient("ftp://25.35.182.85:12975/eventos/" + evento.ID + "/files/", "Prueba", "");
                try
                {
                    ftp.DeleteFTPDirectory(bArchivo.Text.Replace(' ', '_'));
                    subdirectorios = ftp.FTPSubdirectories("");
                    var result = subdirectorios.Select(s => new { Carpeta = s.Replace('_', ' ') }).ToList();
                    dataGridView1.DataSource = result;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    seleccionado = null;

                    MostrarSeleccionado();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("La carpeta ya se encuentra borrada");
                }
            }
            else
            {
                MessageBox.Show("Selecciona una carpeta para borrar");
            }
        }


    }
}
