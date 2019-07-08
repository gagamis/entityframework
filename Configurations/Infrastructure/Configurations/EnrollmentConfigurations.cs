using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tutorial.Core.Entities;

namespace Tutorial.Infrastructure.Configurations
{
    public class EnrollmentConfigurations : IEntityTypeConfiguration<Enrollment>
    {
        public void Configure(EntityTypeBuilder<Enrollment> builder)
        {
            builder.HasKey(x => x.EnrollmentID);
            builder.Property(x => x.EnrollmentID).HasDefaultValueSql("newsequentialid()").IsRequired().HasColumnName(nameof(Enrollment.EnrollmentID));
        }
    }
}
