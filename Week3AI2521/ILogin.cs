using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3AI2521
{
    internal interface ILogin
    {
        public void Login();

        public void Logout(string username);

        public void ChangePassword(string username, string oldPassword, string newPassword);
    }
}
