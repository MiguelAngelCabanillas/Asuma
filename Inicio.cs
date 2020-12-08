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
    public partial class Inicio : Form
    {
        private Principal pr;
        public Inicio(Principal pr)
        {
            InitializeComponent();
            this.pr = pr;
        }

        private void bInicio_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = tUser.Text;
                string password = tPassword.Text;
                User user = new User(usuario, password);
                pr.Usuario = user;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }

        private void bRegistrarse_Click(object sender, EventArgs e)
        {
            Registro reg = new Registro();
            this.Visible = false;
            reg.ShowDialog();
            this.Visible = true;
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
