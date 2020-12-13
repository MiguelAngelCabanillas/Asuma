using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using System.Resources;
using System.IO;

namespace Asuma
{
    public partial class Eventos : Form
    {
        private User usuario;
        public Eventos(User usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            actualizar();
            panelEventos.SendToBack();
            mostrarEventos();
        }
        private void bMyEvents_Click(object sender, EventArgs e)
        {
            if (usuario == null)
            {
                MessageBox.Show("Debe iniciar sesión para mostrar sus eventos");
            }
            else
            {
                MisEventos misEventos = new MisEventos(usuario);
                misEventos.Show();
                this.Close();
            }
        }

        public void actualizar()
        {
            if (usuario == null)
            {
                linitSesion.Visible = true;
                pUser.Visible = false;
                lUsername.Visible = false;
                lSignOut.Visible = false;
            }
            else
            {
                linitSesion.Visible = false;
                pUser.Visible = true;
                lUsername.Text = "Bienvenido " + usuario.Username;
                lUsername.Visible = true;
                lSignOut.Visible = true;
            }
        }

        private void linitSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Inicio init = new Inicio();
            this.Visible = false;
            init.ShowDialog();
            this.usuario = Inicio.usuario;
            actualizar();
            this.Visible = true;
        }

        private void lSignOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        public void mostrarEventos()
        {
            panelEventos.Controls.Clear();
            List<Event> listaEventos = Event.listaEventos();
            int nEventos = listaEventos.Count;
            int separacion = 50;

            for (int i = 0; i < nEventos; i++)
            {

                string eventName = listaEventos.ElementAt(i).EventName;
                string eventDate = listaEventos.ElementAt(i).Date;
                string eventDescription = listaEventos.ElementAt(i).EventDescription;
                string imagen = listaEventos.ElementAt(i).Image;
                int id = listaEventos.ElementAt(i).ID;

                Panel panel = new Panel();
                panel.Name = "pEvento" + id;

                //------------------

                LinkLabel ltitulo = new LinkLabel();
                ltitulo.Text = eventName;
                ltitulo.Size = new Size(292, 38);
                ltitulo.AutoSize = true;
                ltitulo.Font = new Font("Microsoft Sans Serif", 19.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                ltitulo.LinkColor = Color.Black;
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
                Image image = Image.FromFile(imagePath);
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
        private void actualizarBotones()
        {
            this.menuFlowLayoutPanel.Width = this.Width - 25;
            this.bInicio.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bEventos.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bInfo.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bContacto.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
        }
        private void actualizarImagenes()
        {
            lSignOut.Location = new Point(lUsername.Location.X, lUsername.Location.Y + 40);
            linitSesion.Location = new Point(lUsername.Location.X, lUsername.Location.Y);

            int tamaño = this.Width;
            this.pASUMA.Location = new Point((tamaño * 4) / 10, pASUMA.Location.Y);
            this.pASM.Location = new Point((tamaño * 7) / 10, pASM.Location.Y);
        }

        private void actualizarBotonMisEventos()
        {
            bMyEvents.Location = new Point((this.Width * 5) / 10, (int)((this.Height * 8.5) / 10));
        }

        private void actualizarPanelEventos()
        {
            panelEventos.Width = menuFlowLayoutPanel.Width - 40;
            panelEventos.Height = (this.Height * 6) / 10;
            panelEventos.Location = new Point(this.Width/2 - panelEventos.Width/2, this.menuFlowLayoutPanel.Location.Y + 50);
        }

        private void actualizarEventos()
        {         
            foreach (Control c in panelEventos.Controls)
            {
                c.Width = panelEventos.Width - 120;
            }
        }

        protected void ltitulo_click(object sender, EventArgs e)
        {
            LinkLabel link = sender as LinkLabel;
            // identify which button was clicked and perform necessary actions
            var id = Int32.Parse(link.Name);
            Event ev = new Event(id);

            if (usuario == null) {
                Cursor.Current = Cursors.WaitCursor;
                InfoEvento infoEvento = new InfoEvento(ev,null);
                this.Visible = false;
                infoEvento.ShowDialog();
                this.Visible = true;
            } else {
                Boolean found = false;
                BD bd = new BD();
                MySqlDataReader reader = bd.Query("SELECT idEvent FROM inscription WHERE userName = '" + this.usuario.Username + "';");
                if (reader.HasRows) {
                    while (reader.Read() && !found)
                    {
                        int idEvent = (int)reader[0];
                        if (idEvent == ev.ID)
                        {
                            found = true;
                            Cursor.Current = Cursors.WaitCursor;
                            InfoEventoInscrito infoEvento = new InfoEventoInscrito(ev, this.usuario);
                            this.Visible = false;
                            infoEvento.ShowDialog();
                            this.Visible = true;
                        }
                    }
                    if (!found)
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        InfoEvento infoEvento = new InfoEvento(ev, this.usuario);
                        this.Visible = false;
                        infoEvento.ShowDialog();
                        this.Visible = true;
                    }
                } else {
                    Cursor.Current = Cursors.WaitCursor;
                    InfoEvento infoEvento = new InfoEvento(ev, this.usuario);
                    this.Visible = false;
                    infoEvento.ShowDialog();
                    this.Visible = true;
                }
            }
        }

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

        private void Eventos_Resize(object sender, EventArgs e)
        {
            actualizarBotones();
            actualizarImagenes();
            actualizarBotonMisEventos();
            actualizarPanelEventos();
        }

        private void panelEventos_Resize(object sender, EventArgs e)
        {
            actualizarEventos();
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
            //mostrarEventos();
            //actualizarEventos();
        }
    }
}