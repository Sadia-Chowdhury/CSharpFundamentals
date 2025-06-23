using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessingSystem
{
    public class PayPalPayment: PaymentMethod
    {
        private string Email { get; set; }
        private double Amount { get; set; }
        public PayPalPayment(string name, string id, string email):base(name, id) 
        {
            this.PayerName = name;
            this.TransactionID = id;
            this.Email = email;
            
        }
        public override void PrintReceipt()
        {
            Console.WriteLine("PayPal Transfer Details.......");
            Console.WriteLine($"User Name is {PayerName}");
            Console.WriteLine($"Transaction ID : {TransactionID}");
            Console.WriteLine($"User Email : {Email}");
            Console.WriteLine();
        }
        public override bool ValidatePaymentDetails()

        {
            if (Email.Contains("@"))
            {
                this.Email = Email;
                return true;
            }
            else
            {
                Console.WriteLine("Email is not valid.");
                return false;
            }
        }

        public override void MakePayment(double amount)
        {
            Amount += amount;
            Console.WriteLine($"Payment amount {Amount} successfully using Bank Transfer.");
        }
    }
}
