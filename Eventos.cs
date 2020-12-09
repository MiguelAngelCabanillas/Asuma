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
    public partial class Eventos : Form
    {
        private User usuario;
        public Eventos(User usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
