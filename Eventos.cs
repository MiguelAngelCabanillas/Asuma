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
        private User usuario = null;
        public Eventos(User usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            actualizar();
            panelEventos.SendToBack();
            mostrarEventos();
        }

        private void menuFlowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {
            this.menuFlowLayoutPanel.Width = this.Width - 25;
            this.bNoticias.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bEventos.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bInfo.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bContacto.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
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
                this.Visible = false;
                misEventos.ShowDialog();
                this.Visible = true;
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
            Inicio init = new Inicio();
            this.Visible = false;
            init.ShowDialog();
            this.usuario = Inicio.usuario;
            actualizar();
            this.Visible = true;
        }

        private void lSignOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void mostrarEventos()
        {
            List<Event> listaEventos = Event.listaEventos();
            int nEventos = listaEventos.Count;
            int separacion = 100;

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
                ltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                ltitulo.LinkColor = System.Drawing.Color.Black;
                ltitulo.Location = new System.Drawing.Point(230, 18);
                ltitulo.Name = id.ToString(); 
                ltitulo.TabIndex = 31;
                ltitulo.TabStop = true;
                ltitulo.Visible = true;
                ltitulo.Click += new EventHandler(ltitulo_click);
               
                //------------------


                PictureBox pImagen = new PictureBox();
                pImagen.BackColor = System.Drawing.SystemColors.ActiveCaption;
                pImagen.Location = new System.Drawing.Point(59, 28);
                pImagen.Name = "pImagen";
                string path = Path.GetDirectoryName(Application.StartupPath);
                string pathBueno = path.Substring(0,path.Length - 3);
                string imagePath = pathBueno + "images\\" + imagen;
                Image image = Image.FromFile(imagePath);
                pImagen.Image = image;
                pImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                pImagen.Size = new System.Drawing.Size(115, 127);
                pImagen.TabIndex = 0;
                pImagen.TabStop = false;
                pImagen.Visible = true;


                TextBox tFecha = new TextBox();
                tFecha.Text = "Fecha del evento: " + eventDate;
                tFecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
                tFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                tFecha.Location = new System.Drawing.Point(900, 145);
                tFecha.Multiline = true;
                tFecha.Name = "tFecha";
                tFecha.ReadOnly = true;
                tFecha.Size = new System.Drawing.Size(216, 24);
                tFecha.TabIndex = 32;
                tFecha.Visible = true;



                panel.Size = new Size(1142, 186); //1142 186

                panel.Location = new Point(18,separacion);
                panel.Visible = true;
                panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;


                TextBox descripcion = new TextBox();
                descripcion.Text = eventDescription;
                descripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                descripcion.Location = new System.Drawing.Point(233, 68);
                descripcion.Multiline = true;
                descripcion.Name = "tDescripcion";
                descripcion.ReadOnly = true;
                descripcion.Size = new System.Drawing.Size(panel.Width/2, panel.Height/2); //685,59
                descripcion.TabIndex = 2;
                descripcion.Visible = true;



                panel.Controls.Add(ltitulo);
                panel.Controls.Add(pImagen);
                panel.Controls.Add(tFecha);
                panel.Controls.Add(descripcion);
                panelEventos.Controls.Add(panel);
                panelEventos.Size = new Size(1300, 640);
                panelEventos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

                separacion += 300;
            }

        }
        protected void ltitulo_click(object sender, EventArgs e)
        {
            LinkLabel link = sender as LinkLabel;
            // identify which button was clicked and perform necessary actions
            var id = Int32.Parse(link.Name);
            Event ev = new Event(id);
            InfoEvento infoEvento = new InfoEvento(ev, usuario);
            this.Visible = false;
            infoEvento.ShowDialog();
            this.Visible = true;
        }




    }
}
