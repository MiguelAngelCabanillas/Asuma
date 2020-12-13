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
    public partial class InfoEventoInscrito : Form
    {
        private Event evento;
        private User usuario;
        public InfoEventoInscrito(Event e, User u)
        {
            this.evento = e;
            this.usuario = u;
            InitializeComponent();
            lUsername.Text = "Bienvenido " + usuario.Username;
            if (e.EventCreator.Equals(u.Username)){
                bEditEvent.Visible = true;
            }
            else
            {
                bEditEvent.Visible = false;
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

        private void menuFlowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {
            actualizarBotones();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lSignOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void bEditEvent_Click(object sender, EventArgs e)
        {
            EditarEvento editarEvento = new EditarEvento(evento);
            this.Visible = false;
            editarEvento.ShowDialog();
            this.Visible = true;
        }

        private void actualizarBotones()
        {
            this.menuFlowLayoutPanel.Width = this.Width - 40;
            this.bNoticias.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bEventos.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bInfo.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bContacto.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
        }

        private void actualizarImagenes()
        {
            int tamaño = this.Width;
            this.pASUMA.Location = new Point((tamaño * 4) / 10, pASUMA.Location.Y);
            this.pASM.Location = new Point((tamaño * 7) / 10, pASM.Location.Y);
            this.lSignOut.Location = new Point((tamaño * 3) / 10, lSignOut.Location.Y);
            this.pEvento.Location = new Point((tamaño * 2) / 10, pEvento.Location.Y);
        }

        private void actualizarLabels()
        {
            int anchura = this.Width;
            int altura = this.Height;
            this.lTitulo.Location = new Point((int)((anchura * 4.5) / 10), lTitulo.Location.Y);
            this.tDes.Location = new Point((int)((anchura * 4.5) / 10), tDes.Location.Y);
            this.lOrg.Location = new Point((anchura * 2) / 10, lOrg.Location.Y);
            this.lFec.Location = new Point((anchura * 2) / 10, lFec.Location.Y);
            this.lOrganizadores.Location = new Point(lOrg.Location.X + lOrg.Width + 20, lOrganizadores.Location.Y);
            this.lFecha.Location = new Point(lFec.Location.X + lFec.Width + 20, lFecha.Location.Y);
            this.bEditEvent.Location = new Point((anchura * 2) / 10, bEditEvent.Location.Y);
            this.bExit.Location = new Point((int)(anchura * 8.8) / 10, (int)(altura * 8.5) / 10);
        }

        private void InfoEventoInscrito_Resize(object sender, EventArgs e)
        {
            actualizarBotones();
            actualizarImagenes();
            actualizarLabels();
        }
    }
}
