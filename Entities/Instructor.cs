using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Instructor : User
    {
        public string CompanyName { get; set; }
        public Instructor()
        {
            //
        }

        public Instructor(string userName, string firstName, string lastName, DateTime dateOfBirth, string nationalIdentity, string email, string password, string companyName)
            :base(userName, firstName, lastName, dateOfBirth, nationalIdentity, email, password)
        {
            CompanyName = companyName;
        }
    }
}
