using Logic_Tier;
using RentalCar_Version1.Vehicules1.FORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalCar_Version1
{
    public partial class Vehicules : UserControl
    {
        private DataTable DataTable = Vehicules_CLS.DataTable();
       

        private void Refresh()
        {
            DataTable _DataTable = Vehicules_CLS.DataTable();
            DGVVEHICLES.DataSource = _DataTable;
        }
        public Vehicules()
        {
            InitializeComponent();
        }

        private void Vehicules_Load(object sender, EventArgs e)
        {
            FilterBy.SelectedIndex = 0;
            DGVVEHICLES.DataSource = DataTable;
            DGVVEHICLES.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            DGVVEHICLES.Columns[0].HeaderText = "VehicleID";
            DGVVEHICLES.Columns[0].Width = 120;   // Width: 80

            DGVVEHICLES.Columns[1].HeaderText = "Make";
            DGVVEHICLES.Columns[1].Width = 120;  // Width: 100


            DGVVEHICLES.Columns[2].HeaderText = "Model";
            DGVVEHICLES.Columns[2].Width = 120;  // Width: 100


            DGVVEHICLES.Columns[3].HeaderText = "Mileage";
            DGVVEHICLES.Columns[3].Width = 130;   // Width: 100

            DGVVEHICLES.Columns[4].HeaderText = "PlateNumber";
            DGVVEHICLES.Columns[4].Width = 130;   // Width: 100

            DGVVEHICLES.Columns[5].HeaderText = "IsAvailable";
            DGVVEHICLES.Columns[5].Width = 120;   // Width: 100


            DGVVEHICLES.DefaultCellStyle.Font = new Font("Arial", 10);  // Font size and style
            DGVVEHICLES.DefaultCellStyle.BackColor = Color.White;       // Background color
            DGVVEHICLES.DefaultCellStyle.ForeColor = Color.Black;       // Text color

            // Set the header style
            DGVVEHICLES.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold); // Bold header font
            DGVVEHICLES.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray; // Header background color
            DGVVEHICLES.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black; // Header text color

            // Enable row headers and set their style
            DGVVEHICLES.RowHeadersVisible = true; // Show row headers
            DGVVEHICLES.RowHeadersDefaultCellStyle.BackColor = Color.LightGray; // Row header background
            DGVVEHICLES.RowHeadersDefaultCellStyle.ForeColor = Color.Black; // Row header text color

            // Add alternating row colors for better readability
            DGVVEHICLES.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;

            // Enable sorting
            DGVVEHICLES.AllowUserToOrderColumns = true;

            // Set the selection mode
            DGVVEHICLES.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Set grid color
            DGVVEHICLES.GridColor = Color.DarkGray; // Grid line color
            DGVVEHICLES.BorderStyle = BorderStyle.Fixed3D; // Border style for the grid


            // Set the style for the entire DataGridView
            DGVVEHICLES.BackgroundColor = Color.White; // Background color for DataGridView
        }

        private void FilterText_TextChanged(object sender, EventArgs e)
        {

        string FilterBys = "";


            switch (FilterBy.Text)
            {

                case "Vehicule ID":

                    FilterBys = "VehicleID";
                    break;

                case "Plate Number":

                    FilterBys = "PlateNumber";
                    break;
                case "Make":

                    FilterBys = "Make";
                    break;
                case "Model":

                    FilterBys = "Model";
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

            if (FilterBys == "VehicleID")
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

        private void btnAddVehicule_Click(object sender, EventArgs e)
        {
            FRM_ADDUPDATEVEHILE frm = new FRM_ADDUPDATEVEHILE();
            frm.ShowDialog();
            Refresh();


        }

        private void uPDATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ADDUPDATEVEHILE frm = new FRM_ADDUPDATEVEHILE((int)DGVVEHICLES.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            Refresh();

        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ADDUPDATEVEHILE frm = new FRM_ADDUPDATEVEHILE();
            frm.ShowDialog();
            Refresh();

        }

        private void uPDATEAVAIBILTYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_DETAILSVEHICULE frm = new FRM_DETAILSVEHICULE((int)DGVVEHICLES.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            Refresh();

        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Person [" + DGVVEHICLES.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

            {

                //Perform Delele and refresh
                if (Vehicules_CLS.Delete((int)DGVVEHICLES.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Vehicule Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                    MessageBox.Show("Vehicule was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Refresh();

            }
        }
    }
}
