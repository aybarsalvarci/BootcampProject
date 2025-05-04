using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Concreate.EntityFramework.EntityConfigurations
{
    public class BlaclistConfiguration : IEntityTypeConfiguration<Blacklist>
    {
        public void Configure(EntityTypeBuilder<Blacklist> builder)
        {
            builder.ToTable("Blacklist");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("Id").IsRequired();
            builder.Property(x => x.ApplicantId).HasColumnName("ApplicantId").IsRequired();
            builder.Property(x => x.Reason).HasColumnName("Reason").HasMaxLength(255).IsRequired();
            builder.Property(x => x.Date).HasColumnName("Date").IsRequired();

            builder.HasOne(x => x.Applicant);
        }
    }
}
