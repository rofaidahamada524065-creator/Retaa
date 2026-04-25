using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleAttendance.Models
{
    public class Attendance
    {

        public int AttendanceId { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public int SubjectId { get; set; }
        [ForeignKey(("SubjectId"))]
        public Subject? Subject { get; set; }


        public int StudentId { get; set; }
        [ForeignKey(("StudentId"))]
        public Student? Student { get; set; }
    }
}
