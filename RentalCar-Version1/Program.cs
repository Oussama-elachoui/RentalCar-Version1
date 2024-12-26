using RentalCar_Version1.BookingDossier.frmm;
using RentalCar_Version1.Dossier_Returns.frm;
using RentalCar_Version1.Persons.Forms;
using RentalCar_Version1.Users;
using RentalCar_Version1.Vehicules1.FORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalCar_Version1
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
