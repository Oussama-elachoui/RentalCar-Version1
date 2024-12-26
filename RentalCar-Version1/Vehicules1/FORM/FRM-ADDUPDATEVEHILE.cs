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

namespace RentalCar_Version1.Vehicules1.FORM
{
    public partial class FRM_ADDUPDATEVEHILE : Form
    {
        private int _VehicleID = -1;
        private Vehicules_CLS Vehicule;
        private enum ENMODE { update=0 , add=1 }
        private ENMODE enmode= ENMODE.update;


        public FRM_ADDUPDATEVEHILE()
        {
            InitializeComponent();
            enmode = ENMODE.add;
        }
        public FRM_ADDUPDATEVEHILE(int id)
        {
            InitializeComponent();
            _VehicleID = id;
            enmode = ENMODE.update;
        }

        private void _CARCATEGORY()
        {
            DataTable dataTable = CategoryVehicule_CLS.List();
            foreach (DataRow row in dataTable.Rows)
            {
                CarCategoryComboBox.Items.Add(row["CategoryName"].ToString());
            }
        }

        private void _FuelType()
        {
            DataTable dataTable = FuleTypes_CLS.List();
            foreach (DataRow row in dataTable.Rows)
            {
                FuelTypeComoboBox.Items.Add(row["FuleType"].ToString());
            }

        }
        private void _FILLCOMBOBOX()
        {
            _CARCATEGORY();
            _FuelType();

        }

        private void _InitialUpload()
        {

            if (enmode == ENMODE.add)
            {
                Title_label.Text = "ADD NEW CAR";
                Vehicule = new Vehicules_CLS();
                MakeTXT.Text = "";
                YEARTXT.Text = "";
                MILEAGETXT.Text = "";
                MODELTXT.Text = "";
                platenumberTXT.Text = "";
                RPPDTXT.Text = "";
                CarCategoryComboBox.SelectedIndex = 0;
                FuelTypeComoboBox.SelectedIndex = 0;
            }
            else
            {
                Title_label.Text = "UPDATE CAR";
            }
        }

        private void _UPLOADDATA()
        {

            Vehicule = Vehicules_CLS.FindByID(_VehicleID);
            if (Vehicule == null)
            {
                MessageBox.Show("Vehicule not found. Please check the ID and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            VehicleID.Text = Vehicule.VehiculeId.ToString();
            MakeTXT.Text = Vehicule.Make;
            YEARTXT.Text = Vehicule.Year.ToString();
            MILEAGETXT.Text = Vehicule.Mileage.ToString();
            MODELTXT.Text = Vehicule.Model;
            platenumberTXT.Text = Vehicule.PlateNumber;
            RPPDTXT.Text = Vehicule.RentalPricePerDay.ToString();
            FuelTypeComoboBox.SelectedText=FuleTypes_CLS.FindByid(Vehicule.CarCategoryID).NameFuleType;
            CarCategoryComboBox.SelectedText=CategoryVehicule_CLS.FindByid(Vehicule.CarCategoryID).CategoryVehicule;
            if (Vehicule.IsAvailableForRent)
            {
                IsAvailible.Checked = true;

            }
            else
            {
                IsAvailible.Checked = false;
            }
        }
    
        private void FRM_ADDUPDATEVEHILE_Load(object sender, EventArgs e)
        {
            _FILLCOMBOBOX();
            _InitialUpload();
            if (enmode == ENMODE.update)
            {
                _UPLOADDATA();
            }
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmailTXT_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(platenumberTXT.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(platenumberTXT, "The field cannot be empty.");
                return;
            }

            if (Vehicules_CLS.IsExistByPlateNumber(platenumberTXT.Text) && enmode == ENMODE.add)
            {
                e.Cancel = true;
                errorProvider1.SetError(platenumberTXT, "This plate number already exists.");
                return;
            }
            errorProvider1.SetError(platenumberTXT, string.Empty);

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Vehicule.Make= MakeTXT.Text;
            Vehicule.Year=int.Parse(YEARTXT.Text);
            Vehicule.Mileage=int.Parse(MILEAGETXT.Text);
            Vehicule.Model= MODELTXT.Text;
            Vehicule.PlateNumber= platenumberTXT.Text;
            Vehicule.RentalPricePerDay= decimal.Parse(RPPDTXT.Text);

            if (IsAvailible.Checked)
            {
                Vehicule.IsAvailableForRent= true;
            }
            else
            {
                Vehicule.IsAvailableForRent = false;

            }
           
            Vehicule.CarCategoryID = CategoryVehicule_CLS.FindByName(CarCategoryComboBox.Text).IdCategoryVehicule;
            Vehicule.FuelTypeID = FuleTypes_CLS.FindByName(FuelTypeComoboBox.Text).IdFuleType;


            if (Vehicule.SAVE())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            else
            {
                MessageBox.Show("Data Saved not Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void MakeTXT_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(MakeTXT.Text))
            {
                e.Cancel = true;
                errorProvider2.SetError(MakeTXT, "The field cannot be empty.");
                return;
            }
            errorProvider1.SetError(platenumberTXT, string.Empty);

        }

        private void MODELTXT_Validating(object sender, CancelEventArgs e)
        {
            
             if (string.IsNullOrEmpty(MODELTXT.Text))
            {
                e.Cancel = true;
                errorProvider3.SetError(MODELTXT, "The field cannot be empty.");
                return;
            }
            errorProvider1.SetError(platenumberTXT, string.Empty);

        }

        private void YEARTXT_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(YEARTXT.Text))
            {
                e.Cancel = true;
                errorProvider4.SetError(YEARTXT, "The field cannot be empty.");
                return;
            }
            errorProvider1.SetError(platenumberTXT, string.Empty);

        }

        private void MILEAGETXT_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(MILEAGETXT.Text))
            {
                e.Cancel = true;
                errorProvider4.SetError(MILEAGETXT, "The field cannot be empty.");
                return;
            }
            errorProvider5.SetError(MILEAGETXT, string.Empty);
        }

        private void CarCategoryComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(CarCategoryComboBox.Text))
            {
                e.Cancel = true;
                errorProvider4.SetError(CarCategoryComboBox, "The field cannot be empty.");
                return;
            }
            errorProvider6.SetError(CarCategoryComboBox, string.Empty);
        }

        private void RPPDTXT_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(RPPDTXT.Text))
            {
                e.Cancel = true;
                errorProvider4.SetError(RPPDTXT, "The field cannot be empty.");
                return;
            }
            errorProvider7.SetError(RPPDTXT, string.Empty);
        }

        private void FuelTypeComoboBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(FuelTypeComoboBox.Text))
            {
                e.Cancel = true;
                errorProvider4.SetError(FuelTypeComoboBox, "The field cannot be empty.");
                return;
            }
            errorProvider8.SetError(FuelTypeComoboBox, string.Empty);
        }
    }
    }

