using Core.Entities;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Bootcamp : BaseEntity<Guid>
    {
        public Guid InstructorId { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public BootcampState State { get; set; }
        public virtual Instructor? Instructor{ get; set; }

        public Bootcamp()
        {
            // 
        }

        public Bootcamp(Guid instructorId, string name, DateTime startDate, DateTime endDate,
            BootcampState state)
        {
            InstructorId = instructorId;
            Name = name;
            StartDate = startDate;
            EndDate = endDate;
            State = state;
        }
    }
}
