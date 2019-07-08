using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Tutorial.Core.Entities;

namespace Tutorial.Infrastructure.Configurations
{
    public class CourseConfigurations : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(x => x.CourseId);
            builder.Property(x => x.CourseId).HasDefaultValueSql("newsequentialid()").IsRequired().HasColumnName(nameof(Course.CourseId));
            builder.Property(x => x.Title).HasMaxLength(256).IsRequired();

            builder.HasMany(x => x.Enrollments).WithOne(x => x.Course).HasForeignKey(x => x.CourseID).IsRequired();
        }
    }
}
