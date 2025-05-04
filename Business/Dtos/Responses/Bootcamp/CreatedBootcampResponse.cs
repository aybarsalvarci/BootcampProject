using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.Bootcamp
{
    public class CreatedBootcampResponse
    {
        public Guid Id { get; set; }
        public Guid InstructorId { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public BootcampState State { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
