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
    public partial class UpdateCustomer_Form : Form
    {
        ScheduleEntities ent;

        int selectedAddressID;

        public UpdateCustomer_Form()
        {
            InitializeComponent();
        }

        private void UpdateCustomer_Form_Load(object sender, EventArgs e)
        {
            using (ent = new ScheduleEntities())
            {
                PopulateAddressComboBox();
            }

            PopulateCustomerUpdateMenu();
        }

        public event EventHandler UpCust_SaveClicked;
        public event EventHandler UpCust_CancelClicked;

        private void addressID_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedAddressID = Convert.ToInt32(char.GetNumericValue(addressID_ComboBox.SelectedItem.ToString().First()));
        }

        private void save_Button_Click(object sender, EventArgs e)
        {
            using(ent = new ScheduleEntities())
            {
                //update record in the table
                var currentRecord = ent.customers.Attach(CustomerIndex);
                currentRecord.customerName = name_TextBox.Text;
                currentRecord.addressId = selectedAddressID;
                currentRecord.active = IsActive();
                currentRecord.lastUpdate = CurrentTime;
                currentRecord.lastUpdateBy = ActiveUser.userName;
                ent.SaveChanges();
            }

            UpCust_SaveClicked(this, e);
            this.Close();
        }

        private void cancel_Button_Click(object sender, EventArgs e)
        {
            UpCust_CancelClicked(this, e);
            this.Close();
        }

        ////Methods
        private void PopulateAddressComboBox()
        {
            addressID_ComboBox.Items.Clear();

            var addressQuery = from address in ent.addresses
                               select address;

            foreach (var item in addressQuery)
            {
                if (addressID_ComboBox.Items.Contains($"{item.addressId} -"))
                {
                    continue;
                }
                else
                {
                    addressID_ComboBox.Items.Add($"{item.addressId} - {item.address1}");
                }
            }
        }

        //Populate the 'Update Customer' menu with the record that was selected
        private void PopulateCustomerUpdateMenu()
        {
            name_TextBox.Text = CustomerIndex.customerName;
            SetAddressSelection(CustomerIndex.addressId);
            active_Radio.Checked = CustomerIndex.active;
            notActive_Radio.Checked = !CustomerIndex.active;


            created_Label.Text = CustomerIndex.createDate.ToString();
            createdBy_Label.Text = CustomerIndex.createdBy;
            lastUpdate_Label.Text = CustomerIndex.lastUpdate.ToString();
            lastUpdateBy_Label.Text = CustomerIndex.lastUpdateBy;

        }

        private void SetAddressSelection(int id)
        {
            foreach (var item in addressID_ComboBox.Items)
            {
                if (item.ToString().Contains($"{id} -")) 
                {
                    addressID_ComboBox.SelectedItem = item;
                }
            }
        }

        //Determines the "Is Active" value for new customer. Return true if 'yes' is selected.
        private bool IsActive()
        {
            if (active_Radio.Checked)
            {
                return true;
            }
            else if (notActive_Radio.Checked)
            {
                return false;
            }
            return false;
        }
    }
}
