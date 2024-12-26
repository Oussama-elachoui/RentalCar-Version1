using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalCar_Version1.BookingDossier.frmm
{
    public partial class FRM_DETAILSBOOKING : Form
    {
        private int id = -1;
        public FRM_DETAILSBOOKING(int ID)
        {
            InitializeComponent();
            id=ID;
        }

        private void FRM_DETAILSBOOKING_Load(object sender, EventArgs e)
        {
            detailsBookingCtrl1.FindById(id);
        }
    }
}
