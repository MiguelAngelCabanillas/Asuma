using System;
using MySqlConnector;
using System.Windows.Forms;

namespace Asuma
{
    public partial class FormForo : Form
    {
        private Forum foro;
        private User usuario;
        public FormForo(Forum foro, User usuario)
        {
            this.foro = foro;
            this.usuario = usuario;
            InitializeComponent();
        }

        private void Foro_Load(object sender, EventArgs e)
        {
            actualizarTemas();
            lTitulo.Text = foro.evento.EventName;
            if (!usuario.Username.Equals(foro.evento.EventCreator))
            {
                bEliminar.Enabled = false;
                bEliminar.Visible = false;
            }
            else
            {
                bEliminar.Enabled = true;
                bEliminar.Visible = true;
            }
        }

        private void bAñadirTema_Click(object sender, EventArgs e)
        {
            try
            {
                string cad = tituloTema.Text.Trim();
                if (cad != "")
                {
                    string cmd = cad;
                    listaTemas.Items.Add(cmd);
                    Tema tema = new Tema(foro, cad, foro.evento.EventCreator);
                }
                else
                {
                    MessageBox.Show("Necesita añadir un titulo al tema");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            /*
            object selec = listaTemas.SelectedItem;
            listaTemas.Items.Remove(selec);
            string title = (string)selec;
            BD bd = new BD();
            MySqlDataReader writer = bd.Query("DELETE FROM topic WHERE title = '" + title + "'");
            */
        }

        public void actualizarTemas()
        {
            BD bd = new BD();
            MySqlDataReader reader = bd.Query("SELECT title FROM topic WHERE forumID = " + this.foro.ID);
            while (reader.Read())
            {
                listaTemas.Items.Add((string)reader[0]);
            }
            reader.Close();
            bd.closeBD();
        }

        private void listaTemas_DoubleClick(object sender, EventArgs e)
        {
            BD bd = new BD();
            MySqlDataReader reader = bd.Query("SELECT t.topicID FROM topic t WHERE t.title = '" + listaTemas.SelectedItem.ToString() + "' AND t.forumID = " + this.foro.ID + ";");
            reader.Read();
            int temaID = ((int)reader[0]);
            reader.Close();
            bd.closeBD();
            Mensajes mensajes = new Mensajes(this.usuario, temaID, listaTemas.SelectedItem.ToString());
            mensajes.ShowDialog();
        }
    }
}
