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
using MySqlConnector;

namespace Asuma
{
    public partial class CrearEvento : Form
    {
        private bool mouseInPanel = false;
        private Timer hideTimer;    
        private User usuario;
        private string imagen = "";
        private bool tipo;

        #region Creacion del frame
        public CrearEvento(User usuario)
        {
            this.tipo = false;
            hideTimer = new Timer { Interval = 100 };
            hideTimer.Tick += hidePanel;
            InitializeComponent();
            this.usuario = usuario;
            lUsername.Text = "Bienvenido " + usuario.Username;
            actualizarElementos();
            actualizar();
            actualizarFiltro();
        }
        #endregion

        #region GUIs
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
                if (FTPClient.ftpOn)
                {
                    try
                    {
                        FTPClient ftp = new FTPClient("ftp://25.35.182.85:12975/usuarios/" + usuario.Id + "/", "Prueba", "");
                        pUser.Image = ftp.DownloadPngAsImage("image.png", pUser.Size);
                    }
                    catch (Exception)
                    {
                        FTPClient.ftpOn = false;
                        pUser.Image = null;
                    }
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

        private void CrearEvento_Resize(object sender, EventArgs e)
        {
            actualizarElementos();
            this.CenterToScreen();
        }

        private void actualizarElementos()
        {
            linitSesion.Location = new Point(lUsername.Location.X, lUsername.Location.Y);
            this.menuFlowLayoutPanel.Width = this.Width - 25;
            this.bInicio.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bEventos.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bInfo.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bContacto.Width = this.menuFlowLayoutPanel.Width / 4 - 10;

            this.pASUMA.Location = new Point((this.Width * 4) / 10, pASUMA.Location.Y);
            this.pASM.Location = new Point((this.Width * 7) / 10, pASM.Location.Y);

            this.panel1.Location = new Point(this.Width / 2 - panel1.Width / 2, (int)(this.Height * 5.5 / 10 - panel1.Height / 2));     
        }

        private void actualizarFiltro()
        {
            cbTipo.Items.Add("Actividad");
            cbTipo.SelectedItem = cbTipo.Items[0];
            cbTipo.Items.Add("Curso");
        }
        #endregion

        #region Logica del form
        private void bExit_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            MisEventos misEventos = new MisEventos(usuario);
            misEventos.Show();
            this.Close();
        }

        private void bCreateEvent_Click(object sender, EventArgs e)
        {
            /*Cursor.Current = Cursors.WaitCursor;
            try
            {
                string eventName = tTitle.Text;
                string eventDescription = tDescription.Text;
                DateTime date = tDatePicker.Value;

                string[] aux = date.ToString().Split(' ');
                string eventDate = aux[0];
                string eventOrganiser = tOrganizer.Text;
                string eventCreator = usuario.Username;
                string image = tImage.Text;
                Event evento = new Event(eventName, eventDate, image, eventDescription, eventOrganiser, eventCreator);
                MessageBox.Show("Evento creado con exito");
                MisEventos misEventos = new MisEventos(usuario);
                misEventos.Show();
                this.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                string eventName = tTitle.Text;
                string eventDescription = tDescription.Text;
                DateTime date = tDatePicker.Value;

                string[] aux = date.ToString().Split(' ');
                string eventDate = aux[0];
                string eventOrganiser = tOrganizer.Text;
                string eventCreator = usuario.Username;
                string image = "comida.jpg";

                //ADVERTENCIA: HAY QUE CONTROLAR ESTO AL INSERTAR EVENTO
                Event evento = new Event(eventName, eventDate, image, eventDescription, eventOrganiser, eventCreator, this.tipo);
                new Forum(evento);
                if (FTPClient.ftpOn)
                {
                    FTPClient ftp = new FTPClient("ftp://25.35.182.85:12975/", "Prueba", "");
                    try
                    {
                        ftp.MakeFtpDirectory("eventos/" + evento.ID);
                        ftp.MakeFtpDirectory("eventos/" + evento.ID + "/files");
                    }
                    catch (Exception ex) { }
                    ftp.UploadFile(imagen, "/eventos/" + evento.ID + "/image.png");
                }
                // imagePath.Substring(0, imagePath.LastIndexOf("/")

                MessageBox.Show("Evento creado con exito");
                MisEventos misEventos = new MisEventos(usuario);
                misEventos.Show();
                if (this.Owner != null)
                {
                    this.Owner.Close();
                }
                this.Close();

            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }
        }

        private void lSignOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
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
            catch(Exception ex)
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

        private void cbTipo_DropDownClosed(object sender, EventArgs e)
        {
            if (cbTipo.SelectedItem == cbTipo.Items[0])
            {
                this.tipo = false;
            } else {
                this.tipo = true;
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
            /* pUser.Visible = false;
             lUsername.Visible = false;*/
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
