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

namespace RentalCar_Version1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Username.Text))
            {
                errorProvider1.SetError(Username, "Username cannot be empty.");
            }
            else
            {
                errorProvider1.SetError(Username, string.Empty);
            }
            if (string.IsNullOrWhiteSpace(Password.Text))
            {
                errorProvider2.SetError(Password, "Password cannot be empty.");
            }
            else
            {
                errorProvider2.SetError(Password, string.Empty);
            }

            if (!Users_CLS.IsExistByUsernameAndPassword(Username.Text, Password.Text))
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CurrentUser.UsersInfo = Users_CLS.FindBYUsernamePassword(Username.Text, Password.Text);

            if (CurrentUser.UsersInfo != null)
            {

                Menu_Fr menu_Fr = new Menu_Fr(this);
                menu_Fr.Show();
            }
            
  
        }
        public void ClearFields()
        {
            Username.Clear();
            Password.Clear();
            CurrentUser.UsersInfo= null;    
        }

        private void Username_Validated(object sender, EventArgs e)
        {
            
        }

        private void Password_Validated(object sender, EventArgs e)
        {
        }

    }
}
