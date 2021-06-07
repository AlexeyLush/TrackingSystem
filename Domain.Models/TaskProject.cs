using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class TaskProject
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public TaskType TaskType { get; set; }
        public User Users { get; set; }
        public Project Project { get; set; }
    }
}
