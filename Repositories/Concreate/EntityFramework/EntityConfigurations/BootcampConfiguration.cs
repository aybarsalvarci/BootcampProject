using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Concreate.EntityFramework.EntityConfigurations
{
    public class BootcampConfiguration : IEntityTypeConfiguration<Bootcamp>
    {
        public void Configure(EntityTypeBuilder<Bootcamp> builder)
        {
            builder.ToTable("Bootcamps");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("Id").IsRequired();
            builder.Property(x => x.InstructorId).HasColumnName("InstructorId").IsRequired();
            builder.Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(70);
            builder.Property(x => x.StartDate).HasColumnName("StartDate").IsRequired();
            builder.Property(x => x.EndDate).HasColumnName("EndDate").IsRequired();
            builder.Property(x => x.State).HasColumnName("State").IsRequired();

            builder.HasOne(x => x.Instructor);
        }
    }
}
