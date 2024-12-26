using Guna.UI2.WinForms.Suite;
using Logic_Tier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalCar_Version1.Persons.Controls
{
    public partial class PersonDetails : UserControl
    {
        private int _PersonID = -1;
        private Persons_CLS _Personinfo;


        public int PersonId { get { return _PersonID; } }


        public Persons_CLS PersonInfo { get { return _Personinfo; } }

        public PersonDetails()
        {
            InitializeComponent();
        }

        private void _ImagePicture()
        {
            string ImagePath = _Personinfo.ImagePath;
            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    PICTURE.ImageLocation = ImagePath;
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        public void _Load()
        {
            PersonID.Text = _Personinfo.PersonID.ToString();
            FirstName.Text = _Personinfo.Firstname;
            LastName.Text = _Personinfo.Lastname;
            DateOfBirth.Text = _Personinfo.DateOfBirth.ToShortDateString();
            Address.Text = _Personinfo.Address;
            Phone.Text = _Personinfo.Phone;
            Email.Text = _Personinfo.Email;
            NationalityID.Text = _Personinfo.NationalityID.ToString();
            _ImagePicture();
        }
        public void Loadinfo(int PeronsID)
        {
            _Personinfo = Persons_CLS.FindByID(PeronsID);

            if (_Personinfo == null)
            {
                MessageBox.Show("Attention: The specified ID" + PeronsID + "could not be found in our records. Please verify the ID and try again. If you continue to experience issues, please contact support for further assistance.");
                return;
            }

            _PersonID = PeronsID;

            _Load();


        }
        public void LoadinfoByNationalityID(int NationalityID)
        {
            _Personinfo = Persons_CLS.FindByNationalityID(NationalityID);

            if (_Personinfo == null)
            {
                MessageBox.Show("Attention: The specified ID" + NationalityID + "could not be found in our records. Please verify the ID and try again. If you continue to experience issues, please contact support for further assistance.");
                return;
            }

            _PersonID = NationalityID;

            _Load();

        }

        private void PersonDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
