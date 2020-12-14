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
    public partial class MisEventos : Form
    {
        private User usuario;
        public MisEventos(User usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
            lUsername.Text = "Bienvenido " + usuario.Username;
            if (!usuario.Rol.RolName.Equals("Docente"))
            {
                bCreateEvent.Visible = false;
            }
            else
            {
                bCreateEvent.Visible = true;
            }
            mostrarEventos();
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


        public void mostrarEventos()
        {
            List<Event> listaEventos = Event.listaEventosUsuario(usuario);
            List<int> listaCreados = Event.listaEventosCreados(usuario);
            int nEventos = listaEventos.Count;
            int separacion = 50;
            Event aux;
            for (int i = 0; i < nEventos; i++)
            {
                aux = listaEventos.ElementAt(i);
                /*
                string eventName = listaEventos.ElementAt(i).EventName;
                string eventDate = listaEventos.ElementAt(i).Date;
                string eventDescription = listaEventos.ElementAt(i).EventDescription;
                string imagen = listaEventos.ElementAt(i).Image;
                int id = listaEventos.ElementAt(i).ID;
                */
                string eventName = aux.EventName;
                string eventDate = aux.Date;
                string eventDescription = aux.EventDescription;
                string imagen = aux.Image;
                int id = aux.ID;

                Panel panel = new Panel();
                panel.Name = "pEvento" + id;

                //------------------
                
                LinkLabel ltitulo = new LinkLabel();
                ltitulo.Text = eventName;
                ltitulo.Size = new Size(292, 38);
                ltitulo.AutoSize = true;
                ltitulo.Font = new Font("Microsoft Sans Serif", 19.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                if (listaCreados.Contains(aux.ID))
                {
                    ltitulo.LinkColor = Color.Red;
                }
                else
                {
                    ltitulo.LinkColor = Color.Black;
                }
                ltitulo.Location = new Point(230, 18);
                ltitulo.Name = id.ToString();
                ltitulo.TabIndex = 31;
                ltitulo.TabStop = true;
                ltitulo.Visible = true;
                ltitulo.Click += new EventHandler(ltitulo_click);

                //------------------


                PictureBox pImagen = new PictureBox();
                pImagen.BackColor = SystemColors.ActiveCaption;
                pImagen.Location = new Point(59, 28);
                pImagen.Name = "pImagen";

                string path = Path.GetDirectoryName(Application.StartupPath);
                string pathBueno = path.Substring(0, path.Length - 3);
                string imagePath = pathBueno + "images\\" + imagen;
                Image image;
                if (FTPClient.ftpOn)
                {
                    try
                    {
                        FTPClient ftpClient = new FTPClient("ftp://25.35.182.85:12975/eventos/" + listaEventos.ElementAt(i).EventName + "/", "Prueba", "");
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

                pImagen.Image = image;
                pImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                pImagen.Size = new Size(115, 127);
                pImagen.TabIndex = 0;
                pImagen.TabStop = false;
                pImagen.Visible = true;
                pImagen.BorderStyle = BorderStyle.FixedSingle;


                TextBox tFecha = new TextBox();
                tFecha.Text = "Fecha del evento: " + eventDate;
                tFecha.BorderStyle = BorderStyle.None;
                tFecha.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                tFecha.Location = new Point(900, 145);
                tFecha.Multiline = true;
                tFecha.Name = "tFecha";
                tFecha.ReadOnly = true;
                tFecha.Size = new Size(216, 24);
                tFecha.TabIndex = 32;
                tFecha.Visible = true;



                panel.Size = new Size(1142, 186); //1142 186

                panel.Location = new Point(50, separacion);
                panel.Visible = true;
                panel.BorderStyle = BorderStyle.FixedSingle;


                TextBox descripcion = new TextBox();
                descripcion.Text = eventDescription;
                descripcion.BorderStyle = BorderStyle.None;
                descripcion.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                descripcion.Location = new Point(233, 68);
                descripcion.Multiline = true;
                descripcion.Name = "tDescripcion";
                descripcion.ReadOnly = true;
                descripcion.Size = new Size(panel.Width / 2, panel.Height / 2); //685,59
                descripcion.TabIndex = 2;
                descripcion.Visible = true;

                panel.Controls.Add(ltitulo);
                panel.Controls.Add(pImagen);
                panel.Controls.Add(tFecha);
                panel.Controls.Add(descripcion);
                panelEventos.Controls.Add(panel);
                separacion += 180;
            }

            panelEventos.BorderStyle = BorderStyle.FixedSingle;
            panelEventos.Size = new Size(1265, 640);
        }

        protected void ltitulo_click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            LinkLabel link = sender as LinkLabel;
            // identify which button was clicked and perform necessary actions
            var id = Int32.Parse(link.Name);
           
            Event ev = new Event(id);
            /*
           InfoEventoInscrito infoEventoInscrito = new InfoEventoInscrito(ev, usuario);
           infoEventoInscrito.Show();
           this.Close();
           */

            InfoEventoInscrito infoEventoInscrito = new InfoEventoInscrito(ev, usuario);
            this.Visible = false;
            infoEventoInscrito.ShowDialog();
            this.Visible = true;
        }

        private void menuFlowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {
            lSignOut.Location = new Point(lUsername.Location.X, lUsername.Location.Y + 40);

            this.menuFlowLayoutPanel.Location = new Point(15, menuFlowLayoutPanel.Location.Y);
            this.menuFlowLayoutPanel.Width = this.Width - 25;
            this.bInicio.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bEventos.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bInfo.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bContacto.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
        }

        private void bCreateEvent_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CrearEvento crearEvento = new CrearEvento(usuario);
            /*
            crearEvento.Show();
            this.Close();           
            */

            this.Visible = false;
            crearEvento.ShowDialog();
            this.Visible = true;

            

        }

        private void MisEventos_Resize(object sender, EventArgs e)
        {
            actualizarElementos();
        }

        private void actualizarElementos()
        {
            this.menuFlowLayoutPanel.Width = this.Width - 25;
            this.bInicio.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bEventos.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bInfo.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bContacto.Width = this.menuFlowLayoutPanel.Width / 4 - 10;

            this.pASUMA.Location = new Point((this.Width * 4) / 10, pASUMA.Location.Y);
            this.pASM.Location = new Point((this.Width * 7) / 10, pASM.Location.Y);

            panelEventos.Width = menuFlowLayoutPanel.Width - 40;
            panelEventos.Height = (this.Height * 6) / 10;
            panelEventos.Location = new Point(this.Width / 2 - panelEventos.Width / 2, this.menuFlowLayoutPanel.Location.Y + 50);

            foreach (Control c in panelEventos.Controls)
            {
                c.Width = panelEventos.Width - 120;
            }

            bCreateEvent.Location = new Point(((this.Width * 5) / 10)-bCreateEvent.Width/2, (int)((this.Height * 8.5) / 10));
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
            this.Visible = false;
        }

        private void bEventos_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Eventos ev = new Eventos(usuario);
            ev.Show();
            this.Visible = false;
        }
    }
}
