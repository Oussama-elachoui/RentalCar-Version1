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
    public partial class FRM_DETAILSVEHICULE : Form
    {
        public FRM_DETAILSVEHICULE(int ID)
        {
            InitializeComponent();
            detailsVehicule1.loadById(ID);
        }

        private void FRM_DETAILSVEHICULE_Load(object sender, EventArgs e)
        {

        }
    }
}
