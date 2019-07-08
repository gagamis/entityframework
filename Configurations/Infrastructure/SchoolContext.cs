using Microsoft.EntityFrameworkCore;
using Tutorial.Core.Entities;
// using Tutorial.Infrastructure.Configurations;

namespace Tutorial.Infrastructure
{
    public class SchoolContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }

        public SchoolContext(DbContextOptions options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Adds configurations one by one from separate class
            // it is not the best way!
            // modelBuilder.ApplyConfiguration(new StudentConfigurations());
            // modelBuilder.ApplyConfiguration(new EnrollmentConfigurations());
            // modelBuilder.ApplyConfiguration(new CourseConfigurations());

            // add all separate configuration classes
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SchoolContext).Assembly);
        }

    }
}
