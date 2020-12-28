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
                ltitulo.Font = new Font("Microsoft Sans Serif", 19.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
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
                tFecha.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
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
                descripcion.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
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
            //Se puede hacer que cierre solo sesion y siga en la plataforma
            Environment.Exit(Environment.ExitCode);
        }

        private void bEventos_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Eventos ev = new Eventos(usuario);
            ev.Owner = this;
            ev.ShowDialog();
            this.Close();
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
                //this.Visible = true;
                this.Close();
                /*pNoticias.Controls.Clear();
                mostrarNoticias();
                actualizarPanelNoticias();*/
            }
            usuario = iNoticia.Usuario;
            /*actualizar();
            this.Visible = true;*/
        }

        private void bCrearNoticia_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CrearNoticia cNoticia = new CrearNoticia(usuario);
            cNoticia.Owner = this;

            this.Visible = false;
            cNoticia.ShowDialog();
            if (!this.isClosed)
            {
                actualizar();
                actualizarPanelNoticias();
                this.Visible = true;
            }
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            isClosed = true;
        }

        private void mcEventos_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (this.usuario == null)
            {
                MessageBox.Show("Debe registrarse para visualizar sus eventos.");
            }
            else
            {
                List<Event> eventos = Event.listaEventosUsuario(this.usuario);
                if (eventos.Count == 0)
                {
                    MessageBox.Show("No se encuentra inscrito en ningún evento.");
                }
                else
                {
                    string dia = mcEventos.SelectionStart.ToString().Substring(0, mcEventos.SelectionStart.ToString().Count() - 8);
                    string res = "";
                    foreach (Event evento in eventos)
                    {
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
        
        private void actualizarElementos()
        {
            panel1.Width = this.Width;
            actualizarBotones();
            actualizarImagenes();
            actualizarPanelNoticias();
            mcEventos.Location = new Point(pASM.Location.X,pNoticias.Location.Y);
            lNoticias.Location = new Point(pNoticias.Location.X+pNoticias.Width/2-lNoticias.Text.Length*6,pNoticias.Location.Y-50);
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
                bCrearNoticia.Visible = false;
            }
            else
            {
                pintarCalendario();
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
                        FTPClient.ftpOn = false;
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
                }
                else
                {
                    bCrearNoticia.Visible = false;
                }
            }
        }

        private void actualizarPanelNoticias()
        {
            pNoticias.Width = (this.menuFlowLayoutPanel.Width*3)/5;
            pNoticias.Height = (this.Height * 6) / 10;
            pNoticias.Location = new Point(this.menuFlowLayoutPanel.Location.X+50, this.menuFlowLayoutPanel.Location.Y + 100);
        }

        private void actualizarNoticias()
        {
            foreach (Control c in pNoticias.Controls)
            {
                c.Width = pNoticias.Width - 120;
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
            frame.Owner = this;
            this.Visible = false;
            frame.ShowDialog();
            usuario = Inicio.usuario;
            actualizar();
            this.Visible = true;
        }

        private void pintarCalendario()
        {
            if (this.usuario != null)
            {
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

        private void bMensajes_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
