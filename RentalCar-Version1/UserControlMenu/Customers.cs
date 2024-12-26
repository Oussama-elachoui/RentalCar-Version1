using Logic_Tier;
using RentalCar_Version1.Customers1;
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
    public partial class Customers : UserControl
    {
        public DataTable DataTable = Customers_CLS.List();
        

        public Customers()
        {
            InitializeComponent();
        }

        private void _refresh()
        {
         DataTable DataTable = Customers_CLS.List();
         dataGridView2.DataSource = DataTable;

        }
    private void Customers_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = DataTable;

            dataGridView2.Size = new Size(797, 244);

            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView2.Columns[0].HeaderText = "CustomerID";
            dataGridView2.Columns[0].Width = 100;   // Width: 80

            dataGridView2.Columns[1].HeaderText = "DriverLicenseNumber";
            dataGridView2.Columns[1].Width = 180;  // Width: 100


            dataGridView2.Columns[2].HeaderText = "Fullname";
            dataGridView2.Columns[2].Width = 130;  // Width: 100


            dataGridView2.Columns[3].HeaderText = "Email";
            dataGridView2.Columns[3].Width = 200;    // Width: 90

            dataGridView2.Columns[4].HeaderText = "NationalityID";
            dataGridView2.Columns[4].Width = 144;   // Width: 100

            dataGridView2.DefaultCellStyle.Font = new Font("Arial", 10);  // Font size and style
            dataGridView2.DefaultCellStyle.BackColor = Color.White;       // Background color
            dataGridView2.DefaultCellStyle.ForeColor = Color.Black;       // Text color

            // Set the header style
            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold); // Bold header font
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray; // Header background color
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black; // Header text color

            // Enable row headers and set their style
            dataGridView2.RowHeadersVisible = true; // Show row headers
            dataGridView2.RowHeadersDefaultCellStyle.BackColor = Color.LightGray; // Row header background
            dataGridView2.RowHeadersDefaultCellStyle.ForeColor = Color.Black; // Row header text color

            // Add alternating row colors for better readability
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;

            // Enable sorting
            dataGridView2.AllowUserToOrderColumns = true;

            // Set the selection mode
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Set grid color
            dataGridView2.GridColor = Color.DarkGray; // Grid line color
            dataGridView2.BorderStyle = BorderStyle.Fixed3D; // Border style for the grid


            // Set the style for the entire DataGridView
            dataGridView2.BackgroundColor = Color.White; // Background color for DataGridView

        }

        private void FilterText_TextChanged(object sender, EventArgs e)
        {
            string FilterBys = "";

            switch (FilterBy.Text)
            {
                case "Custumer ID":

                    FilterBys = "CustomerID";
                    break;

                case "DriverLicenseNumber":

                    FilterBys = "DriverLicenseNumber";
                    break;
                case "Fullname":

                    FilterBys = "Fullname";
                    break;
                default:
                    FilterBys = "";
                    break;
            }
            if (string.IsNullOrWhiteSpace(FilterBy.Text))
            {
                DataTable.DefaultView.RowFilter = "";
                return;
            }

            if (FilterBys == "CustomerID")
            {
                if (int.TryParse(FilterText.Text.Trim(), out int filterValue))
                {
                    DataTable.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterBys, filterValue);
                }
                
            }
            else
            {
                DataTable.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterBys, FilterText.Text.Trim());
            }
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            using (CustomerUPDATEADD FRM = new CustomerUPDATEADD())
            {
                if (FRM.ShowDialog() == DialogResult.OK) // Wait until the form is closed
                {
                    _refresh(); // Refresh after the user finishes adding/updating
                }
            }
        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (CustomerUPDATEADD FRM = new CustomerUPDATEADD())
            {
                if (FRM.ShowDialog() == DialogResult.OK) // Wait until the form is closed
                {
                    _refresh(); // Refresh after the user finishes adding/updating
                }
            }
        }

        private void eDITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerUPDATEADD FRM = new CustomerUPDATEADD((int)dataGridView2.CurrentRow.Cells[0].Value);
            FRM.Show();
            _refresh();
        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Customer [" + dataGridView2.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

            {

                //Perform Delele and refresh
                if (Customers_CLS.Delete((int)dataGridView2.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Customer Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                    MessageBox.Show("Customer was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _refresh();

            }
        }

        private void iNFOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetailsCustomer frm = new DetailsCustomer((int)dataGridView2.CurrentRow.Cells[0].Value);
            frm.Show();
            _refresh();
        }
    }

}
