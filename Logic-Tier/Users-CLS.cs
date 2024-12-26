using Data_Tier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Tier
{
    public class Users_CLS
    {
        private enum Enmode { Update=0, ADD=1 }
        private Enmode _enmode= Enmode.ADD;
        public int UsersID {  get; set; }

        public int PersonID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public bool IsActive { get; set; }

        public int Permissions {  get; set; }
        public Persons_CLS PersonsInfo { get; set; }

        public Users_CLS() 
        {
            this.UsersID = -1;
            this.PersonID = -1;
            this.Username = "";
            this.Password = "";
            this.IsActive = false;
            this.Permissions = -1;
            _enmode = Enmode.ADD;
        }
        public Users_CLS(int UsersID, int PersonID, string Username,string Password, bool IsActive,int Permission)
        {
            this.UsersID = UsersID;
            this.PersonID = PersonID;
            this.Username = Username;
            this.Password = Password;
            this.IsActive = IsActive;
            this.PersonsInfo = Persons_CLS.FindByID(PersonID);
            this.Permissions = Permission;
            _enmode = Enmode.Update;

        }
        public static string NumberOfUsers()
        {

            string NumberOfUsers = "";


            if (Users_SQL.NumberOfUsers(ref NumberOfUsers))
            {
                return NumberOfUsers;
            }

            return null;
        }

        private bool _UPDATE()
        {
            return (Users_SQL.Update(this.UsersID, this.PersonID, this.Username, this.Password, this.IsActive,this.Permissions));
        }
        private bool _ADD()
        {
            this.UsersID = Users_SQL.ADDNEWUSER(this.PersonID,this.Username,this.Password,this.IsActive,this.Permissions);
            return (this.UsersID!=-1);
        }

        public bool save()
        {
            switch (this._enmode)
            {
                case Enmode.ADD: if (_ADD())
                    {
                        return true;
                        _enmode = Enmode.Update;
                    }
                else
                    {
                        return false;
                    }

                case Enmode.Update: return (_UPDATE());

            }

            return false;

        }

        public static Users_CLS FindBYUSERID(int UsersID)
        {
            int PersonID = -1; int Permission = -1; string Username = ""; string Password = ""; bool IsActive = false;

            if (Users_SQL.FindByID(UsersID, ref PersonID, ref Username, ref Password, ref IsActive, ref Permission))
            {
                return new Users_CLS(UsersID, PersonID, Username, Username, IsActive, Permission);
            }

            return null;
        }
        public static Users_CLS FindBYPersonID(int PersonID)
            {
                int UserID = -1; string Username = "";int Permission = -1; string Password = ""; bool IsActive = false;

                if (Users_SQL.FindByPersonID(PersonID, ref UserID, ref Username, ref Password, ref IsActive, ref Permission))
                {
                    return new Users_CLS(UserID, PersonID, Username, Username, IsActive, Permission     );
                }

                return null;
            }
        public static Users_CLS FindBYUsernamePassword(string Username,string Password)
        {
            int UserID = -1; int PersonID = -1; int Permission = -1; bool IsActive = false;

            if (Users_SQL.FindByUsernamePassword(Username, Password, ref UserID, ref PersonID, ref IsActive, ref Permission))
            {
                return new Users_CLS(UserID, PersonID, Username, Username, IsActive, Permission);
            }

            return null;
        }

        public static DataTable List()
        {
            return Users_SQL.DatatablePerson();
        }
        public static bool Delete(int UserID)
        {
            return (Users_SQL.Delete(UserID));
        }

        public static bool IsExistByPersonID(int PersonID)
        {
            return (Users_SQL.IsExistByPersonID(PersonID));
        }
        public static bool IsExistByIDUser(int PersonID)
        {
            return (Users_CLS.IsExistByIDUser(PersonID));
        }

        public static bool IsExistByUsername(string Username)
        {
            return (Users_SQL.IsExistByUsername(Username));
        }
        public static bool IsExistByUsernameAndPassword(string Username,string Password)
        {
            return (Users_SQL.IsExistByUsernameAndPassword(Username, Password));
        }

        public enum enPermissions
        {

            ManageCustomers = 1,
            ManageUsers = 2,
            ManageVehicles = 4,
            ManageBooking = 8,
            ManageReturn = 16,
            ManageTransactions = 32,
            ManagePeople= 64
        }



    }
}
