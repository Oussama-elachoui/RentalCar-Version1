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
    public partial class CustomerUPDATEADD : Form
    {
        private int _CustomerID = -1;
        private Customers_CLS _Customer;
        private enum Enmode { Update = 0, ADD = 1 }
        private Enmode _Enmode;
        public CustomerUPDATEADD()
        {
            InitializeComponent();
            _Enmode = Enmode.ADD;

        }
        public CustomerUPDATEADD(int CustomerID)
        {
            InitializeComponent();
            _Enmode = Enmode.Update;
            _CustomerID = CustomerID;

        }

        private void _Initialfilling()
        {
            if (_Enmode == Enmode.Update)
            {
                personDetailsWithFilter1.FilterEnabled = false;
                button1.Enabled = true;
                personIDTXT.Enabled = false;
                DriverLicenseNumberTXT.Enabled = true;
                TITLE.Text = "Update Customer";
            }
            else
            {
                _Customer= new Customers_CLS();
                personDetailsWithFilter1.FilterEnabled = true;
                button1.Enabled = true;
                personIDTXT.Enabled = false;
                personIDTXT.Text = ""; 
                DriverLicenseNumberTXT.Enabled = true;
                DriverLicenseNumberTXT.Text = "";
                TITLE.Text = "ADD NEW Customer";
            }
        }
        private void _FILLDATA()
        {
            _Customer = Customers_CLS.FindByCustomerID(_CustomerID);
            if (_Customer == null)
            {
                MessageBox.Show("The provided Customer ID is invalid. Please verify and try again.");
                return;
            }
            personDetailsWithFilter1.LOADBYID(_Customer.PersonID);
            CustomerIDTXT.Text = _Customer.CustomerID.ToString();
            personIDTXT.Text = _Customer.PersonID.ToString();
            personIDTXT.Enabled = false;
            DriverLicenseNumberTXT.Text = _Customer.DriverLicenseNumber.ToString();
        }


        private void CustomerUPDATEADD_Load(object sender, EventArgs e)
        {
            _Initialfilling();
            if (_Enmode == Enmode.Update)
            {
                _FILLDATA();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(_Enmode == Enmode.Update)
            {
                tabControl1.SelectedTab = tabControl1.TabPages["CustomerTAB"];
            }
            else 
            { 


                if (personDetailsWithFilter1.PersonId == -1)
                {
                    MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (Customers_CLS.IsExistByPersonID(personDetailsWithFilter1.PersonId))
                {
                    MessageBox.Show("Selected Person already has a Customer, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                tabControl1.SelectedTab = tabControl1.TabPages["CustomerTAB"];
                personIDTXT.Text = personDetailsWithFilter1.PersonId.ToString();
            }







        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _Customer.PersonID= personDetailsWithFilter1.PersonId;
            _Customer.DriverLicenseNumber=DriverLicenseNumberTXT.Text;

            if (_Customer.SAVE())
            {
                _Enmode = Enmode.Update;  
                TITLE.Text = "Update Customer";
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CustomerIDTXT.Text = _Customer.CustomerID.ToString();

            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void DriverLicenseNumberTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void DriverLicenseNumberTXT_Validating(object sender, CancelEventArgs e)
        {
            // Check if the field is empty
            if (string.IsNullOrEmpty(DriverLicenseNumberTXT.Text))
            {
                e.Cancel = true; // Prevent the user from leaving the control
                errorProvider1.SetError(DriverLicenseNumberTXT, "Please enter a value.");
                return;
            }

            // Check if the driver license number already exists in ADD mode
            if (_Enmode == Enmode.ADD && Customers_CLS.IsDriverlicenceNumberExist(DriverLicenseNumberTXT.Text))
            {
                e.Cancel = true; // Prevent the user from leaving the control
                errorProvider1.SetError(DriverLicenseNumberTXT, "This Driver License Number already exists.");
                return;
            }

            // If all validations pass, clear the error
            errorProvider1.SetError(DriverLicenseNumberTXT, string.Empty);
        }
    }
}
