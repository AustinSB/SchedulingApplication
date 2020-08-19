using SchedulingDataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SchedulingForms.UserTracker;

namespace SchedulingForms
{
    public partial class Report_UserSchedules_Form : Form
    {
        ScheduleEntities ent;

        public Report_UserSchedules_Form()
        {
            InitializeComponent();

            FillReport();
        }
        //Schedule of each user
        private void FillReport()
        {
            using(ent = new ScheduleEntities())
            {

                var userList = new List<string>();

                var userQuery = from u in ent.users
                                select u;

                foreach (var u in userQuery)
                {
                    userList.Add($"{u.userId} - Username: {u.userName}");
                }

                foreach (var u in userList)
                {
                    display_TextBox.AppendText($"--------------------------------------------------");
                    display_TextBox.AppendText(Environment.NewLine);

                    display_TextBox.AppendText($"ID: {u}");
                    display_TextBox.AppendText(Environment.NewLine);

                    display_TextBox.AppendText($"--------------------------------------------------");
                    display_TextBox.AppendText(Environment.NewLine);
                    
                    foreach (var ap in userAppointments)
                    {
                        var uid = Convert.ToInt32(char.GetNumericValue(u.ToString().First()));

                        if (uid == ap.userId)
                        {
                            if (ap.start.Kind == DateTimeKind.Unspecified || ap.start.Kind == DateTimeKind.Utc)
                            {
                                ap.start = DateTime.SpecifyKind(ap.start, DateTimeKind.Utc).ToLocalTime();
                            }

                            if (ap.end.Kind == DateTimeKind.Unspecified || ap.end.Kind == DateTimeKind.Utc)
                            {
                                ap.end = DateTime.SpecifyKind(ap.end, DateTimeKind.Utc).ToLocalTime();
                            }

                            display_TextBox.AppendText($"    Title: {ap.title} - {ap.type}");
                            display_TextBox.AppendText(Environment.NewLine);

                            display_TextBox.AppendText($"    Scheduled for: {ap.start.ToString("MM/dd/yyyy")}");
                            display_TextBox.AppendText(Environment.NewLine);
                            display_TextBox.AppendText($"    From: {ap.start.ToString("hh:mm tt")} - To: {ap.end.ToString("hh:mm tt")} ");
                            display_TextBox.AppendText(Environment.NewLine);

                            display_TextBox.AppendText($"    Description: {ap.description}");
                            display_TextBox.AppendText(Environment.NewLine);
                            display_TextBox.AppendText(Environment.NewLine);
                        }
                    }
                }
            }
        }

        private void close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
