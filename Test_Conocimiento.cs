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
    public partial class Test_Conocimiento : Form
    {
        SortedDictionary<int, String> nombrePreguntas;
        SortedDictionary<int, String[]> listaRespuestas;
        public Test_Conocimiento(SortedDictionary<int, String> nombrePreguntas,
                                 SortedDictionary<int, String[]> listaRespuestas)
        {
            this.nombrePreguntas = nombrePreguntas;
            this.listaRespuestas = listaRespuestas;
            InitializeComponent();
            //añadirRespuestasQ1();
            //añadirRespuestasQ2();
            //añadirRespuestasQ3();
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
            }
        }

        private void añadirRespuestasQ1()
        {
            /*
            String R1 = "Respuesta 1";
            String R2 = "Respuesta 2";
            String R3 = "Respuesta 3 (Correcta)";
            String[] respuestasQ1 = { R1, R2, R3};
            checkedListBoxQ1.Items.AddRange(respuestasQ1);
            // Changes the selection mode from double-click to single click.
            checkedListBoxQ1.CheckOnClick = true;
            */
        }
        private void añadirRespuestasQ2()
        {
            /*
            String R1 = "Respuesta 1 (Correcta)";
            String R2 = "Respuesta 2";
            String R3 = "Respuesta 3";
            String[] respuestasQ2 = { R1, R2, R3 };
            checkedListBoxQ2.Items.AddRange(respuestasQ2);
            // Changes the selection mode from double-click to single click.
            checkedListBoxQ2.CheckOnClick = true;
            */
        }
        private void añadirRespuestasQ3()
        {
            /*
            String R1 = "Respuesta 1";
            String R2 = "Respuesta 2 (Correcta)";
            String R3 = "Respuesta 3";
            String[] respuestasQ3 = { R1, R2, R3 };
            checkedListBoxQ3.Items.AddRange(respuestasQ3);
            // Changes the selection mode from double-click to single click.
            checkedListBoxQ3.CheckOnClick = true;
            */
        }

        private void check()
        {
            /*
            
              switch (seleccion)
            {
                case 1:
                    if (this.opcion3.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta2();
                    Limpiar();
                    break;
             
            int cont = 0;
            String R1 = "Respuesta 1 (Correcta)";
            String R2 = "Respuesta 2 (Correcta)";
            String R3 = "Respuesta 3 (Correcta)";
            if (checkedListBoxQ1.CheckedItems.Contains(R3)){
                lResQ1.Text = "Respuesta Correcta";
                cont += 1;
            }
            else
            {
                lResQ1.Text = "Respuesta Incorrecta";
            }

            if (checkedListBoxQ2.CheckedItems.Contains(R1))
            {
                lResQ2.Text = "Respuesta Correcta";
                cont += 1;
            }
            else
            {
                lResQ2.Text = "Respuesta Incorrecta";
            }

            if (checkedListBoxQ3.CheckedItems.Contains(R2))
            {
                lResQ3.Text = "Respuesta Correcta";
                cont += 1;
            }
            else
            {
                lResQ3.Text = "Respuesta Incorrecta";
            }

            if (cont >= 2)
            {
                MessageBox.Show("Ole to tu polla");
            }
            */
        }

        private void bEnviar_Click(object sender, EventArgs e)
        {
            check();
        }

        private void checkedListBoxQ1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            /*
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
            */
        }
    }
}
