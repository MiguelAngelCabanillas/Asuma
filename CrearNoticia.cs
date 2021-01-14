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
    public partial class CrearNoticia : Form
    {
        private bool mouseInPanel = false;
        private Timer hideTimer;

        private User usuario;
        private string imagen = "";

        #region Creacion del form
        public CrearNoticia(User usuario)
        {
            hideTimer = new Timer { Interval = 100 };
            hideTimer.Tick += hidePanel;
            InitializeComponent();
            this.usuario = usuario;
            tDescription.AutoSize = false;
            tDescription.Height = 80;
            pImage.Visible = true;
            lUsername.Text = "Bienvenido " + usuario.Username;
            actualizarElementos();
            actualizarPanelPerfil();
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

        public void actualizar()
        {
            if (FTPClient.ftpOn)
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
            }
            pUser.Visible = true;
            lUsername.Text = "Bienvenido " + usuario.Username;
            lUsername.Visible = true;
            lSignOut.Visible = true;
        }

        private void menuFlowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {
            this.menuFlowLayoutPanel.Location = new Point(15, menuFlowLayoutPanel.Location.Y);
            this.menuFlowLayoutPanel.Width = this.Width - 25;
            this.bInicio.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bEventos.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bInfo.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bContacto.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
        }

        private void CrearNoticia_Resize(object sender, EventArgs e)
        {
            actualizarElementos();
            actualizarPanelPerfil();
        }

        private void actualizarElementos()
        {
            this.lUsername.Location = new Point((int)(this.Width * 1.2) / 10, lUsername.Location.Y);
            this.lSignOut.Location = new Point(lUsername.Location.X, lSignOut.Location.Y);
            this.pUser.Location = new Point(lUsername.Location.X - pUser.Width - 15, pUser.Location.Y);
            this.menuFlowLayoutPanel.Width = this.Width - 25;
            this.bInicio.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bEventos.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bInfo.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bContacto.Width = this.menuFlowLayoutPanel.Width / 4 - 10;

            this.pASUMA.Location = new Point((this.Width * 4) / 10, pASUMA.Location.Y);
            this.pASM.Location = new Point((this.Width * 7) / 10, pASM.Location.Y);

            this.panel1.Location = new Point(this.bInicio.Location.X + 100, this.menuFlowLayoutPanel.Location.Y + 80);
            this.panel1.Size = new Size(this.menuFlowLayoutPanel.Width, this.Height - this.menuFlowLayoutPanel.Location.Y - 30);
        }

        private void actualizarPanelPerfil()
        {
            pPerfil.Location = new Point(pUser.Location.X, pUser.Location.Y + pUser.Height - 10);
        }
        #endregion

        #region Logica del form
        private void bExit_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Principal inicio = new Principal(usuario);
            inicio.Show();
            this.Close();
        }

        private void bCrearNoticia_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                string name = tTitle.Text;
                string description = tDescription.Text;
                string image = "comida.jpg";
                News noticia = new News(name, description, image);
                if (FTPClient.ftpOn)
                {
                    FTPClient ftp = new FTPClient("ftp://25.35.182.85:12975/", "Prueba", "");
                    try
                    {
                        ftp.MakeFtpDirectory("noticias/" + noticia.ID);
                    }
                    catch (Exception) { }
                    ftp.UploadFile(imagen, "/noticias/" + noticia.ID + "/image.png");
                }
                // imagePath.Substring(0, imagePath.LastIndexOf("/")

                MessageBox.Show("Noticia creada con exito");
                Principal inicio = new Principal(usuario);
                inicio.Show();
                this.Close();

            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }
        }

        private void lSignOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Environment.Exit(Environment.ExitCode);
            Cursor.Current = Cursors.WaitCursor;
            Principal inicio = new Principal(null);
            inicio.Show();
            this.Close();
        }

        private void bInicio_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Principal p = new Principal(usuario);
            p.Show();
            this.Close();
        }

        private void bEventos_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Eventos ev = new Eventos(usuario);
            ev.Show();
            this.Close();
        }

        private void bContacto_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Contacto con = new Contacto(usuario);
            con.Show();
            this.Close();
        }

        private void bInfo_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Informacion info = new Informacion(usuario);
            info.Show();
            this.Close();
        }

        private void tImage_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string path = Path.GetDirectoryName(Application.StartupPath);
                string pathBueno = path.Substring(0, path.Length - 3);
                string imagePath = pathBueno + "images\\" + tImage.Text;
                Image image = Image.FromFile(imagePath);
                pImage.Image = image;
                pImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {

            }

        }

        private void bEscogerImg_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            char[] separadores = { '\\' };
            switch (openFileDialog1.FileName.Split(separadores)[openFileDialog1.FileName.Split(separadores).Length - 1].Split('.')[openFileDialog1.FileName.Split(separadores)[openFileDialog1.FileName.Split(separadores).Length - 1].Split('.').Length - 1])
            {
                case "png":
                case "PNG":
                case "jpg":
                case "JPG":
                case "jpeg":
                case "JPEG":
                    //ftp.UploadFile(openFileDialog1.FileName, "eventos/" + tTitle.Text + "/image.png"); //+ 

                    // Get file extension
                    //openFileDialog1.FileName.Split(separadores)[openFileDialog1.FileName.Split(separadores).Length - 1].Split('.')[openFileDialog1.FileName.Split(separadores)[openFileDialog1.FileName.Split(separadores).Length - 1].Split('.').Length-1]);
                    pImage.Image = (Image)(new Bitmap(Image.FromFile(openFileDialog1.FileName), pImage.Size));
                    imagen = openFileDialog1.FileName;


                    //MessageBox.Show("Se ha subido correctamente el archivo " + openFileDialog1.FileName.Split(separadores)[openFileDialog1.FileName.Split(separadores).Length - 1]);
                    break;
                default:
                    MessageBox.Show("Formatos compatibles: .png, .PNG, .jpg, .JPG, .jpeg, .JPEG");
                    break;
            }
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


    }
}
