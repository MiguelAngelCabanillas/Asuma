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
    public partial class CambiarPassword : Form
    {
        private User usuarioACambiar;
        public CambiarPassword(User usuario)
        {
            InitializeComponent();
            usuarioACambiar = usuario;
        }

        private void bChange_Click(object sender, EventArgs e)
        {
            string password = tPassword.Text;
            string repeatedPassword = tRepeatedPassword.Text;
            if (password.Equals(repeatedPassword))
            {
                usuarioACambiar.Password = tPassword.Text;
                MessageBox.Show("Contraseña cambiada con exito");
                this.Close();
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden");
                this.tPassword.Text = "";
                this.tRepeatedPassword.Text = "";
            }
        }

        private void cShow_CheckedChanged(object sender, EventArgs e)
        {
            if (cShow.Checked)
            {
                this.tRepeatedPassword.PasswordChar = '\0';
                this.tPassword.PasswordChar = '\0';
            }
            else
            {
                this.tRepeatedPassword.PasswordChar = '*';
                this.tPassword.PasswordChar = '*';
            }
        }
    }
}
