﻿using System;
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
        SortedDictionary<int, Button> botonesDinamicos;
        public Test_Conocimiento_Edicion()
        {
            InitializeComponent();
            id = 0;
            nombrePreguntas = new SortedDictionary<int, string>();
            listasRespuestas = new SortedDictionary<int, string[]>();
            botonesDinamicos = new SortedDictionary<int, Button>();
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
            if (nombrePreguntas.Count <= 18)
            {
                String pregunta = textBoxPregunta.Text.Trim();

                mostrarErrores(pregunta);

                if ((pregunta != "") && (checkedListBoxQ1.Items.Count > 0)
                    && hayUnaUnicaRespuestaCorrecta())
                {
                    nombrePreguntas.Add(id, pregunta);

                    List<String> respuestas = new List<string>();

                    foreach (String item in checkedListBoxQ1.Items)
                    {   
                        respuestas.Add(item);
                    }

                    listasRespuestas.Add(id, respuestas.ToArray());

                    Button P_id = new Button { Name = "P" + id, Text = "P" + id };
                    botonesDinamicos.Add(id, P_id);
                    P_id.Click += new EventHandler(P_id_Click);     
                    flowLayoutPanel1.Controls.Add(P_id);

                    resetPregunta();

                    id++;
                }
            }
            else
            {
                MessageBox.Show("No se pueden crear más preguntas");
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
            textBoxPregunta.Text = "Pregunta" + id;
            lQ1.Text = "Pregunta" + id + ":";
            checkedListBoxQ1.Items.Clear();
            textBoxRespuesta.Text = "Respuesta0";
            radioButtonCorrecta.Checked = false;
        }

        private Boolean hayUnaUnicaRespuestaCorrecta()
        {
            int cont = 0;
            foreach (String item in checkedListBoxQ1.Items)
            {
                if (item.Contains("*"))
                {
                    cont++;
                }
            }
            return cont == 1;
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

            if (!hayUnaUnicaRespuestaCorrecta())
            {
                MessageBox.Show("Debe haber una única respuesta correcta");
            }           
        }

        private void bEliminar_Respuesta_Click(object sender, EventArgs e)
        {
            if (checkedListBoxQ1.CheckedItems.Count > 0)
            {
                //Solo va a tener uno seleccionado por el _ItemCheck
                System.Collections.IEnumerator it = checkedListBoxQ1.CheckedItems.GetEnumerator();
                it.MoveNext();
                checkedListBoxQ1.Items.Remove(it.Current);
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

        private void bActualizarPregunta_Click(object sender, EventArgs e)
        {
            String pregunta = textBoxPregunta.Text.Trim();
            int id_P = int.Parse(lQ1.Text.Replace("Pregunta", "").Replace(":", ""));

            mostrarErrores(pregunta);

            if (!nombrePreguntas.ContainsKey(id_P))
            {
                MessageBox.Show("No se puede actualizar una pregunta que no esta añadida");
            }

            if ((pregunta != "") && (checkedListBoxQ1.Items.Count > 0) 
                && hayUnaUnicaRespuestaCorrecta() && nombrePreguntas.ContainsKey(id_P))
            {
                nombrePreguntas.Remove(id_P);
                nombrePreguntas.Add(id_P, pregunta);

                List<String> respuestas = new List<string>();

                foreach (String item in checkedListBoxQ1.Items)
                {
                    respuestas.Add(item);
                }

                listasRespuestas.Remove(id_P);
                listasRespuestas.Add(id_P, respuestas.ToArray());

                resetPregunta();
            }
        }

        private void bEliminarPregunta_Click(object sender, EventArgs e)
        {
            int id_P = int.Parse(lQ1.Text.Replace("Pregunta", "").Replace(":", ""));

            if (!nombrePreguntas.ContainsKey(id_P))
            {
                MessageBox.Show("No se puede eliminar una pregunta que no esta añadida");
            }
            else
            {
                nombrePreguntas.Remove(id_P);
                listasRespuestas.Remove(id_P);
                Button aux = new Button();
                botonesDinamicos.TryGetValue(id_P, out aux);
                aux.Enabled = false;
                aux.Visible = false;
                aux.Dispose();
                botonesDinamicos.Remove(id_P);

                resetPregunta();
            }
        }

        private void bFinalizar_Test_Click(object sender, EventArgs e)
        {
            Test_Conocimiento aux = new Test_Conocimiento(nombrePreguntas, listasRespuestas);
            aux.Show();
        }
    }
}
