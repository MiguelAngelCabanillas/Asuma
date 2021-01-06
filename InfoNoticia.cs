using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Asuma
{
    public partial class InfoNoticia : Form
    {
        private bool mouseInPanel = false;
        private Timer hideTimer;

        private News noticia;
        private User usuario;
        public bool isClosed = false;

        #region Creacion del form
        public InfoNoticia(News n, User u)
        {
            hideTimer = new Timer { Interval = 100 };
            hideTimer.Tick += hidePanel;
            this.noticia = n;
            this.usuario = u;

            InitializeComponent();

            actualizar();
        }
        #endregion

        #region GUIs
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

        private void actualizar()
        {
            if (usuario == null)
            {
                lUsername.Visible = false;
                pUser.Visible = false;
                linitSesion.Visible = true;
                lSignOut.Visible = false;
                bEditarNoticia.Visible = false;
            }
            else
            {
                try
                {
                    FTPClient ftp = new FTPClient("ftp://25.35.182.85:12975/usuarios/" + usuario.Id + "/", "Prueba", "");
                    pUser.Image = ftp.DownloadPngAsImage("image.png", pUser.Size);
                }
                catch (Exception ex)
                {
                    pUser.Image = null;
                }
                pUser.Visible = true;
                lUsername.Text = "Bienvenido " + usuario.Username;
                lUsername.Visible = true;
                linitSesion.Visible = false;
                lSignOut.Visible = true;

                if (usuario.Rol.Admin == 1)
                {
                    bEditarNoticia.Visible = true;
                }
                else
                {
                    bEditarNoticia.Visible = false;
                }
            }

            string path = Path.GetDirectoryName(Application.StartupPath);
            string pathBueno = path.Substring(0, path.Length - 3);
            string imagePath = pathBueno + "images\\" + noticia.Image;

            Image image;
            if (FTPClient.ftpOn)
            {
                try
                {
                    FTPClient ftpClient = new FTPClient("ftp://25.35.182.85:12975/noticias/" + noticia.ID + "/", "Prueba", "");
                    image = ftpClient.DownloadPngAsImage("image.png", pNoticia.Size);
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
            pNoticia.Image = image;
            pNoticia.SizeMode = PictureBoxSizeMode.StretchImage;

            lTitulo.Text = noticia.Name;
            tDes.Text = noticia.Description;
            lFecha.Text = noticia.Date;
        }

        private void actualizarBotones()
        {
            linitSesion.Location = new Point(lUsername.Location.X, lUsername.Location.Y);
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
            this.lSignOut.Location = new Point((tamaño * 3) / 10, lSignOut.Location.Y);
            this.pNoticia.Location = new Point((tamaño * 2) / 10, pNoticia.Location.Y);
        }

        private void actualizarLabels()
        {
            int anchura = this.Width;
            int altura = this.Height;
            this.lUsername.Location = new Point((int)(this.Width * 1.2) / 10, lUsername.Location.Y);
            this.lSignOut.Location = new Point(lUsername.Location.X, lSignOut.Location.Y);
            this.pUser.Location = new Point(lUsername.Location.X - pUser.Width - 15, pUser.Location.Y);
            this.lTitulo.Location = new Point((int)((anchura * 4.5) / 10), lTitulo.Location.Y);
            this.tDes.Location = new Point((int)((anchura * 4.5) / 10), tDes.Location.Y);
            this.lFec.Location = new Point((anchura * 2) / 10, lFec.Location.Y);
            this.lFecha.Location = new Point(lFec.Location.X + lFec.Width + 20, lFecha.Location.Y);
            this.bExit.Location = new Point((int)(anchura * 8.8) / 10, (int)(altura * 8.5) / 10);
            this.bEditarNoticia.Location = new Point(this.menuFlowLayoutPanel.Location.X, bExit.Location.Y);
        }

        private void InfoNoticia_Resize(object sender, EventArgs e)
        {
            actualizarBotones();
            actualizarImagenes();
            actualizarLabels();
        }
        #endregion

        #region Logica del formulario
        private void bExit_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Principal inicio = new Principal(usuario);
            inicio.ShowDialog();
            this.Close();
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

        private void lSignOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void bEditarNoticia_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            EditarNoticia en = new EditarNoticia(noticia, usuario);
            en.Owner = this;
            this.Visible = false;
            en.ShowDialog();
            if (!isClosed)
            {
                actualizar();
                this.Visible = true;
            }
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
            if (this.Owner != null)
            {
                this.Owner.Close();
            }
            this.Close();

        }

        private void bEventos_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Eventos ev = new Eventos(usuario);
            ev.Show();
            if (this.Owner != null)
            {
                this.Owner.Close();
            }
            this.Close();
        }

        private void InfoNoticia_FormClosing(object sender, FormClosingEventArgs e)
        {
            isClosed = true;
        }
        #endregion

        #region Desplegable de mi perfil
        private void pPerfil_MouseLeave(object sender, EventArgs e)
        {
            mouseInPanel = false;
            hideTimer.Start();
        }

        private void hidePanel(object sender, EventArgs e)
        {
            hideTimer.Stop();
            if (!mouseInPanel)
            {
                pPerfil.Visible = false;
                pUser.BringToFront();
                pUser.Visible = true;
                lUsername.Visible = true;
            }
        }

        private void pUser_MouseClick(object sender, EventArgs e)
        {
            if (usuario != null)
            {
                mouseInPanel = true;
                pUser.SendToBack();
                pPerfil.Visible = true;
            }
            else
            {
                pUser.Visible = false;
            }
        }

        private void bPerfil_MouseEnter(object sender, EventArgs e)
        {
            pPerfil.Visible = true;
            mouseInPanel = true;
            hideTimer.Stop();
        }

        private void bPerfil_MouseLeave(object sender, EventArgs e)
        {
            hideTimer.Start();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (usuario != null)
            {
                pPerfil.Visible = false;
                pUser.BringToFront();
                pUser.Visible = true;
                lUsername.Visible = true;
            }
        }

        private void bPerfil_Click(object sender, EventArgs e)
        {
            MiPerfil frame = new MiPerfil(usuario);
            frame.Owner = this;
            this.Visible = false;
            frame.ShowDialog();
            usuario = Inicio.usuario;
            actualizar();
            this.Visible = true;
        }

        private void bMensajes_Click(object sender, EventArgs e)
        {
            Mensajeria frame = new Mensajeria(usuario);
            frame.Owner = this;
            this.Visible = false;
            frame.ShowDialog();
            usuario = Inicio.usuario;
            actualizar();
            this.Visible = true;
        }
        #endregion

        private void bContacto_Click(object sender, EventArgs e)
        {
            Contacto contacto = new Contacto(usuario);
            this.Visible = false;
            contacto.ShowDialog();
            this.Close();
        }
    }
}
