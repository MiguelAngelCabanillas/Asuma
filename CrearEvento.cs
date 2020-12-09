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
    public partial class CrearEvento : Form
    {
        private User usuario;
        public CrearEvento(User usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            tDescription.AutoSize = false;
            tDescription.Height = 80;
            pImage.Visible = false;
        }

        private void menuFlowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {
            this.menuFlowLayoutPanel.Width = this.Width - 25;
            this.bNoticias.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bEventos.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bInfo.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bContacto.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(cIncludeImage.Checked == true)
            {
                pImage.Visible = true;
            }
            else
            {
                pImage.Visible = false;
            }
        }
    }
}
