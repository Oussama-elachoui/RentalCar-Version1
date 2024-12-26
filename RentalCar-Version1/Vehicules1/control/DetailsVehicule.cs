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

namespace RentalCar_Version1.Vehicules1
{
    public partial class DetailsVehicule : UserControl
    {
        private int _VehicleID = -1;
        private Vehicules_CLS _Vehicle;
        public DetailsVehicule()
        {
            InitializeComponent();
        }

        public int VehicleID {  get { return _VehicleID; }  }
        public Vehicules_CLS Vehicleinfo { get { return _Vehicle; } }

        private void DetailsVehicule_Load(object sender, EventArgs e)
        {

        }

        private void _LoadInfo()
        {
            Make.Text = _Vehicle.Make;
            Year.Text= _Vehicle.Year.ToString();
            Mileage.Text= _Vehicle.Mileage.ToString();
            FuelType.Text= _Vehicle.FuleType.NameFuleType;
            Model.Text= _Vehicle.Model;
            Platenumber.Text= _Vehicle.PlateNumber.ToString();
            carCategory.Text = _Vehicle.CategoryVehicule.CategoryVehicule;
            IDVehicule.Text=_Vehicle.VehiculeId.ToString();
            RPPD.Text = _Vehicle.RentalPricePerDay.ToString() + " " + "$";
            if (_Vehicle.IsAvailableForRent==true)
            {
                avaibility.Text = "YES";
            }
            else
            {
                avaibility.Text = "NO";
                
            }

        }
        public void loadById(int id)
        {
            _Vehicle = Vehicules_CLS.FindByID(id);

            if( _Vehicle == null )
            {
                MessageBox.Show("Attention: The specified ID" + id + "could not be found in our records. Please verify the ID and try again. If you continue to experience issues, please contact support for further assistance.");
                return;
            }
            _VehicleID = id;
            _LoadInfo();

        }
        public void loadByPlatenumber(string PN)
        {
            _Vehicle = Vehicules_CLS.FindByPlateNumber(PN);

            if (_Vehicle == null)
            {
                MessageBox.Show("Attention: The specified ID" + PN + "could not be found in our records. Please verify the ID and try again. If you continue to experience issues, please contact support for further assistance.");
                return;
            }
            _VehicleID = _Vehicle.VehiculeId;
            _LoadInfo();

        }
    }
}

