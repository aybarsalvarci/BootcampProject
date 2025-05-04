using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests.Application
{
    public interface UpdateApplicationRequest
    {
        public Guid ApplicantId { get; set; }
        public Guid BootcampId { get; set; }
        public ApplicationState State { get; set; }
    }
}
