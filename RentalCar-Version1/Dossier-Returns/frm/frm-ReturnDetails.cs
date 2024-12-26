using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalCar_Version1.Dossier_Returns.frm
{
    public partial class frm_ReturnDetails : Form
    {
        private int _id=-1;
        public frm_ReturnDetails(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private void frm_ReturnDetails_Load(object sender, EventArgs e)
        {
            returnDetails1.LoadByid(_id);

        }
    }
}
