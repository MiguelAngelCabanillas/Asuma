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
    public partial class Cuestionario_Satisfaccion : Form
    {
        Event evento;
        User user;
        public Cuestionario_Satisfaccion(Event e, User u)
        {
            InitializeComponent();
            evento = e;
            user = u;
        }

        public Cuestionario_Satisfaccion(String resQ1, int resQ2, int resQ3, int resQ4, int resQ5,
                                         int resQ6, String resQ7, Event e)
        {
            InitializeComponent();
            evento = e;
            String[] respuestasQ1 = resQ1.Split('_');
            for (int i = 0; i < respuestasQ1.Length; i++)
            {
                //La ultima es la cadena vacia
                if (i < respuestasQ1.Length - 1)
                {
                    CLB_Q1.SetItemChecked(int.Parse(respuestasQ1[i]), true);
                }
            }
            CLB_Q2.SetItemChecked(resQ2, true);
            CLB_Q3.SetItemChecked(resQ3, true);
            CLB_Q4.SetItemChecked(resQ4, true);
            CLB_Q5.SetItemChecked(resQ5, true);
            CLB_Q5.SetItemChecked(resQ5, true);
            CLB_Q6.SetItemChecked(resQ6, true);
            RTB_Q7.Text = resQ7;
            CLB_Q1.Enabled = false;
            CLB_Q2.Enabled = false;
            CLB_Q3.Enabled = false;
            CLB_Q4.Enabled = false;
            CLB_Q5.Enabled = false;
            CLB_Q6.Enabled = false;
            RTB_Q7.ReadOnly = true;
            bEnviar.Enabled = false;
            bEnviar.Visible = false;
        }

        private void CLB_Q2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //Este Codigo solo permite seleccionar un check
            if (CLB_Q2.CheckedItems.Count == 1)
            {
                Boolean isCheckedItemBeingUnchecked = (e.CurrentValue == CheckState.Checked);
                if (isCheckedItemBeingUnchecked)
                {
                    e.NewValue = CheckState.Checked;
                }
                else
                {
                    Int32 checkedItemIndex = CLB_Q2.CheckedIndices[0];
                    CLB_Q2.ItemCheck -= CLB_Q2_ItemCheck;
                    CLB_Q2.SetItemChecked(checkedItemIndex, false);
                    CLB_Q2.ItemCheck += CLB_Q2_ItemCheck;
                }
                return;
            }
        }

        private void CLB_Q3_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //Este Codigo solo permite seleccionar un check
            if (CLB_Q3.CheckedItems.Count == 1)
            {
                Boolean isCheckedItemBeingUnchecked = (e.CurrentValue == CheckState.Checked);
                if (isCheckedItemBeingUnchecked)
                {
                    e.NewValue = CheckState.Checked;
                }
                else
                {
                    Int32 checkedItemIndex = CLB_Q3.CheckedIndices[0];
                    CLB_Q3.ItemCheck -= CLB_Q3_ItemCheck;
                    CLB_Q3.SetItemChecked(checkedItemIndex, false);
                    CLB_Q3.ItemCheck += CLB_Q3_ItemCheck;
                }
                return;
            }
        }

        private void CLB_Q4_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //Este Codigo solo permite seleccionar un check
            if (CLB_Q4.CheckedItems.Count == 1)
            {
                Boolean isCheckedItemBeingUnchecked = (e.CurrentValue == CheckState.Checked);
                if (isCheckedItemBeingUnchecked)
                {
                    e.NewValue = CheckState.Checked;
                }
                else
                {
                    Int32 checkedItemIndex = CLB_Q4.CheckedIndices[0];
                    CLB_Q4.ItemCheck -= CLB_Q4_ItemCheck;
                    CLB_Q4.SetItemChecked(checkedItemIndex, false);
                    CLB_Q4.ItemCheck += CLB_Q4_ItemCheck;
                }
                return;
            }
        }

        private void CLB_Q5_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //Este Codigo solo permite seleccionar un check
            if (CLB_Q5.CheckedItems.Count == 1)
            {
                Boolean isCheckedItemBeingUnchecked = (e.CurrentValue == CheckState.Checked);
                if (isCheckedItemBeingUnchecked)
                {
                    e.NewValue = CheckState.Checked;
                }
                else
                {
                    Int32 checkedItemIndex = CLB_Q5.CheckedIndices[0];
                    CLB_Q5.ItemCheck -= CLB_Q5_ItemCheck;
                    CLB_Q5.SetItemChecked(checkedItemIndex, false);
                    CLB_Q5.ItemCheck += CLB_Q5_ItemCheck;
                }
                return;
            }
        }

        private void CLB_Q6_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //Este Codigo solo permite seleccionar un check
            if (CLB_Q6.CheckedItems.Count == 1)
            {
                Boolean isCheckedItemBeingUnchecked = (e.CurrentValue == CheckState.Checked);
                if (isCheckedItemBeingUnchecked)
                {
                    e.NewValue = CheckState.Checked;
                }
                else
                {
                    Int32 checkedItemIndex = CLB_Q6.CheckedIndices[0];
                    CLB_Q6.ItemCheck -= CLB_Q6_ItemCheck;
                    CLB_Q6.SetItemChecked(checkedItemIndex, false);
                    CLB_Q6.ItemCheck += CLB_Q6_ItemCheck;
                }
                return;
            }
        }

        private void bEnviar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            String q1 = "";
            int q2, q3, q4, q5, q6;
            q2 = q3 = q4 = q5 = q6 = -1;
            
            foreach (var res in CLB_Q1.CheckedIndices)
            {
                q1 += (int)res + "_";
            }

            foreach (var select in CLB_Q2.CheckedIndices)
            {
                q2 = (int)select;
            }

            foreach (var select in CLB_Q3.CheckedIndices)
            {
                q3 = (int)select;
            }

            foreach (var select in CLB_Q4.CheckedIndices)
            {
                q4 = (int)select;
            }

            foreach (var select in CLB_Q5.CheckedIndices)
            {
                q5 = (int)select;
            }

            foreach (var select in CLB_Q6.CheckedIndices)
            {
                q6 = (int)select;
            }

            String q7 = RTB_Q7.Text;

            if (q1.Equals("") || q2 == -1 || q3 == -1 || q4 == -1 || q5 == -1 || q6 == -1)
            {
                MessageBox.Show("Debe contestar a todas las preguntas");
            }
            else
            {
                try
                {
                    BD myBd = new BD();
                    MySqlDataReader writer = myBd.Query("INSERT INTO survey (`q1`, `q2`, `q3`, `q4`, `q5`, `q6`, `q7`, `userID`, `eventID`) VALUES('" + q1 + "', " + q2 + ", " + q3 + ", " + q4 + ", " + q5 + ", " + q6 + ", '" + q7 + "', " + user.Id + ", " + evento.ID + ")");
                    writer.Read();
                    writer.Close();
                    myBd.closeBD();
                }
                catch (Exception)
                {                  
                    throw;
                }
                MessageBox.Show("La encuesta se ha enviado con éxito");
                this.Close();
            }
        }

        private void Cuestionario_Satisfaccion_Load(object sender, EventArgs e)
        {
            lNameCurso.Text = evento.EventName;
            lTestName.Focus();
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            this.Close();
        }
    }
}
