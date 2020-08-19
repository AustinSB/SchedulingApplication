using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulingForms
{
    public static class ValidateCustomers
    {
        public static bool IsComboBoxItemSelected(ComboBox box, string message)
        {
            if (box.SelectedIndex > -1)
            {
                return true;
            }
            MessageBox.Show($"Must select a {message}","Invalid Selection");
            return false;
        }

        //Validate TextBox Value
        public static bool DoesTextBoxHaveValue(string text, string message)
        {
            if (String.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show($"'{message}' must have a value", "Invalid Input");
                return false;
            }
            return true;
        }

        //Validate Phone
        public static bool IsPhoneValid(string text)
        {
            if(text.Length == 10 && text.All(c => Char.IsDigit(c)))
            {
                return true;
            }
            MessageBox.Show("Phone number must be 10 digits", "");
            return false;
        }

        //Validate Postal
        public static bool IsPostalValid(string text)
        {
            if (text.Length == 5 && text.All(c => Char.IsDigit(c)))
            {
                return true;
            }
            MessageBox.Show("Postal number must be 5 digits", "");
            return false;
        }
    }
}
