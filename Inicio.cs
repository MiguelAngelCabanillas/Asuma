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
        public static User usuario = null;
        public Inicio()
        {
            InitializeComponent();
        }

        private void bInicio_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = tUser.Text;
                string password = tPassword.Text;
                User user = new User(usuario, password);
                Inicio.usuario = user;
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

        public static User getUsuario()
        {
            return usuario;
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
           // panel1.Location = new Point(this.Width/2 - panel1.Width/2, this.Height/2 - panel1.Height/2);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //panel1.Location = new Point(this.Width / 2 - panel1.Width / 2, this.Height / 2 - panel1.Height / 2);
        }

        private void Inicio_Resize(object sender, EventArgs e)
        {
            panel1.Location = new Point(this.Width / 2 - panel1.Width / 2, this.Height / 2 - panel1.Height / 2);
        }
    }
}
