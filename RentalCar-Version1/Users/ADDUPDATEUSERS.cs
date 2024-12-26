using Logic_Tier;
using RentalCar_Version1.UserControlMenu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RentalCar_Version1.Menu_Fr;

namespace RentalCar_Version1.Users
{
    public partial class ADDUPDATEUSERS : Form
    {
        private int _UserID;
        private Users_CLS _UserInfo;

        private enum Enmode { ADD = 0, UPDATE = 1 }
        Enmode _ENMODE = Enmode.ADD;


        public ADDUPDATEUSERS()
        {
            InitializeComponent();
            _ENMODE = Enmode.ADD;

        }

        public ADDUPDATEUSERS(int userID)
        {
            InitializeComponent();
            _UserID = userID;
            _ENMODE = Enmode.UPDATE;
        }

        private void _InitialUpload()
        {
            if(_ENMODE == Enmode.ADD)
            {
                TITLE.Text = "ADD NEW USER";
                _UserInfo = new Users_CLS();
                UsernameTXT.Text = "";
                PasswordTXT.Text = "";
                personDetailsWithFilter1.FilterEnabled = true;
                SelectUserPage.Enabled=false;

            }
            else
            {
                TITLE.Text = "UPDATE USER";
                personDetailsWithFilter1.FilterEnabled = false;
                SelectUserPage.Enabled = true;

            }


        }

        private void _UPLOADDATA()
        {
            _UserInfo = Users_CLS.FindBYUSERID( _UserID );

                if (_UserInfo == null)
                {
                    MessageBox.Show("Person not found. Please check the ID and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                USERIDTXT.Text = _UserID.ToString();
                UsernameTXT.Text = _UserInfo.Username;
                PasswordTXT.Text = _UserInfo.Password;
                personIDTXT.Text= _UserInfo.PersonID.ToString();
            _FillPermission();

                if (_UserInfo.IsActive)
                {
                    IsActive.Checked = true;
                }
                else
                {
                    IsActive.Checked = false;

                }
                personDetailsWithFilter1.LOADBYID(_UserInfo.PersonID);
            
        }

        private void ADDUPDATEUSERS_Load(object sender, EventArgs e)
        {
            _InitialUpload();

            if (_ENMODE == Enmode.UPDATE)
            {
                _UPLOADDATA();
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (_ENMODE == Enmode.UPDATE)
            {
                UserTAB.SelectedTab = UserTAB.TabPages["SelectUserPage"];
                return;
            }

            if (personDetailsWithFilter1.PersonId == -1)
            {
                MessageBox.Show("Please select an Person ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Users_CLS.IsExistByPersonID(personDetailsWithFilter1.PersonId))
            {
                MessageBox.Show("Selected Person already has a user, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SelectUserPage.Enabled = true;
            UserTAB.SelectedTab = UserTAB.TabPages["SelectUserPage"];
            personIDTXT.Text = personDetailsWithFilter1.PersonId.ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _FillPermission()
        {
            if(_ENMODE == Enmode.UPDATE)
            {
                Customers.Checked = CurrentUser.CheckAccessDenied(Users_CLS.enPermissions.ManageCustomers, _UserInfo);
                Users.Checked = CurrentUser.CheckAccessDenied(Users_CLS.enPermissions.ManageUsers, _UserInfo);
                Vehicles.Checked = CurrentUser.CheckAccessDenied(Users_CLS.enPermissions.ManageVehicles, _UserInfo);
                Booking.Checked = CurrentUser.CheckAccessDenied(Users_CLS.enPermissions.ManageBooking, _UserInfo);
                Return.Checked = CurrentUser.CheckAccessDenied(Users_CLS.enPermissions.ManageReturn, _UserInfo);
                Transactions.Checked = CurrentUser.CheckAccessDenied(Users_CLS.enPermissions.ManageTransactions,_UserInfo);
                People.Checked = CurrentUser.CheckAccessDenied(Users_CLS.enPermissions.ManagePeople, _UserInfo);
            }
        }

        public enum enPermissions
        {

            ManageCustomers = 1,
            ManageUsers = 2,
            ManageVehicles = 4,
            ManageReturn = 8, 
            ManageBooking = 16,
            ManageTransactions = 32,
            ManagePeople = 64
        }
        private int _CountPermissions()
        {
            int Permissions = 0;


            if (Customers.Checked)
                Permissions += (int)enPermissions.ManageCustomers;

            if (Users.Checked)
                Permissions += (int)enPermissions.ManageUsers;

            if (Vehicles.Checked)
                Permissions += (int)enPermissions.ManageVehicles;

            if (Booking.Checked)
                Permissions += (int)enPermissions.ManageBooking;

            if (Return.Checked)
                Permissions += (int)enPermissions.ManageReturn;

            if (Transactions.Checked)
                Permissions += (int)enPermissions.ManageTransactions;

            if (People.Checked)
                Permissions += (int)enPermissions.ManagePeople;

            return Permissions;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                _UserInfo.PersonID = int.Parse(personIDTXT.Text);
                _UserInfo.Username = UsernameTXT.Text;
                _UserInfo.Password = PasswordTXT.Text;
                _UserInfo.Permissions = _CountPermissions();
                _UserInfo.IsActive = IsActive.Checked;

                if (_UserInfo.save())
                {
                    MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data Save Failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please check your entries.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UsernameTXT_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(UsernameTXT.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(UsernameTXT, "The field cannot be empty.");
                return;
            }

            if(_UserInfo.Username != UsernameTXT.Text && Users_CLS.IsExistByUsername(UsernameTXT.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(UsernameTXT, "Is already exist this Username , Please enter another one");
                return;
            }
        }

        private void UsernameTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void SelectUserPage_Click(object sender, EventArgs e)
        {

        }
    }
}
