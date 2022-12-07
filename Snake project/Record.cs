using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_project
{
    internal class Record
    {
        public static string Username { get; set; } // зробити посилання на об юзера
        public static int HighScore { get; set; }

        public Record()
        {
            Username = "";
            HighScore = 0;
        }
    }
}
