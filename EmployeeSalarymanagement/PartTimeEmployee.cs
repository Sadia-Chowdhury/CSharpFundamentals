using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalarymanagement
{
    internal class PartTimeEmployee: Employee
    {
        

        private double hourlyRate;

        private int workingHour;

        public PartTimeEmployee(string name, string ID, double amount, int hour):base(name,ID)
        {
           
            this.hourlyRate = amount;
            this.workingHour = hour;
        }

        public override double CalculateSalary()
        {
            double salary = hourlyRate* this.workingHour;
            return salary;
        }

    }
}
