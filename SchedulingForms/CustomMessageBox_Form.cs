using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulingForms
{
    public partial class CustomMessageBox_Form : Form
    {
        public CustomMessageBox_Form()
        {
            InitializeComponent();
        }

        //OK Message Box
        public DialogResult ShowMessage(string message, string caption, string buttonText)
        {
            this.Text = caption;
            message_Label.Text = message;

            no_Button.Visible = false;
            yes_Button.Visible = false;
            ok_Button.Location = new Point(200, 100);
            ok_Button.Text = buttonText;

            return this.ShowDialog();
        }

        //YesNo Message Box
        public DialogResult ShowMessage(string message, string caption, string noButtonText, string yesButtonText)
        {
            this.Text = caption;
            message_Label.Text = message;

            ok_Button.Visible = false;
            no_Button.Text = noButtonText;
            yes_Button.Text = yesButtonText;

            return this.ShowDialog();
        }
    }
}
