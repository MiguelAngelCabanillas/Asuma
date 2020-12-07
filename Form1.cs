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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bInicio_Click(object sender, EventArgs e)
        {
            string usuario = tUser.Text;
            string password = tPassword.Text;
            BD bd = new BD();
            MySqlDataReader reader = bd.Query("SELECT username, password from usuarios where username ='" + usuario + "'");
            while (reader.Read())
            {
                if(usuario.Equals((string)reader[0]) && password.Equals((string)reader[1]))
                {
                    tCheck.Checked = true;
                }
            }


        }
    }
}
