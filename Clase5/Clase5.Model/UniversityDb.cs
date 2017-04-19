using System.Data.Entity;

namespace Clase5.Model
{
    public class UniversityDb : DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Course> Courses { get; set; }

        public UniversityDb() : base("name=UniversityDb")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Instructor>().ToTable("Instructors");
            modelBuilder.Entity<Student>().ToTable("Students");
        }
    }
}