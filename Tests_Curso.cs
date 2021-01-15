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
    public partial class Tests_Curso : Form
    {
        Event evento;
        public Tests_Curso(Event evento)
        {
            InitializeComponent();
            AñadirTestsRealizados(evento);
            this.evento = evento;
        }

        private void AñadirTestsRealizados(Event evento)
        {
            String username;
            try
            {
                BD bd = new BD();
                MySqlDataReader reader = bd.Query("SELECT nombre FROM resultsTest WHERE evento = " + evento.ID + ";");
                while (reader.Read())
                {
                    username = (String)reader[0];
                    LB_Tests.Items.Add("Test de " + username);
                }
                reader.Close();
                bd.closeBD();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void bVisualizar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            String selected = (String)LB_Tests.SelectedItem;
            String username = selected.Replace("Test de ", "");
            String idsP, respuestasUsuario;
            try
            {
                BD bd = new BD();
                MySqlDataReader reader = bd.Query("SELECT idsP, respuestasUsuario, user FROM resultsTest WHERE nombre = '" + username + "';");
                reader.Read();
                idsP = (String)reader[0];
                respuestasUsuario = (String)reader[1];
                reader.Close();
                bd.closeBD();
            }
            catch (Exception e1)
            {
                throw new Error(e1.Message);
            }
            Test resultadoTest = new Test(evento, new User(username), idsP, respuestasUsuario);
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            this.Close();
        }

        private void Tests_Curso_Load(object sender, EventArgs e)
        {
            try
            {
                BD bd = new BD();
                MySqlDataReader reader = bd.Query("SELECT nombre FROM resultsTest WHERE evento = " + evento.ID + ";");
                if (reader.HasRows)
                {
                    bVisualizar.Enabled = true;
                }
                reader.Close();
                bd.closeBD();
            }
            catch (Exception)
            {

            }
        }
    }
}
