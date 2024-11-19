using System.ComponentModel.DataAnnotations;

namespace Attendance_Management_System.Model
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public bool Status { get; set; }
        public string QrCode { get; set; }
        public int ParentID { get; set; }
        public Parent Parent { get; set; }

    }

}
