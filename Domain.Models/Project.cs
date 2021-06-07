using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Project
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public IList<User> Users { get; set; }
        public IList<TaskProject> Tasks { get; set; }
    }
}
