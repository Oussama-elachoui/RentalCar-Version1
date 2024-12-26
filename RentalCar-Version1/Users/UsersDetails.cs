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

namespace RentalCar_Version1.Users
{
    public partial class UsersDetails : Form
    {
        private int _USERID = -1;
        private Users_CLS Users;
        public UsersDetails(int UserID)
        {
            InitializeComponent();      
            _USERID = UserID;

        }

        private void UsersDetails_Load(object sender, EventArgs e)
        {
            Users = Users_CLS.FindBYUSERID(_USERID);
            if (Users == null)
            {
                MessageBox.Show("Attention: The specified ID" + _USERID + "could not be found in our records. Please verify the ID and try again. If you continue to experience issues, please contact support for further assistance.");
                return;
            }
            personDetails1.Loadinfo(Users.PersonID);
            Username.Text = Users.Username;
            UserID.Text= Users.UsersID.ToString();
            if (Users.IsActive)
            {
                isactiveTXT.Text = "YES";
            }
            else
            {
                isactiveTXT.Text = "NO";
            }
        }
    }
}
