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
    public partial class Contacto : Form
    {
        private User usuario;
        public Contacto(User usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            actualizar();
            cReason.SelectedItem = "Problema";
            tMessage.Text = "He aquí un mensaje de prueba para ver como funciona el correo electrónico y sus funcionalidades, y como conectarlo con gmail y similares. UN SALUDO Y FELIZ NAVIDAD";
        }

        private void tSend_Click(object sender, EventArgs e)
        {
            try
            {
                if(tName.Text.Trim(' ').Equals("") || cReason.SelectedItem == null || tMessage.Text.Trim(' ').Equals(""))
                {
                    MessageBox.Show("Debe rellenar todos los campos");
                }
                else
                {
                    Email email = new Email();
                    email.sendEmailToAdmin(tName.Text, usuario.Email, cReason.Text, tMessage.Text);
                    MessageBox.Show("Mensaje enviado correctamente");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }


        private void actualizarImagenes()
        {
            int tamaño = this.Width;
            this.pASUMA.Location = new Point((tamaño * 4) / 10, pASUMA.Location.Y);
            this.pASM.Location = new Point((tamaño * 7) / 10, pASM.Location.Y);
        }


        private void actualizarBotones()
        {
            linitSesion.Location = new Point(lUsername.Location.X, lUsername.Location.Y);
            this.menuFlowLayoutPanel.Width = this.Width - 25;
            this.bInicio.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bEventos.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bInfo.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bContacto.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
        }

        public void actualizar()
        {
            if (usuario == null)
            {
                linitSesion.Visible = true;
                pUser.Visible = false;
                lUsername.Visible = false;
                lSignOut.Visible = false;
                //pPerfil.Visible = false;
            }
            else
            {
                linitSesion.Visible = false;
                try
                {
                   // FTPClient ftp = new FTPClient("ftp://25.35.182.85:12975/usuarios/" + usuario.Id + "/", "Prueba", "");
                    //pUser.Image = ftp.DownloadPngAsImage("image.png", pUser.Size);
                }
                catch (Exception ex)
                {
                    pUser.Image = null;
                }
                pUser.Visible = true;
                lUsername.Text = "Bienvenido " + usuario.Username;
                lUsername.Visible = true;
                lSignOut.Visible = true;
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

        private void menuFlowLayoutPanel_Paint_1(object sender, PaintEventArgs e)
        {
            actualizarBotones();
        }



        private void Contacto_Resize(object sender, EventArgs e)
        {
            actualizarBotones();
            actualizarImagenes();
        }

    }
}
