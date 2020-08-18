using Org.BouncyCastle.Asn1.Cms;
using SchedulingDataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations.Model;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static SchedulingForms.UserTracker;

namespace SchedulingForms
{
    public partial class UserMenu_Form : Form
    {
        ScheduleEntities ent;

        public UserMenu_Form()
        {
            InitializeComponent();

            using (ent = new ScheduleEntities())
            {
                PopulateUserMenu();

                appointments_DataGrid.DataSource = userAppointments;
                appointments_DataGrid.Columns["customer"].Visible = false;
                appointments_DataGrid.Columns["user"].Visible = false;

                customer_DataGrid.DataSource = userCustomers;
                customer_DataGrid.Columns["address"].Visible = false;

                ShowReminder();
            }
        }

        private void UserMenu_Form_Load(object sender, EventArgs e)
        {
            DeselectRows();
        }

    ////Appointment Controls
        private void appointments_DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0)
            {
                AppointmentIndex = userAppointments[0];
                appointments_DataGrid.Rows[0].Selected = true;
            }
            else
            {
                AppointmentIndex = userAppointments[e.RowIndex];
                Debug.WriteLine($"AppointmentTest: {AppointmentIndex.appointmentId} - {AppointmentIndex.type}");
            }
        }

        //Add Appointment
        private void apptAdd_Button_Click(object sender, EventArgs e)
        {
            var addAppointment = new AddAppointment_Form();
            addAppointment.ApptAdd_SaveClicked += new EventHandler(addAppointment_Form_SaveClicked);
            addAppointment.ApptAdd_CancelClicked += new EventHandler(addAppointment_Form_CancelClicked);
            addAppointment.Show();
            this.Enabled = false;
        }

        private void addAppointment_Form_SaveClicked(object sender, EventArgs e)
        {
            using(ent = new ScheduleEntities())
            {
                PopulateAppointmentGrid();
                appointments_DataGrid.DataSource = userAppointments;
                DeselectRows();
                AppointmentIndex = null;
            }

            this.Enabled = true;
        }

        private void addAppointment_Form_CancelClicked(object sender, EventArgs e)
        {
            this.Enabled = true;
        }

        //Update Appointment
        private void apptUpdate_Button_Click(object sender, EventArgs e)
        {
            if (IsIndexNull(AppointmentIndex, "Appointment", "Update")) { return; }

            var updateAppointment = new UpdateAppointment_Form();
            updateAppointment.updateAppt_SaveClicked += new EventHandler(updateAppointment_Form_SaveClicked);
            updateAppointment.updateAppt_CancelClicked += new EventHandler(updateAppointment_Form_CancelClicked);
            updateAppointment.Show();
            
            this.Enabled = false;
        }

        private void updateAppointment_Form_SaveClicked(object sender, EventArgs e)
        {
            //
            //
            //
            ChangeTimeZone();
            this.Enabled = true;
        }

        private void updateAppointment_Form_CancelClicked(object sender, EventArgs e)
        {
            this.Enabled = true;
        }

        //Delete Appointment
        private void apptDelete_Button_Click(object sender, EventArgs e)
        {
            if (IsIndexNull(AppointmentIndex, "Appointment", "Delete")) { return; }

            var messageDeleteAppointment = MessageBox.Show($"Are you sure you want to delete appointment with ID {AppointmentIndex.appointmentId}?", "Delete Appointment", MessageBoxButtons.YesNo);
            if(messageDeleteAppointment == DialogResult.Yes)
            {
                using(ent = new ScheduleEntities())
                {
                    ent.appointments.Attach(AppointmentIndex);
                    ent.appointments.Remove(AppointmentIndex);
                    ent.SaveChanges();

                    PopulateAppointmentGrid();
                    appointments_DataGrid.DataSource = userAppointments;
                    DeselectRows();
                    AppointmentIndex = null;
                }
            }
        }

        //Show appointments based on calendar radio button selection
        private void CalendarRadioButtonSelection_Click(object sender, EventArgs e)
        {
            using (ent = new ScheduleEntities())
            {
                PopulateAppointmentGrid();
                DeselectRows();
            }
        }

        ////Customer Controls
        private void customer_DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                CustomerIndex = userCustomers[0];
                customer_DataGrid.Rows[0].Selected = true;
            }
            else
            {
                CustomerIndex = userCustomers[e.RowIndex];
                Debug.WriteLine($"CustomerTest: {CustomerIndex.customerId} - {CustomerIndex.customerName}");
            }
        }

        private void custAdd_Button_Click(object sender, EventArgs e)
        {
            var addCustomer = new AddCustomer_Form();
            addCustomer.AddCust_SaveClicked += new EventHandler(addNewCustomer_Form_SaveClicked);
            addCustomer.AddCust_CancelClicked += new EventHandler(addNewCustomer_Form_CancelClicked);
            addCustomer.Show();

            this.Enabled = false;
        }

        //Handles the event of new customer being saved.
        private void addNewCustomer_Form_SaveClicked(object sender, EventArgs e)
        {
            using(ent = new ScheduleEntities())
            {
                PopulateCustomerGrid();
                customer_DataGrid.DataSource = userCustomers;
                DeselectRows();
                CustomerIndex = null;
            }

            this.Enabled = true;
        }

        //Handles the event of 'Add New Customer' window being closed/canceled.
        private void addNewCustomer_Form_CancelClicked(object sender, EventArgs e)
        {
            this.Enabled = true;
        }

        //Update Customer
        private void custUpdate_Button_Click(object sender, EventArgs e)
        {
            if (IsIndexNull(CustomerIndex, "Customer", "Update")) { return; }

            var updateCustomer = new UpdateCustomer_Form();
            updateCustomer.UpCust_SaveClicked += new EventHandler(updateCustomer_Form_SaveClicked);
            updateCustomer.UpCust_CancelClicked += new EventHandler(updateCustomer_Form_CancelClicked);
            updateCustomer.Show();

            this.Enabled = false;
        }

        private void updateCustomer_Form_SaveClicked(object sender, EventArgs e)
        {
            using (ent = new ScheduleEntities())
            {
                PopulateCustomerGrid();
                customer_DataGrid.DataSource = userCustomers;
                DeselectRows();
                CustomerIndex = null;
            }

            this.Enabled = true;
        }

        private void updateCustomer_Form_CancelClicked(object sender, EventArgs e)
        {
            this.Enabled = true;
        }

        //Delete Customer
        private void custDelete_Button_Click(object sender, EventArgs e)
        {
            if (IsIndexNull(CustomerIndex, "Customer", "Delete")) { return; }

            var messageDeleteCustomer = MessageBox.Show($"Are you sure you want to delete record '{CustomerIndex.customerName}'?", "Delete Customer", MessageBoxButtons.YesNo);
            if(messageDeleteCustomer == DialogResult.Yes) 
            {
                using (ent = new ScheduleEntities())
                {
                    ent.customers.Attach(CustomerIndex);
                    ent.customers.Remove(CustomerIndex);
                    ent.SaveChanges();

                    PopulateCustomerGrid();
                    customer_DataGrid.DataSource = userCustomers;
                    DeselectRows();
                    CustomerIndex = null;
                }
            }
        }

        private void print_Button_Click(object sender, EventArgs e)
        {
            switch (report_ComboBox.SelectedIndex)
            {
                case 0:
                    var custReport = new Report_AllCustomers_Form();
                    custReport.Show();
                    break;
                case 1:
                    var monthReport = new Report_ApptTypesByMonth_Form();
                    monthReport.Show();
                    break;
                case 2:
                    var userReport = new Report_UserSchedules_Form();
                    userReport.Show();
                    break;
                default:
                    break;
            }
        }

        public event EventHandler ExitClicked;

        private void exitApp_Button_Click(object sender, EventArgs e)
        {
            var messageExit = MessageBox.Show("Are you sure you want to exit the program?", "Confirm Exit", MessageBoxButtons.YesNo);

            if(messageExit == DialogResult.Yes)
            {
                ExitClicked(this, e);
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void UserMenu_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            ExitClicked(this, e);
        }

        ////Methods
        private void PopulateUserMenu()
        {
            userMenu_Label.Text = $"{ActiveUser.userName}'s Menu";
            this.Text = $"{ActiveUser.userName}'s Account";

            PopulateAppointmentGrid();
            PopulateCustomerGrid();

            FillReportComboBox();
        }

        private void PopulateAppointmentGrid()
        {
            foreach (var item in userAppointments.ToList())
            {
                userAppointments.Remove(item);
            }

            if (all_Radio.Checked)
            {
                
                //Lambda reduces the amount of code that is needed (replaces several LINQ queries).
                var allQuery = ent.appointments.Where(ap => ap.userId == ActiveUser.userId);

                //Lambda allows for code reuse (replaces several nearly identical foreach loops)
                ForEachListItem(allQuery, ap => userAppointments.Add(ap));
                ChangeTimeZone();
            }
            else if (week_Radio.Checked)
            {
                var weekQuery = ent.appointments
                     .Where(ap => ap.userId == ActiveUser.userId)
                     .Where(ap => ap.start.Month == CurrentTime.Month);
                foreach (var ap in weekQuery)
                {
                    if (DaysOfCurrentWeek(ap.start.Day))
                    {
                        userAppointments.Add(ap);
                    }
                }
                ChangeTimeZone();
            }
            else if (month_Radio.Checked)
            {
                var monthQuery = ent.appointments
                                    .Where(ap => ap.userId == ActiveUser.userId)
                                    .Where(ap => ap.start.Month == CurrentTime.Month);
                ForEachListItem(monthQuery, ap => userAppointments.Add(ap));
                ChangeTimeZone();
            }
        }

        //Changes the appointment datetimes to local time
        private void ChangeTimeZone()
        {
            Debug.WriteLine($"{TimeZone.CurrentTimeZone.StandardName}");

            foreach (var item in userAppointments)
            {
                item.start = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(item.start, TimeZoneInfo.Local.Id);
                item.end = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(item.end, TimeZoneInfo.Local.Id);
            }
        }

        //Get the current week of the month for appointments
        private bool DaysOfCurrentWeek(int currentDay)
        {
            var list = new List<int>();

            //subtract days to get monday, then add from there
            var date = CurrentTime;

            switch (CurrentTime.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    date = date.AddDays(0);
                    break;
                case DayOfWeek.Monday:
                    date = date.AddDays(-1);
                    break;
                case DayOfWeek.Tuesday:
                    date = date.AddDays(-2);
                    break;
                case DayOfWeek.Wednesday:
                    date = date.AddDays(-3);
                    break;
                case DayOfWeek.Thursday:
                    date = date.AddDays(-4);
                    break;
                case DayOfWeek.Friday:
                    date = date.AddDays(-5);
                    break;
                case DayOfWeek.Saturday:
                    date = date.AddDays(-6);
                    break;
                default:
                    break;
            }

            for (int i = 0; i < 7; i++)
            {
                list.Add(date.Day);
                date = date.AddDays(1);
            }

            //if current day is in the list of this week's days, return true
            foreach (var d in list)
            {
                if (currentDay == d)
                {
                    return true;
                }
            }
            return false;
        }
        
        private void PopulateCustomerGrid()
        {
            foreach (var item in userCustomers.ToList())
            {
                userCustomers.Remove(item);
            }

            var cuQuery = ent.customers.Where(c => c.createdBy == ActiveUser.userName);
            ForEachListItem(cuQuery, cu => userCustomers.Add(cu)); 
        }
        
        private void ForEachListItem<T>(IEnumerable<T> list, Action<T> action)
        {
            foreach (var item in list)
            {
                action(item);
            }
        }

        private void FillReportComboBox()
        {
            report_ComboBox.Items.Add("Print all customers, order by name");
            report_ComboBox.Items.Add("Print appointment types by month");
            report_ComboBox.Items.Add("Print all user schedules");
        }

        //Deselect datagrid rows
        private void DeselectRows()
        {
            for (int i = 0; i < appointments_DataGrid.Rows.Count; i++)
            {
                appointments_DataGrid.Rows[i].Selected = false;
            }

            for (int i = 0; i < customer_DataGrid.Rows.Count; i++)
            {
                customer_DataGrid.Rows[i].Selected = false;
            }
        }

        //If an index variable is null, show error message and return false
        private bool IsIndexNull(object index, string item, string action)
        {
            if(index == null)
            {
                MessageBox.Show($"Must select {item.ToLower()} to {action.ToLower()}",$"{action} Error");
                return true;
            }
            //index is not null
            return false;
        }

        //Show a reminder for appointments that will happen within 15 minutes
        private void ShowReminder()
        {
            using(ent = new ScheduleEntities())
            {
                foreach (var appt in userAppointments)
                {
                    //This lambda allows me to get the customer which corresponds with the current appointment in this foreach block
                    var cust = ent.customers.FirstOrDefault(c => c.customerId == appt.customerId);
                   
                    var timeLeft = appt.start - CurrentTime;

                    if (timeLeft.TotalMinutes <= 15  && timeLeft.TotalSeconds > 0)
                    {
                        MessageBox.Show($"You have an appointment with {cust.customerName} today at {appt.start.ToString("hh:mm tt")}", "Appointment Reminder");
                    }
                }
            }
        }
    }
}
