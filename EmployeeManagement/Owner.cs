using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagement
{
    class Owner : User
    {
        public Owner(String empID, String fullName, String firstName, String nic, String address, int contactNo, String shop, String type, String status, String password)
            : base(empID, fullName, firstName, nic, address, contactNo, shop, type, status, password)
        {
            //addUserToDatabase(this);
            //addToUsers(this);
        }

        public static void login()
        {
            AdminInterface admin = new AdminInterface();
            admin.Show();
        }

        public void logout()
        { }

    }
}
