using SimpleAttendance.Models;

namespace SimpleAttendance.Repo.IRepo
{
    public interface IAttendanceRepo
    {
        void Update(Attendance attendance);
        void Delete(int id);
        List<Attendance> GetAll(int? StudentId,int? SubjectId);
        Attendance GetById(int id);
        void Add(Attendance attendance);
    }
}
