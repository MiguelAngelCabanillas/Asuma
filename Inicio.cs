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
        public Inicio()
        {
            InitializeComponent();
        }

        private void bInicio_Click(object sender, EventArgs e)
        {
            string usuario = tUser.Text;
            string password = tPassword.Text;
            BD bd = new BD();
            MySqlDataReader reader = bd.Query("SELECT password from user where username ='" + usuario + "'");
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (password.Equals((string)reader[0]))
                    {
                        tCheck.Checked = true;
                    }
                }
            }
        }

        private void bRegistrarse_Click(object sender, EventArgs e)
        {
            Registro reg = new Registro();
            this.Visible = false;
            reg.ShowDialog();
            this.Visible = true;
        }
    }
}
