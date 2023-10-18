using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSTMansouraD01.Models
{
    public class Department
    {
        public int Id { get; set; } //EF Convention => Id (Identity)
        public string Name { get; set; }
        public string Location { get; set; }
        public virtual  ICollection<Employee> Employees{ get; set; }

        public override string ToString()
        {
            return $"[{Name} , {Location}]";
        }
    }
} 
