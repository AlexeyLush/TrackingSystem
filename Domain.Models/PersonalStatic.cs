using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class PersonalStatic
    {
        public int Id { get; set; }
        public string NameOfProject { get; set; }
        public string NameofTask { get; set; }
        public DateTime TimeOfWorkToday { get; set; }
        public DateTime TimeOfWorkAllTime { get; set; }
        public bool StatusOfTask { get; set; }
        public User Users { get; set; }
        public Project Project { get; set; }
    }
}
