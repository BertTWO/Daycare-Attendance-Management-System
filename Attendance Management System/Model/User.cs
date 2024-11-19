using System.Collections.Generic;

namespace Attendance_Management_System.Model
{
    internal class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public static List<User> Users = new List<User>();
    }
}
