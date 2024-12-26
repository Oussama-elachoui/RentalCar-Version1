using Data_Tier;
using Guna.UI2.HtmlRenderer.Adapters;
using Logic_Tier;
using RentalCar_Version1.Properties;
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

namespace RentalCar_Version1.Persons.Forms
{
    public partial class Frm_ADDUPDATEPERSONS : Form
    {
        public delegate void DataBackEventHandler(object sender, int PersonID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;

        private int _PersonID = -1;
        private Persons_CLS _Person;

        private enum Enmode { ADD=0, Update=1 };
        private Enmode _Enmode=Enmode.ADD;
        public Frm_ADDUPDATEPERSONS()
        {
            InitializeComponent();
            _Enmode = Enmode.ADD;

        }
        public Frm_ADDUPDATEPERSONS(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            _Enmode= Enmode.Update;
        }

        private void IntialLoad()
        {

            if(_Enmode==Enmode.ADD)
            {
                _Person = new Persons_CLS();
                FirstNameTXT.Text = "";
                LastNameTXT.Text = ""; 
                NationalityIDTXT.Text = "";
                EmailTXT.Text= "";
                PhoneTXT.Text="";
                AddressTXT.Text = "";
                FirstNamePicker.Value = DateTime.Now;

            }
            else
            {
                Title_label.Text = "Update Person";
            }

        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadInfo()
        {
            _Person = Persons_CLS.FindByID(_PersonID);

            if(_Person == null)
            {
                MessageBox.Show("Person not found. Please check the ID and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PesonIDLabel.Text = _Person.PersonID.ToString();
            FirstNameTXT.Text = _Person.Firstname.ToString();
            LastNameTXT.Text = _Person.Lastname.ToString();
                
            NationalityIDTXT.Text = _Person.NationalityID.ToString();
            EmailTXT.Text = _Person.Email;
            PhoneTXT.Text = _Person.Phone;
            AddressTXT.Text = _Person.Address;
            FirstNamePicker.Value = _Person.DateOfBirth;
            _ImagePicture();
        }
        private void Frm_ADDUPDATEPERSONS_Load(object sender, EventArgs e)
        {
            IntialLoad();

            if (_Enmode == Enmode.Update)
            {
                LoadInfo();
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (!_HandlePersonImage())
                return;

            _Person.Firstname = FirstNameTXT.Text;
            _Person.Lastname = LastNameTXT.Text;
            _Person.Address = AddressTXT.Text;
            _Person.Email = EmailTXT.Text;
            _Person.Phone = PhoneTXT.Text;
            _Person.DateOfBirth = FirstNamePicker.Value;
            _Person.NationalityID = int.Parse(NationalityIDTXT.Text);
            if (pictureBox1.ImageLocation != null)
                _Person.ImagePath = pictureBox1.ImageLocation;
            else
                _Person.ImagePath = "";


            if (_Person.Save())
            {
                _PersonID = _Person.PersonID;
                PesonIDLabel.Text = _PersonID.ToString();
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Enmode = Enmode.Update;
                Title_label.Text = "Update Person";
                DataBack?.Invoke(this,_PersonID);
            }

            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }







        private void _ImagePicture()
        {
            string ImagePath = _Person.ImagePath;
            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pictureBox1.ImageLocation = ImagePath;
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private bool _HandlePersonImage()
        {


            if (_Person.ImagePath != pictureBox1.ImageLocation)
            {
                if (_Person.ImagePath != "")
                {


                    try
                    {
                        File.Delete(_Person.ImagePath);
                    }
                    catch (IOException)
                    {

                    }
                }

                if (pictureBox1.ImageLocation != null)
                {

                    string SourceImageFile = pictureBox1.ImageLocation.ToString();

                    if (clsUtil.CopyImageToProjectImagesFolder(ref SourceImageFile))
                    {
                        pictureBox1.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

            }
            return true;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;
                pictureBox1.Load(selectedFilePath);
                linkLabel2.Visible = true;
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            pictureBox1.ImageLocation = null;


            linkLabel2.Visible = false;
        }

        private void NationalityIDTXT_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(NationalityIDTXT.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(NationalityIDTXT, "The field cannot be empty.");
                return;
            }

            if (!int.TryParse(NationalityIDTXT.Text, out int nationalityID))
            {
                e.Cancel = true;
                errorProvider1.SetError(NationalityIDTXT, "Please enter a valid number.");
                return;
            }
            
                if (NationalityIDTXT.Text!=_Person.NationalityID.ToString() &Persons_CLS.PersonIsExistByNationalityID(nationalityID))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(NationalityIDTXT, "This Nationality ID already exists.");
                    return;
                }
            

            errorProvider1.SetError(NationalityIDTXT, string.Empty);
        }

        private void EmailTXT_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(EmailTXT.Text))
            {
                e.Cancel = true;
                errorProvider2.SetError(EmailTXT, "The field cannot be empty.");
                return;
            }

            // Check if the value is a valid email address
            try
            {
                var email = new System.Net.Mail.MailAddress(EmailTXT.Text);
            }
            catch (FormatException)
            {
                e.Cancel = true;
                errorProvider2.SetError(EmailTXT, "Please enter a valid email address.");
                return;
            }

            // Check if the email already exists
            
                if (EmailTXT.Text!=_Person.Email & Persons_CLS.PersonIsExistByEmail(EmailTXT.Text))
                {
                    e.Cancel = true;
                    errorProvider2.SetError(EmailTXT, "This email address already exists.");
                    return;
                }
            

            // Clear the error if all validations pass
            errorProvider2.SetError(EmailTXT, string.Empty);
        }

        private void PhoneTXT_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(PhoneTXT.Text))
            {
                e.Cancel = true;
                errorProvider3.SetError(PhoneTXT, "The field cannot be empty.");
                return;
            }

            string phonePattern = @"^\+?[0-9\s\-]+$";

            // Validate the phone number format using Regex
            if (!System.Text.RegularExpressions.Regex.IsMatch(PhoneTXT.Text, phonePattern))
            {
                e.Cancel = true;
                errorProvider3.SetError(PhoneTXT, "Please enter a valid phone number.");
                return;
            }

            // Check if the email already exists
            
                if (PhoneTXT.Text!=_Person.Phone&Persons_CLS.PersonIsExistByPhone(PhoneTXT.Text))
                {
                    e.Cancel = true;
                    errorProvider3.SetError(PhoneTXT, "This number phone already exists.");
                    return;
                }
            
            // Clear the error if all validations pass
            errorProvider3.SetError(PhoneTXT, string.Empty);
        }




    }
}
