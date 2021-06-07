using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public class User: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UserType UserType { get; set; }
        public IList<Project> Projects { get; set; }
        public IList<TaskProject> Tasks { get; set; }
    }
}
