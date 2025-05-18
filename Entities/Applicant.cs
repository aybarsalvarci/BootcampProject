using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Applicant : User
    {
        public string About { get; set; }
        public virtual ICollection<Application> Applications { get; set; }
        public Applicant()
        {
            Applications = new HashSet<Application>();
        }

        public Applicant(string userName, string firstName, string lastName, DateTime dateOfBirth, string nationalIdentity, string email, string password, string about)
            : base(userName, firstName, lastName, dateOfBirth, nationalIdentity, email, password)
        {
            About = about;
        }
    }
}
