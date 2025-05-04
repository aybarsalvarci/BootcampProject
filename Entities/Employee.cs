using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Employee : User
    {
        public string Position { get; set; }
        public Employee()
        {
        }
        public Employee(string userName, string firstName, string lastName, DateTime dateOfBirth, string nationalIdentity, string email, string password, string position)
            : base(userName, firstName, lastName, dateOfBirth, nationalIdentity, email, password)
        {
            Position = position;
        }

    }
}
