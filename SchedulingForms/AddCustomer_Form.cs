using SchedulingDataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulingForms
{
    public partial class AddCustomer_Form : Form
    {
        ScheduleEntities ent;

        int selectedAddressID;
        int selectedCityID;
        int selectedCountryID;

        public AddCustomer_Form()
        {
            InitializeComponent();
            
            using (ent = new ScheduleEntities()) 
            {
                PopulateAddressComboBox();
                PopulateCityComboBox();
                PopulateCountryComboBox();
            }
        }

    ////Customer Controls and Save/Cancel Buttons
        private void addressID_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedAddressID = Convert.ToInt32(char.GetNumericValue(addressID_ComboBox.SelectedItem.ToString().First()));
        }

        //Event Handlers for when this form is either saved or closed (canceled)
        public event EventHandler AddCust_SaveClicked;
        public event EventHandler AddCust_CancelClicked;

        private void save_Button_Click(object sender, EventArgs e)
        {

            using (ent = new ScheduleEntities())
            {//adds new customer
                var newCustomer = new customer()
                {
                    customerName = name_TextBox.Text,
                    active = IsActive(),
                    createDate = UserTracker.CurrentTime,
                    createdBy = UserTracker.ActiveUser.userName,
                    lastUpdate = UserTracker.CurrentTime,
                    lastUpdateBy = UserTracker.ActiveUser.userName,
                    addressId = selectedAddressID
                };

                ent.customers.Add(newCustomer);
                ent.SaveChanges();

            }

            AddCust_SaveClicked(this, e);
            this.Close();
        }

        private void cancel_Button_Click(object sender, EventArgs e)
        {
            AddCust_CancelClicked(this, e);
            this.Close();
        }


    ////Address Controls
        private void addAddress_Button_Click(object sender, EventArgs e)
        {
            try
            {
                using (ent = new ScheduleEntities())
                {
                    var newAddress = new address()
                    {
                        address1 = address1_TextBox.Text,
                        address2 = address2_TextBox.Text,
                        cityId = selectedCityID,
                        postalCode = postal_TextBox.Text,
                        phone = phone_TextBox.Text,
                        createDate = UserTracker.CurrentTime,
                        createdBy = UserTracker.ActiveUser.userName,
                        lastUpdate = UserTracker.CurrentTime,
                        lastUpdateBy = UserTracker.ActiveUser.userName
                    };

                    ent.addresses.Add(newAddress);
                    ent.SaveChanges();

                    PopulateAddressComboBox();
                    ClearAddressFields();
                    MessageBox.Show($"'{newAddress.address1}' was added", "New Address");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong","Error");
            }
        }

        private void cityID_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCityID = Convert.ToInt32(char.GetNumericValue(cityID_ComboBox.SelectedItem.ToString().First()));
        }

    ////City Controls
        private void addCity_Button_Click(object sender, EventArgs e)
        {
            try
            {
                using (ent = new ScheduleEntities())
                {
                    var newCity = new city
                    {
                        cityName = cityName_TextBox.Text,
                        countryId = selectedCountryID,
                        createDate = UserTracker.CurrentTime,
                        createdBy = UserTracker.ActiveUser.userName,
                        lastUpdate = UserTracker.CurrentTime,
                        lastUpdateBy = UserTracker.ActiveUser.userName
                    };

                    ent.cities.Add(newCity);
                    ent.SaveChanges();

                    PopulateCityComboBox();
                    ClearCityFields();
                    MessageBox.Show($"'{newCity.cityName}' was added", "New City");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong", "Error");
            }
        }

        private void countryID_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCountryID = Convert.ToInt32(char.GetNumericValue(countryID_ComboBox.SelectedItem.ToString().First()));
            Debug.WriteLine($"{selectedCountryID}");
        }

    ////Country Controls
        private void addCountry_Button_Click(object sender, EventArgs e)
        {
            try
            {
                using (ent = new ScheduleEntities())
                {
                    var newCountry = new country 
                    {
                        countryName = countryName_TextBox.Text,
                        createDate = UserTracker.CurrentTime,
                        createdBy = UserTracker.ActiveUser.userName,
                        lastUpdate = UserTracker.CurrentTime,
                        lastUpdateBy = UserTracker.ActiveUser.userName
                    };

                    ent.countries.Add(newCountry);
                    ent.SaveChanges();

                    PopulateCountryComboBox();
                    countryName_TextBox.Text = "";
                    MessageBox.Show($"'{newCountry.countryName}' was added", "New Country");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong", "Error");
            }
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

        private void PopulateCityComboBox()
        {
            cityID_ComboBox.Items.Clear();

            var cityQuery = from city in ent.cities
                            select city;

            foreach (var item in cityQuery)
            {
                if (cityID_ComboBox.Items.Contains($"{item.cityId} -"))
                {
                    continue;
                }
                else
                {
                    cityID_ComboBox.Items.Add($"{item.cityId} - {item.cityName}");
                }
            }
        }

        private void PopulateCountryComboBox()
        {
            countryID_ComboBox.Items.Clear();

            var countryQuery = from country in ent.countries
                               select country;

            foreach (var item in countryQuery)
            {
                if (countryID_ComboBox.Items.Contains($"{item.countryId} -"))
                {
                    continue;
                }
                else
                {
                    countryID_ComboBox.Items.Add($"{item.countryId} - {item.countryName}");
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

        //Clears the fields for the 'Add New Address' section when a new address is added.
        private void ClearAddressFields()
        {
            address1_TextBox.Text = "";
            address2_TextBox.Text = "";
            postal_TextBox.Text = "";
            phone_TextBox.Text = "";
            cityID_ComboBox.ResetText();
        }

        //Clears fields for 'Add New City'
        private void ClearCityFields()
        {
            cityName_TextBox.Text = "";
            countryID_ComboBox.ResetText();
        }


    ////SQL Controls for testing purposes
        private void sql_Button_Click(object sender, EventArgs e)
        {
            var confirmSQL = MessageBox.Show("Run SQL Command?", "SQL", MessageBoxButtons.YesNo);

            if (confirmSQL == DialogResult.Yes) 
            {
                try
                {
                    using (ent = new ScheduleEntities())
                    {
                        string script = sql_TextBox.Text;
                        ent.Database.ExecuteSqlCommand(script);

                        PopulateAddressComboBox();
                        PopulateCityComboBox();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("SQL Failed","Failed");
                }
            }
        }


    }
}
