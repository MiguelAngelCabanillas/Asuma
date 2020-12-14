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
            añadirAlPanel();
            this.ActiveControl = bInicio;
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
        }

        private void actualizarImagenes() {
            int tamaño = this.Width;
            this.pASUMA.Location = new Point((tamaño * 4)/10, pASUMA.Location.Y);
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
            Environment.Exit(Environment.ExitCode);
        }

        private void bEventos_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Eventos ev = new Eventos(usuario);
            ev.Show();
            this.Visible = false;
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
            panel1.Width = this.Width;
            actualizarBotones();
            actualizarImagenes();
        }
    }
}
