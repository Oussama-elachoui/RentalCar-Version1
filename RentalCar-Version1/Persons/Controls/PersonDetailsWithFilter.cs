using Logic_Tier;
using RentalCar_Version1.Persons.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalCar_Version1.Persons.Controls
{
    public partial class PersonDetailsWithFilter : UserControl
    {
       
        public PersonDetailsWithFilter()
        {
            InitializeComponent();

        }

        public PersonDetailsWithFilter(int USERID)
        {
            InitializeComponent();
        
        
        
        }

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
                Filterbox.Enabled = _FilterEnabled;
            }
        }

        public int PersonId { get { return personDetails1.PersonId; } }

        public Persons_CLS PersonInfo { get { return personDetails1.PersonInfo; } }

        public void  LOADBYID(int PersonID)
        {
            FilterBy.SelectedIndex = 0;
            SearchText.Text= PersonID.ToString();
            personDetails1.Loadinfo(PersonID);
        }
        private void SearchBTN_Click(object sender, EventArgs e)
        {

            switch (FilterBy.Text)
            {
                case "Person ID":
                    if (!string.IsNullOrEmpty(SearchText.Text))
                    {
                        personDetails1.Loadinfo(int.Parse(SearchText.Text));
                    }
                    else
                    {
                        MessageBox.Show("The 'Person ID' field cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "Nationality ID":
                    if (!string.IsNullOrEmpty(SearchText.Text))
                    {
                        personDetails1.Loadinfo(int.Parse(SearchText.Text));
                    }
                    else
                    {
                        MessageBox.Show("The 'Nationality ID' field cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                default:
                    MessageBox.Show("Please select a valid search criteria.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        private void PersonDetailsWithFilter_Load(object sender, EventArgs e)
        {
            FilterBy.SelectedIndex = 0;


        }

        private void SearchText_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(SearchText.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(SearchText, "Le champ ne peut pas être vide.");
                return;
            }

            if (!int.TryParse(SearchText.Text, out _))
            {
                e.Cancel = true;
                errorProvider1.SetError(SearchText, "Veuillez entrer un nombre valide.");
                return;
            }

            errorProvider1.SetError(SearchText, string.Empty);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_ADDUPDATEPERSONS frm_ADDUPDATEPERSONS = new Frm_ADDUPDATEPERSONS();
            frm_ADDUPDATEPERSONS.DataBack += DATABACK; // Subscribe to the event
            frm_ADDUPDATEPERSONS.ShowDialog();
        }

        private void DATABACK(object sender, int personID)
        {
            FilterBy.SelectedIndex = 0;
            SearchText.Text = personID.ToString();
            personDetails1.Loadinfo(personID);
        }
    }
}
