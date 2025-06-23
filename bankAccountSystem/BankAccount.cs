using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace bankAccountSystem
{
    internal class BankAccount
    {
        public string accHolderName;
        private double balance = 0;

        public BankAccount(string name, double balance=0)
        {
            if(name == null || name == " ")
            {
                Console.WriteLine("Please give a valid name");
                return;
            }
            this.accHolderName = name;
            if(balance > 0 )
            {
                this.balance = balance;
            }
            else
            {
                Console.WriteLine("Initial Balance must be greater than 0");
            }
            

        }

        public string AccHolderName
        {
            get
            {
                return accHolderName;
            }
            private set
            {
                accHolderName = value;
            }
        }

        public double Balance
        {
            get
            {
                return balance;
            }

        }
        public void Deposit (double amount)
        {
           if( amount >0)
            {
                balance += amount;
            }
           else
            {
                Console.WriteLine("This Amount cann't be deposited.");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficent Balance");
            }
        }

        public void GetBalance(ref double balanceRef)
        {
            Console.WriteLine($"Balance is : {balance}Tk.");
        }

    }
}
