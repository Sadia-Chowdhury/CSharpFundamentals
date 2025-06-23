using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessingSystem
{
    public interface IPaymentProcessor
    {
        public bool ValidatePaymentDetails();

        public void MakePayment(double amount);

    }
}
