using System;
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
    public partial class Principal : Form
    {
        private User usuario;
        public Principal(User user)
        {
            this.usuario = user;
            InitializeComponent();
            actualizar();
            
        }


        private void linitSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Inicio init = new Inicio();
            this.Visible = false;
            init.ShowDialog();
            this.Usuario = Inicio.usuario;
            actualizar();
            this.Visible = true;
        }

        public User Usuario
        {
            get{ return this.usuario; }
            set{ this.usuario = value;}
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

        private void lSignOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Se puede hacer que cierre solo sesion y siga en la plataforma
            usuario = null;
            this.Close();
        }

        private void menuFlowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {
            this.menuFlowLayoutPanel.Width = this.Width - 25;
            this.bNoticias.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bEventos.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bInfo.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bContacto.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
        }

        private void bEventos_Click(object sender, EventArgs e)
        {

                Eventos ev = new Eventos(usuario);
                this.Visible = false;
                ev.ShowDialog();
                this.Visible = true;
        }
    }
}
