using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Applicant : User
    {
        public Guid UserId { get; set; }
        public string About { get; set; }
        public virtual User? User { get; set; }
        public Applicant()
        {
            //
        }

        public Applicant(string userName, string firstName, string lastName, DateTime dateOfBirth, string nationalIdentity, string email, string password, string about)
            : base(userName, firstName, lastName, dateOfBirth, nationalIdentity, email, password)
        {
            About = about;
        }
    }
}
