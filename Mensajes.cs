using MySqlConnector;
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
    public partial class Mensajes : Form
    {
        private User usuario;
        private int temaID;
        private string titulo;
        private int horizontalExtent;
        public Mensajes(User usuario, int temaID, string titulo)
        {
            this.usuario = usuario;
            this.temaID = temaID;
            this.titulo = titulo.ToUpper();
            this.horizontalExtent = 0;
            InitializeComponent();
        }

        private void Mensajes_Load(object sender, EventArgs e)
        {
            actualizarMensajes();
        }

        public void actualizarMensajes()
        {
            try
            {
                BD bd = new BD();
                MySqlDataReader reader = bd.Query("SELECT m.username, m.text, m.date FROM message m WHERE m.topicID = " + this.temaID + ";");
                while (reader.Read())
                {
                    string user = (string)reader[0];
                    string mensaje = (string)reader[1];
                    string date = (string)reader[2];
                    string nuevo = "> " + date + @"  |  " + user + ": " + mensaje + Environment.NewLine + Environment.NewLine;
                    if (nuevo.Length > this.horizontalExtent)
                    {
                        lbMensajes.HorizontalExtent = nuevo.Length + mensaje.Length * 8;
                        this.horizontalExtent = nuevo.Length + mensaje.Length * 8;
                    }
                    lbMensajes.Items.Add(nuevo);
                }
                reader.Close();
                bd.closeBD();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void enviarMensaje()
        {
            try
            {
                if (tbMensaje.Text.Equals(""))
                {
                    MessageBox.Show("Introduzca un mensaje.");
                }
                else
                {
                    BD bd = new BD();
                    string date = DateTime.Now.ToString();
                    MySqlDataReader reader = bd.Query("INSERT INTO message (username, topicID, text, date) VALUES ('" + this.usuario.Username + "', " + this.temaID + ", '" + tbMensaje.Text + "', '" + date + "');");
                    reader.Read();
                    reader.Close();
                    bd.closeBD();
                    string mensaje = "> " + date + @"  |  " + usuario.Username + ": " + tbMensaje.Text + Environment.NewLine + Environment.NewLine;
                    if (mensaje.Length > this.horizontalExtent)
                    {
                        lbMensajes.HorizontalExtent = mensaje.Length + mensaje.Length * 8;
                        this.horizontalExtent = mensaje.Length + mensaje.Length * 8;
                    }
                    lbMensajes.Items.Add(mensaje);
                    tbMensaje.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bEnviar_Click(object sender, EventArgs e)
        {
            enviarMensaje();
        }

        private void tbMensaje_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                enviarMensaje();
            }
        }

        private void label1_Paint(object sender, PaintEventArgs e)
        {
            label1.Text = "TEMA: " + this.titulo;
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
