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
        public Cuestionario_Satisfaccion()
        {
            InitializeComponent();
        }

        public Cuestionario_Satisfaccion(String resQ1, int resQ2, int resQ3, int resQ4, int resQ5,
                                         int resQ6, String resQ7)
        {
            InitializeComponent();
            String[] respuestasQ1 = resQ1.Split('_');
            for (int i = 0; i < respuestasQ1.Length; i++)
            {
                CLB_Q1.SetItemChecked(int.Parse(respuestasQ1[i]), true);
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
    }
}
