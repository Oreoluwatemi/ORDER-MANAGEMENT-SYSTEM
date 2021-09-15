using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    class Validator
    {
        public static bool isPresent(Control control, String name)
        {
            if (control is TextBox)
            {
                if (((TextBox)control).Text == "")
                {
                    MessageBox.Show(name + " is a required field.", "Error");
                    ((TextBox)control).Focus();
                    return false;
                }
            }
            return true;
        }

        public static bool isInt(TextBox textBox)
        {
            try
            {
                Convert.ToInt32(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(textBox.Tag + " must be an integer.", "Error");
                textBox.Focus();
                return false;
            }
        }

        public static bool isDecimal(TextBox textBox)
        {
            try
            {
                Convert.ToDecimal(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(textBox.Tag + " must be an integer.", "Error");
                textBox.Focus();
                return false;
            }
        }
    }
}
