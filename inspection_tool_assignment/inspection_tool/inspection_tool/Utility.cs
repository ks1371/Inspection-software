using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace inspection_tool
{
    class Utility
    {
        // Simulate a placeholder text when starting to type
        public void changePlaceholder_Enter(object sender)
        {
            TextBox inputBox = sender as TextBox;

            if (inputBox.Text == inputBox.Name)
            {
                inputBox.Text = "";

                inputBox.ForeColor = Color.Black;
            }
        }

        // Simulate a placeholder text when leaving the TextBox empty
        public void changePlaceholder_Leave(object sender)
        {
            TextBox inputBox = sender as TextBox;

            if (inputBox.Text == "")
            {
                inputBox.Text = inputBox.Name;

                inputBox.ForeColor = Color.Silver;
            }
        }
    }
}
