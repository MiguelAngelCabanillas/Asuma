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
    public partial class Test_Conocimiento_Edicion : Form
    {
        int id;
        SortedDictionary<int, String> nombrePreguntas;
        SortedDictionary<int, String[]> listasRespuestas;
        public Test_Conocimiento_Edicion()
        {
            InitializeComponent();
            id = 0;
            nombrePreguntas = new SortedDictionary<int, string>();
            listasRespuestas = new SortedDictionary<int, string[]>();
        }

        private void bAñadir_Respuesta_Click(object sender, EventArgs e)
        {
            int cont;
            String respuesta = textBoxRespuesta.Text.Trim();
            Boolean correcta = radioButtonCorrecta.Checked;
            String asterisco = "";
            if (correcta) 
            {
                asterisco = "*";
                radioButtonCorrecta.Checked = false;
            }
            if(respuesta != "")
            {
                checkedListBoxQ1.Items.Add(respuesta + asterisco);
                cont = checkedListBoxQ1.Items.Count;
                textBoxRespuesta.Text = "Respuesta" + cont;
            }
        }

        private void bAñadir_Pregunta_Click(object sender, EventArgs e)
        {
            String pregunta = textBoxPregunta.Text.Trim();

            mostrarErrores(pregunta);

            if ((pregunta != "") && (checkedListBoxQ1.Items.Count > 0) && hayAlgunaRespuestaCorrecta())
            {
                nombrePreguntas.Add(id, pregunta);

                List<String> respuestas = new List<string>();

                foreach (String item in checkedListBoxQ1.Items)
                {   
                    respuestas.Add(item);
                }

                listasRespuestas.Add(id, respuestas.ToArray());

                Button P_id = new Button { Name = "P" + id, Text = "P" + id };
                P_id.Click += new EventHandler(P_id_Click);     
                flowLayoutPanel1.Controls.Add(P_id);

                resetPregunta();

                textBoxRespuesta.Text = "Respuesta0";
                radioButtonCorrecta.Checked = false;

                id++;
            }
        }
        protected void P_id_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int id_P = int.Parse(button.Text.Replace("P", ""));
            String nameP = "";
            nombrePreguntas.TryGetValue(id_P, out nameP);
            lQ1.Text = "Pregunta" + id_P;
            textBoxPregunta.Text = nameP;
            String[] respuestasP;
            listasRespuestas.TryGetValue(id_P, out respuestasP);
            checkedListBoxQ1.Items.Clear();
            checkedListBoxQ1.Items.AddRange(respuestasP);
        }
        private void resetPregunta()
        {
            int cont = nombrePreguntas.Count;
            textBoxPregunta.Text = "Pregunta" + cont;
            lQ1.Text = "Pregunta" + cont;
            checkedListBoxQ1.Items.Clear();
        }
        private Boolean hayAlgunaRespuestaCorrecta()
        {
            Boolean res = false;
            foreach (String item in checkedListBoxQ1.Items)
            {
                if (item.Contains("*"))
                {
                    res = true;
                }
            }
            return res;
        }
        private void mostrarErrores(String pregunta)
        {
            if (pregunta == "")
            {
                MessageBox.Show("Nombre de la pregunta esta vacio");
            }

            if (checkedListBoxQ1.Items.Count == 0)
            {
                MessageBox.Show("No hay ninguna respuesta");
            }

            if (!hayAlgunaRespuestaCorrecta())
            {
                MessageBox.Show("No hay ninguna respuesta correcta");
            }
        }
        private void bEliminar_Respuesta_Click(object sender, EventArgs e)
        {
            if (checkedListBoxQ1.CheckedItems.Count > 0)
            {
                //Solo va a tener uno seleccionado por el _ItemCheck
                System.Collections.IEnumerator it = checkedListBoxQ1.CheckedItems.GetEnumerator();
                it.MoveNext();
                int index = checkedListBoxQ1.Items.IndexOf(it.Current);
                checkedListBoxQ1.Items.Remove(it.Current);

                int id_P = int.Parse(lQ1.Text.Replace("Pregunta", "").Replace(":", ""));
                String[] respuestasP;
                List<String> aux = new List<string>();

                if(listasRespuestas.TryGetValue(id_P, out respuestasP))
                {
                    System.Collections.IEnumerator it_P = respuestasP.GetEnumerator();
                    int i = 0;
                    while (it_P.MoveNext())
                    {
                        if (i != index)
                        {
                            aux.Add((String)it_P.Current);
                        }
                        i++;
                    }
                    listasRespuestas.Remove(id_P);
                    listasRespuestas.Add(id_P, aux.ToArray());
                }
            }
        }
        private void checkedListBoxQ1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //Este Codigo solo permite seleccionar un check
            if (checkedListBoxQ1.CheckedItems.Count == 1)
            {
                Boolean isCheckedItemBeingUnchecked = (e.CurrentValue == CheckState.Checked);
                if (isCheckedItemBeingUnchecked)
                {
                    e.NewValue = CheckState.Checked;
                }
                else
                {
                    Int32 checkedItemIndex = checkedListBoxQ1.CheckedIndices[0];
                    checkedListBoxQ1.ItemCheck -= checkedListBoxQ1_ItemCheck;
                    checkedListBoxQ1.SetItemChecked(checkedItemIndex, false);
                    checkedListBoxQ1.ItemCheck += checkedListBoxQ1_ItemCheck;
                }

                return;
            }
        }
    }
}
