using Logic_Tier;
using RentalCar_Version1.BookingDossier.frmm;
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
    public partial class Booking : UserControl
    {
        private DataTable booksDatatable = Booking_CLS.List();

        private void _Rerfresh()
        {
            DataTable booksDatatable = Booking_CLS.List();
            dgvBooking.DataSource = booksDatatable;
        }
        public Booking()
        {
            InitializeComponent();
        }
        public void Refresh()
        {
            _Rerfresh();
        }
        private void Booking_Load(object sender, EventArgs e)
        {
            FilterBy.SelectedIndex = 0;
            dgvBooking.DataSource = booksDatatable;
            dgvBooking.Size = new Size(797, 244);

            dgvBooking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvBooking.Columns[0].HeaderText = "ID";
            dgvBooking.Columns[0].Width = 60;

            dgvBooking.Columns[1].HeaderText = "Fullname";
            dgvBooking.Columns[1].Width = 140;


            dgvBooking.Columns[2].HeaderText = "Nationality ID";
            dgvBooking.Columns[2].Width = 90;


            dgvBooking.Columns[3].HeaderText = "Make";
            dgvBooking.Columns[3].Width = 80;

            dgvBooking.Columns[4].HeaderText = "Model";
            dgvBooking.Columns[4].Width = 80;

            dgvBooking.Columns[5].HeaderText = "InitialRentalDays";
            dgvBooking.Columns[5].Width = 130;

            dgvBooking.Columns[6].HeaderText = "InitialTotalDueAmount";
            dgvBooking.Columns[6].Width = 180;


            dgvBooking.DefaultCellStyle.Font = new Font("Arial", 10);
            dgvBooking.DefaultCellStyle.BackColor = Color.White;
            dgvBooking.DefaultCellStyle.ForeColor = Color.Black;

            // Set the header style
            dgvBooking.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvBooking.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dgvBooking.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            // Enable row headers and set their style
            dgvBooking.RowHeadersVisible = true; // Show row headers
            dgvBooking.RowHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dgvBooking.RowHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvBooking.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGreen;

            dgvBooking.AllowUserToOrderColumns = true;

            dgvBooking.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvBooking.GridColor = Color.DarkGray;
            dgvBooking.BorderStyle = BorderStyle.Fixed3D;


            dgvBooking.BackgroundColor = Color.White;
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            FRM_ADDUPDATEBOOKING FRM = new FRM_ADDUPDATEBOOKING();
            FRM.ShowDialog();
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void eDITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ADDUPDATEBOOKING FRM = new FRM_ADDUPDATEBOOKING((int)dgvBooking.CurrentRow.Cells[0].Value);
            FRM.ShowDialog();
        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Booking [" + dgvBooking.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

            {

                //Perform Delele and refresh
                if (Booking_CLS.Delete((int)dgvBooking.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Booking Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                    MessageBox.Show("Booking was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _Rerfresh();

            }
        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ADDUPDATEBOOKING FRM = new FRM_ADDUPDATEBOOKING();
            FRM.ShowDialog();
        }

        private void iNFOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_DETAILSBOOKING FRM = new FRM_DETAILSBOOKING((int)dgvBooking.CurrentRow.Cells[0].Value);
            FRM.ShowDialog();
        }

        private void FilterText_TextChanged(object sender, EventArgs e)
        {
            string FilterBys = "";

            switch (FilterBy.Text)
            {
                case "Booking ID": 

                    FilterBys = "BookingID";
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
                booksDatatable.DefaultView.RowFilter = "";
                return;
            }

            if (FilterBys == "BookingID")
            {
                if (int.TryParse(FilterText.Text.Trim(), out int filterValue))
                {
                    booksDatatable.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterBys, filterValue);
                }

            }
            else
            {
                booksDatatable.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterBys, FilterText.Text.Trim());
            }
        }
    }
}
