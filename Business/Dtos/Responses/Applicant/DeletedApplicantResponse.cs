﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.Applicant
{
    public class DeletedApplicantResponse
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalIdentity { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string About { get; set; }
    }
}
