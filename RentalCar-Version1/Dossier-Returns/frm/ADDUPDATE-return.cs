using Logic_Tier;
using RentalCar_Version1.Vehicules1.control;
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
using static Logic_Tier.Persons_CLS;

namespace RentalCar_Version1.Dossier_Returns.frm
{
    public partial class ADDUPDATE_return : Form
    {

        private enum ENMODE { add=0  }   
        private int _ID = -1;
        private Return_CLS ReturnInfo;
        public ADDUPDATE_return()
        {
            InitializeComponent();
            ReturnInfo = new Return_CLS();
        }


        private void ARD2_Click(object sender, EventArgs e)
        {
        }
        private void _Initial()
        {
            
            
                label1.Text = "ADD RETURN";
                detailsWithFilterBooking1.FilterEnabled = true;
                Next.Enabled = true;
               Infos.Enabled = false;
            
        }
        private void _Fill()
        {
            ReturnInfo =Return_CLS.FindByID(_ID);
            if (ReturnInfo == null)
            {
                MessageBox.Show("Person not found. Please check the ID and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ReturnID.Text = _ID.ToString();
            ACTUALRETURNDATE.Value = ReturnInfo.ActualReturnDate;
            AdditionalCharges.Text = ReturnInfo.AdditionalCharges.ToString();
            ActualRentalDays.Text = ReturnInfo.ActualRentalDays.ToString();
            Mileage.Text = ReturnInfo.Mileage.ToString();
            ActualTotalDueAmount.Text = ReturnInfo.ActualTotalDueAmount.ToString();
            ConsumedMileage.Text = ReturnInfo.ConsumedMileage.ToString();
            FinalCheckNotes.Text = ReturnInfo.FinalCheckNotes.ToString();
            detailsWithFilterBooking1.Enabled =false;


        }
        private void ADDUPDATE_return_Load(object sender, EventArgs e)
        {
            _Initial();

        }

        private void Next_Click(object sender, EventArgs e)
        {

            if (detailsWithFilterBooking1.BookingID == -1)
            {
                MessageBox.Show("Please Select a booking");
                return;
            }
            if (CLS_TRANSACTIONS.IsExistByBookingID(detailsWithFilterBooking1.BookingID))
            {
                MessageBox.Show("Please select another booking ID because this booking has already been returned.");
                return;
            }

            tabControl1.SelectedTab = tabControl1.TabPages["TabReturn"];
            Infos.Enabled = true;

            ACTUALRETURNDATE.MinDate= detailsWithFilterBooking1.BookingInfo.RentalStartDate;
            ACTUALRETURNDATE.MaxDate = detailsWithFilterBooking1.BookingInfo.RentalStartDate.AddDays(30);


        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            ReturnInfo.ActualReturnDate = ACTUALRETURNDATE.Value;
            ReturnInfo.AdditionalCharges = decimal.Parse(AdditionalCharges.Text);
            ReturnInfo.ActualRentalDays= byte.Parse(ActualRentalDays.Text);
            ReturnInfo.ActualTotalDueAmount = decimal.Parse(ActualTotalDueAmount.Text);
            ReturnInfo.Mileage= short.Parse(Mileage.Text);
            ReturnInfo.ConsumedMileage= short.Parse(ConsumedMileage.Text);
            ReturnInfo.FinalCheckNotes= FinalCheckNotes.Text;
            if (ReturnInfo.save())
            {
                if (ReturnInfo.TransactionUpdateByreturn(detailsWithFilterBooking1.BookingID))
                {
                    Vehicules_CLS.ADDMileage(detailsWithFilterBooking1.BookingInfo.VehicleId,int.Parse(ConsumedMileage.Text));
                    Vehicules_CLS.UpdateDisponibility(detailsWithFilterBooking1.BookingInfo.VehicleId, 1);
                    MessageBox.Show("Return info has been saved !");
                    return;
                }
                else
                {
                    MessageBox.Show("Return info has not been saved !");
                    return;
                }

            }
            else
            {
                MessageBox.Show("Return info has not been saved !");
                return;
            }



        }
        public byte CalculateDaysBetweenDates(DateTime startDate, DateTime endDate)
        {
            int totalDays = (endDate - startDate).Days;

            if (totalDays < 0 || totalDays > 255)
                throw new ArgumentOutOfRangeException("The day difference exceeds the range of a byte (0-255).");

            return (byte)totalDays;
        }
        private void AdditionalCharges_Click(object sender, EventArgs e)
        {

            ActualRentalDays.Text = CalculateDaysBetweenDates(detailsWithFilterBooking1.BookingInfo.RentalStartDate, ACTUALRETURNDATE.Value).ToString();
            ActualTotalDueAmount.Text = (byte.Parse(ActualRentalDays.Text )* detailsWithFilterBooking1.BookingInfo.VehiculesInfo.RentalPricePerDay).ToString();
        }

        private void Mileage_Validated(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(Mileage.Text))
            {
                errorProvider1.SetError(Mileage, "Mileage cannot be empty.");
                return; 
            }

            if (detailsWithFilterBooking1.BookingInfo.VehiculesInfo.Mileage > byte.Parse(Mileage.Text))
            {
                errorProvider1.SetError(Mileage, "Mileage cannot be greater than the current vehicle mileage.");
                return; 
            }

        }

        private void FinalCheckNotes_Click(object sender, EventArgs e)
        {
            ConsumedMileage.Text = (byte.Parse(Mileage.Text) - detailsWithFilterBooking1.BookingInfo.VehiculesInfo.Mileage).ToString();


        }
    }
}
