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
    public partial class Report_ApptTypesByMonth_Form : Form
    {
        ScheduleEntities ent;
        
        public Report_ApptTypesByMonth_Form()
        {
            InitializeComponent();

            FillReport();
        }

        private void close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillReport()
        {
            List<string> apptTypes = new List<string>();

            //NUMBER OF APPOINTMENT TYPES BY MONTH
            using (ent = new ScheduleEntities())
            {
                var query = from ap in ent.appointments.Where(ap => ap.userId == ActiveUser.userId)
                            select ap;

                //get earliest month and latest month in the list of appointments
                var startingDate = new DateTime(2100,1,1);
                var endingDate = new DateTime(1900, 1, 1);

                foreach (var item in query)
                {
                    if(item.start.Date < startingDate)
                    {
                        startingDate = item.start;
                    }

                    if(item.start.Date > endingDate)
                    {
                        endingDate = item.start;
                    }
                }

                while (startingDate <= endingDate)
                {
                    foreach (var item in query)
                    {
                        //if the appointment matches the month and year
                        if(item.start.Year == startingDate.Year && item.start.Month == startingDate.Month)
                        {
                            //if list does not have appointment type, add it to list and display the type on screen
                            if (!apptTypes.Contains(item.type))
                            {
                                //apptTypes.Add($"APPT ID: {item.appointmentId} - {item.type}");
                                apptTypes.Add($"{item.type}");
                            }
                        }
                    }

                    if(apptTypes.Count > 0)
                    {
                        display_TextBox.AppendText($"---------------------------------");
                        display_TextBox.AppendText(Environment.NewLine);

                        display_TextBox.AppendText($"{startingDate.ToString("yyyy MMMM")}");
                        display_TextBox.AppendText(Environment.NewLine);

                        display_TextBox.AppendText($"---------------------------------");
                        display_TextBox.AppendText(Environment.NewLine);

                        foreach (var appt in apptTypes)
                        {
                            display_TextBox.AppendText($"    {appt}");
                            display_TextBox.AppendText(Environment.NewLine);
                        }

                        display_TextBox.AppendText($"    Number of appointment types: {apptTypes.Count}");
                        display_TextBox.AppendText(Environment.NewLine);
                    }

                    apptTypes.Clear();

                    startingDate = startingDate.AddMonths(1);
                }
            }
        }
    }
}
