using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tutorial.Core.Entities;

namespace Tutorial.Infrastructure.Configurations
{
    public class StudentConfigurations : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).HasDefaultValueSql("newsequentialid()").IsRequired().HasColumnName(nameof(Student.ID));
            builder.Property(x => x.FirstMidName).HasMaxLength(256).HasColumnName(nameof(Student.FirstMidName));
            builder.Property(x => x.LastName).HasMaxLength(256).HasColumnName(nameof(Student.LastName));
            builder.Property(x => x.EnrollmentDate).HasColumnType("datetime").HasColumnName(nameof(Enrollment.EnrollmentID));

            builder.HasMany(x => x.Enrollments).WithOne(x => x.Student).HasForeignKey(x => x.StudentID).IsRequired();
        }
    }
}
