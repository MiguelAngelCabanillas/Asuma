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
