using SimpleAttendance.Data;
using SimpleAttendance.Models;
using SimpleAttendance.Repo.IRepo;

namespace SimpleAttendance.Repo
{
    public class StudentRepo : IStudentRepo
    {
        readonly AppDbcontext context;
        public StudentRepo(AppDbcontext context)
        {
            this.context = context;
        }
        public void Add(Student student)
        {
           context.Students.Add(student);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
           var x= context.Students.Find(id);
            if (x != null)
            {
                context.Students.Remove(x);
                context.SaveChanges();
            }
        }

        public List<Student> GetAll()
        {
            return context.Students.ToList();
        }

        public Student GetById(int id)
        {
            return context.Students.Find(id);
        }

        public void Update(Student student)
        {
            context.Update(student);
            context.SaveChanges();
        }
    }
}
