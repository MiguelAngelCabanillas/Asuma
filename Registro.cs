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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }


        private void lUsername_Click(object sender, EventArgs e)
        {

        }

        private void cUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cUserType.Text.Equals("Usuario"))
            {
                lCode.Visible = true;
                tCode.Visible = true;
            }
            else
            {
                lCode.Visible = false;
                tCode.Visible = false;
            }
        }
    }
}
