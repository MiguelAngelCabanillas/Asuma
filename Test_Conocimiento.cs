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
        public Test_Conocimiento(SortedDictionary<int, String> nombrePreguntas,
                                 SortedDictionary<int, String[]> listaRespuestas,
                                 SortedDictionary<int, List<string>> respuestasCorrectas,
                                 Boolean seleccionMultiple)
        {
            this.nombrePreguntas = nombrePreguntas;
            this.listaRespuestas = listaRespuestas;
            this.seleccionMultiple = seleccionMultiple;
            this.respuestasCorrectas = respuestasCorrectas;
            this.Respuestas_Resultado = new SortedDictionary<int, CheckedListBox>();
            this.Label_Resultado = new SortedDictionary<int, Label>();

            InitializeComponent();
            mostrarPreguntasyRespuestas();
        }

        private void mostrarPreguntasyRespuestas()
        {
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
                ResPregunta.Text = "label1";

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

                Respuestas_Resultado.Add(id_Pregunta, respuestasPregunta);
                Label_Resultado.Add(id_Pregunta, ResPregunta);
            }
        }
        private void Check()
        {
            int res = 0;
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
            if (nombrePreguntas.Count % 2 == 0) //Par
            {
                if (res >= nombrePreguntas.Count / 2)
                {
                    MessageBox.Show("Has superado el test");
                }
                else
                {
                    MessageBox.Show("Intentalo de nuevo");
                }
            }
            else
            {
                if (res > nombrePreguntas.Count / 2)
                {
                    MessageBox.Show("Has superado el test");
                }
                else
                {
                    MessageBox.Show("Intentalo de nuevo");
                }
            }
        }

        private void bEnviar_Click(object sender, EventArgs e)
        {
            Check();
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
    }
}
