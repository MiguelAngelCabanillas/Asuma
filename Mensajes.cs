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
        public Mensajes(User usuario, int temaID, string titulo)
        {
            this.usuario = usuario;
            this.temaID = temaID;
            this.titulo = titulo.ToUpper();
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
                    string autor = user.ToUpper() + " dice:";
                    string nuevo = mensaje /*+ " (" + date + ")"*/;
                    string fecha = "(" + date + ")";
                    lbMensajes.Items.Add(autor);
                    if (nuevo.Length > 70)
                    {
                        for (int i = 0; i < nuevo.Length; i += 70)
                        {
                            nuevo = nuevo.Insert(i, "º");
                            i++;
                        }
                        string[] split = nuevo.Split('º');
                        int j = 0;
                        foreach (string s in split)
                        {
                            if (j != 0)
                            {
                                lbMensajes.Items.Add(s);
                            }
                            j++;
                        }
                    }
                    else
                    {
                        lbMensajes.Items.Add(nuevo);
                    }
                    lbMensajes.Items.Add(fecha);
                    lbMensajes.Items.Add(" ");
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
                    lbMensajes.Items.Clear();
                    actualizarMensajes();
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
