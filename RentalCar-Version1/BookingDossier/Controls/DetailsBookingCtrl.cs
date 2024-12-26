using Logic_Tier;
using RentalCar_Version1.Customers1;
using RentalCar_Version1.Vehicules1.FORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalCar_Version1.BookingDossier.Controls
{
    public partial class DetailsBookingCtrl : UserControl
    {
        private int _Bookingid = -1;
        private Booking_CLS _BookingInfo;
        public DetailsBookingCtrl()
        {
            InitializeComponent();
        }
        private bool _FilterEnabled;
        public bool ShowDetailsVehicle
        {
            get
            {
                return _FilterEnabled;
            }
            set
            {
                _FilterEnabled = value;
                InfoCustomer.Enabled = _FilterEnabled;
            }
        }
        public bool ShowDetailsCustomer
        {
            get
            {
                return _FilterEnabled;
            }
            set
            {
                _FilterEnabled = value;
                InfoCustomer.Enabled = _FilterEnabled;

            }
        }
        public int IDBooking { get { return _Bookingid; } }
        public Booking_CLS BookingInfo { get { return _BookingInfo; } }
        private void _FILLINFO()
        {
            BookingID.Text = Convert.ToString(BookingInfo.BookingID);
            VehicleID.Text = Convert.ToString(BookingInfo.VehicleId);
            CustomerID.Text = Convert.ToString(BookingInfo.CustomerID);
            start.Text = BookingInfo.RentalStartDate.ToShortDateString();
            END.Text = BookingInfo.RentalEndDate.ToShortDateString();
            PICKUP.Text = BookingInfo.PickupLocation;
            DROPOFF.Text = BookingInfo.DropoffLocation;
            if (BookingInfo.InitialRentalDays > 1)
            {
                DAYS.Text = BookingInfo.InitialRentalDays.ToString() + " " + "Days ";
            }
            else
            {
                DAYS.Text = BookingInfo.InitialRentalDays.ToString() + " " + "Day ";
            }
            PRICE.Text = BookingInfo.RentalPricePerDay.ToString() + " " + "$";
            TOTALPRICE.Text = BookingInfo.InitialTotalDueAmount.ToString() + " " + "$";
            NOTES.Text = BookingInfo.InitialCheckNotes;

        }
        public void FindById(int id)
        {
            _BookingInfo = Booking_CLS.FindByid(id);
            if (BookingInfo == null)
            {
                MessageBox.Show("Attention: The specified ID" + id + "could not be found in our records. Please verify the ID and try again. If you continue to experience issues, please contact support for further assistance.");
                return;
            }
            _Bookingid = BookingInfo.BookingID;
            _FILLINFO();


        }
        private void DetailsBookingCtrl_Load(object sender, EventArgs e)
        {
            
        }

        private void InfoCustomer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DetailsCustomer frm = new DetailsCustomer(BookingInfo.CustomerID);
            frm.ShowDialog();
        }

        private void InfoVehicle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FRM_DETAILSVEHICULE frm = new FRM_DETAILSVEHICULE(BookingInfo.VehicleId);
            frm.ShowDialog();
        }
    }
    }

