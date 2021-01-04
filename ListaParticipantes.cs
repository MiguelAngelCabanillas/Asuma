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
    public partial class ListaParticipantes : Form
    {
        private User usuario;
        private Event evento;
        private bool mouseInPanel = false;
        private Timer hideTimer;
        private string nombreGestor;

        #region Creacion del frame
        public ListaParticipantes(User u, Event e)
        {

            hideTimer = new Timer { Interval = 100 };
            hideTimer.Tick += hidePanel;
            InitializeComponent();
            this.usuario = u;
            this.evento = e;
            this.nombreGestor = e.EventCreator;
            actualizar();
            panelParticipantes.SendToBack();
            mostrarParticipantes();
        }

        public void mostrarParticipantes()
        {

            panelParticipantes.Controls.Clear();
            List<User> listaParticipantes = new List<User>();
            BD bd = new BD();
            MySqlDataReader reader = bd.Query("SELECT userName FROM inscription WHERE idEvent = " + evento.ID + ";");
            while (reader.Read())
            {
                string userName = (string)reader[0];
                User u = new User(userName);
                listaParticipantes.Add(u);
            }
            reader.Close();
            bd.closeBD();

            int nParticipantes = listaParticipantes.Count;
            int separacionV = 50, separacionH = 50;

            for (int i= 0; i < nParticipantes; i++)
            {
                string name = listaParticipantes.ElementAt(i).Username;
                //string imagen = listaParticipantes.ElementAt(i).;
                string imagen = "";
                int id = listaParticipantes.ElementAt(i).Id;

                Panel panel = new Panel();
                panel.Name = "pUsuario" + id;
                panel.Size = new Size(200, 250);
                panel.Location = new Point(separacionH, separacionV);

                //------------------

                Label lUsuario = new Label();
                lUsuario.Text = name;
                lUsuario.Size = new Size(120, 30);
                lUsuario.AutoSize = true;
                lUsuario.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                lUsuario.Location = new Point(panel.Width/2 - lUsuario.Text.Length*5, 130);
                //lUsuario.TabIndex = 31;
                //lUsuario.TabStop = true;
                lUsuario.Visible = true;

                //------------------


                PictureBox pImagen = new PictureBox();
                pImagen.BackColor = SystemColors.ActiveCaption;
                pImagen.Location = new Point(panel.Width/2-pImagen.Width/2, 10);
                pImagen.Name = "pImagen";

                string path = Path.GetDirectoryName(Application.StartupPath);
                string pathBueno = path.Substring(0, path.Length - 3);
                string imagePath = pathBueno + "images\\" + imagen;

                /*Image image;
                if (FTPClient.ftpOn)
                {
                    try
                    {
                        FTPClient ftpClient = new FTPClient("ftp://25.35.182.85:12975/eventos/" + listaParticipantes.ElementAt(i).Id + "/", "Prueba", "");
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
                else if (FTPClient.ftpBackupOn)
                {
                    FTPClient ftp = new FTPClient("ftp://25.35.182.85:12975/", "Prueba", "");
                    try
                    {
                        ftp.MakeFtpDirectory("eventos/" + listaEventos.ElementAt(i).ID);
                    }
                    catch (Exception ex) { }
                    ftp.UploadFile(imagePath, "eventos/" + listaEventos.ElementAt(i).ID + "/image.png");
                    image = Image.FromFile(imagePath);
                }
                else { image = Image.FromFile(imagePath); }

                pImagen.Image = image;*/
                pImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                pImagen.Size = new Size(100, 100);
                pImagen.TabIndex = 0;
                pImagen.TabStop = false;
                pImagen.Visible = true;
                pImagen.BorderStyle = BorderStyle.FixedSingle;

                if (usuario.Username.Equals(nombreGestor) && !name.Equals(nombreGestor))
                {
                    Button bCancelarSus = new Button();
                    bCancelarSus.Text = "Cancelar suscripción";
                    bCancelarSus.Size = new Size(120,30);
                    bCancelarSus.Location = new Point(panel.Width/2 - bCancelarSus.Width/2,170);
                    bCancelarSus.Name = name;
                    bCancelarSus.Visible = true;
                    bCancelarSus.Click += new EventHandler(bCancelarSus_click);
                    panel.Controls.Add(bCancelarSus);
                }

                //------------------------------------------

                
                panel.Visible = true;
                panel.BorderStyle = BorderStyle.FixedSingle;


                panel.Controls.Add(lUsuario);
                panel.Controls.Add(pImagen);
                
                panelParticipantes.Controls.Add(panel);
                separacionH += 230;
                if(i !=0 && (i+1)%6 == 0)
                {
                    separacionH = 50;
                    separacionV += 300;
                }

                //Separación inferior dentro del panel de noticias
                if (i == nParticipantes - 1)
                {
                    PictureBox pSep = new PictureBox();
                    pSep.Location = new Point(50, separacionV+panel.Height);
                    pSep.Size = new Size(panel.Width, 50);
                    panelParticipantes.Controls.Add(pSep);
                }
            }
            panelParticipantes.BorderStyle = BorderStyle.FixedSingle;
            //panelParticipantes.Size = new Size(1265, 600);
        }
        #endregion

        #region GUIs
        public void actualizar()
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
            lSignOut.Visible = true;
        }

        private void lSignOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }


        private void actualizarBotones()
        {
            this.menuFlowLayoutPanel.Width = this.Width - 25;
            this.bInicio.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bEventos.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bInfo.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bContacto.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bExit.Location = new Point(this.Width-200,this.Height-100);
        }
        private void actualizarImagenes()
        {
            lSignOut.Location = new Point(lUsername.Location.X, lUsername.Location.Y + 40);

            int tamaño = this.Width;
            this.pASUMA.Location = new Point((tamaño * 4) / 10, pASUMA.Location.Y);
            this.pASM.Location = new Point((tamaño * 7) / 10, pASM.Location.Y);
        }

        private void actualizarPanelParticipantes()
        {
            panelParticipantes.Width = menuFlowLayoutPanel.Width - 60;
            panelParticipantes.Height = (this.Height * 6) / 10;
            panelParticipantes.Location = new Point(this.Width / 2 - panelParticipantes.Width / 2, this.menuFlowLayoutPanel.Location.Y + 50);
        }

        private void actualizarParticipantes()
        {
            panelParticipantes.Controls.Clear();
            mostrarParticipantes();
        }

        /*private void actualizarParticipantes()
        {
            foreach (Control c in panelParticipantes.Controls)
            {
                c.Width = panelParticipantes.Width - 120;
            }
        }*/

        private void pUser_Paint(object sender, PaintEventArgs e)
        {
            this.pUser.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pASUMA_Paint(object sender, PaintEventArgs e)
        {
            this.pASUMA.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pASM_Paint(object sender, PaintEventArgs e)
        {
            this.pASM.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void ListaParticipantes_Resize(object sender, EventArgs e)
        {
            actualizarBotones();
            actualizarImagenes();
            actualizarPanelParticipantes();
        }
        #endregion

        #region Logica del formulario
        protected void bCancelarSus_click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Button b = sender as Button;
            string name = b.Name;

            BD bd = new BD();
            MySqlDataReader writer = bd.Query("DELETE FROM inscription WHERE userName = '" + name + "' AND idEvent = " + evento.ID + ";");
            writer.Close();
            bd.closeBD();
            /*FTPClient ftp = new FTPClient("ftp://25.35.182.85:12975/", "Prueba", "");
            ftp.DeleteFTPDirectory("eventos/" + evento.ID + "/");*/
            Email email = new Email();
            email.sendEmailToCancelInscription(new User(name).Email, evento, usuario);
            MessageBox.Show("Suscripción cancelada con éxito");
            actualizarParticipantes();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
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
            Eventos eventos = new Eventos(usuario);
            eventos.Show();
            this.Close();

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
            actualizar();
            this.Visible = true;
        }

        private void bMensajes_Click(object sender, EventArgs e)
        {

        }

        public void setUser(User usuario)
        {
            this.usuario = usuario;
        }
    }
    #endregion
}

