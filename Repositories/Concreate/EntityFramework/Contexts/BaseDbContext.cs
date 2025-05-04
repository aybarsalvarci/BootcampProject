using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System.Reflection;

namespace Repositories.Concreate.EntityFramework.Contexts
{
    public class BaseDbContext : DbContext
    {
        protected IConfiguration Configuration;
        public DbSet<User> Users { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Blacklist> Blacklist { get; set; }
        public DbSet<Bootcamp> Bootcamps { get; set; }

        public BaseDbContext(DbContextOptions contextOptions ,IConfiguration configuration) : base(contextOptions)
        {
            Configuration = configuration;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Applicant>().ToTable("Applicants");
            modelBuilder.Entity<Employee>().ToTable("Employees");
            modelBuilder.Entity<Instructor>().ToTable("Instructors");


            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(x => x.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            
        }
    }
}
