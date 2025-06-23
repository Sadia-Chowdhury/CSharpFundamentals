using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalarymanagement
{
    internal class FullTimeEmployee: Employee
    {
        

        double monthlySalary;

        public FullTimeEmployee( string name, string ID, double amount):base( name, ID)
        {
           
            this.monthlySalary = amount;
        }

        public override double CalculateSalary()
        {
            return monthlySalary;
        }

    }
}
