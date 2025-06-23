namespace EmployeeSalarymanagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Details..");

            List<Employee> employees = new List<Employee>();

            while(true)
            {
                Console.WriteLine("Enter a choice:  ");
                Console.WriteLine("1. Enter Details of Fulltime Employee");
                Console.WriteLine("2. Enter Details of PartTime Employee");
                Console.WriteLine("3. Display Employee Salary Structure");
                Console.WriteLine("4. Exit..");

                string choice = Console.ReadLine();
                switch(choice)
                {
                    case "1":
                        Console.WriteLine("Enter name of Employee");
                        string name = Console.ReadLine();

                        Console.WriteLine("Enter ID of Employee");
                        string ID = Console.ReadLine();

                        Console.WriteLine("Enter monthly salary of Employee");
                        double amount =Convert.ToDouble(Console.ReadLine());

                        employees.Add(new FullTimeEmployee(name,ID, amount));
                        break;


                    case "2":
                        Console.WriteLine("Enter name of Employee");
                        string name1 = Console.ReadLine();

                        Console.WriteLine("Enter ID of Employee");
                        string ID1 = Console.ReadLine();

                        Console.WriteLine("Enter Hourly salary of Employee");
                        double amount1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Enter Hourly salary of Employee");
                        int hour = Convert.ToInt32(Console.ReadLine());

                        employees.Add(new PartTimeEmployee(name1, ID1, amount1, hour));
                        break;

                    case "3":
                        Console.WriteLine("Salary report of the employees: ");
                        foreach(Employee emp in employees)
                        {
                            emp.DisplayEmployeeInfo();
                            Console.WriteLine($"Employee's Salary: {emp.CalculateSalary()}");
                            Console.WriteLine();
                        }
                        break;

                    case "4":
                        Console.WriteLine("Exit Program.Thank YOU");
                        return;

                    default:
                        Console.WriteLine("Invalid Choice.");
                        break;


                }
            }

        }
    }
}
