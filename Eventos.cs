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
                MessageBox.Show("Si eres USUARIO");
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
            int separacion = 20;

            for (int i = 0; i < nEventos; i++)
            {
                //reader.Read();
                //string eventName = (string)reader[0];
                //string eventDate = (string)reader[1];
                //string eventDescription = (string)reader[2];

                Panel panel = new Panel();

                TextBox tDescripcion = new TextBox();
                //tDescripcion.Text = eventDescription;
                tDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
                tDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                tDescripcion.Location = new System.Drawing.Point(233, 78);
                tDescripcion.Multiline = true;
                tDescripcion.Name = "tDescripcion";
                tDescripcion.ReadOnly = true;
                tDescripcion.Size = new System.Drawing.Size(685, 59);
                tDescripcion.TabIndex = 2;

                LinkLabel ltitulo = new LinkLabel();
                //ltitulo.Text = eventName;
                ltitulo.Size = new Size(292, 38);
                ltitulo.Location = new Point(230, 28);
                ltitulo.AutoSize = true;
                ltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                ltitulo.LinkColor = System.Drawing.Color.Black;
                ltitulo.Location = new System.Drawing.Point(230, 28);
                ltitulo.Name = "linkLabel1";
                ltitulo.Size = new System.Drawing.Size(292, 38);
                ltitulo.TabIndex = 31;
                ltitulo.TabStop = true;
                ltitulo.Text = "Reparto de comida";
                ltitulo.Visible = false;

                PictureBox pImagen = new PictureBox();
                pImagen.BackColor = System.Drawing.SystemColors.ActiveCaption;
                pImagen.Location = new System.Drawing.Point(59, 28);
                pImagen.Name = "pImagen";
                pImagen.Size = new System.Drawing.Size(115, 127);
                pImagen.TabIndex = 0;
                pImagen.TabStop = false;

                TextBox tFecha = new TextBox();
                //tFecha.Text = eventDate;
                tFecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
                tFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                tFecha.Location = new System.Drawing.Point(233, 159);
                tFecha.Multiline = true;
                tFecha.Name = "tFecha";
                tFecha.ReadOnly = true;
                tFecha.Size = new System.Drawing.Size(216, 24);
                tFecha.TabIndex = 32;

                panelEventos.Controls.Add(panel);
                panel.Size = new Size(1142, 186);
                panel.Location = new Point(18, separacion);
                panel.Controls.Add(tDescripcion);
                panel.Controls.Add(ltitulo);
                panel.Controls.Add(pImagen);
                panel.Controls.Add(tFecha);

                separacion += 20;
            }

        }
    }
}
