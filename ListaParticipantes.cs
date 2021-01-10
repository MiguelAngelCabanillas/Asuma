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
            actualizarPanelPerfil();
            panelParticipantes.SendToBack();
            mostrarParticipantes();
        }

        public void mostrarParticipantes()
        {

            panelParticipantes.Controls.Clear();
            BD bd = new BD();
            MySqlDataReader reader = bd.Query("SELECT username, id FROM user WHERE username IN (SELECT userName FROM inscription WHERE idEvent = " + evento.ID + ");");
            int separacionV = 50, separacionH = 50;
            int i = 0;
            while (reader.Read())
            {
                string name = (string)reader[0];
                string imagen = "";
                int id = (int)reader[1];

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
                lUsuario.Location = new Point(panel.Width / 2 - lUsuario.Text.Length * 5, 130);
                lUsuario.Visible = true;

                //------------------


                PictureBox pImagen = new PictureBox();
                pImagen.BackColor = SystemColors.ActiveCaption;
                pImagen.Location = new Point(panel.Width / 2 - pImagen.Width / 2, 10);
                pImagen.Name = "pImagen";

                Image image;
                if (FTPClient.ftpOn)
                {
                    try
                    {
                        FTPClient ftp = new FTPClient("ftp://25.35.182.85:12975/usuarios/" + id + "/", "Prueba", "");
                        pImagen.Image = ftp.DownloadPngAsImage("image.png", pImagen.Size);
                    }
                    catch (Exception)
                    {
                        //FTPClient.ftpOn = false;
                        pImagen.Image = null;
                    }
                }
                else
                {
                    pImagen.Image = null;
                }
                pImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                pImagen.Size = new Size(100, 100);
                pImagen.TabIndex = 0;
                pImagen.TabStop = false;
                pImagen.Visible = true;
                pImagen.BorderStyle = BorderStyle.FixedSingle;

                if ((usuario.Username.Equals(nombreGestor) || usuario.Rol.Admin == 1) && !name.Equals(nombreGestor))
                {
                    Button bCancelarSus = new Button();
                    bCancelarSus.Text = "Cancelar suscripción";
                    bCancelarSus.Size = new Size(120, 30);
                    bCancelarSus.Location = new Point(panel.Width / 2 - bCancelarSus.Width / 2, 170);
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
                if (i != 0 && (i + 1) % 6 == 0)
                {
                    separacionH = 50;
                    separacionV += 300;
                }

                i++;
            }
            reader.Close();
            bd.closeBD();

            //Separación inferior dentro del panel de noticias
            PictureBox pSep = new PictureBox();
            pSep.Location = new Point(50, separacionV + 250);
            pSep.Size = new Size(200, 50);
            panelParticipantes.Controls.Add(pSep);

            panelParticipantes.BorderStyle = BorderStyle.FixedSingle;
        }
        #endregion

        #region GUIs
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
            else
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
            //Environment.Exit(Environment.ExitCode);
            Cursor.Current = Cursors.WaitCursor;
            Principal inicio = new Principal(null);
            inicio.Show();
            this.Close();
        }


        private void actualizarBotones()
        {
            this.menuFlowLayoutPanel.Width = this.Width - 25;
            this.bInicio.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bEventos.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bInfo.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bContacto.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bExit.Location = new Point(this.pASM.Location.X+50,this.Height-100);
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


        private void actualizarPanelPerfil()
        {
            pPerfil.Location = new Point(pUser.Location.X, pUser.Location.Y + pUser.Height - 10);
        }

        private void actualizarParticipantes()
        {
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
            actualizarPanelPerfil();
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
            InfoEventoInscrito iei = new InfoEventoInscrito(evento, usuario);
            iei.Show();
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
            Mensajeria frame = new Mensajeria(usuario);
            frame.Owner = this;
            this.Visible = false;
            frame.ShowDialog();
            usuario = Inicio.usuario;
            actualizar();
            this.Visible = true;
        }

        public void setUser(User usuario)
        {
            this.usuario = usuario;
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
            Informacion inf = new Informacion(usuario);
            inf.Show();
            this.Close();
        }
    }
    #endregion
}

