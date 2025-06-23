using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessingSystem
{
    public class BankTransferPayment : PaymentMethod
    {
        public string AccNumber {  get; set; }
        private double Amount { get; set; }
        public BankTransferPayment(string name, string id, string accNumber):base(name,id)
        {
            this.PayerName = name;
            this.TransactionID = id;
            this.AccNumber = accNumber;
            
        }
        public override void PrintReceipt()
        {
            Console.WriteLine("Bank Transfer Details.......");
            Console.WriteLine($"User Name is {PayerName}");
            Console.WriteLine($"Transaction ID : {TransactionID}");
            Console.WriteLine($"Account Number : {AccNumber}");
            Console.WriteLine();
        }
        public override bool ValidatePaymentDetails()

        {
            if (AccNumber.Length == 10)
            {
                this.AccNumber = AccNumber;
                return true;
            }
            else
            {
                Console.WriteLine("Account Number is not valid");
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

