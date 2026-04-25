using Microsoft.EntityFrameworkCore;
using SimpleAttendance.Models;

namespace SimpleAttendance.Data
{
    public class AppDbcontext:DbContext
    {
        public AppDbcontext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
    }
}
