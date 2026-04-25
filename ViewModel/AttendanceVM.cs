using SimpleAttendance.Models;

namespace SimpleAttendance.ViewModel
{
    public class AttendanceVM
    {
        public string Status {  get; set; }
        public int AttendanceId { get; set; }
        public DateTime Date { get; set; }
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public List<Student> Studentss { get; set; }
        public List<Subject> Subjectss { get; set; }
        public List<Attendance> attendances { get; set; }
    }
}
