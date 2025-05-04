using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Concreate.EntityFramework.EntityConfigurations
{
    public class ApplicationConfiguration : IEntityTypeConfiguration<Application>
    {
        public void Configure(EntityTypeBuilder<Application> builder)
        {
            builder.ToTable("Applications");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("Id").IsRequired();
            builder.Property(x => x.BootcampId).HasColumnName("BootcampId").IsRequired();
            builder.Property(x => x.ApplicantId).HasColumnName("ApplicantId").IsRequired();
            builder.Property(x => x.State).HasColumnName("State").IsRequired();

            builder.HasOne(x => x.Applicant);
            builder.HasOne(x => x.Bootcamp);
        }
    }
}
