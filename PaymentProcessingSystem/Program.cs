namespace PaymentProcessingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Payment Section!!");
            Console.WriteLine("Please input payment number..");
            int paymentNumber = Convert.ToInt32(Console.ReadLine());
            List<PaymentMethod> list = new List<PaymentMethod>();
            for (int i =0;i<paymentNumber;i++)
            {
                Console.WriteLine("Select Payment Type..");
                Console.WriteLine("1. Credit Card Payment");
                Console.WriteLine("2. PayPal Payment");
                Console.WriteLine("3. Bank Transfer");
                Console.WriteLine("4. Exit..");


                
                string choice = Console.ReadLine();
                switch(choice)
                {
                    case "1":
                        Console.WriteLine("Enter user name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter Transaction ID: ");
                        string id = Console.ReadLine();
                        Console.WriteLine("Enter Card Number: ");
                        string cardNumber = Console.ReadLine();
                        Console.WriteLine();
                        list.Add(new CreditCardPayment(name,id, cardNumber));

                        break;
                    case "2":
                        Console.WriteLine("Enter user name: ");
                        string name1 = Console.ReadLine();
                        Console.WriteLine("Enter Transaction ID: ");
                        string id1 = Console.ReadLine();
                        Console.WriteLine("Enter Email Adddress: ");
                        string email = Console.ReadLine();
                        Console.WriteLine();
                        list.Add(new PayPalPayment(name1, id1, email));
                        break;
                    case "3":
                        Console.WriteLine("Enter user name: ");
                        string name2 = Console.ReadLine();
                        Console.WriteLine("Enter Transaction ID: ");
                        string id2 = Console.ReadLine();
                        Console.WriteLine("Enter Bank Account Number: ");
                        string accNumber = Console.ReadLine();
                        Console.WriteLine();
                        list.Add(new BankTransferPayment(name2, id2, accNumber));
                        break;
                    case "4":
                        Console.WriteLine("Exit!! Thank you");
                        break;
                }

            }
            foreach (var payment in list)
            {
                Console.Write("💵 Enter payment amount: ");
                double amount = Convert.ToDouble(Console.ReadLine());

                if (payment.ValidatePaymentDetails())
                {
                    payment.MakePayment(amount);
                    payment.PrintReceipt();
                }
                else
                {
                    Console.WriteLine("Payment validation failed. Skipping receipt.\n");
                }
            }

            Console.WriteLine("\nAll done. Thank you!");
        }
    }
}
    

