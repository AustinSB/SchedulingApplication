using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SchedulingForms.UserTracker;

namespace SchedulingForms
{
    static public class ValidateAppointment
    {
        //Validate Customer Selection
        public static bool IsCutomerSelected(int id)
        {
            if (id < 0)
            {
                MessageBox.Show("Must select a customer", "Invalid ID");
                return false;
            }
            return true;
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

        //Validate Appointment Dates
        static public bool IsDateValid(DateTime start, DateTime end, int id = -1)
        {
            //Is the start date the same as end date?
            if (start.Date != end.Date)
            {
                MessageBox.Show("Start and End day must be the same", "Invalid Days");
                return false;
            }
            //Is the selected date before the current date?
            if (start.Date < CurrentTime.Date)
            {
                MessageBox.Show("Cannot set an appointment before the current date", "Invalid Date");
                return false;
            }
            //Do the hours fall within business hours?
            if (start.Hour < 8 || start.Hour > 17 || end.Hour < 8 || end.Hour > 17)
            {
                MessageBox.Show("Hours must be within business hours (8am - 5pm)", "Invalid Hours");
                return false;
            }
            //Is start hour earlier than the end hour?
            if (start.Hour >= end.Hour)
            {
                MessageBox.Show("Start time cannot be after or same as end time", "Invalid Hours");
                return false;
            }
            //Is there overlap with another appointment? Skip comparison for appointment that is being updated
            foreach (var ap in userAppointments)
            {// still needs that check

                if (ap.appointmentId == id)
                {
                    continue;
                }
                else if (ap.start.Day == start.Day)
                {
                    if (ap.start.Hour < end.Hour && start.Hour < ap.end.Hour)
                    {
                        MessageBox.Show("Cannot overlap with an existing appointment", "Invalid Appointment Time");
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
