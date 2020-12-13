using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

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
            lUsername.Text = "Bienvenido " + usuario.Username;
            actualizarElementos();
        }

        private void pASUMA_Paint(object sender, PaintEventArgs e)
        {
            //this.pASUMA.Location = new Point((this.Width * 4) / 10, pASUMA.Location.Y);
            this.pASUMA.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pASM_Paint(object sender, PaintEventArgs e)
        {
            //this.pASM.Location = new Point((this.Width * 7) / 10, pASM.Location.Y);
            this.pASM.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pUser_Paint(object sender, PaintEventArgs e)
        {
            this.pUser.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void menuFlowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {
            this.menuFlowLayoutPanel.Location = new Point(15, menuFlowLayoutPanel.Location.Y);
            this.menuFlowLayoutPanel.Width = this.Width - 25;
            this.bNoticias.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bEventos.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bInfo.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bContacto.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
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
                MessageBox.Show("Evento creado con exito");
                this.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }

        private void CrearEvento_Resize(object sender, EventArgs e)
        {
            actualizarElementos();
        }

        private void actualizarElementos()
        {
            this.pUser.Location = new Point(72,16);
            this.lUsername.Location = new Point(pUser.Location.X+120, pUser.Location.Y+40);
            this.menuFlowLayoutPanel.Width = this.Width - 25;
            this.bNoticias.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bEventos.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bInfo.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bContacto.Width = this.menuFlowLayoutPanel.Width / 4 - 10;

            this.pASUMA.Location = new Point((this.Width * 4) / 10, pASUMA.Location.Y);
            this.pASM.Location = new Point((this.Width * 7) / 10, pASM.Location.Y);

            this.panel1.Location = new Point(this.bNoticias.Location.X+100,this.menuFlowLayoutPanel.Location.Y+80);
            this.panel1.Size = new Size(this.menuFlowLayoutPanel.Width,this.Height-this.menuFlowLayoutPanel.Location.Y-30);
        }
    }
}
