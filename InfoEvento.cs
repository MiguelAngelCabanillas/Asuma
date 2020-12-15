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
            Image image;

            if (FTPClient.ftpOn)
            {
                try
                {
                    FTPClient ftpClient = new FTPClient("ftp://25.35.182.85:12975/eventos/" + ev.ID + "/", "Prueba", "");
                    byte[] byteArrayIn = ftpClient.DownloadFileBytesInArray("image.png");
                    using (var ms = new MemoryStream(byteArrayIn))
                    {
                        image = Image.FromStream(ms);
                    }
                }
                catch (Exception ex)
                {
                    image = null;
                }


            }
            else { image = Image.FromFile(imagePath); }
            pEvento.Image = image;


            lTitulo.Text = e.EventName;
            tDes.Text = e.EventDescription;
            lOrganizadores.Text = e.Organizer;
            lFecha.Text = e.Date;

            this.usuario = u;

            if(usuario == null)
            {
                lUsername.Visible = false;
                pUser.Visible = false;
                linitSesion.Visible = true;
                lSignOut.Visible = false;
                bInscription.Visible = false;
            }
            else
            {
                pUser.Visible = true;
                lUsername.Text = "Bienvenido " + usuario.Username;
                linitSesion.Visible = false;
                lSignOut.Visible = true;
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
            actualizarBotones();
        }

        private void pEvento_Paint(object sender, PaintEventArgs e)
        {
            this.pEvento.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pEvento.BorderStyle = BorderStyle.FixedSingle;
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
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
                    reader.Close();
                    bd.closeBD();
                    MessageBox.Show("Inscripción realizada con éxito.");
                    this.Close();
                }
                catch { MessageBox.Show("Error al formular la inscripción"); }
            }
        }

        private void actualizarBotones()
        {
            this.menuFlowLayoutPanel.Width = this.Width - 40;
            this.bInicio.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bEventos.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bInfo.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bContacto.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
        }

        private void actualizarImagenes()
        {
            int tamaño = this.Width;
            this.pASUMA.Location = new Point((tamaño * 4) / 10, pASUMA.Location.Y);
            this.pASM.Location = new Point((tamaño * 7) / 10, pASM.Location.Y);
            //this.linitSesion.Location = new Point((tamaño * 3) / 10, linitSesion.Location.Y);
            //this.lSignOut.Location = new Point((tamaño * 3) / 10, lSignOut.Location.Y);
            this.pEvento.Location = new Point((tamaño * 2) / 10, pEvento.Location.Y);
        }

        private void actualizarLabels()
        {
            int anchura = this.Width;
            int altura = this.Height;
            linitSesion.Location = new Point(lUsername.Location.X, lUsername.Location.Y);
            this.lTitulo.Location = new Point((int)((anchura * 4.5) / 10), lTitulo.Location.Y);
            this.tDes.Location = new Point((int)((anchura * 4.5) / 10), tDes.Location.Y);
            this.lOrg.Location = new Point((anchura * 2) / 10, lOrg.Location.Y);
            this.lFec.Location = new Point((anchura * 2) / 10, lFec.Location.Y);
            this.lOrganizadores.Location = new Point(lOrg.Location.X + lOrg.Width + 20, lOrganizadores.Location.Y);
            this.lFecha.Location = new Point(lFec.Location.X + lFec.Width + 20, lFecha.Location.Y);
            this.bInscription.Location = new Point((anchura * 2) / 10, bInscription.Location.Y);
            this.bSalir.Location = new Point((int)(anchura * 8.8) / 10, (int)(altura * 8.5) / 10);
        }

        private void InfoEvento_Resize(object sender, EventArgs e)
        {
            actualizarBotones();
            actualizarImagenes();
            actualizarLabels();
        }

        public void actualizar()
        {
            if (usuario == null)
            {
                linitSesion.Visible = true;
                pUser.Visible = false;
                lUsername.Visible = false;
                lSignOut.Visible = false;
            }
            else
            {
                linitSesion.Visible = false;
                pUser.Visible = true;
                lUsername.Text = "Bienvenido, " + usuario.Username;
                lUsername.Visible = true;
                lSignOut.Visible = true;
            }
        }

        private void linitSesion_Click(object sender, EventArgs e)
        {
            Inicio init = new Inicio();
            this.Visible = false;
            init.ShowDialog();
            this.usuario = Inicio.usuario;
            actualizar();
            this.Visible = true;
        }

        public User Usuario
        {
            get { return usuario; }
        }

        private void bInicio_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Principal p = new Principal(usuario);
            p.Show();
            //misEventos.Close();
            this.Owner.Close();
            this.Close();

        }

        private void bEventos_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Eventos ev = new Eventos(usuario);
            ev.Show();
            this.Owner.Close();
            this.Close();
        }
    }
}
