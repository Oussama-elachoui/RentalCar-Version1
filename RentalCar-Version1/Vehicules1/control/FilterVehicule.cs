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

namespace RentalCar_Version1.Vehicules1.control
{
    public partial class FilterVehicule : UserControl
    {
        public FilterVehicule()
        {
            InitializeComponent();
        }
        public int VehicleID { get { return detailsVehicule1.VehicleID; } }
        public Vehicules_CLS Vehicleinfo { get { return detailsVehicule1.Vehicleinfo; } }

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
                Filter.Enabled = _FilterEnabled;
            }
        }
        private void SearchBTN_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                
                case "Vehicle ID":
                    detailsVehicule1.loadById(int.Parse(textBox1.Text));
                    break;
                case "Plate Number":
                    detailsVehicule1.loadByPlatenumber(textBox1.Text);
                    break;
                default:break;
                        
            }
        }
         public void LoadByID(int id)
        {
            detailsVehicule1.loadById(id);
            textBox1.Text = id.ToString();

        }
        private void detailsVehicule1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox1, "The field cannot be empty.");
                return;
            }
            errorProvider1.SetError(textBox1, string.Empty);
        }

        private void FilterVehicule_Load(object sender, EventArgs e)
        {

        }
    }
}
