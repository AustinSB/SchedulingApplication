using SchedulingDataModel;
using System;
using System.Linq;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using static SchedulingForms.UserTracker;
using System.Collections;
using System.Collections.Generic;

namespace SchedulingForms
{
    public partial class AddAppointment_Form : Form
    {
        ScheduleEntities ent;

        int selectedCustomerID;

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
            if(!IsValid()) { return; }

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

                        start = start_TimePicker.Value.ToUniversalTime(),
                        end = end_TimePicker.Value.ToUniversalTime(),

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

        //Validation
        private bool IsValid()
        {

            if (!IsDateValid(start_TimePicker.Value, end_TimePicker.Value)) { return false; }

            return true;
        }



        //Make sure days and hours are valid
        private bool IsDateValid(DateTime start, DateTime end)
        {
            //Is the start day the same as end day?
            if (start.Day != end.Day)
            {
                MessageBox.Show("Start and End days must be the same", "Invalid Days");
                return false;
            }
            //Do the hours fall within business hours?
            if (start.Hour < 8 || start.Hour > 17 || end.Hour < 8 || end.Hour > 17)
            {
                MessageBox.Show("Hours must be within business hours (8am - 5pm)", "Invalid Hours");
                return false;
            }
            //Is start hour earlier than the end hour?
            if(start.Hour >= end.Hour)
            {
                MessageBox.Show("Start time cannot be after or same as end time","Invalid Hours");
                return false;
            }
            //Is there overlap with another appointment?
            foreach (var ap in userAppointments)
            {
                if (ap.start.Day == start.Day)
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
