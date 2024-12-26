using Logic_Tier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalCar_Version1.Customers1
{
    public partial class DetailsCustomer : Form
    {
        private int _CustomerID;
        private Customers_CLS _Customer;
        public DetailsCustomer(int CustomerID)
        {
            InitializeComponent();
            _CustomerID = CustomerID;

        }

        private void isactiveTXT_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void _checkIfexist()
        {
            _Customer = Customers_CLS.FindByCustomerID(_CustomerID);

            if (_Customer == null)
            {
                MessageBox.Show("The provided Customer ID is invalid. Please verify and try again.");
                return;
            }

        }
        private void personDetails1_Load(object sender, EventArgs e)
        {
            _checkIfexist();

            personDetails1.Loadinfo(_Customer.PersonID);
            CustomerID.Text = _Customer.CustomerID.ToString();
            DLN.Text = _Customer.DriverLicenseNumber;
        }

        private void DetailsCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
