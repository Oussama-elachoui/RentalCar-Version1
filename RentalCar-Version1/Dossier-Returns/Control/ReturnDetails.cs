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

namespace RentalCar_Version1.Dossier_Returns.Control
{
    public partial class ReturnDetails : UserControl
    {
        private int _ReturnId=-1;
        private Return_CLS ReturnINFO;

        public int ReturnId { get { return _ReturnId; } }
        public Return_CLS ReturnInfo { get { return ReturnINFO; } }

        public ReturnDetails()
        {
            InitializeComponent();
        }

        

        public  void LoadByid(int  ReturnId)
        {
            ReturnINFO = Return_CLS.FindByID(ReturnId);
            if (ReturnINFO == null)
            {
                MessageBox.Show($"Attention: The specified ID {ReturnId} could not be found in our records. Please verify the ID and try again.");
                return;
            }
            _ReturnId = ReturnId;

            ReturnID.Text = ReturnINFO.ReturenID.ToString();
            ARD1.Text = ReturnINFO.ActualReturnDate.ToShortDateString();
            ARD2.Text = ReturnINFO.ActualRentalDays.ToString();
            kms.Text = ReturnINFO.Mileage.ToString();
            CKMD.Text = ReturnINFO.ConsumedMileage.ToString();
            ATDM.Text = ReturnINFO.ActualTotalDueAmount.ToString();
            AC.Text = ReturnINFO.AdditionalCharges.ToString();
            FinalCheckNotes.Text = ReturnINFO.FinalCheckNotes.ToString();
        }
        private void ReturnDetails_Load(object sender, EventArgs e)
        {
        }

        private void AC_Click(object sender, EventArgs e)
        {

        }
    }
}
