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
        public Test_Conocimiento()
        {
            InitializeComponent();
            añadirRespuestasQ1();
            añadirRespuestasQ2();
            añadirRespuestasQ3();
        }

        private void añadirRespuestasQ1()
        {
            String R1 = "Respuesta 1";
            String R2 = "Respuesta 2";
            String R3 = "Respuesta 3 (Correcta)";
            String[] respuestasQ1 = { R1, R2, R3};
            checkedListBoxQ1.Items.AddRange(respuestasQ1);
            // Changes the selection mode from double-click to single click.
            checkedListBoxQ1.CheckOnClick = true;
        }
        private void añadirRespuestasQ2()
        {
            String R1 = "Respuesta 1 (Correcta)";
            String R2 = "Respuesta 2";
            String R3 = "Respuesta 3";
            String[] respuestasQ2 = { R1, R2, R3 };
            checkedListBoxQ2.Items.AddRange(respuestasQ2);
            // Changes the selection mode from double-click to single click.
            checkedListBoxQ2.CheckOnClick = true;
        }
        private void añadirRespuestasQ3()
        {
            String R1 = "Respuesta 1";
            String R2 = "Respuesta 2 (Correcta)";
            String R3 = "Respuesta 3";
            String[] respuestasQ3 = { R1, R2, R3 };
            checkedListBoxQ3.Items.AddRange(respuestasQ3);
            // Changes the selection mode from double-click to single click.
            checkedListBoxQ3.CheckOnClick = true;
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
             */
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
        }

        private void bEnviar_Click(object sender, EventArgs e)
        {
            check();
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

        private void checkedListBoxQ2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //Este Codigo solo permite seleccionar un check
            if (checkedListBoxQ2.CheckedItems.Count == 1)
            {
                Boolean isCheckedItemBeingUnchecked = (e.CurrentValue == CheckState.Checked);
                if (isCheckedItemBeingUnchecked)
                {
                    e.NewValue = CheckState.Checked;
                }
                else
                {
                    Int32 checkedItemIndex = checkedListBoxQ2.CheckedIndices[0];
                    checkedListBoxQ2.ItemCheck -= checkedListBoxQ2_ItemCheck;
                    checkedListBoxQ2.SetItemChecked(checkedItemIndex, false);
                    checkedListBoxQ2.ItemCheck += checkedListBoxQ2_ItemCheck;
                }
                return;
            }
        }

        private void checkedListBoxQ3_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //Este Codigo solo permite seleccionar un check
            if (checkedListBoxQ3.CheckedItems.Count == 1)
            {
                Boolean isCheckedItemBeingUnchecked = (e.CurrentValue == CheckState.Checked);
                if (isCheckedItemBeingUnchecked)
                {
                    e.NewValue = CheckState.Checked;
                }
                else
                {
                    Int32 checkedItemIndex = checkedListBoxQ3.CheckedIndices[0];
                    checkedListBoxQ3.ItemCheck -= checkedListBoxQ3_ItemCheck;
                    checkedListBoxQ3.SetItemChecked(checkedItemIndex, false);
                    checkedListBoxQ3.ItemCheck += checkedListBoxQ1_ItemCheck;
                }
                return;
            }
        }
    }
}
