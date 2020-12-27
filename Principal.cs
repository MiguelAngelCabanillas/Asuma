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
    public partial class Principal : Form
    {
        private User usuario;
        private bool mouseInPanel = false;
        private Timer hideTimer;

        #region Creacion del form
        public Principal(User user)
        {
            hideTimer = new Timer { Interval = 100 };
            hideTimer.Tick += hidePanel;
            this.usuario = user;
            InitializeComponent();
            actualizar();
            añadirAlPanel();
            this.ActiveControl = bInicio;
        }

        public User Usuario
        {
            get{ return this.usuario; }
            set{ this.usuario = value;}
        }
        #endregion

        #region Logica del Form
        private void lSignOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Se puede hacer que cierre solo sesion y siga en la plataforma
            Environment.Exit(Environment.ExitCode);
        }

        private void bEventos_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Eventos ev = new Eventos(usuario);
            ev.Show();
            this.Visible = false;
        }

        private void añadirAlPanel()
        {
            panel1.Controls.Add(pUser);
            panel1.Controls.Add(lUsername);
            panel1.Controls.Add(linitSesion);
            panel1.Controls.Add(lSignOut);
            panel1.Controls.Add(pASUMA);
            panel1.Controls.Add(pASM);
            panel1.Controls.Add(menuFlowLayoutPanel);
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (this.usuario == null) {
                MessageBox.Show("Debe registrarse para visualizar sus eventos.");
            } else {
                List<Event> eventos = Event.listaEventosUsuario(this.usuario);
                if (eventos.Count == 0) {
                    MessageBox.Show("No se encuentra inscrito en ningún evento.");
                }
                else
                {
                    string dia = mcEventos.SelectionStart.ToString().Substring(0,mcEventos.SelectionStart.ToString().Count() - 8);
                    string res = "";
                    foreach(Event evento in eventos) {
                        if (dia.Equals(evento.Date))
                        {
                            res = res + "- " + evento.EventName + " (" + (evento.Tipo ? "Curso" : "Actividad") + ")\n";
                        }
                    }
                    if (res == "")
                    {
                        MessageBox.Show("No tiene ningún evento programado para este día.");
                    }
                    else
                    {
                        MessageBox.Show(res);
                    }
                }
            }

        }

        #endregion


        #region GUIs

        private void pintarCalendario()
        {
            if (this.usuario != null) {
                List<Event> eventos = Event.listaEventosUsuario(this.usuario);
                DateTime[] dates = new DateTime[eventos.Count];
                int i = 0;
                foreach (Event evento in eventos)
                {
                    dates[i] = DateTime.Parse(evento.Date);
                    i++;
                }
                mcEventos.BoldedDates = dates;
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

        private void linitSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Inicio init = new Inicio();
            this.Visible = false;
            init.ShowDialog();
            this.Usuario = Inicio.usuario;
            actualizar();
            this.Visible = true;
            this.ActiveControl = bInicio;
        }

        public void actualizar()
        {
            if (usuario == null)
            {
                linitSesion.Visible = true;
                pUser.Visible = false;
                lUsername.Visible = false;
                lSignOut.Visible = false;
                pPerfil.Visible = false;
            }
            else
            {
                pintarCalendario();
                linitSesion.Visible = false;
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

        private void Principal_Resize(object sender, EventArgs e)
        {
            panel1.Width = this.Width;
            actualizarBotones();
            actualizarImagenes();
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
            if (usuario != null) {
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

        }
        #endregion


    }
}
