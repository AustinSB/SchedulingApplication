using SchedulingDataModel;
using System;
using System.Linq;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using static SchedulingForms.UserTracker;

namespace SchedulingForms
{
    public partial class AddAppointment_Form : Form
    {
        ScheduleEntities ent;

        private DateTime startDate;
        private DateTime endDate;

        int selectedCustomerID;

        bool enteredStartTextBox = false;
        bool enteredEndTextBox = false;

        public AddAppointment_Form()
        {
            InitializeComponent();

            using(ent = new ScheduleEntities())
            {
                PopulateCustomerComboBox();
            }
        }

        public event EventHandler ApptAdd_SaveClicked;
        public event EventHandler ApptAdd_CancelClicked;

        private void save_Button_Click(object sender, EventArgs e)
        {
            if (!IsDateValid())
            {
                MessageBox.Show("Cannot schedule appointment before or on today.","Invalid Date");
                return;
            }
            if (!AreHoursValid(startTime_TextBox.Text) || !AreHoursValid(endTime_TextBox.Text))
            {
                MessageBox.Show("Hours must be typed in '00:00' format in 24-hour time, between business hours (8AM-5PM)","Invalid Hours");
                return;
            }

            startDate = SetDate(startTime_TextBox.Text);
            endDate = SetDate(endTime_TextBox.Text);

            if (IsThereOverlap())
            {
                MessageBox.Show("Appointment time cannot overlap with another appointment on the same day.","Appointment Overlap");
                return;
            }

            AddAppointment();

            ApptAdd_SaveClicked(this, e);
            this.Close();
        }

        private void cancel_Button_Click(object sender, EventArgs e)
        {
            ApptAdd_CancelClicked(this, e);
            this.Close();
        }

        //Get the selected customer
        private void customerID_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCustomerID = Convert.ToInt32(char.GetNumericValue(customerID_ComboBox.SelectedItem.ToString().First()));
        }

        ////Methods
        //Make sure time is valid
        private bool AreHoursValid(string input)
        {
            //Validate Time
            var hourAndMinute = input.Split(':');

            //if the format is NOT "00:00", return false
            if (hourAndMinute.Length != 2 || hourAndMinute[0].Length != 2 || hourAndMinute[1].Length != 2)
            {
                return false;
            }

            var hour = Convert.ToInt32(hourAndMinute[0]);
            var minute = Convert.ToInt32(hourAndMinute[1]);

            //Make sure hour is between 8AM and 5PM, and make sure minute is valid
            if (hour < 8 || hour > 17)
            {
                return false;
            }
            else if (minute < 0 || minute > 59)
            {
                return false;
            }
            else if (hour == 17 && minute > 0)
            {
                return false;
            }

            return true;
        }

        //Make sure appointments do not overlap
        private bool IsThereOverlap()
        {
            foreach (var ap in userAppointments)
            {
                if (ap.start.Day == startDate.Day)
                {
                    if (ap.start.Hour < endDate.Hour && startDate.Hour < ap.end.Hour)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        //Set start and end Dates for the new appointment record
        private DateTime SetDate(string input)
        {
            var hourAndMinute = input.Split(':');
            var hour = Convert.ToInt32(hourAndMinute[0]);
            var minute = Convert.ToInt32(hourAndMinute[1]);
            var selectedDate = date_MonthCalendar.SelectionRange.Start;

            var date = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day, hour, minute, 0);

            return date;
        }

        //You cannot schedule an appointment before or on the current day.
        private bool IsDateValid()
        {
            if (date_MonthCalendar.SelectionRange.Start <= CurrentTime)
            {
                return false;
            }
            return true;
        }

        //Adds a new appointment to the database
        private void AddAppointment()
        {
            try
            {
                using (ent = new ScheduleEntities())
                {
                    var newAppointment = new appointment
                    {
                        customerId = selectedCustomerID,
                        userId = ActiveUser.userId,
                        title = title_TextBox.Text,
                        description = description_TextBox.Text,
                        location = location_TextBox.Text,
                        contact = contact_TextBox.Text,
                        type = type_TextBox.Text,
                        url = url_TextBox.Text,
                        start = startDate.ToUniversalTime(),
                        end = endDate.ToUniversalTime(),
                        createDate = CurrentTime,
                        createdBy = ActiveUser.userName,
                        lastUpdate = CurrentTime,
                        lastUpdateBy = ActiveUser.userName
                    };

                    ent.appointments.Add(newAppointment);
                    ent.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }  
        }

        private void PopulateCustomerComboBox()
        {

            customerID_ComboBox.Items.Clear();

            var customerQuery = from customer in ent.customers
                                select customer;

            foreach (var item in customerQuery)
            {
                if (customerID_ComboBox.Items.Contains($"{item.customerId}"))
                {
                    continue;
                }
                else
                {
                    customerID_ComboBox.Items.Add($"{item.customerId} - {item.customerName}");
                }
            }
        }

        //Remove placeholder text on enter
        private void startTime_TextBox_Enter(object sender, EventArgs e)
        {
            if (enteredStartTextBox)
            {
                return;
            }
            else
            {
                startTime_TextBox.Text = "";
                enteredStartTextBox = true;
            }
        }

        private void endTime_TextBox_Enter(object sender, EventArgs e)
        {
            if (enteredEndTextBox)
            {
                return;
            }
            else
            {
                endTime_TextBox.Text = "";
                enteredEndTextBox = true;
            }
        }
    }
}
