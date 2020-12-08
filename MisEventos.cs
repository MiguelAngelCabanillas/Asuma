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
    public partial class MisEventos : Form
    {
        public MisEventos()
        {
            InitializeComponent();
        }

        private void MisEventos_Load(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            this.menuFlowLayoutPanel.Width = this.Width-25;
            this.bNoticias.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bEventos.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bInfo.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            this.bContacto.Width = this.menuFlowLayoutPanel.Width / 4 - 10;
            
        }

        private void pLogo_Paint(object sender, PaintEventArgs e)
        {
            this.pLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pLogo.Location = new Point(this.Width/2 - pLogo.Width/2,30);
        }

        private void pUser_Paint(object sender, PaintEventArgs e)
        {
            this.pUser.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void bMisEventos_Paint(object sender, PaintEventArgs e)
        {
            this.bMisEventos.Location = new Point(25,this.Height-100);
        }

        private void bCrearEvento_Paint(object sender, PaintEventArgs e)
        {
            this.bCrearEvento.Location = new Point(this.Width - 150, this.Height - 100);
        }

        private void MisEventos_Paint(object sender, PaintEventArgs e)
        {
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }
    }
}
