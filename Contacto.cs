﻿using System;
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
        private bool mouseInPanel = false;
        private Timer hideTimer;
        private User usuario;

        public Contacto(User usuario)
        {
            hideTimer = new Timer { Interval = 100 };
            hideTimer.Tick += hidePanel;
            InitializeComponent();
            this.usuario = usuario;
            actualizar();
        }

      


        private void actualizarImagenes()
        {
            int tamaño = this.Width;
            this.pASUMA.Location = new Point((tamaño * 4) / 10, pASUMA.Location.Y);
            this.pASM.Location = new Point((tamaño * 7) / 10, pASM.Location.Y);
            this.lUsername.Location = new Point((int)(this.Width * 1.2) / 10, lUsername.Location.Y);
            this.lSignOut.Location = new Point(lUsername.Location.X, lSignOut.Location.Y);
            this.pUser.Location = new Point(lUsername.Location.X - pUser.Width - 15, pUser.Location.Y);
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
            CentrarPanel();
        }

        private void CentrarPanel()
        {
            panel1.Location = new Point(this.Width/2 - panel1.Width/2, this.Height/2 - panel1.Height/2);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void tSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (tName.Text.Trim(' ').Equals("") || cReason.SelectedItem == null || tMessage.Text.Trim(' ').Equals("") || tEmail.Text.Trim(' ').Equals(""))
                {
                    MessageBox.Show("Debe rellenar todos los campos");
                }
                else
                {
                    Email email = new Email();
                    email.sendEmailToAdmin(tName.Text, tEmail.Text, cReason.Text, tMessage.Text);
                    MessageBox.Show("Mensaje enviado correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void bNotificar_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> listaEmails = User.listaEmailsUsuariosEnEvento(new Event(61));
                Email email = new Email();
                string asunto = "Recordatorio de subida de actividad";
                string cuerpo = "Buenos días, os envio esta notificación para recordaros que debeis terminar y enviar a tiempo la tarea que teniamos acordada para esta semana, espero que la entregueis todos. Un saludo";
                email.sendEmailToVarious(listaEmails, asunto, cuerpo, new Event(61).EventName);
                MessageBox.Show("Notificación enviada con éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void linitSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Inicio init = new Inicio();
            init.ShowDialog();
            this.usuario = Inicio.usuario;
            actualizar();
        }

        private void lSignOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Principal inicio = new Principal(null);
            inicio.Show();
            this.Close();
        }

        private void bInfo_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Informacion info = new Informacion(usuario);
            info.Show();
            this.Close();
        }

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
