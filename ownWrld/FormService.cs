using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ownWrld
{
    public class FormService
    {
        public static void MakeAction(ToolStripItem clickedItem,Dictionary<string,string> dict)
        {

            if (clickedItem.Text == dict[StripParameters.AddNewParameter.ToString()])
            {
               AddForm form2 = new AddForm();
                  form2.ShowDialog();
            }
            else if (clickedItem.Text == dict[StripParameters.RemoveParameter.ToString()])
            {
                MessageBox.Show("Jest ok Rem");
            }
            else if (clickedItem.Text == dict[StripParameters.CheckParameter.ToString()])
            {
                MessageBox.Show("Jest ok Check");
            }
            else if (clickedItem.Text == dict[StripParameters.ModifyParameter.ToString()])
            {
                MessageBox.Show("Jest ok Modif");
            }
            else
            {
                throw new Exception("Unimplemented dictionary/Enum definition, check if all parameters were registered");
            }
        }
    }
}