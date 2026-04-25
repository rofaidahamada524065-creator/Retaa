using System.ComponentModel.DataAnnotations;

namespace SimpleAttendance.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Email { get; set; }
        public List<Attendance>? Attendances { get; set; }
    }
}
