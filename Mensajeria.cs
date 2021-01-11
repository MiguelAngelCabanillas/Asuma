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
    public partial class Mensajeria : Form
    {
        private User usuario;
        private string seleccionado = "";
        private System.Timers.Timer timer;

        public Mensajeria(User usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            cargarDataGrid();            
        }

        public void cargarDataGrid()
        {
           // string select = "(SELECT COUNT(t.username) from ((SELECT u.username FROM conversation c LEFT JOIN `user` u ON u.id = c.user2 WHERE c.user1 = 1) UNION (SELECT u1.username FROM conversation c1 LEFT JOIN `user` u1 ON u1.id = c1.user1 WHERE c1.user2 = 1)) t);";

            BD bd = new BD();
            //select = "(SELECT u.username FROM conversation c LEFT JOIN `user` u ON u.id = c.user2 WHERE c.user1 = 1) UNION (SELECT u.username FROM conversation c LEFT JOIN `user` u ON u.id = c.user1 WHERE c.user2 = 1);";
            string select = "SELECT * FROM ((SELECT u.username, m.message, m.id, m.conversation FROM conversation c LEFT JOIN `user` u ON u.id = c.user2 LEFT JOIN privateMessages m ON c.id = m.conversation WHERE c.user1 = " + usuario.Id + ") UNION (SELECT u.username, m.message, m.id, m.conversation  FROM conversation c LEFT JOIN `user` u ON u.id = c.user1 LEFT JOIN privateMessages m ON c.id = m.conversation WHERE c.user2 = " + usuario.Id + ")) t WHERE t.id IN (SELECT MAX(id) FROM privateMessages c WHERE c.conversation = t.conversation) OR t.id IS NULL;";
                //"SELECT t.username, t.message FROM ((SELECT u.username, m.message, m.id, m.conversation FROM conversation c LEFT JOIN `user` u ON u.id = c.user2 LEFT JOIN privateMessages m ON c.id = m.conversation WHERE c.user1 = 1 GROUP BY m.conversation) UNION (SELECT u.username, m.message, m.id, m.conversation FROM conversation c LEFT JOIN `user` u ON u.id = c.user1 LEFT JOIN privateMessages m ON c.id = m.conversationWHERE c.user2 = 1 GROUP BY m.conversation)) t;";
            MySqlDataReader reader2 = bd.Query(select);

            if (!reader2.HasRows)
            {
        
                dataGridView1.DataSource = null;
                return;

            }
            
            List<Struct> usuarios = new List<Struct>();
            Struct st;
            String str;
            while(reader2.Read())
            {
                try
                {
                    if(reader2.IsDBNull(1)){
                        str = "";
                    } else {
                        str = (string)reader2[1];
                    }

                    st = new Struct((string)reader2[0], str);
                    usuarios.Add(st);
                } catch(Exception ex){
                    MessageBox.Show(ex.Message);
                }
                
            }
            var result = usuarios.Select(s => new { Nombre = s.nombre, Mensaje = s.mensaje }).ToList();
            dataGridView1.DataSource = result;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private partial class Struct
        {
            public string nombre;
            public string mensaje;

            public Struct(string nombre, string mensaje) { this.nombre = nombre; this.mensaje = mensaje; }
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

        private void bBorrar_Click(object sender, EventArgs e)
        {
            if (seleccionado == "")
            {
                MessageBox.Show("Seleccione una conversación para borrar");
            }
            else
            {
                int userid = Commons.GetUserIdByName(seleccionado);
                BD bd = new BD();
                bd.Query("DELETE FROM conversation WHERE (user1 = " + userid + " AND user2 = " + usuario.Id + ") OR (user2 = " + userid + " AND user1 = " + usuario.Id + ");");
                MessageBox.Show("Conversación eliminada");
                cargarDataGrid();
                seleccionado = "";
                dataGridView1.ClearSelection();

            }
        }

        private void bAcceder_Click(object sender, EventArgs e)
        {
            if (seleccionado == "") MessageBox.Show("Selecciona antes un chat");
            else
            {
               //int userid = Commons.GetUserIdByName(seleccionado);
               Conversaciones conv = new Conversaciones(seleccionado, usuario);
               conv.Owner = this;
               this.Visible = false;
               conv.ShowDialog();
               cargarDataGrid();
               this.Visible = true;

            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ListaUsuarios lUs = new ListaUsuarios(usuario);
            lUs.Owner = this;
            this.Visible = false;
            lUs.ShowDialog();
            cargarDataGrid();
            this.Visible = true;
        }

        private void Mensajeria_Shown(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == null)
            {
                timer = new System.Timers.Timer(200);
                timer.Elapsed += timer_Tick;
                timer.AutoReset = false;
                timer.Enabled = true;
                
            }
        }

        void timer_Tick(object sender, EventArgs e)
        {
            this.BeginInvoke((Action)(() => MessageBox.Show("No tienes conversaciones abiertas")));
            timer.Enabled = false;
        }
    }

    
}
