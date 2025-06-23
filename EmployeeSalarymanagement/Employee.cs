using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalarymanagement
{
    internal abstract class Employee
    {
        public string Name { get; set; }
        public string ID { get; set; }

        public Employee(string name, string id)
        {
            Name = name;
            ID = id;
        }
        public abstract double CalculateSalary();

        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Employee's Name: {Name}.");
            Console.WriteLine($"Employee's ID: {ID}.");
        }
        
    }
}
