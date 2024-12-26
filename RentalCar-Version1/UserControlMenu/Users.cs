using Logic_Tier;
using Microsoft.VisualBasic.ApplicationServices;
using RentalCar_Version1.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RentalCar_Version1.UserControlMenu
{
    public partial class Users : UserControl
    {
        private DataTable DGVUSERS = Users_CLS.List();

        public Users()
        {
            InitializeComponent();
        }

        private void _refresh()
        {
         DataTable DGVUSERS = Users_CLS.List();
        dataGridView1.DataSource = DGVUSERS;

        }

        private void Users_Load(object sender, EventArgs e)
        {
            FilterBy.SelectedIndex = 0;
            dataGridView1.DataSource = DGVUSERS;
            dataGridView1.Size = new Size(797, 244);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView1.Columns[0].HeaderText = "IDUsers";
            dataGridView1.Columns[0].Width = 110;   // Width: 80

            dataGridView1.Columns[1].HeaderText = "Fullname";
            dataGridView1.Columns[1].Width = 140;  // Width: 100

            dataGridView1.Columns[2].HeaderText = "Username";
            dataGridView1.Columns[2].Width = 120;   // Width: 100

            dataGridView1.Columns[3].HeaderText = "Email";
            dataGridView1.Columns[3].Width = 180;    // Width: 90

            dataGridView1.Columns[4].HeaderText = "NationalityID";
            dataGridView1.Columns[4].Width = 110;    // Width: 90
            
            dataGridView1.Columns[5].HeaderText = "IsActive";
            dataGridView1.Columns[5].Width = 94;// Width: 127 for remaining space

            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 10);  // Font size and style
            dataGridView1.DefaultCellStyle.BackColor = Color.White;       // Background color
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;       // Text color

            // Set the header style
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold); // Bold header font
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray; // Header background color
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black; // Header text color

            // Enable row headers and set their style
            dataGridView1.RowHeadersVisible = true; // Show row headers
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.LightGray; // Row header background
            dataGridView1.RowHeadersDefaultCellStyle.ForeColor = Color.Black; // Row header text color

            // Add alternating row colors for better readability
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;

            // Enable sorting
            dataGridView1.AllowUserToOrderColumns = true;

            // Set the selection mode
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Set grid color
            dataGridView1.GridColor = Color.DarkGray; // Grid line color
            dataGridView1.BorderStyle = BorderStyle.Fixed3D; // Border style for the grid


            // Set the style for the entire DataGridView
            dataGridView1.BackgroundColor = Color.White; // Background color for DataGridView

        }

        private void FilterText_TextChanged(object sender, EventArgs e)
        {
            string FilterBys = "";

            switch (FilterBy.Text)
            {
                case "User ID":

                    FilterBys = "IDUsers";
                    break;

                case "Full Name":

                    FilterBys = "Fullname";
                    break;
                case "Username":

                    FilterBys = "Username";
                    break;
                default:
                    FilterBys = "";
                    break;
            }
            if (string.IsNullOrWhiteSpace(FilterBy.Text))
            {
                DGVUSERS.DefaultView.RowFilter = "";
                return;
            }

            if (FilterBys == "IDUsers")
            {
                if (int.TryParse(FilterText.Text.Trim(), out int filterValue))
                {
                    DGVUSERS.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterBys, filterValue);
                }
                else
                {
                    MessageBox.Show("Invalid input for Person ID. Please enter a valid integer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                DGVUSERS.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterBys, FilterText.Text.Trim());
            }

        }

        private void btnAdduser_Click(object sender, EventArgs e)
        {
            ADDUPDATEUSERS aDDUPDATEUSERS = new ADDUPDATEUSERS();
            aDDUPDATEUSERS.ShowDialog();
            _refresh();
        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADDUPDATEUSERS aDDUPDATEUSERS = new ADDUPDATEUSERS();
            aDDUPDATEUSERS.ShowDialog();
            _refresh();

        }

        private void eDITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADDUPDATEUSERS aDDUPDATEUSERS = new ADDUPDATEUSERS((int)dataGridView1.CurrentRow.Cells[0].Value);
            aDDUPDATEUSERS.ShowDialog();
            _refresh();

        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Person [" + dataGridView1.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

            {

                //Perform Delele and refresh
                if (Users_CLS.Delete((int)dataGridView1.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Person Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                    MessageBox.Show("Person was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _refresh();

            }
        }

        private void iNFOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersDetails FRM = new UsersDetails((int)dataGridView1.CurrentRow.Cells[0].Value);
            FRM.ShowDialog();
        }
    }
}
