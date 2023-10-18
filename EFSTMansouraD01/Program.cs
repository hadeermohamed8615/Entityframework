using ClassLibrary1;        
using EFSTMansouraD01.Context;
using EFSTMansouraD01.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace EFSTMansouraD01
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            //EF Creatation Staratgy
            //1-EnsureCreated
            //2-EnsureDeleted
            //3-Migration
            CompanyContext Db = new CompanyContext();
           // Db.Database.EnsureDeleted(); //Development
            Db.Database.EnsureCreated();
            #region Insert Department & Employee
            // //Department d = new Department() { Name = "SD" , Location = "Ism" };
            // //Department d2 = new Department() { Name = "UI" , Location = "Cairo" };
            // //Department d3 = new Department() { Name = "Mobile" , Location = "Smart" };
            // //Db.Departments.Add(d);
            // //Db.Departments.Add(d2);
            // //Db.Departments.Add(d3);

            // // Db.Departments.AddRange(d, d2, d3);


            // Employee e1 = new Employee() { Name = "ali", Salary = 2500, Age = 25, Address = "Cairo", DeptId = 1 };
            // Employee e2 = new Employee() { Name = "Ahmed", Salary = 2500, Age = 25, Address = "Giza", DeptId = 2 };
            // Employee e3 = new Employee() { Name = "Aya", Salary = 2500, Age = 25, Address = "Alex", DeptId = 3 };
            // Employee e4 = new Employee() { Name = "Hamada", Salary = 2500, Age = 25, Address = "Cairo", DeptId = 1 };

            // Db.Employees.AddRange(new[] { e1, e2, e3, e4 });
            ////Db.Employees.Add(e1); //add data in local storage 
            #endregion



            #region GetAll
            ///Lazy Loading
            //var Emp = Db.Employees.ToList();
            ///Eager Loading (include)
            ///
            //var Emp = Db.Employees.Include(e=>e.Department).ToList(); 

            //foreach (var emp in Emp)
            //{
            //    Console.WriteLine(emp);
            //}

            #endregion


            #region GetById
            //Console.WriteLine("Enter Emp Id : ");
            //int id = int.Parse(Console.ReadLine());
            //var emp = Db.Employees.FirstOrDefault(e => e.Id == id);
            // var emp = Db.Employees.Include(e=>e.Department).FirstOrDefault(e => e.Id == id);
            //var emp = Db.Employees.Find(id);
            //Console.WriteLine(emp);

            #endregion


            #region Update
            //Console.WriteLine("Enter Emp Id : ");
            //int id = int.Parse(Console.ReadLine());

            //var emp = Db.Employees.Find(id);
            //Console.WriteLine(emp);
            //emp.Name = "Hello";
            //Db.Employees.Update(emp); 
            //Console.WriteLine(emp);
            #endregion


            #region Remove
            //Console.WriteLine("Enter Emp Id : ");
            //int id = int.Parse(Console.ReadLine());

            //var emp = Db.Employees.Find(id);
            //Db.Employees.Remove(emp);

            #endregion

            Db.SaveChanges(); //change DB


            foreach (var e in Db.Employees)
            {
                Console.WriteLine(e);
            }

        }
    }
}
///Lab Assignment
///1-Department => [Id , Name , Location ] => 1 
///2-Student   => [id , name , age , level , address , phone] => M