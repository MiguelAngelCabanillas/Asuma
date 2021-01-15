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
        public Boolean isClosed = false;
        List<Event> eventos;
        List<int> eventosInscritos;

        #region Creacion del form
        public Principal(User user)
        {
            if (FTPClient.ftpOn == true)
            {
                try
                {
                    FTPClient ftp = new FTPClient("ftp://25.35.182.85:12975/", "Prueba", "");
                    ftp.GetFileDownloadSize("pruebaConexion");
                }
                catch (Exception)
                {
                    MessageBox.Show("Iniciando en modo sin conexión");
                    FTPClient.ftpOn = false;
                }
            }
            eventos = Event.listaEventos();
            hideTimer = new Timer { Interval = 100 };
            hideTimer.Tick += hidePanel;
            this.usuario = user;
            InitializeComponent();
            this.Text = "Inicio / Noticias";
            actualizar();
            añadirAlPanel();
            this.ActiveControl = bInicio;
            pNoticias.SendToBack();
            mostrarNoticias();
            
        }

        public User Usuario
        {
            get{ return this.usuario; }
            set{ this.usuario = value;}
        }

        public void mostrarNoticias()
        {
            pNoticias.Controls.Clear();
            List<News> listaNoticias = News.listaNoticias();
            int nNoticias = listaNoticias.Count;
            int separacion = 50;

            for (int i = 0; i < nNoticias; i++)
            {
                Object aux = listaNoticias.ElementAt(i);
                string newsName = listaNoticias.ElementAt(i).Name;
                string newsDate = listaNoticias.ElementAt(i).Date;
                string newsDescription = listaNoticias.ElementAt(i).Description;
                string newsImage = listaNoticias.ElementAt(i).Image;
                int newsId = listaNoticias.ElementAt(i).ID;

                Panel panel = new Panel();
                panel.Name = "pNoticia" + newsId;

                //------------------

                LinkLabel ltitulo = new LinkLabel();
                ltitulo.Text = newsName;
                ltitulo.Size = new Size(200, 30);
                ltitulo.AutoSize = true;
                ltitulo.Font = new Font("Verdana", 19.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                ltitulo.LinkColor = Color.Black;
                ltitulo.Location = new Point(230, 15);
                ltitulo.Name = newsId.ToString();
                ltitulo.TabIndex = 31;
                ltitulo.TabStop = true;
                ltitulo.Visible = true;
                ltitulo.Click += new EventHandler(ltitulo_click);

                //------------------


                PictureBox pImagen = new PictureBox();
                pImagen.BackColor = SystemColors.ActiveCaption;
                //pImagen.Location = new Point(60, panel.Height/2 - pImagen.Height/2);
                pImagen.Name = "pImagen";

                string path = Path.GetDirectoryName(Application.StartupPath);
                string pathBueno = path.Substring(0, path.Length - 3);
                string imagePath = pathBueno + "images\\" + newsImage;

                Image image;
                if (FTPClient.ftpOn)
                {
                    try
                    {
                        FTPClient ftpClient = new FTPClient("ftp://25.35.182.85:12975/noticias/" + listaNoticias.ElementAt(i).ID + "/", "Prueba", "");
                        byte[] byteArrayIn = ftpClient.DownloadFileBytesInArray("image.png");
                        using (var ms = new MemoryStream(byteArrayIn))
                        {
                            image = Image.FromStream(ms);
                        }
                    }
                    catch (Exception)
                    {
                        image = null;
                    }


                }else { image = Image.FromFile(imagePath); }

                pImagen.Image = image;
                pImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                pImagen.Size = new Size(150,150);//115,127
                pImagen.TabIndex = 0;
                pImagen.TabStop = false;
                pImagen.Visible = true;
                pImagen.BorderStyle = BorderStyle.FixedSingle;


                TextBox tFecha = new TextBox();
                tFecha.Text = "Fecha de la noticia: " + newsDate;
                tFecha.BorderStyle = BorderStyle.None;
                tFecha.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                tFecha.Location = new Point(240, 145);//900,130
                tFecha.Multiline = true;
                tFecha.Name = "tFecha";
                tFecha.ReadOnly = true;
                tFecha.Size = new Size(300, 30);//216,30
                tFecha.TabIndex = 32;
                tFecha.Visible = true;



                panel.Size = new Size(400, 185);

                panel.Location = new Point(50, separacion);
                panel.Visible = true;
                panel.BorderStyle = BorderStyle.FixedSingle;
                pImagen.Location = new Point(40, panel.Height / 2 - pImagen.Height / 2);



                TextBox descripcion = new TextBox();
                descripcion.Text = newsDescription;
                descripcion.BorderStyle = BorderStyle.None;
                descripcion.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                descripcion.Location = new Point(240, 60);
                descripcion.Multiline = true;
                descripcion.Name = "tDescripcion";
                descripcion.ReadOnly = true;
                descripcion.Size = new Size(400,100);//Size(panel.Width / 2, panel.Height / 2); //685,59
                descripcion.TabIndex = 2;
                descripcion.Visible = true;



                panel.Controls.Add(ltitulo);
                panel.Controls.Add(pImagen);
                panel.Controls.Add(tFecha);
                panel.Controls.Add(descripcion);
                pNoticias.Controls.Add(panel);
                separacion += 180;

                //Separación inferior dentro del panel de noticias
                if(i == nNoticias - 1)
                {
                    PictureBox pSep = new PictureBox();
                    pSep.Location = new Point(50, separacion);
                    pSep.Size = new Size(panel.Width, 50);
                    pNoticias.Controls.Add(pSep);
                }
            }

            pNoticias.BorderStyle = BorderStyle.FixedSingle;
            pNoticias.Size = new Size(800, 640);//Size(this.menuFlowLayoutPanel.Width*3/4, 640); //1265,640
        }
        #endregion

        #region Logica del Form
        private void lSignOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Principal inicio = new Principal(null);
            inicio.Show();
            this.Close();
        }

        private void linitSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Inicio init = new Inicio();
            init.ShowDialog();
            this.Usuario = Inicio.usuario;
            actualizar();
            this.ActiveControl = bInicio;
        }

        private void linkGesUsers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ListaUsuariosAplicacion usuarios = new ListaUsuariosAplicacion();
            usuarios.ShowDialog();
        }

        private void bInfo_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Informacion inf = new Informacion(usuario);
            inf.Show();
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

        protected void ltitulo_click(object sender, EventArgs e)
        {
            LinkLabel link = sender as LinkLabel;
            // identify which button was clicked and perform necessary actions
            var aux = link.Name;
            var id = Int32.Parse(link.Name);
            News nw = new News(id);

            Cursor.Current = Cursors.WaitCursor;
            InfoNoticia iNoticia = new InfoNoticia(nw,usuario);
            this.Visible = false;
            iNoticia.Owner = this;
            iNoticia.ShowDialog();
            if (!this.isClosed)
            {
                actualizar();

                this.Close();

            }
            usuario = iNoticia.Usuario;
        }

        private void bCrearNoticia_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CrearNoticia cNoticia = new CrearNoticia(usuario);
            cNoticia.Show();
            this.Close();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            isClosed = true;
        }

        private void mcEventos_DateSelected(object sender, DateRangeEventArgs e)
        {
                string dia = mcEventos.SelectionStart.ToString().Substring(0, mcEventos.SelectionStart.ToString().Count() - 8);
                string res = "";
                int i = 1;
                foreach (Event evento in this.eventos)
                {
                string date = evento.Date;
                    if (dia.Equals(date))
                    {
                        if (this.usuario == null)
                        {
                            res = res + i + ") " + (evento.EsCurso ? "Curso" : "Actividad") + ": " + evento.EventName + "\n";
                        }
                        else
                        {
                        if (this.eventosInscritos.Contains(evento.ID))
                            {
                                res = res + i + ") " + (evento.EsCurso ? "Curso" : "Actividad") + ": " + evento.EventName + " (INSCRITO)\n";
                            }
                            else
                            {
                                res = res + i +  ") " + (evento.EsCurso ? "Curso" : "Actividad") + ": " + evento.EventName + " (NO INSCRITO)\n";
                            }
                        }
                        i++;
                    }
                }
                if (res == "")
                {
                    MessageBox.Show("No existe ningún evento programado para este día.");
                }
                else
                {
                    MessageBox.Show(res);
                }
        }

        #endregion

        #region GUIs
        
        private void actualizarElementos()
        {
            panel1.Width = this.Width;
            actualizarBotones();
            actualizarImagenes();
            actualizarPanelNoticias();
            mcEventos.ShowTodayCircle = false;
            mcEventos.MaxSelectionCount = 1;
            mcEventos.Location = new Point(pASM.Location.X,pNoticias.Location.Y);
            lNoticias.Location = new Point(pNoticias.Location.X+pNoticias.Width/2-lNoticias.Text.Length*6,pNoticias.Location.Y-50);
            lCalendario.Location = new Point(pASM.Location.X + 32, pNoticias.Location.Y - 30);
            this.lUsername.Location = new Point((int)(this.Width * 1.2) / 10, lUsername.Location.Y);
            this.lSignOut.Location = new Point(lUsername.Location.X, lSignOut.Location.Y + 7);
            this.linkGesUsers.Location = new Point(lUsername.Location.X + lSignOut.Width + 10, lSignOut.Location.Y);
            this.pUser.Location = new Point(lUsername.Location.X - pUser.Width - 15, pUser.Location.Y);
            actualizarPanelPerfil();
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
            this.bCrearNoticia.Location = new Point(this.Width*7/10+mcEventos.Width/2-bCrearNoticia.Width/2,
              this.pNoticias.Location.Y + mcEventos.Height + 20);
        }



        public void actualizar()
        {
            pintarCalendario();
            if (usuario == null)
            {
                linitSesion.Visible = true;
                pUser.Visible = false;
                lUsername.Visible = false;
                lSignOut.Visible = false;
                pPerfil.Visible = false;
                bCrearNoticia.Visible = false;
                linkGesUsers.Visible = false;
            }
            else
            {
                eventosInscritos = Event.listaIdEventosUsuario(this.usuario);

                linitSesion.Visible = false;
                if (FTPClient.ftpOn)
                {
                    try
                    {
                        FTPClient ftp = new FTPClient("ftp://25.35.182.85:12975/usuarios/" + usuario.Id + "/", "Prueba", "");
                        pUser.Image = ftp.DownloadPngAsImage("image.png", pUser.Size);
                    }
                    catch (Exception)
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

                if (usuario.Rol.Admin == 1)
                {
                    bCrearNoticia.Visible = true;
                    linkGesUsers.Visible = true;
                }
                else
                {
                    bCrearNoticia.Visible = false;
                    linkGesUsers.Visible = false;
                }
            }
        }

        private void actualizarPanelNoticias()
        {
            pNoticias.Width = (this.menuFlowLayoutPanel.Width*3)/5;
            pNoticias.Height = (this.Height * 6) / 10;
            pNoticias.Location = new Point(this.menuFlowLayoutPanel.Location.X+50, this.menuFlowLayoutPanel.Location.Y + 100);
        }

        private void actualizarPanelPerfil()
        {
            pPerfil.Location = new Point(pUser.Location.X, pUser.Location.Y + pUser.Height - 10);
        }

        private void actualizarNoticias()
        {
            foreach (Control c in pNoticias.Controls)
            {
                c.Width = pNoticias.Width - 120;
            }
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
            panel1.Controls.Add(lNoticias);
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
            actualizarElementos();
        }

        private void pNoticias_Resize(object sender, EventArgs e)
        {
            actualizarNoticias();
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
            frame.ShowDialog();
            usuario = frame.Usuario;
            actualizar();
        }

        private void pintarCalendario()
        {
                DateTime[] dates = new DateTime[eventos.Count];
                int i = 0;
                foreach (Event evento in this.eventos)
                {
                    dates[i] = DateTime.Parse(evento.Date);
                    i++;
                }
                mcEventos.BoldedDates = dates;
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
