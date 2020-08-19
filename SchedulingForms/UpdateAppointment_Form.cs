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
using static SchedulingForms.ValidateAppointment;

namespace SchedulingForms
{
    public partial class UpdateAppointment_Form : Form
    {
        ScheduleEntities ent;
        
        int selectedCustomerID;

        public UpdateAppointment_Form()
        {
            InitializeComponent();

            using(ent = new ScheduleEntities())
            {
                PopulateCustomerComboBox();
                PopulateAppointmentUpdateForm();
            }
        }

        public event EventHandler updateAppt_SaveClicked;
        public event EventHandler updateAppt_CancelClicked;

        private void save_Button_Click(object sender, EventArgs e)
        {
            if (!IsValid()) { return; }

            UpdateAppointment();

            updateAppt_SaveClicked(this, e);
            this.Close();
        }

        private void cancel_Button_Click(object sender, EventArgs e)
        {
            updateAppt_CancelClicked(this, e);
            this.Close();
        }

        //Get the selected customer
        private void customerID_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCustomerID = Convert.ToInt32(char.GetNumericValue(customerID_ComboBox.SelectedItem.ToString().First()));
        }

        ////Methods
        //Fill the form with the data of the appointment that was selected for updating
        private void PopulateAppointmentUpdateForm()
        {
            SetCustomerSelection(AppointmentIndex.customerId);

            selectedCustomerID = Convert.ToInt32(char.GetNumericValue(customerID_ComboBox.SelectedItem.ToString().First()));

            title_TextBox.Text = AppointmentIndex.title;
            location_TextBox.Text = AppointmentIndex.location;
            contact_TextBox.Text = AppointmentIndex.contact;
            type_TextBox.Text = AppointmentIndex.type;
            url_TextBox.Text = AppointmentIndex.url;
            description_TextBox.Text = AppointmentIndex.description;

            start_TimePicker.Value = AppointmentIndex.start;
            end_TimePicker.Value = AppointmentIndex.end;
        }

        private void SetCustomerSelection(int id)
        {
            foreach (var item in customerID_ComboBox.Items)
            {
                if(item.ToString().Contains($"{id} -"))
                {
                    customerID_ComboBox.SelectedItem = item;
                }
            }
        }

        //Fill the customer combo box with existing customers
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

        //Update database record
        private void UpdateAppointment()
        {
            try
            {
                using(ent = new ScheduleEntities())
                {
                    var currentAppointment = ent.appointments.Attach(AppointmentIndex);
                    
                    currentAppointment.customerId = selectedCustomerID;
                    currentAppointment.userId = ActiveUser.userId;

                    currentAppointment.title = title_TextBox.Text;
                    currentAppointment.location = location_TextBox.Text;
                    currentAppointment.contact = contact_TextBox.Text;
                    currentAppointment.type = type_TextBox.Text;
                    currentAppointment.url = url_TextBox.Text;
                    currentAppointment.description = description_TextBox.Text;
                    
                    currentAppointment.start = start_TimePicker.Value.ToUniversalTime();
                    currentAppointment.end = end_TimePicker.Value.ToUniversalTime();

                    currentAppointment.lastUpdate = CurrentTime;
                    currentAppointment.lastUpdateBy = ActiveUser.userName;

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
            if (!IsDateValid(start_TimePicker.Value, end_TimePicker.Value, AppointmentIndex.appointmentId)) { return false; }

            if (!IsCutomerSelected(selectedCustomerID)) { return false; }

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
