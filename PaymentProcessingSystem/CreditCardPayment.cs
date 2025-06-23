using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace PaymentProcessingSystem
{
    public class CreditCardPayment: PaymentMethod
    {
        public string CardNumber { get; set; }
        private double Amount { get; set; }

        public CreditCardPayment(string name, string id, string cardNumber=" "):base(name,id)
        {
           
            this.PayerName = name;
            this.TransactionID = id;
            this.CardNumber = cardNumber;
        }
        public override void PrintReceipt()
        {
            Console.WriteLine("Card Payment Details.......");
            Console.WriteLine($"USer name is {PayerName}");
            Console.WriteLine($"Transaction ID : {TransactionID}");
            Console.WriteLine($"Card Number : {CardNumber}");
            Console.WriteLine();
        }
        public override bool ValidatePaymentDetails()

        {
            if (CardNumber.Length == 16 && CardNumber.All(char.IsDigit))
            {
                this.CardNumber = CardNumber;
                return true;
            }
            else
            {
                Console.WriteLine("CardNumber is not Valid!!");
                return false;
            }
        }

        public override void MakePayment(double amount)
        {
            Amount += amount;
            Console.WriteLine($"Payment amount {amount} successfully using Card.");
        }
    }
}
