using Logic_Tier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalCar_Version1.BookingDossier.Controls
{
    public partial class DetailsWithFilterBooking : UserControl
    {
        private int _BookingID = -1;
        private Booking_CLS _BookingInfo;
        public DetailsWithFilterBooking()
        {
            InitializeComponent();
        }
        private bool _FilterEnabled;

        public bool FilterEnabled
        {
            get
            {
                return _FilterEnabled;
            }
            set
            {
                _FilterEnabled = value;
                comboBox1.Enabled = _FilterEnabled;
            }
        }

        public int BookingID { get { return detailsBookingCtrl1.IDBooking; } }
        public Booking_CLS BookingInfo { get { return detailsBookingCtrl1.BookingInfo; } }
        private void SearchBTN_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Booking ID": detailsBookingCtrl1.FindById(int.Parse(TextSearch.Text));
                    detailsBookingCtrl1.ShowDetailsVehicle = true;
                    detailsBookingCtrl1.ShowDetailsCustomer = true;
                    break;
                default: break;
            }
        }

        private void DetailsWithFilterBooking_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            detailsBookingCtrl1.ShowDetailsVehicle=false;
            detailsBookingCtrl1.ShowDetailsCustomer=false;
        }


        public void FindByid(int id)
        {
            _BookingInfo = Booking_CLS.FindByid(id);
            if (BookingInfo == null)
            {
                MessageBox.Show("Attention: The specified ID" + id + "could not be found in our records. Please verify the ID and try again. If you continue to experience issues, please contact support for further assistance.");
                return;
            }
            _BookingID = BookingInfo.BookingID;
            detailsBookingCtrl1.FindById(_BookingID);
        }

        private void TextSearch_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextSearch.Text) || !TextSearch.Text.All(char.IsDigit))
            {
                errorProvider1.SetError(TextSearch, "Please enter a valid numeric value.");
            }
            else
            {
                errorProvider1.SetError(TextSearch, string.Empty);
            }
        }
    }
}
