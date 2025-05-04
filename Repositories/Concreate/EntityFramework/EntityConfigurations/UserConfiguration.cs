using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Concreate.EntityFramework.EntityConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.Property(x => x.Id).HasColumnName("Id").IsRequired();
            builder.Property(x => x.UserName).HasColumnName("UserName").IsRequired().HasMaxLength(50);
            builder.Property(x => x.FirstName).HasColumnName("FirstName").IsRequired().HasMaxLength(50);
            builder.Property(x => x.LastName).HasColumnName("LastName").IsRequired().HasMaxLength(50);
            builder.Property(x => x.DateOfBirth).HasColumnName("DateOfBirth").IsRequired();
            builder.Property(x => x.Email).HasColumnName("Email").IsRequired().HasMaxLength(80);
            builder.Property(x => x.NationalIdentity).HasColumnName("NationalIdentity").IsRequired().HasMaxLength(11);
            builder.Property(x => x.Password).HasColumnName("Password").IsRequired().HasMaxLength(50);

        }
    }
}
