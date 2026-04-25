using Microsoft.EntityFrameworkCore;
using SimpleAttendance.Data;
using SimpleAttendance.Models;
using SimpleAttendance.Repo.IRepo;

namespace SimpleAttendance.Repo
{
    public class AttendanceRepo : IAttendanceRepo
    {
       private readonly AppDbcontext context;
        public AttendanceRepo(AppDbcontext context)
        {
            this.context = context;
        }

        public void Add(Attendance attendance)
        {
            context.Attendances.Add(attendance);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var x = context.Attendances.Find(id);
            if (x != null)
            {
                context.Attendances.Remove(x);
                context.SaveChanges();
            }
        }

        public List<Attendance> GetAll(int? StudentId, int? SubjectId)
        {
            var a = context.Attendances
                .Include(a => a.Student)
                .Include(e => e.Subject)
                .AsQueryable();
           if(StudentId != null)
            {
                a=a.Where(a=>a.StudentId == StudentId);
            }
            if (SubjectId != null)
            {
                a = a.Where(a => a.SubjectId == SubjectId);
            }
            return a.ToList();
        }

        public Attendance GetById(int id)
        {
            return context.Attendances.Find(id);
        }

        public void Update(Attendance attendance)
        {
            context.Update(attendance);
            context.SaveChanges();
        }
    }
}
