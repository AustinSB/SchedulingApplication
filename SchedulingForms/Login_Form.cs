using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using SchedulingDataModel;
using static SchedulingForms.Login_Translate;

namespace SchedulingForms
{
    public partial class Login_Form : Form
    {
        ScheduleEntities entity;

        public Login_Form()
        {
            //CultureInfo.CurrentUICulture = new CultureInfo("es-ES", false);
            
            InitializeComponent();

            
            ChangeLabels();
        }

        private void login_Button_Click(object sender, EventArgs e)
        {
            AttemptLogin();
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            var exitBox = new CustomMessageBox_Form();

            exitBox.ShowMessage(ConfirmExitMessage, ConfirmExitCaption, NoButton, YesButton);
            if(exitBox.DialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        //If User Menu is exited, close this form as well.
        private void userMenu_Form_ExitClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        //public event EventHandler UserLoggedIn;

        private void AttemptLogin()
        {
            using (entity = new ScheduleEntities())
            {
                var errorBox = new CustomMessageBox_Form();

                var userQuery = from u in entity.users
                                where u.userName == username_TextBox.Text
                                select u;

                if(userQuery.Count() == 1)
                {//Check to see if selected User has correct password.
                    var sUser = userQuery.First();
                    if (sUser.userName == username_TextBox.Text && sUser.password == password_TextBox.Text)
                    {//Set this user as one to be tracked, then open up this user's account menu.
                        UserTracker.GetUser(sUser);

                        var userMenu = new UserMenu_Form();
                        userMenu.ExitClicked += new EventHandler(userMenu_Form_ExitClicked);
                        userMenu.Show();

                        TrackLogins.SaveToLogFile();

                        this.Hide();
                    }
                    else
                    {
                        errorBox.ShowMessage(CredentialsDontMatch, LoginFailed, OkButton);
                        return;
                    }
                }
                else
                {
                    errorBox.ShowMessage(InvalidUsername, LoginFailed, OkButton);
                    return;
                }
            }
        }

        private void ChangeLabels()
        {
                //Text values for labels and buttons translated to Spanish.
                username_Label.Text = UserName;
                password_Label.Text = PassWord;
                login_Button.Text = Login;
                exit_Button.Text = Exit;
                this.Text = Login;
        }
    }
}
