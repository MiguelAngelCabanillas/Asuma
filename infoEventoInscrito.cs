using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using MySqlConnector;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asuma
{
    public partial class InfoEventoInscrito : Form
    {
        private bool mouseInPanel = false;
        private Timer hideTimer;

        private Event evento;
        private User usuario;
        private Forum foro;
        public bool isClosed = false;

        #region Creacion del frame
        public InfoEventoInscrito(Event e, User u)
        {
            hideTimer = new Timer { Interval = 100 };
            hideTimer.Tick += hidePanel;
            this.evento = e;
            this.usuario = u;

            InitializeComponent();
            lUsername.Text = "Bienvenido " + usuario.Username;
            if (e.EventCreator.Equals(u.Username) || usuario.Rol.RolName.Equals("Admin"))
            {
                bTestConocimiento.Visible = false;
                bRealizarEncSatisfaccion.Visible = false;
            }
            else
            {
                bEditEvent.Visible = false;
                bNotifyEmail.Visible = false;
                bTestsRealizados.Visible = false;
                bEncuestas.Visible = false;
            }

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

        private void menuFlowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {
            actualizarBotones();
        }

        private void actualizar()
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
                    //FTPClient.ftpOn = false;
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
            string path = Path.GetDirectoryName(Application.StartupPath);
            string pathBueno = path.Substring(0, path.Length - 3);
            string imagePath = pathBueno + "images\\" + evento.Image;
            //Image image = Image.FromFile(imagePath);
            Image image;
            if (FTPClient.ftpOn)
            {
                try
                {
                    FTPClient ftpClient = new FTPClient("ftp://25.35.182.85:12975/eventos/" + evento.ID + "/", "Prueba", "");
                    image = ftpClient.DownloadPngAsImage("image.png", pEvento.Size);
                    /*byte[] byteArrayIn = ftpClient.DownloadFileBytesInArray("image.png");
                    using (var ms = new MemoryStream(byteArrayIn))
                    {
                        image = Image.FromStream(ms);
                    }*/

                }
                catch (Exception ex)
                {
                    image = null;
                }


            }
            else { image = Image.FromFile(imagePath); }
            pEvento.Image = image;
            pEvento.SizeMode = PictureBoxSizeMode.StretchImage;

            lTitulo.Text = evento.EventName;
            tDes.Text = evento.EventDescription;
            lOrganizadores.Text = evento.Organizer;
            lFecha.Text = evento.Date;
        }

        private void actualizarElementos()
        {
            actualizarBotones();
            actualizarImagenes();
            actualizarLabels();
            actualizarPanelPerfil();
        }

        private void actualizarPanelPerfil()
        {
            pPerfil.Location = new Point(pUser.Location.X, pUser.Location.Y + pUser.Height - 10);
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
            this.lUsername.Location = new Point((int)(this.Width * 1.2) / 10, lUsername.Location.Y);
            this.lSignOut.Location = new Point(lUsername.Location.X, lSignOut.Location.Y);
            this.pUser.Location = new Point(lUsername.Location.X - pUser.Width - 15, pUser.Location.Y);
            int tamaño = this.Width;
            this.pASUMA.Location = new Point((tamaño * 4) / 10, pASUMA.Location.Y);
            this.pASM.Location = new Point((tamaño * 7) / 10, pASM.Location.Y);
            this.lSignOut.Location = new Point((tamaño * 3) / 10, lSignOut.Location.Y);
            pEvento.Location = new Point(tamaño*2/10, menuFlowLayoutPanel.Location.Y + 100);
        }

        private void actualizarLabels()
        {
            int anchura = this.Width;
            int altura = this.Height;
            lSignOut.Location = new Point(lUsername.Location.X, lUsername.Location.Y + 40);
            this.lTitulo.Location = new Point((int)((anchura * 4.5) / 10), lTitulo.Location.Y);
            this.tDes.Location = new Point((int)((anchura * 4.5) / 10), lTitulo.Location.Y + tDes.Height / 3);
            this.lOrg.Location = new Point((anchura * 2) / 10, lOrg.Location.Y);
            this.lFec.Location = new Point((anchura * 2) / 10, lFec.Location.Y);
            this.lOrganizadores.Location = new Point(lOrg.Location.X + lOrg.Width + 20, lOrganizadores.Location.Y);
            this.lFecha.Location = new Point(lFec.Location.X + lFec.Width + 20, lFecha.Location.Y);
            this.linkForum.Location = new Point((anchura * 2) / 10, linkForum.Location.Y);
            this.linkArchivos.Location = new Point((anchura *3) / 10, linkForum.Location.Y);
            this.bExit.Location = new Point(tDes.Location.X + tDes.Width - bExit.Width, (int)(altura * 8.8) / 10);
            this.bEditEvent.Location = new Point(lFec.Location.X, bExit.Location.Y);
            lTipo.Location = new Point((anchura * 2) / 10, lTipo.Location.Y);
            lTipoDef.Location = new Point(lTipo.Location.X + lTipo.Width + 10, lTipo.Location.Y + 5);

            this.bListParticipantes.Location = new Point((int)(anchura * 4.9) / 10, lFecha.Location.Y);
            this.bNotifyEmail.Location = new Point((int)((anchura * 5.3) / 10)+ bListParticipantes.Width , lFecha.Location.Y);

            this.bRealizarEncSatisfaccion.Location = new Point((int)(anchura * 4.9) / 10, lTipo.Location.Y);
            this.bEncuestas.Location = new Point((int)((anchura * 5.3) / 10) + bListParticipantes.Width, lTipo.Location.Y);

            this.bTestConocimiento.Location = new Point((int)(anchura * 4.9) / 10, linkForum.Location.Y);
            this.bTestsRealizados.Location = new Point((int)((anchura * 5.3) / 10) + bListParticipantes.Width, linkForum.Location.Y);
           
        }

        private void InfoEventoInscrito_Resize(object sender, EventArgs e)
        {
            actualizarElementos();
        }
        #endregion


        #region Logica del formulario
        private void bExit_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            MisEventos misEventos = new MisEventos(usuario);
            misEventos.Show();
            this.Close();
        }

        private void lSignOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Environment.Exit(Environment.ExitCode);
            Cursor.Current = Cursors.WaitCursor;
            Principal inicio = new Principal(null);
            inicio.Show();
            this.Close();
        }

        private void bEditEvent_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            EditarEvento ed = new EditarEvento(evento, usuario);
            ed.Show();
            this.Close();
        }

        private void bInicio_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Principal ev = new Principal(usuario);
            ev.Show();
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
            Contacto contacto = new Contacto(usuario);
            this.Visible = false;
            contacto.ShowDialog();
            this.Close();
        }

        private void linkForum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormForo formularioForo = new FormForo(foro, usuario);
            formularioForo.ShowDialog();
        }

        private void InfoEventoInscrito_Load(object sender, EventArgs e)
        {
            try
            {
                if (!evento.EsCurso)
                {
                    bTestConocimiento.Visible = false;
                    bTestsRealizados.Visible = false;
                }
                foro = new Forum(evento.ID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InfoEventoInscrito_FormClosing(object sender, FormClosingEventArgs e)
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

        private void lTipoDef_Paint(object sender, PaintEventArgs e)
        {
            if (this.evento.EsCurso)
            {
                lTipoDef.Text = "Curso";
            }
            else
            {
                lTipoDef.Text = "Actividad";
            }
        }


        private void bTestConocimiento_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (!Test.testCreado(evento))
            {
                //Si el gestor no ha creado el test muestro un mensaje
                MessageBox.Show("No existe test de conocimiento para este curso");
            }
            else
            {
                //No permito que el usuario realize el test si ya lo ha aprobado
                if (!Test.testAprobado(evento, usuario))
                {
                    new Test(evento, usuario);
                }
                else
                {
                    MessageBox.Show("El test de conocimiento esta aprobado");
                }
            }
        }

        private void bNotifyEmail_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Notificacion n = new Notificacion();
            n.ShowDialog();
        }

        private void bListParticipantes_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ListaParticipantes lPa = new ListaParticipantes(usuario, evento);
            lPa.Show();
            this.Close();
        }

        private void linkArchivos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Directorios pftp = new Directorios(evento, usuario);
            pftp.ShowDialog();
        }

        private void bTestsRealizados_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Tests_Curso testRealizados = new Tests_Curso(evento);
            testRealizados.ShowDialog();
        }

        private void bRealizarEncSatisfaccion_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (Surveys_Evento.EncuestaRealizada(usuario.Id))
            {
                MessageBox.Show("La encuesta ya ha sido realizada");
            }
            else
            {
                Cuestionario_Satisfaccion cuestionario = new Cuestionario_Satisfaccion(evento, usuario);
                cuestionario.ShowDialog();
            }
        }

        private void bEncuestas_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Surveys_Evento encuestas = new Surveys_Evento(evento);
            encuestas.ShowDialog();
        }
    }
}
