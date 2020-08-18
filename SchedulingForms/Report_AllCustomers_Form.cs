using SchedulingDataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Environment;

namespace SchedulingForms
{
    public partial class Report_AllCustomers_Form : Form
    {
        ScheduleEntities ent;

        public Report_AllCustomers_Form()
        {
            InitializeComponent();

            FillReport();
        }

        private void FillReport()
        {
            using(ent = new ScheduleEntities())
            {
                var cuQuery = from cu in ent.customers
                              orderby cu.customerName ascending
                              select cu;

                foreach (var cu in cuQuery.ToList())
                {
                    //Lambdas allow for associated records from several different tables to be used together in this report
                    var custAddress = ent.addresses.FirstOrDefault(a => a.addressId == cu.addressId);
                    var custCity = ent.cities.FirstOrDefault(c => c.cityId == custAddress.cityId);
                    var custCountry = ent.countries.FirstOrDefault(ctry => ctry.countryId == custCity.countryId);



                    display_TextBox.AppendText($"------------------------------------------{NewLine}");

                    display_TextBox.AppendText($"ID: {cu.customerId} - Name: {cu.customerName}{NewLine}");

                    display_TextBox.AppendText($"------------------------------------------{NewLine}");

                    display_TextBox.AppendText($"    Address: {custAddress.address1}{NewLine}");
                    
                    display_TextBox.AppendText($"    {custCity.cityName} - {custCountry.countryName}{NewLine}");
                }
            }
        }

        private void close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private string Seperator(int n)
        //{
        //    return new string('-', n);
        //}
    }
}
