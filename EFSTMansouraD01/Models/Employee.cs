using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSTMansouraD01.Models
{
    /// <summary>
    /// EF Models Writing
    /// 1-EF Convention
    /// 2-Data Annotaion //[attributeProp] => .DataAnnotation
    /// ///////////POCO Class
    /// 3-Fluent API 
    /// 4-External Config.
    /// </summary>
    /// EF Convention
    /// 1-Primitive DT (int , short , long )+Id | EmployeeId => PK + notNull + Identity
    /// 2-Primitive DT => not null
    /// 3-Refrence DT => before C#8 (null) After C#8 (not Null)
    /// 4-Forign key => ClassName+PK
    public class Employee
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public int Age { get; set; }
        public int? Salary { get; set; }
        public string ? Address { get; set; }

        [ForeignKey("Department")]
        public int? DeptId { get; set; }
        public virtual Department Department { get; set; } //null

        public override string ToString()
        {
            return $"{Id} , {Name} , {Age} , {Salary} , {DeptId} , {Department?.Name ?? "No Name"}"; //null.Name
        }
    }
}
