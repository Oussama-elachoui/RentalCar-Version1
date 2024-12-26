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
using static Logic_Tier.Persons_CLS;

namespace RentalCar_Version1.BookingDossier.frmm
{
    public partial class FRM_ADDUPDATEBOOKING : Form
    {
        private int _BookingID = -1;
        private Booking_CLS Booking;

        private enum ENMODE { Update=0,ADD=1};

        private ENMODE _ENMODE= ENMODE.Update;

        public FRM_ADDUPDATEBOOKING()
        {
            InitializeComponent();
            _ENMODE=ENMODE.ADD;
            Booking = new Booking_CLS();
        }
        public FRM_ADDUPDATEBOOKING(int id)
        {
            InitializeComponent();
            _BookingID=id;
            _ENMODE = ENMODE.Update;

        }

        private void _InnitialFill()
        {
            if(_ENMODE == ENMODE.Update)
            {
                Title_label.Text = "Update";
                Next.Enabled = true;
                filterVehicule1.FilterEnabled = false;
                filerCustomers1.FilterEnabled = false;
                button3.Enabled = false;

            }
            else
            {
                Title_label.Text = "Booking Now";
                filterVehicule1.FilterEnabled = true;
                filerCustomers1.FilterEnabled = true;
                filerCustomers1.Enabled = false;
                button3.Enabled = false;
                button3.Enabled = false;
                GBINFORMATIONS.Enabled = false;
                dateStart.MinDate = DateTime.Now.Date;
                dateStart.MaxDate = DateTime.Now.Date.AddDays(30);

                dateEnd.MinDate = DateTime.Now.Date;
                dateEnd.MaxDate = DateTime.Now.Date.AddDays(30);

            }
        }

        private void _FillData()
        {
            Booking = Booking_CLS.FindByid(_BookingID);
            if(Booking == null)
            {
                MessageBox.Show("Person not found. Please check the ID and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            filterVehicule1.LoadByID(Booking.VehicleId);
            Vehicleid.Text = filterVehicule1.VehicleID.ToString();


            filerCustomers1.LoadByid(Booking.Customers.PersonID);
            Customerid.Text = filerCustomers1.Customerid.ToString();

            Pickup.Text = Booking.PickupLocation;
            Dropoff.Text = Booking.DropoffLocation;

            DAYS.Text= Booking.InitialRentalDays.ToString();
            PRICE.Text= Booking.RentalPricePerDay.ToString();
            TOTALPRICE.Text=Booking.InitialTotalDueAmount.ToString();
            Notes.Text = Booking.InitialCheckNotes;
            dateStart.Value = Booking.RentalStartDate;
            dateEnd.Value = Booking.RentalEndDate;
        }

        private void FRM_ADDUPDATEBOOKING_Load(object sender, EventArgs e)
        {
            _InnitialFill();
            if(_ENMODE== ENMODE.Update)
            {
                _FillData();
            }
        }


        private void Next_Click(object sender, EventArgs e)
        {
            if (_ENMODE == ENMODE.Update)
            {
                Tab.SelectedTab = Tab.TabPages["SelectPerson"];
                return;
            }

            if (filterVehicule1.VehicleID ==-1)
            {
                MessageBox.Show("Please select a vehicle !");
                return;
            }

            if (!Vehicules_CLS.VehiculeIsDisponibleOrNotByID(filterVehicule1.VehicleID))
            {
                MessageBox.Show("This vehicle not Disponible ! Please choose another vehicle");
                return;
            }
            else
            {
                Tab.SelectedTab = Tab.TabPages["SelectPerson"];
                Vehicleid.Text = filterVehicule1.VehicleID.ToString();
                PRICE.Text = Vehicules_CLS.FindByID(filterVehicule1.VehicleID).RentalPricePerDay.ToString();
                filerCustomers1.Enabled = true;
                button3.Enabled = true;
            }

            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(_ENMODE == ENMODE.ADD)
            {
                if (filerCustomers1.Customerid == -1 && filterVehicule1.VehicleID==-1)
                {
                    MessageBox.Show("Please select a customer also vehicle ! ");
                    return;
                }
                else
                {
                    MessageBox.Show("Vehicle and Customer have been selected.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Customerid.Text= filerCustomers1.Customerid.ToString();
                    GBINFORMATIONS.Enabled = true;

                }
            }
        }
        public byte CalculateDaysBetweenDates(DateTime startDate, DateTime endDate)
        {
            int totalDays = (endDate - startDate).Days;

            if (totalDays < 0 || totalDays > 255)
                throw new ArgumentOutOfRangeException("The day difference exceeds the range of a byte (0-255).");

            return (byte)totalDays;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Booking.VehicleId = filterVehicule1.VehicleID;

            Booking.CustomerID = filerCustomers1.Customerid;
            Booking.RentalStartDate = dateStart.Value;
            Booking.RentalEndDate = dateEnd.Value;
            Booking.PickupLocation = Pickup.Text;
            Booking.DropoffLocation = Dropoff.Text;
            Booking.InitialRentalDays = byte.Parse(DAYS.Text);
            Booking.RentalPricePerDay = decimal.Parse(PRICE.Text);
            Booking.InitialTotalDueAmount = decimal.Parse(TOTALPRICE.Text);
            Booking.InitialCheckNotes = Notes.Text;

            if (Booking.save())
            {
                MessageBox.Show("YES");
                if (_ENMODE == ENMODE.ADD)
                {
                    Vehicules_CLS.UpdateDisponibility(filterVehicule1.VehicleID, 0);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("NO");

            }
        }

        private void Pickup_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pickup_Click(object sender, EventArgs e)
        {
            DAYS.Text= CalculateDaysBetweenDates(dateStart.Value, dateEnd.Value).ToString();
            PRICE.Text = filterVehicule1.Vehicleinfo.RentalPricePerDay.ToString();
            TOTALPRICE.Text= (CalculateDaysBetweenDates(dateStart.Value, dateEnd.Value)*filterVehicule1.Vehicleinfo.RentalPricePerDay).ToString();



           }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pickup_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }
    }
}
