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

namespace RentalCar_Version1
{
    public partial class Dashboard : UserControl
    {
        private DataTable DataTable = CLS_TRANSACTIONS.top5();
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataTable;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView1.Columns[0].HeaderText = "VehicleID";
            dataGridView1.Columns[0].Width = 60;

            dataGridView1.Columns[1].HeaderText = "Make";
            dataGridView1.Columns[1].Width = 70;


            dataGridView1.Columns[2].HeaderText = "Model";
            dataGridView1.Columns[2].Width = 70;


            dataGridView1.Columns[3].HeaderText = "PlateNumber";
            dataGridView1.Columns[3].Width = 80;

            dataGridView1.Columns[4].HeaderText = "TotalRevenue";
            dataGridView1.Columns[4].Width = 120;
            CustomersTXT.Text = Customers_CLS.NumberOfCustomers();
            BookingTXT.Text = Booking_CLS.NumberOfbooking();
            AvVehicleTXT.Text = Vehicules_CLS.NumberOfVehiclesAv();
            UNAvVehicleTXT.Text =Vehicules_CLS.NumberOfVehiclesUnAv();
            ReturnTXT.Text = Return_CLS.NumberOfbooking();
            UsersTXT.Text= Users_CLS.NumberOfUsers();


        }
    }
}
