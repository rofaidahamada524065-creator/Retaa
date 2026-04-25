using SimpleAttendance.Models;

namespace SimpleAttendance.Repo.IRepo
{
    public interface IStudentRepo
    {
        void Add(Student student);
        List<Student> GetAll();
        Student GetById(int id);
        void Update(Student student);
        void Delete(int id);
    }
}
