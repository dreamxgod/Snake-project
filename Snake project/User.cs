using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_project
{
    internal class User
    {
        public static string Username { get; set; }
        public static string Password { get; set; }

        public User()
        {
            Username = "";
            Password = "";
        }
    }
}
