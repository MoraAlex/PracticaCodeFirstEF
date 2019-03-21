using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst2.Classes
{
    class Employee
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime StartDate { get; set; }
        public Company company { get; set; }

        public virtual ICollection<Position> Positions { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}
