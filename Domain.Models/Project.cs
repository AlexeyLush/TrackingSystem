using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Models
{
    public class Project
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        [Display(Name = "Название")]
        [Required(ErrorMessage = "Заполните поле")]
        public string Title { get; set; }
        public IList<User> Users { get; set; }
        public IList<TaskProject> Tasks { get; set; }
        public IList<PersonalStatic> PersonalStatics { get; set; }
    }
}