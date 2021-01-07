using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.Windows.Forms;

namespace Asuma
{
    public partial class Surveys_Evento : Form
    {
        Event evento;
        public Surveys_Evento(Event evento)
        {
            InitializeComponent();
            this.evento = evento;
            añadirIDCuestionarios();
        }

        private void añadirIDCuestionarios()
        {
            int idSurvey;                   
            try
            {
                BD bd = new BD();
                MySqlDataReader reader = bd.Query("SELECT id FROM survey WHERE eventID = " + evento.ID + ";");
                while (reader.Read())
                {
                    idSurvey = (int)reader[0];
                    LB_Surveys.Items.Add("Cuestionario " + idSurvey);
                }              
                reader.Close();
                bd.closeBD();

            }
            catch (Exception e)
            {
                throw new Error(e.Message);
            }
        }

        private void bVisualizar_Click(object sender, EventArgs e)
        {
            String selected = (String)LB_Surveys.SelectedItem;
            int idS = int.Parse(selected.Replace("Cuestionario ", ""));
            String q1, q7;
            int q2, q3, q4, q5, q6;
            try
            {
                BD bd = new BD();
                MySqlDataReader reader = bd.Query("SELECT q1, q2, q3, q4, q5, q6, q7 FROM survey WHERE id = " + idS + ";");
                reader.Read();
                q1 = (String)reader[0];
                q2 = (int)reader[1];
                q3 = (int)reader[2];
                q4 = (int)reader[3];
                q5 = (int)reader[4];
                q6 = (int)reader[5];
                q7 = (String)reader[6];
                reader.Close();
                bd.closeBD();

            }
            catch (Exception e2)
            {
                throw new Error(e2.Message);
            }
            Cuestionario_Satisfaccion cuestionario = new Cuestionario_Satisfaccion(q1, q2, q3, q4, q5, q6, q7, evento);
            cuestionario.ShowDialog();
        }

        public static bool EncuestaRealizada(int idUser)
        {
            bool res = false;
            try
            {
                BD bd = new BD();
                MySqlDataReader reader = bd.Query("SELECT id FROM survey WHERE userID = " + idUser + ";");
                reader.Read();
                if (reader.HasRows) res = true;
                reader.Close();
                bd.closeBD();

            }
            catch (Exception e2)
            {
                throw new Error(e2.Message);
            }
            return res;
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
