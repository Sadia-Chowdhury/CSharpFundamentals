using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessingSystem
{
    public abstract class PaymentMethod: IPaymentProcessor
    {
       public string PayerName { get; set; }
       public string TransactionID { get; set; }

        public PaymentMethod(string name, string id)
        {
            this.PayerName = name;
            this.TransactionID = id;
        }
        public abstract bool ValidatePaymentDetails();
        public abstract void MakePayment(double amount);
        public abstract void PrintReceipt();
       

    }
}
