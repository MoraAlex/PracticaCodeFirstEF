using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst2.Classes
{
    public enum Cat_Role
    {
        ProgramadorJr,
        Manager,
        ProgramadorSr,
        Soport,
        WebDeveloper
    }
    class Position
    {
        [Key]
        [Column(Order = 1)]
        public int Id { get; set; }
        [Key]
        [Column(Order = 2)]
        public Cat_Role Name { get; set; }
        public string Description { get; set; }
        
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}

