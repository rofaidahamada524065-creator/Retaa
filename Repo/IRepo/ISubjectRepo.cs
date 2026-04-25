using SimpleAttendance.Models;

namespace SimpleAttendance.Repo.IRepo
{
    public interface ISubjectRepo
    {
        List<Subject> GetAll();
        void Add(Subject subject);
    }
}
