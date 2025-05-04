using Core.Entities;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Application : BaseEntity<Guid>
    {
        public Guid ApplicantId { get; set; }
        public Guid BootcampId { get; set; }
        public ApplicationState State { get; set; }

        public virtual Applicant? Applicant { get; set; }
        public virtual Bootcamp? Bootcamp { get; set; }

        public Application()
        {
            //
        }

        public Application(Guid applicationId, Guid bootcampId, ApplicationState state)
        {
            ApplicantId = applicationId;
            BootcampId = bootcampId;
            State = state;
        }
    }
}
