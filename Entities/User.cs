using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User : BaseEntity<Guid>
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalIdentity { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public ICollection<Applicant> Applicants { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public ICollection<Instructor> Instructors { get; set; }

        public User()
        {
            Applicants = new HashSet<Applicant>();
            Employees = new HashSet<Employee>();
            Instructors = new HashSet<Instructor>();
        }
        public User(string userName, string firstName, string lastName, DateTime dateOfBirth, string nationalIdentity, string email, string password)
        {
            UserName = userName;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            NationalIdentity = nationalIdentity;
            Email = email;
            Password = password;
        }
    }
}
