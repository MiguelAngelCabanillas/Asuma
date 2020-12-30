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
    public partial class Conversaciones : Form
    {
        User usuario;
        int idConv;
        int idUsuario;
        int numMensajes = 0;

        public Conversaciones(int id, User usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            idUsuario = id;
            loadConversation();

        }

        private void loadConversation()
        {
            BD bd = new BD();
            MySqlDataReader reader = bd.Query("SELECT p.id, u.username, p.message, p.date, c.id  FROM (conversation c LEFT JOIN privateMessages p ON c.id = p.conversation) LEFT JOIN `user` u ON p.`user` = u.id WHERE (user1 = " + idUsuario + " AND user2 = " + usuario.Id + ") OR (user2 = " + idUsuario + " AND user1 = " + usuario.Id + ") ORDER BY p.id ASC;");

            if (!reader.HasRows) 
            {
                reader.Close();
                MySqlDataReader reader2 = bd.Query("SELECT c.id FROM conversation c LEFT JOIN privateMessages p ON c.id = p.conversation WHERE (user1 = " + idUsuario + " AND user2 = " + usuario.Id + ") OR (user2 = " + idUsuario + " AND user1 = " + usuario.Id + ")");
                reader2.Read();
                idConv = (int)reader2[0];
                bd.closeBD();
            }
            else
            {
                
                tConversacion.Text = "";
                while (reader.Read())
                {
                    idConv = (int)reader[4];
                    if (!reader.IsDBNull(2))
                    {
                        tConversacion.AppendText((string)reader[3] + @"  |  " + (string)reader[1] + ": " + (string)reader[2] + Environment.NewLine + Environment.NewLine);
                        numMensajes++;
                    }
                } 
                
            }
            reader.Close();
            bd.closeBD();
        }

        private void bEnviar_Click(object sender, EventArgs e)
        {
                BD bd = new BD();
                MySqlDataReader writer = bd.Query("INSERT INTO privateMessages VALUES (" + idConv + ", " + numMensajes + ", " + usuario.Id + ", '" + tEnviar.Text + "', '" + DateTime.Now.ToString() + "');");
                numMensajes = 0;
                writer.Close();
                bd.closeBD();
                loadConversation();
                tEnviar.Text = "";
            
        }

        private void tEnviar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                bEnviar.PerformClick();
            }
        }
    }
}
