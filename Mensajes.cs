﻿using MySqlConnector;
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
                    lbMensajes.Items.Add("> " + user + ": " + mensaje + " (" + date + ")");
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
                    lbMensajes.Items.Add("> " + this.usuario.Username + ": " + tbMensaje.Text + " (" + date + ")");
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
    }
}
