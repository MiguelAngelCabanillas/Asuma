using MySqlConnector;
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

namespace Asuma
{
    public partial class InfoEvento : Form
    {
        private Event ev;
        private User usuario;
        public InfoEvento(Event e, User u)
        {
            this.ev = e;
            InitializeComponent();
            string imagen = "asuma2.ico";
            string path = Path.GetDirectoryName(Application.StartupPath);
            string pathBueno = path.Substring(0, path.Length - 3);
            string imagePath = pathBueno + "images\\" + imagen;
            Icon icon = new Icon(imagePath,100,100); 
            this.Icon = icon;

            imagen = e.Image;
            path = Path.GetDirectoryName(Application.StartupPath);
            pathBueno = path.Substring(0, path.Length - 3);
            imagePath = pathBueno + "images\\" + imagen;
            Image image = Image.FromFile(imagePath);
            pEvento.Image = image;


            lTitulo.Text = e.EventName;
            tDes.Text = e.EventDescription;
            lOrganizadores.Text = e.Organizer;
            lFecha.Text = e.Date;

            this.usuario = u;

            if(usuario == null)
            {
                bInscription.Visible = false;
            }
            else
            {
                bInscription.Visible = true;
            }
        }

        private void pASUMA_Paint(object sender, PaintEventArgs e)
        {
            this.pASUMA.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pASM_Paint(object sender, PaintEventArgs e)
        {
            this.pASM.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pUser_Paint(object sender, PaintEventArgs e)
        {
            this.pUser.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void menuFlowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {
            this.menuFlowLayoutPanel.Width = this.Width - 25;
            this.bNoticias.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bEventos.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bInfo.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bContacto.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
        }

        private void pEvento_Paint(object sender, PaintEventArgs e)
        {
            this.pEvento.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pEvento.BorderStyle = BorderStyle.FixedSingle;
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bInscription_Click(object sender, EventArgs e)
        {
            if (this.usuario == null)
            {
                MessageBox.Show("Debe iniciar sesión para inscribirse en un evento");
            }
            else
            {
                try
                {
                    BD bd = new BD();
                    MySqlDataReader reader = bd.Query("INSERT INTO inscription VALUES ('" + this.usuario.Username + "', " + ev.ID + ");");
                    reader.Read();
                    MessageBox.Show("Inscripción realizada con éxito.");
                    this.Close();
                }
                catch { MessageBox.Show("Error al formular la inscripción"); }
            }
        }
    }
}
