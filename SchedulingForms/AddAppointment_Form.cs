using SchedulingDataModel;
using System;
using System.Linq;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using static SchedulingForms.UserTracker;
using static SchedulingForms.ValidateAppointment;
using System.Collections;
using System.Collections.Generic;

namespace SchedulingForms
{
    public partial class AddAppointment_Form : Form
    {
        ScheduleEntities ent;

        int selectedCustomerID = -1;

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

            if(!IsCutomerSelected(selectedCustomerID)) { return false; }

            if (!DoesTextBoxHaveValue(title_TextBox.Text, "Title")) { return false; }
            if (!DoesTextBoxHaveValue(location_TextBox.Text, "Location")) { return false; }
            if (!DoesTextBoxHaveValue(contact_TextBox.Text, "Contact")) { return false; }
            if (!DoesTextBoxHaveValue(type_TextBox.Text, "Type")) { return false; }
            if (!DoesTextBoxHaveValue(url_TextBox.Text, "Url")) { return false; }
            if (!DoesTextBoxHaveValue(description_TextBox.Text, "Description")) { return false; }

            return true;
        }

        
    }
}
