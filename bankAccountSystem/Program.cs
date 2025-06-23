namespace bankAccountSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WelCome To City Trust bank !!");
            Console.WriteLine("Enter Your Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Amount deposit for Initial Balance");
            double amount = Convert.ToInt32(Console.ReadLine());

            BankAccount banker1 = new BankAccount(name, amount);

            while(true)
            {
                Console.WriteLine("Choose An Option");
                Console.WriteLine("1. Deposite");
                Console.WriteLine("2. WithDraw");
                Console.WriteLine("3. Check Balance ");
                Console.WriteLine("Any key for Exit");
                string choice = Console.ReadLine();
              
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter Amount for deposite:");
                        double depositeAmount = Convert.ToInt32(Console.ReadLine());
                        banker1.Deposit(depositeAmount);
                        Console.WriteLine("Amount Deposited Successfully!!");
                        break;

                    case "2":
                        Console.WriteLine("Enter Amount for Withdraw:");
                        double withdrawAmount = Convert.ToInt32(Console.ReadLine());
                        banker1.Withdraw(withdrawAmount);
                        Console.WriteLine("Amount withdrawed Successfully!!");
                        break;

                    case "3":
                        Console.WriteLine("Total Balance is: ");
                        double balance = banker1.Balance;
                        banker1.GetBalance(ref balance);
                        break;

                    default:
                        Console.WriteLine("Thank You!!");
                        return;


                }
            }
            

            

            
        }
    }
}
