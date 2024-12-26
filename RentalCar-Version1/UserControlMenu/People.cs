using Logic_Tier;
using RentalCar_Version1.Persons.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalCar_Version1.UserControlMenu
{
    public partial class People : UserControl
    {
        private static DataTable _ALLPEOPLE = Persons_CLS.List();
        private DataTable _People = _ALLPEOPLE.DefaultView.ToTable(false,
            "ID", "Fullname", "NationalityID", "Phone", "Email", "Address");
        public People()
        {
            InitializeComponent();
        }

        private void _Refresh()
        {
            DataTable _ALLPEOPLE = Persons_CLS.List();
            DataTable _People = _ALLPEOPLE.DefaultView.ToTable(false,
               "ID", "Fullname", "NationalityID", "Phone", "Email", "Address");
            dataGridView1.DataSource = _People; 
        }
        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            Frm_ADDUPDATEPERSONS frm = new Frm_ADDUPDATEPERSONS();
            frm.ShowDialog();
            _Refresh();
        }

        private void People_Load(object sender, EventArgs e)
        {
            FilterBy.SelectedIndex = 0;

            dataGridView1.DataSource = _People;
            dataGridView1.Size = new Size(797, 244);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[0].Width = 40;   

            dataGridView1.Columns[1].HeaderText = "F";
            dataGridView1.Columns[0].Width = 40;

            dataGridView1.Columns[2].HeaderText = "Nationality ID";
            dataGridView1.Columns[2].Width = 130;  


            dataGridView1.Columns[3].HeaderText = "Phone";
            dataGridView1.Columns[3].Width = 90;    

            dataGridView1.Columns[4].HeaderText = "Email";
            dataGridView1.Columns[4].Width = 180;   

            dataGridView1.Columns[5].HeaderText = "Address";
            dataGridView1.Columns[5].Width = 180;    

            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 10);  
            dataGridView1.DefaultCellStyle.BackColor = Color.White;       
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;       

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold); 
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray; 
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black; 

            dataGridView1.RowHeadersVisible = true; 
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.LightGray; 
            dataGridView1.RowHeadersDefaultCellStyle.ForeColor = Color.Black; 

            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;

            dataGridView1.AllowUserToOrderColumns = true;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.GridColor = Color.DarkGray; 
            dataGridView1.BorderStyle = BorderStyle.Fixed3D; 


            dataGridView1.BackgroundColor = Color.White; 
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string FiltredBy = "";
            switch (FilterBy.Text)
            {
                case "Person ID":
                    FiltredBy = "ID";
                    break;
                case "Full Name":
                    FiltredBy = "Fullname";
                    break;
                case "Email":
                    FiltredBy = "Email";
                    break;
                case "Phone":
                    FiltredBy = "Phone";
                    break;
                default:
                    FiltredBy = "";
                    break;
            }

            if (string.IsNullOrWhiteSpace(FilterBy.Text))
            {
                _People.DefaultView.RowFilter = ""; 
                return;
            }


            if (FiltredBy == "ID")
            {
                if (int.TryParse(FilterText.Text.Trim(), out int filterValue))
                {
                    _People.DefaultView.RowFilter = string.Format("[{0}] = {1}", FiltredBy, filterValue);
                }
                else
                {
                    MessageBox.Show("Invalid input for Person ID. Please enter a valid integer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                _People.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FiltredBy, FilterText.Text.Trim());
            }

        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ADDUPDATEPERSONS frm = new Frm_ADDUPDATEPERSONS();
            frm.ShowDialog();
            _Refresh();


        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ADDUPDATEPERSONS frm = new Frm_ADDUPDATEPERSONS((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _Refresh();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Person [" + dataGridView1.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

            {

                //Perform Delele and refresh
                if (Persons_CLS.delete((int)dataGridView1.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Person Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                    MessageBox.Show("Person was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _Refresh();

            }
        }

        private void personInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_PersonDetails frm = new Frm_PersonDetails((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _Refresh();

        }
    }
}
