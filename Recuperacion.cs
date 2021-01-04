using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asuma
{
    public partial class Recuperacion: Form
    {
        private Stopwatch watch = new Stopwatch();
        private string username;
        private string email;
        private string token;
        public Recuperacion()
        {
            InitializeComponent();
            this.username = null;
            this.email = null;
            this.token = null;
            lRecoverInfo.Visible = false;
            tRecover.Visible = false;
            bRecover.Visible = false;
            bRecover.Enabled = false;

        }

        private void bSend_Click(object sender, EventArgs e)
        {
            string nombreUsuario = tUsername.Text;
            string correo = tEmail.Text;

            if (nombreUsuario.Trim().Equals("") || correo.Trim().Equals(""))
            {
                MessageBox.Show("Debe introducir los datos");
                tRecover.Text = "";
                lRecoverInfo.Visible = false;
                tRecover.Visible = false;
                bRecover.Visible = false;
                bRecover.Enabled = false;
                this.username = null;
                this.email = null;
                this.token = null;
            }
            else
            {
                try
                {
                    if (User.buscarUsuarioRecuperacion(tUsername.Text, tEmail.Text))
                    {
                        this.username = nombreUsuario;
                        this.email = correo;
                        Email email = new Email();
                        string token = Guid.NewGuid().ToString();
                        this.token = token;
                        User.insertarToken(nombreUsuario, correo, token);
                        email.sendEmailRecoverPassword(correo, token);
                        MessageBox.Show("Mensaje de recuperación enviado");
                        watch.Start();
                        timer.Enabled = true;
                        bSend.Enabled = false;
                        //timer.Start();
                        lRecoverInfo.Visible = true;
                        tRecover.Visible = true;
                        bRecover.Visible = true;
                        bRecover.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("No existe ningún usuario con los datos introducidos");
                        tRecover.Text = "";
                        lRecoverInfo.Visible = false;
                        tRecover.Visible = false;
                        bRecover.Visible = false;
                        bRecover.Enabled = false;
                        this.username = null;
                        this.email = null;
                        this.token = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 0, (int)watch.Elapsed.Seconds);
            int segundos = ts.Seconds;
            int tiempoRestante = 10 - segundos;
            if (tiempoRestante == -1)
            {
                watch.Reset();
               // timer.Stop();
                timer.Enabled = false;
                bSend.Text = "Enviar mensaje";
                bSend.Enabled = true;
            }
            else
            {
                bSend.Text = tiempoRestante.ToString();
            }
        }

        private void bRecover_Click(object sender, EventArgs e)
        {
            string token = tRecover.Text;

            if (this.token.Equals(token))
            {
                MessageBox.Show("Token correcto");
                User user = new User(username);
                CambiarPassword cp = new CambiarPassword(user);
                cp.Show();

            }
            else
            {
                MessageBox.Show("Token introducido incorrecto");
            }


        }
    }
}
