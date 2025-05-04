using Entities;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.Application
{
    public class GetSingleApplicationResponse
    {
        public Guid Id { get; set; }
        public Guid ApplicantId { get; set; }
        public Guid BootcampId { get; set; }
        public ApplicationState State { get; set; }
        public virtual Entities.Applicant? Applicant { get; set; }
        public virtual Entities.Bootcamp? Bootcamp { get; set; }
    }
}
