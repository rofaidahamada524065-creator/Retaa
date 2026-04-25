using System.ComponentModel.DataAnnotations;

namespace SimpleAttendance.Models
{
    public class Subject
    {
        [Key]
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public List<Attendance>? Attendances { get; set; }
    }
}
