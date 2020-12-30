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
    public partial class ListaUsuarios : Form
    {
        User usuario;
        string seleccionado = "";

        public ListaUsuarios(User usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            cargarDatagrid();
        }

        private void cargarDatagrid()
        {
            BD bd = new BD();
            MySqlDataReader reader = bd.Query("SELECT username FROM `user` WHERE id != " + usuario.Id);
            if (!reader.HasRows) { MessageBox.Show("No se han encontrado más usuarios en la plataforma..."); }
            else
            {
                List<string> str = new List<string>();
                while (reader.Read())
                {
                    str.Add((string)reader[0]);
                }
                var result = str.Select(s => new { Nombre = s }).ToList();
                dataGridView1.DataSource = result;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }   
        }

        private void bCrear_Click(object sender, EventArgs e)
        {
            if (seleccionado != "") { 
                int id = 0;
                int idUser = Commons.GetUserIdByName(seleccionado);
                BD bd = new BD();
                MySqlDataReader reader3 = bd.Query("SELECT * FROM conversation WHERE (user1 = " + usuario.Id + " AND user2 = " + idUser + ") OR (user2 = " + usuario.Id + " AND user1 = " + idUser + ");");
                if (reader3.HasRows)
                {
                    MessageBox.Show("Ya existe una conversación abierta con esa persona");
                    reader3.Close();
                }
                else
                {
                    reader3.Close();
                    MySqlDataReader reader = bd.Query("SELECT MAX(id) FROM conversation");
                    if (!reader.HasRows) { }
                    else
                    {
                        reader.Read();
                        id = (int)reader[0] + 1;
                        reader.Close();
                        MySqlDataReader writer = bd.Query("INSERT INTO conversation VALUES (" + id + ", " + usuario.Id + ", " + idUser + ");");
                        writer.Close();
                        bd.closeBD();
                        this.Close();
                    }
                }
            }
                
            else
            {
                MessageBox.Show("Selecciona un usuario para crear una conversación");
            } 
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    seleccionado = (string)dataGridView1.SelectedRows[0].Cells[0].Value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message);
                }
            }
        }


    }
}
