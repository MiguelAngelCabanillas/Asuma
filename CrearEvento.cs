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
    public partial class CrearEvento : Form
    {
        private User usuario;
        public CrearEvento(User usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            tDescription.AutoSize = false;
            tDescription.Height = 80;
            pImage.Visible = false;
        }

        private void menuFlowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {
            this.menuFlowLayoutPanel.Width = this.Width - 25;
            this.bNoticias.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bEventos.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bInfo.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bContacto.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(cIncludeImage.Checked == true)
            {
                pImage.Visible = true;
            }
            else
            {
                pImage.Visible = false;
            }
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bCreateEvent_Click(object sender, EventArgs e)
        {
            try
            {
                string eventName = tTitle.Text;
                string eventDescription = tDescription.Text;
                DateTime date = tDatePicker.Value;
                string eventDate = date.ToString();
                string eventOrganiser = tOrganizer.Text;
                string eventCreator = usuario.Username;
                string image = tImage.Text;
                Event evento = new Event(eventName, eventDate, image, eventDescription, eventOrganiser, eventCreator);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tTitle.Text == "") {
                MessageBox.Show("Introduzca antes un título al evento");
            }
            else { openFileDialog1.ShowDialog();}
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            FTPClient ftp = new FTPClient("ftp://25.35.182.85:12975/", "Prueba", "");

            char[] separadores = { '\\' };


            try
            {
                ftp.MakeFtpDirectory("eventos/" + tTitle.Text);
                MessageBox.Show("Se ha creado el directorio");
            }
            catch (Exception ex)
            {
            }


            ftp.UploadFile(openFileDialog1.FileName, "eventos/" + tTitle.Text + "/image.png"); //+ 
                // Get file extension
                //openFileDialog1.FileName.Split(separadores)[openFileDialog1.FileName.Split(separadores).Length - 1].Split('.')[openFileDialog1.FileName.Split(separadores)[openFileDialog1.FileName.Split(separadores).Length - 1].Split('.').Length-1]);
            pImage.Image = Image.FromFile(openFileDialog1.FileName);

            MessageBox.Show("Se ha subido correctamente el archivo " + openFileDialog1.FileName.Split(separadores)[openFileDialog1.FileName.Split(separadores).Length - 1]);

        }
    }
}
