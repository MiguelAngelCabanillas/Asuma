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
    public partial class Test_Conocimiento : Form
    {
        SortedDictionary<int, String> nombrePreguntas;
        SortedDictionary<int, String[]> listaRespuestas;
        SortedDictionary<int, CheckedListBox> Respuestas_Resultado;
        SortedDictionary<int, Label> Label_Resultado;
        SortedDictionary<int, List<String>> respuestasCorrectas;
        Boolean seleccionMultiple;
        Event evento;
        User usuario;
        public Test_Conocimiento(SortedDictionary<int, String> nombrePreguntas,
                                 SortedDictionary<int, String[]> listaRespuestas,
                                 SortedDictionary<int, List<string>> respuestasCorrectas,
                                 Boolean seleccionMultiple, Event evento, User usuario)
        {
            this.nombrePreguntas = nombrePreguntas;
            this.listaRespuestas = listaRespuestas;
            this.seleccionMultiple = seleccionMultiple;
            this.respuestasCorrectas = respuestasCorrectas;
            this.Respuestas_Resultado = new SortedDictionary<int, CheckedListBox>();
            this.Label_Resultado = new SortedDictionary<int, Label>();
            this.evento = evento;
            this.usuario = usuario;

            InitializeComponent();
            mostrarPreguntasyRespuestas();
        }

        public Test_Conocimiento(SortedDictionary<int, string> nombrePreguntas,
                                 SortedDictionary<int, string[]> listaRespuestas,
                                 SortedDictionary<int, List<string>> respuestasCorrectas,
                                 bool seleccionMultiple, Event evento, User usuario,
                                 string idsP, string respuestasUsuario)
        : this(nombrePreguntas, listaRespuestas, respuestasCorrectas, seleccionMultiple,
              evento, usuario)
        {
            ReadOnly(idsP, respuestasUsuario);
        }

        private void ReadOnly(string idsP, string respuestasUsuario)
        {
            String[] idPregunta = idsP.Split('_');
            String[] respuestasAllPreguntas = respuestasUsuario.Split('_');
            String[] resP;
            int i = 0;
            int idP;
            foreach (var item in Respuestas_Resultado)
            {
                idP = int.Parse(idPregunta[i]);
                Respuestas_Resultado.TryGetValue(idP, out CheckedListBox aux);
                //La ultima es la cadena vacia
                if (i < respuestasAllPreguntas.Length - 1)
                {
                    resP = respuestasAllPreguntas[i].Split('|');
                    for (int j = 0; j < resP.Length; j++)
                    {
                        //La ultima es la cadena vacia
                        if (j < resP.Length - 1)
                        {
                            aux.SetItemChecked(int.Parse(resP[j]), true);
                        }
                    }
                }               
                aux.Enabled = false;
                i++;
            }
            bEnviar.Enabled = false;
            bEnviar.Visible = false;
            Boolean readOnly = true;
            Check(readOnly);
        }

        private void mostrarPreguntasyRespuestas()
        {
            lNameCurso.Text = evento.EventName;

            panelPregyRes.Controls.Clear();
            int numPreg = nombrePreguntas.Count;
            int separacion = 50;

            KeyValuePair<int, String> aux;
            int id_Pregunta;
            String nombrePregunta;
            String[] respuestas;

            for (int i = 0; i < numPreg; i++)
            {
                aux = nombrePreguntas.ElementAt(i);
                id_Pregunta = aux.Key;
                nombrePregunta = aux.Value;
                listaRespuestas.TryGetValue(id_Pregunta, out respuestas);

                Panel panel = new Panel();
                panel.Name = "pPregunta" + id_Pregunta;

                //------------------

                Label Pregunta = new Label();
                Pregunta.Name = "P" + id_Pregunta;
                Pregunta.Text = nombrePregunta;
                Pregunta.AutoSize = true;
                Pregunta.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                Pregunta.Location = new Point(13, 13);
                Pregunta.Size = new Size(98, 18);
                Pregunta.TabIndex = 2;

                //------------------

                CheckedListBox respuestasPregunta = new CheckedListBox { Name = "CLB" + id_Pregunta};
                respuestasPregunta.Items.AddRange(respuestas);
                respuestasPregunta.BorderStyle = BorderStyle.FixedSingle;
                respuestasPregunta.CheckOnClick = true;
                respuestasPregunta.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                respuestasPregunta.FormattingEnabled = true;
                respuestasPregunta.Location = new Point(16, 40);
                respuestasPregunta.Size = new Size(510, 87);
                respuestasPregunta.TabIndex = 3;
                if (!seleccionMultiple)
                {
                    respuestasPregunta.ItemCheck += new ItemCheckEventHandler(checkedListBox_ItemCheck);
                }

                //------------------

                Label ResPregunta = new Label();
                ResPregunta.Name = "Res" + id_Pregunta;
                ResPregunta.AutoSize = true;
                ResPregunta.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                ResPregunta.Location = new Point(578, 60);
                ResPregunta.Size = new Size(84, 25);
                ResPregunta.TabIndex = 9;
                ResPregunta.Text = "";

                //------------------

                panel.Size = new Size(790, 161); //1142 186
                panel.Location = new Point(16, separacion);
                panel.Visible = true;
                panel.BorderStyle = BorderStyle.FixedSingle;

                panel.Controls.Add(Pregunta);
                panel.Controls.Add(respuestasPregunta);
                panel.Controls.Add(ResPregunta);
                panelPregyRes.Controls.Add(panel);
                separacion += 180;

                lAprobadoRO.Visible = false;

                Respuestas_Resultado.Add(id_Pregunta, respuestasPregunta);
                Label_Resultado.Add(id_Pregunta, ResPregunta);
            }
        }
        private Boolean Check(Boolean readOnly)
        {
            int res = 0;
            Boolean aprobado = false;
            int id_P;
            foreach (var item in Respuestas_Resultado)
            {
                id_P = item.Key;
                respuestasCorrectas.TryGetValue(id_P, out List<string> respuestasC);
                int cont = 0;
                foreach (var aux in respuestasC)
                {
                    if (item.Value.CheckedItems.Contains(aux))
                    {
                        cont++;
                    }
                }
                Label_Resultado.TryGetValue(id_P, out Label labelRes);
                //Tienes que acertar la mitad de las respuestas para que sea correcta la pregunta
                //NO TENGO GANAS DE PENSAR PERO TIENE QUE HABER UNA MANERA MEJOR DE HACER ESTO
                if (respuestasC.Count % 2 == 0) //Par
                {
                    if (cont >= respuestasC.Count / 2)
                    {
                        labelRes.Text = "Correcta";
                        res++;
                    }
                    else
                    {
                        labelRes.Text = "Incorrecta";
                    }
                }
                else
                {
                    if (cont > respuestasC.Count / 2)
                    {
                        labelRes.Text = "Correcta";
                        res++;
                    }
                    else
                    {
                        labelRes.Text = "Incorrecta";
                    }
                }
            }
            //Tienes que acertar la mitad de las preguntas para superar el test
            if (nombrePreguntas.Count % 2 == 0 && !readOnly) //Par
            {
                if (res >= nombrePreguntas.Count / 2)
                {
                    MessageBox.Show("Has superado el test");
                    aprobado = true;
                }
                else
                {
                    MessageBox.Show("Intentalo de nuevo");
                }
            }
            else if (!readOnly)
            {
                if (res > nombrePreguntas.Count / 2)
                {
                    MessageBox.Show("Has superado el test");
                    aprobado = true;
                }
                else
                {
                    MessageBox.Show("Intentalo de nuevo");
                }
            }

            if (nombrePreguntas.Count % 2 == 0 && readOnly) //Par
            {
                if (res >= nombrePreguntas.Count / 2)
                {
                    lAprobadoRO.Text = "Aprobado";
                    lAprobadoRO.ForeColor = Color.Green;
                    lAprobadoRO.Visible = true;
                }
                else
                {
                    lAprobadoRO.Text = "Suspenso";
                    lAprobadoRO.ForeColor = Color.Red;
                    lAprobadoRO.Visible = true;
                }
            }
            else if (readOnly)
            {
                if (res > nombrePreguntas.Count / 2)
                {
                    lAprobadoRO.Text = "Aprobado";
                    lAprobadoRO.ForeColor = Color.Green;
                    lAprobadoRO.Visible = true;
                }
                else
                {
                    lAprobadoRO.Text = "Suspenso";
                    lAprobadoRO.ForeColor = Color.Red;
                    lAprobadoRO.Visible = true;
                }
            }
            return aprobado;
        }

        private void bEnviar_Click(object sender, EventArgs e)
        {
            Boolean res = Check(false);
            if (res)
            {
                String idsP = "";
                String respuestasUsuario = "";
                foreach (var respuesta in Respuestas_Resultado)
                {
                    //idP -> 1_2_3_4
                    //indexRes -> 2|3|_1|_2|2|_1|3|_
                    if (Respuestas_Resultado.Last().Equals(respuesta))
                    {
                        idsP += respuesta.Key;
                    }
                    else
                    {
                        idsP += respuesta.Key + "_";
                    }
                    foreach (var item in respuesta.Value.CheckedIndices)
                    {
                        respuestasUsuario += item.ToString() + "|";
                    }
                    respuestasUsuario += "_";
                }
                //Inserto sus respuestas en la base de datos si ha aprobado
                Test.SubmitAprobado(evento, usuario, idsP, respuestasUsuario);
            }
        }

        protected void checkedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox checkedlistbox = sender as CheckedListBox;

            //Este Codigo solo permite seleccionar un check
            if (checkedlistbox.CheckedItems.Count == 1)
            {
                Boolean isCheckedItemBeingUnchecked = (e.CurrentValue == CheckState.Checked);
                if (isCheckedItemBeingUnchecked)
                {
                    e.NewValue = CheckState.Checked;
                }
                else
                {
                    Int32 checkedItemIndex = checkedlistbox.CheckedIndices[0];
                    checkedlistbox.ItemCheck -= checkedListBox_ItemCheck;
                    checkedlistbox.SetItemChecked(checkedItemIndex, false);
                    checkedlistbox.ItemCheck += checkedListBox_ItemCheck;
                }
                return;
            }        
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
