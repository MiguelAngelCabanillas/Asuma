using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace Asuma
{
    class Test
    {
        public Test(Event Evento, User Usuario)
        {
            SortedDictionary<int, String> nombrePreguntas = new SortedDictionary<int, string>();
            SortedDictionary< int, String[]> listaRespuestas = new SortedDictionary<int, string[]>();
            SortedDictionary<int, List<string>> respuestasCorrectas = new SortedDictionary<int, List<string>>();
            Boolean seleccionMultiple = false;
            int idP;
            String nombreP;
            String resline;
            String resCorrectLine;
            String[] respuestas;
            List<String> resCorrectas;
            try
            {
                BD bd = new BD();
                MySqlDataReader reader = bd.Query("SELECT nombre, respuestas, respuestasCorrectas, idPregunta FROM preguntas WHERE test = "+ Evento.ID +";");
                while (reader.Read())
                {
                    //ID y el nombre de la pregunta
                    idP = (int)reader[3];
                    nombreP = (String)reader[0];
                    nombrePreguntas.Add(idP, nombreP);

                    //ID y respuestas de la pregunta
                    resline = (String)reader[1];
                    respuestas = resline.Split('|');
                    listaRespuestas.Add(idP, respuestas);

                    //ID y la respuesta o respuestas correctas a la pregunta
                    resCorrectLine = (String)reader[2];
                    resCorrectas = resCorrectLine.Split('|').ToList();
                    //Compruebo si es seleccion multiple al tener mas de una respuesta correcta
                    if (resCorrectas.Count > 1) seleccionMultiple = true;
                    respuestasCorrectas.Add(idP, resCorrectas);
                }
                reader.Close();
                bd.closeBD();
            }
            catch (Exception e)
            {
                throw new Error(e.Message);
            }
            Test_Conocimiento testC = new Test_Conocimiento(nombrePreguntas, listaRespuestas, respuestasCorrectas, seleccionMultiple, Evento, Usuario);
            testC.ShowDialog();
        }

        public Test(int idEvento, SortedDictionary<int, String> nombrePreguntas,
                                 SortedDictionary<int, String[]> listaRespuestas,
                                 SortedDictionary<int, List<string>> respuestasCorrectas)
        {
            try
            {
                BD bd = new BD();
                //Si existe el test lo eliminamos para volver a crearlo
                if (selecIDTest(idEvento))
                {
                    MySqlDataReader writer2 = bd.Query("DELETE FROM preguntas WHERE test = "+ idEvento +";");
                    writer2.Read();
                    writer2.Close();
                    writer2 = bd.Query("DELETE FROM resultsTest WHERE evento = "+ idEvento +"");
                    writer2.Read();
                    writer2.Close();
                }
                else
                {
                    //Se crea el test con el idEvento
                    MySqlDataReader writer = bd.Query("INSERT INTO test VALUES(" + idEvento + ")");
                    writer.Read();
                    writer.Close();
                }

                foreach (var nombreQ in nombrePreguntas)
                {
                    int idP = nombreQ.Key;
                    String nombrePregunta = nombreQ.Value;

                    listaRespuestas.TryGetValue(idP, out String[] respuestas);
                    String nombreRespuestas = seleccionarRespuestas(respuestas);

                    respuestasCorrectas.TryGetValue(idP, out List<string> correctas);
                    String resCorrectas = seleccionarRespuestasCorrectas(correctas);

                    MySqlDataReader writer3 = bd.Query("INSERT INTO preguntas VALUES(" + idEvento + ", '" + nombrePregunta + "', '" + nombreRespuestas + "', '" + resCorrectas + "', " + idP + ");");
                    writer3.Read();
                    writer3.Close();
                }
                bd.closeBD();               
            }
            catch (Exception e2)
            {
                throw new Error(e2.Message);
            }

            string seleccionarRespuestas(string[] respuestas)
            {
                string nombreRespuestas = "";

                for (int i = 0; i < respuestas.Length; i++)
                {
                    //Respuesta0|Respuesta1|Respuesta2
                    if (i == respuestas.Length - 1)
                    {
                        nombreRespuestas += respuestas[i];
                    }
                    else
                    {
                        nombreRespuestas += respuestas[i] + "|";
                    }
                }

                return nombreRespuestas;
            }
        }

        public Test(Event Evento, User Usuario, string idsP, string respuestasUsuario)
        {
            SortedDictionary<int, String> nombrePreguntas = new SortedDictionary<int, string>();
            SortedDictionary<int, String[]> listaRespuestas = new SortedDictionary<int, string[]>();
            SortedDictionary<int, List<string>> respuestasCorrectas = new SortedDictionary<int, List<string>>();
            Boolean seleccionMultiple = false;
            int idP;
            String nombreP;
            String resline;
            String resCorrectLine;
            String[] respuestas;
            List<String> resCorrectas;
            try
            {
                BD bd = new BD();
                MySqlDataReader reader = bd.Query("SELECT nombre, respuestas, respuestasCorrectas, idPregunta FROM preguntas WHERE test = " + Evento.ID + ";");
                while (reader.Read())
                {
                    //ID y el nombre de la pregunta
                    idP = (int)reader[3];
                    nombreP = (String)reader[0];
                    nombrePreguntas.Add(idP, nombreP);

                    //ID y respuestas de la pregunta
                    resline = (String)reader[1];
                    respuestas = resline.Split('|');
                    listaRespuestas.Add(idP, respuestas);

                    //ID y la respuesta o respuestas correctas a la pregunta
                    resCorrectLine = (String)reader[2];
                    resCorrectas = resCorrectLine.Split('|').ToList();
                    //Compruebo si es seleccion multiple al tener mas de una respuesta correcta
                    if (resCorrectas.Count > 1) seleccionMultiple = true;
                    respuestasCorrectas.Add(idP, resCorrectas);
                }
                reader.Close();
                bd.closeBD();
            }
            catch (Exception e)
            {
                throw new Error(e.Message);
            }
            Test_Conocimiento testC = new Test_Conocimiento(nombrePreguntas, listaRespuestas, respuestasCorrectas, seleccionMultiple, Evento, Usuario, idsP, respuestasUsuario);
            testC.ShowDialog();
        }

        private static string seleccionarRespuestasCorrectas(List<string> correctas)
        {
            String resCorrectas = "";
            foreach (var res in correctas)
            {
                //ResCorrecta0|ResCorrecta1
                if (correctas.Last().Equals(res))
                {
                    resCorrectas += res;
                }
                else
                {
                    resCorrectas += res + "|";
                }
            }

            return resCorrectas;
        }

        private Boolean selecIDTest(int idEvent)
        {
            Boolean res = false;
            try
            {
                BD bd = new BD();
                MySqlDataReader reader = bd.Query("SELECT testID FROM test WHERE testID = "+ idEvent + ";");
                reader.Read();
                if (reader.HasRows)
                {
                    res = true;
                }
                else
                {
                    res = false;
                }
                reader.Close();
                bd.closeBD();
            }
            catch (Exception e3)
            {

                throw new Error(e3.Message);
            }
            return res;
        }
        public static void SubmitAprobado(Event e, User u, String idsP, String respuestasUsuario)
        {
            try
            {
                BD bd = new BD();
                MySqlDataReader writer = bd.Query("INSERT INTO resultsTest VALUES("+ e.ID +", "+ u.Id +", '"+ u.Username +"', 1, '"+ idsP +"', '"+ respuestasUsuario +"')");
                writer.Read();
                writer.Close();
                bd.closeBD();
            }
            catch (Exception e4)
            {
                throw new Error(e4.Message);
            }
        }

        public static Boolean testAprobado(Event e, User u)
        {
            //En la base de datos solo se guardan aprobados
            Boolean aprobado = false;
            try
            {
                BD bd = new BD();
                MySqlDataReader reader = bd.Query("SELECT * FROM resultsTest WHERE evento = "+ e.ID +" AND user = "+ u.Id +";");
                reader.Read();
                if (reader.HasRows) aprobado = true;
                reader.Close();
                bd.closeBD();
            }
            catch (Exception e4)
            {
                throw new Error(e4.Message);
            }
            return aprobado;
        }

        public static Boolean testCreado(Event e)
        {
            Boolean creado = false;
            try
            {
                BD bd = new BD();
                MySqlDataReader reader = bd.Query("SELECT * FROM test WHERE testID = " + e.ID + ";");
                reader.Read();
                if (reader.HasRows) creado = true;
                reader.Close();
                bd.closeBD();
            }
            catch (Exception ex)
            {
                throw new Error(ex.Message);
            }
            return creado;
        }
    }
}
