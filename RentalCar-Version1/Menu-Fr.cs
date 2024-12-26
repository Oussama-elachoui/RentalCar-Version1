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

namespace RentalCar_Version1
{
    public partial class Menu_Fr : Form
    {
        public enum Permissions
        {
            None = 0,
            People = 1,
            Users = 2,
            Customers = 4,
            Vehicles = 8,
            Booking = 16,
            Return = 32,
            Transactions = 64
        }
        private Form _LoginForm;
        public Menu_Fr(Form Login)
        {
            InitializeComponent();
            _LoginForm = Login;
        }
        private Button currentbtn;
        private void Menu_Fr_Load(object sender, EventArgs e)
        {
            dashboard1.BringToFront();
            user.Text=CurrentUser.UsersInfo.Username;

        }

        private void ActivateButton(object btnsender)
        {
            desabledbutton();
            if (btnsender != null)
            {
                if (currentbtn !=(Button)btnsender)
                {
                    Color clr = Color.FromArgb(71, 71, 96); 
                    currentbtn = (Button)btnsender;
                    currentbtn.BackColor = clr;
                    currentbtn.ForeColor = Color.White;      

                }
            }
        }
        private void desabledbutton()
        {
            foreach(Control previousbtn in panelMenu.Controls)
            {
                if (previousbtn.GetType() == typeof(Button))
                {
                    previousbtn.BackColor = Color.FromArgb(51,51, 76);
                    previousbtn.ForeColor = Color.Gainsboro;
                }
            }
        }

        private void btnDashboad_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            dashboard1.BringToFront();

        }

        private void btnPeople_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            if (!CurrentUser.CheckAccessDenied(Users_CLS.enPermissions.ManagePeople))
            {
                ShowLockedScreen();
                return;
            }
            people1.BringToFront();
        }

        private void CustomersBTN_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            if (!CurrentUser.CheckAccessDenied(Users_CLS.enPermissions.ManageCustomers))
            {
                ShowLockedScreen();
                return;
            }
            customers1.BringToFront();
        }

        private void btnVehicules_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            if (!CurrentUser.CheckAccessDenied(Users_CLS.enPermissions.ManageVehicles))
            {
                ShowLockedScreen();
                return;
            }
            vehicules1.BringToFront();
        }

        private void BookingBTN_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            if (!CurrentUser.CheckAccessDenied(Users_CLS.enPermissions.ManagePeople))
            {
                ShowLockedScreen();
                return;
            }
            booking1.BringToFront();
        }

        private void ReturnBTN_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            if (!CurrentUser.CheckAccessDenied(Users_CLS.enPermissions.ManageReturn))
            {
                ShowLockedScreen();
                return;
            }
            return1.BringToFront();
        }

        private void Transactions_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            if (!CurrentUser.CheckAccessDenied(Users_CLS.enPermissions.ManageTransactions))
            {
                ShowLockedScreen();
                return;
            }
            transactions1.BringToFront();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            if (!CurrentUser.CheckAccessDenied(Users_CLS.enPermissions.ManageUsers))
            {
                ShowLockedScreen();
                return;
            }
            users1.BringToFront();
        }

        private void ShowLockedScreen()
        {
            locked11.BringToFront();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_LoginForm is Login loginForm)
            {
                loginForm.ClearFields(); 
            }
            this.Close();
            _LoginForm.Show();
        }

        private void locked11_Load(object sender, EventArgs e)
        {

        }

        private void locked11_Load_1(object sender, EventArgs e)
        {

        }
    }
}
