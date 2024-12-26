using Logic_Tier;
using RentalCar_Version1.Dossier_Returns.Control;
using RentalCar_Version1.Dossier_Returns.frm;
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
    public partial class Return : UserControl
    {
        private DataTable DtReturn = Return_CLS.TableReturn();
        public Return()
        {
            InitializeComponent();
        }

        private void _Rerfresh()
        {
            dgvReturn.DataSource = DtReturn;

        }
        private void Return_Load(object sender, EventArgs e)
        {
            dgvReturn.DataSource = DtReturn;
            dgvReturn.Size = new Size(797, 244);

            dgvReturn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvReturn.Columns[0].HeaderText = "ReturenID";
            dgvReturn.Columns[0].Width = 140;

            dgvReturn.Columns[1].HeaderText = "ActualReturnDate";
            dgvReturn.Columns[1].Width = 185;


            dgvReturn.Columns[2].HeaderText = "ActualRentalDays";
            dgvReturn.Columns[2].Width = 190;


            dgvReturn.Columns[3].HeaderText = "ActualTotalDueAmount";
            dgvReturn.Columns[3].Width = 220;


            dgvReturn.DefaultCellStyle.Font = new Font("Arial", 10);
            dgvReturn.DefaultCellStyle.BackColor = Color.White;
            dgvReturn.DefaultCellStyle.ForeColor = Color.Black;

            dgvReturn.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvReturn.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dgvReturn.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            dgvReturn.RowHeadersVisible = true;
            dgvReturn.RowHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dgvReturn.RowHeadersDefaultCellStyle.ForeColor = Color.Black;

            dgvReturn.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;

            dgvReturn.AllowUserToOrderColumns = true;

            dgvReturn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvReturn.GridColor = Color.DarkGray;
            dgvReturn.BorderStyle = BorderStyle.Fixed3D;


            dgvReturn.BackgroundColor = Color.White; 
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            ADDUPDATE_return FRM = new ADDUPDATE_return();
            FRM.Show();
            _Rerfresh();
        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADDUPDATE_return FRM = new ADDUPDATE_return();
            FRM.Show();
            _Rerfresh();
        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to delete Booking [" + dgvReturn.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

            {

                //Perform Delele and refresh
                if (Return_CLS.Delete((int)dgvReturn.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Booking Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                    MessageBox.Show("Booking was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _Rerfresh();

            }
        }

        private void dETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frm_ReturnDetails FRM = new frm_ReturnDetails((int)dgvReturn.CurrentRow.Cells[0].Value);
            FRM.Show();
        }
    }
}
