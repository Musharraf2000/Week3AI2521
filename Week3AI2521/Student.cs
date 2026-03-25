using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3AI2521
{
    internal class Student : ILogin
    {

        public void Logout(string username)
        {
            Console.WriteLine("Student logged out.");
        }

        public void ChangePassword(string username, string oldPassword, string newPassword)
        {
            Console.WriteLine("Student password changed.");
        }

        public void Login()
        {
            Console.WriteLine("Student logged in.");
        }
    }
}
