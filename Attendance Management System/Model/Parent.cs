using System.Collections.Generic;

namespace Attendance_Management_System.Model
{
    public class Parent
    {

        public int ParentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Contact { get; set; }
        public List<Student> Students { get; set; }

    }
}
