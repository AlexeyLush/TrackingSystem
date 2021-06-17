using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class User: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Display(Name = "Тип пользователя")]
        public UserType UserType { get; set; } = UserType.DefaultUser;
        public IList<Project> Projects { get; set; }
        public IList<TaskProject> Tasks { get; set; }
    }
}