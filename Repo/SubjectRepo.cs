using SimpleAttendance.Data;
using SimpleAttendance.Models;
using SimpleAttendance.Repo.IRepo;

namespace SimpleAttendance.Repo
{
    public class SubjectRepo : ISubjectRepo
    {
        readonly AppDbcontext context;
        public SubjectRepo(AppDbcontext context)
        {
            this.context = context;
        }

        public void Add(Subject subject)
        {
            context.Subjects.Add(subject);
            context.SaveChanges();
        }

        public List<Subject> GetAll()
        {
            return context.Subjects.ToList();
        }
    }
}
