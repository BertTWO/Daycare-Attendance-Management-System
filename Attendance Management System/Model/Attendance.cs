using System.ComponentModel.DataAnnotations;

namespace Attendance_Management_System.Model
{
    public class Attendance
    {
        [Key]
        public int AttendanceID { get; set; }
        public string Status { get; set; }
        public int StudentID { get; set; }
        public Student Student { get; set; }
    }

}
