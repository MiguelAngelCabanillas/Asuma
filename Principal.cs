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
            Inicio init = new Inicio(this);
            this.Visible = false;
            init.ShowDialog();
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
                lSesionIniciada.Visible = false;
            }
            else
            {
                linitSesion.Visible = false;
                lSesionIniciada.Visible = true;
            }
        }

        private void lSesionIniciada_Click(object sender, EventArgs e)
        {

        }
    }
}
