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
        public Test(int idEvento)
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
                MySqlDataReader reader = bd.Query("SELECT nombre, respuestas, respuestasCorrectas, idPregunta FROM preguntas WHERE test = "+idEvento+";");
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
            Test_Conocimiento testC = new Test_Conocimiento(nombrePreguntas, listaRespuestas, respuestasCorrectas, seleccionMultiple);
            testC.ShowDialog();
        }

        public Test(int idEvento, SortedDictionary<int, String> nombrePreguntas,
                                 SortedDictionary<int, String[]> listaRespuestas,
                                 SortedDictionary<int, List<string>> respuestasCorrectas)
        {
            try
            {
                BD bd = new BD();
                //Se crea el test con el idEvento
                MySqlDataReader writer = bd.Query("INSERT INTO test VALUES(" + idEvento + ")");
                writer.Read();
                writer.Close();

                foreach (var nombreQ in nombrePreguntas)
                {
                    String nombreRespuestas = "";
                    String resCorrectas = "";
                    int idP = nombreQ.Key;
                    String nombrePregunta = nombreQ.Value;              
                    listaRespuestas.TryGetValue(idP, out String[] respuestas);

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

                    respuestasCorrectas.TryGetValue(idP, out List<string> correctas);

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

                    MySqlDataReader writer2 = bd.Query("INSERT INTO preguntas VALUES("+idEvento+", '"+ nombrePregunta +"', '"+ nombreRespuestas +"', '"+ resCorrectas +"', "+ idP  +");");
                    writer2.Read();
                    writer2.Close();
                }
                bd.closeBD();
            }
            catch (Exception e2)
            {

                throw new Error(e2.Message);
            }
        }
    }
}
