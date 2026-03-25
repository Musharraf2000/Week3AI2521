using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3AI2521
{
    internal class Lecturer : ILogin
    {
        public void ChangePassword(string username, string oldPassword, string newPassword)
        {
            Console.WriteLine("Ask Lecturer Credentials and Change Password");
        }

        public void Login()
        {
            Console.WriteLine("Ask Lecturer Credentials and Login");
        }

        public void Logout(string username)
        {
           Console.WriteLine("Logout");
        }
    }
}
