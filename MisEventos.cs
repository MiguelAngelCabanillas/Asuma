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
            int separacion = 100;
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
                ltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                if (listaCreados.Contains(aux.ID))
                {
                    ltitulo.LinkColor = System.Drawing.Color.Red;
                }
                else
                {
                    ltitulo.LinkColor = System.Drawing.Color.Black;
                }
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
                string pathBueno = path.Substring(0, path.Length - 3);
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

                panel.Location = new Point(18, separacion);
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
                descripcion.Size = new System.Drawing.Size(panel.Width / 2, panel.Height / 2); //685,59
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

        private void menuFlowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {
            this.menuFlowLayoutPanel.Width = this.Width - 25;
            this.bNoticias.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bEventos.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bInfo.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bContacto.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
        }
    }
}
