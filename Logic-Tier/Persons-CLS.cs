using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static Logic_Tier.Persons_CLS;

namespace Logic_Tier
{
    public class Persons_CLS
    {
        public enum EnMode {Update=0,ADD=1 }
        private EnMode _Mode = EnMode.Update;
        public int PersonID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int NationalityID { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string ImagePath {  get; set; }

        public Persons_CLS()
        
        {
            this.PersonID = -1;
            this.Firstname = "";
            this.Lastname = "";
            this.NationalityID = -1;
            this.DateOfBirth = DateTime.MinValue;
            this.Phone = "";
            this.Email = "";
            this.Address = "";
            this.ImagePath = "";
            _Mode = EnMode.ADD;
        }
         
        public Persons_CLS(int PersonID,string Firstname , string Lastname , int NationalityID,DateTime Dateofbirth, string Phone , string Email,string Address, string imagePath)
        {
            this.PersonID = PersonID;
            this.Firstname = Firstname;
            this.Lastname = Lastname;   
            this.NationalityID = NationalityID;
            this.DateOfBirth = Dateofbirth;
            this.Phone = Phone;
            this.Email = Email;
            this.Address = Address;
            this.ImagePath = imagePath;
            _Mode = EnMode.Update;
        }

        private bool _ADD()
        {
            this.PersonID = Data_Tier.PeronsSQL.ADDPERSON(this.Firstname, this.Lastname, this.NationalityID, this.DateOfBirth, this.Phone, this.Email, this.Address, this.ImagePath);
             return (this.PersonID != -1);
        }

        private bool _Update()
        {

            return (Data_Tier.PeronsSQL.Update(this.PersonID, this.Firstname, this.Lastname, this.NationalityID, this.DateOfBirth, this.Phone, this.Email, this.Address, this.ImagePath));
        }

        public static Persons_CLS FindByID(int ID)
        {
            string Firstname = ""; string Lastname = ""; string Phone = ""; string Email = ""; string Address = ""; string ImagePath = "";
            DateTime Dateofbirth = DateTime.MinValue; int NationalityID = -1;

            if (Data_Tier.PeronsSQL.FindByID(ID, ref Firstname, ref Lastname, ref NationalityID, ref Dateofbirth, ref Phone, ref Email, ref Address, ref ImagePath))
            {
                return new Persons_CLS(ID, Firstname, Lastname, NationalityID, Dateofbirth, Phone, Email, Address, ImagePath);
            }

            else
            {
                return null;
            }

        }

        public static Persons_CLS FindByNationalityID(int ID)
        {
            string Firstname = ""; string Lastname = ""; string Phone = ""; string Email = ""; string Address = ""; string ImagePath = "";
            DateTime Dateofbirth = DateTime.MinValue; int PersonID = -1;

            if (Data_Tier.PeronsSQL.FindByNationalityID(ID,ref PersonID, ref Firstname, ref Lastname, ref Dateofbirth, ref Phone, ref Email, ref Address, ref ImagePath))
            {
                return new Persons_CLS(PersonID, Firstname, Lastname, ID, Dateofbirth, Phone, Email, Address, ImagePath);
            }

            else
            {
                return null;
            }

        }

        public static bool delete(int ID)
        {
            return (Data_Tier.PeronsSQL.Delete(ID));
        }

        public static DataTable List()
        {
            return Data_Tier.PeronsSQL.DatatablePerson();
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case EnMode.ADD:
                    if (_ADD())
                    {

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case EnMode.Update: return (_Update());
            }

            return false;
        }

        public static bool PersonIsExistByID(int ID)
        {
            return Data_Tier.PeronsSQL.PersonIdExist(ID);
        }


        public static bool PersonIsExistByNationalityID(int ID)
        {
            return Data_Tier.PeronsSQL.NationalityIdExist(ID);

        }
        public static bool PersonIsExistByEmail(string EMAIL)
        {
            return Data_Tier.PeronsSQL.EmailExist(EMAIL);

        }

        public static bool PersonIsExistByPhone(string Phone)
        {
            return Data_Tier.PeronsSQL.PhoneExist(Phone);

        }

    }
}
