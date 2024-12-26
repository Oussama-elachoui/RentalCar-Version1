using Logic_Tier;
using RentalCar_Version1.BookingDossier.frmm;
using RentalCar_Version1.Customers1;
using RentalCar_Version1.Dossier_Returns.frm;
using RentalCar_Version1.Vehicules1;
using RentalCar_Version1.Vehicules1.FORM;
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
    public partial class Transactions : UserControl
    {
        public Transactions()
        {
            InitializeComponent();
        }

        private void Transactions_Load(object sender, EventArgs e)
        {
            dgvTransactions.DataSource = CLS_TRANSACTIONS.Transactions();


            dgvTransactions.Columns[0].HeaderText = "TransactionID";
            dgvTransactions.Columns[0].Width = 190;

            dgvTransactions.Columns[1].HeaderText = "BookingID";
            dgvTransactions.Columns[1].Width = 190;
            dgvTransactions.Columns[2].HeaderText = "PaidInitialTotalDueAmount";
            dgvTransactions.Columns[2].Width = 210;
            dgvTransactions.Columns[3].HeaderText = "TransactionDate";
            dgvTransactions.Columns[3].Width = 190;
            dgvTransactions.Columns[4].HeaderText = "ReturnID";
            dgvTransactions.Columns[4].Width = 190;
            dgvTransactions.Columns[5].HeaderText = "ActualTotalDueAmount";
            dgvTransactions.Columns[5].Width = 190;
            dgvTransactions.Columns[6].HeaderText = "TotalRefundedAmount";
            dgvTransactions.Columns[6].Width = 190;
            dgvTransactions.Columns[7].HeaderText = "TotalRemaining";
            dgvTransactions.Columns[7].Width = 190;
            dgvTransactions.Columns[8].HeaderText = "UpdatedTransactionDate";
            dgvTransactions.Columns[8].Width = 190;
            dgvTransactions.Columns[9].HeaderText = "PaymentDetails";
            dgvTransactions.Columns[9].Width = 190;
            dgvTransactions.Columns[10].HeaderText = "IsDone";
            dgvTransactions.Columns[10].Width = 190;
            dgvTransactions.DefaultCellStyle.Font = new Font("Arial", 10);
            dgvTransactions.DefaultCellStyle.BackColor = Color.White;
            dgvTransactions.DefaultCellStyle.ForeColor = Color.Black;

            dgvTransactions.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvTransactions.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dgvTransactions.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            dgvTransactions.RowHeadersVisible = true;
            dgvTransactions.RowHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dgvTransactions.RowHeadersDefaultCellStyle.ForeColor = Color.Black;

            dgvTransactions.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;

            dgvTransactions.AllowUserToOrderColumns = true;

            dgvTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvTransactions.GridColor = Color.DarkGray;
            dgvTransactions.BorderStyle = BorderStyle.Fixed3D;


            dgvTransactions.BackgroundColor = Color.White;

        }

        private void showCustomerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetailsCustomer frm = new DetailsCustomer(Booking_CLS.FindByid((int)dgvTransactions.CurrentRow.Cells[1].Value).Customers.CustomerID);
            frm.ShowDialog();

        }

        private void showBookingDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_DETAILSBOOKING frm = new FRM_DETAILSBOOKING((int)dgvTransactions.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
        }

        private void showReturnDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ReturnDetails frm = new frm_ReturnDetails((int)dgvTransactions.CurrentRow.Cells[4].Value);
            frm.ShowDialog();
        }

        private void reciveMoneyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_DETAILSVEHICULE detailsVehicule = new FRM_DETAILSVEHICULE(Booking_CLS.FindByid((int)dgvTransactions.CurrentRow.Cells[1].Value).VehicleId);
            detailsVehicule.ShowDialog();

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void reciveMoneyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void reciveMoneyToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (CLS_TRANSACTIONS.Isdone((int)dgvTransactions.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("Is already terminated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Are you sure [" + dgvTransactions.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

            {

                if (CLS_TRANSACTIONS.FindByID((int)dgvTransactions.CurrentRow.Cells[0].Value).UpdateDone())
                {
                    MessageBox.Show("Done.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                    MessageBox.Show("error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvTransactions.DataSource = CLS_TRANSACTIONS.Transactions();

            }
        }
    }
}
