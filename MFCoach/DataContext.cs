using MFCoach.Entities;
using System.Data.Entity;

namespace MFCoach
{
    public class DataContext:DbContext
    {
        public DataContext():base("name=con")
        {

        }
        public DbSet<Adviser> Advisers { get; set; }
        public DbSet<Coach> Coaches{ get; set; }
        public DbSet<Company> Companies{ get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Coordinator> Coordinators { get; set; }
        public DbSet<Major> Majors { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
