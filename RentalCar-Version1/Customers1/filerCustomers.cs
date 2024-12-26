using Logic_Tier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalCar_Version1.Customers1
{
    public partial class filerCustomers : UserControl
    {
        private int _id = -1;
        private Customers_CLS _Customers;
        private bool _FilterEnabled;
        public filerCustomers()
        {
            InitializeComponent();
        }
        public bool FilterEnabled
        {
            get
            {
                return _FilterEnabled;
            }
            set
            {
                _FilterEnabled = value;
                Filter.Enabled = _FilterEnabled;
            }
        }

        public int Customerid
        {
            get { return _id; } 
        }
        public Customers_CLS CustomerInfo 
        {
            get { return _Customers; }

        }

        public void LoadByid(int id)
        {
            personDetails1.Loadinfo(id);
            _Customers = Customers_CLS.FindByPersonID(id);
            if (_Customers == null)
            {
                MessageBox.Show("NOT FOUND !");
                return;
            }
            _id = _Customers.CustomerID;
            CustomerID.Text = _id.ToString();
            driverlicence.Text = _Customers.DriverLicenseNumber;
        }
        private void filerCustomers_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void SearchBTN_Click(object sender, EventArgs e)
        {
            _Customers = Customers_CLS.FindByCustomerID(int.Parse(customid.Text));
            if (_Customers == null)
            {
                MessageBox.Show("NOT FOUND !");
                return;
            }
            personDetails1.Loadinfo(_Customers.PersonID);
            
            CustomerID.Text = _Customers.CustomerID.ToString();
            _id= _Customers.CustomerID;
            driverlicence.Text= _Customers.DriverLicenseNumber.ToString();
        }
    }
}
