using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Tier
{
    public class CurrentUser
    {
        public static Users_CLS UsersInfo=null;
        public static bool CheckAccessDenied(Users_CLS.enPermissions enPermissions)
        {


            if (((int)enPermissions & CurrentUser.UsersInfo.Permissions) == (int)enPermissions)
                return true;

            else
                return false;

        }
        public static bool CheckAccessDenied(Users_CLS.enPermissions enPermissions, Users_CLS user)
        {


            if (((int)enPermissions & user.Permissions) == (int)enPermissions)
                return true;

            else
                return false;

        }

    }
}
