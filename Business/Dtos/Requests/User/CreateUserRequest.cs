﻿using System;
using System.Collections.Generic;
namespace Business.Dtos.Requests.User
{
    public class CreateUserRequest
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalIdentity { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
