using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Principles
{
    internal class Encapsulation
    {
        class Account
        {
            private double balance;

        public void deposit(double amount)
            {
                if (amount > 0)
                {
                    balance += amount;
                }
            }

            public void withdraw( double amount)
            {
                if (amount <= balance)
                {
                    balance -= amount;
                }
            }
            public double getbalance()
            {
                return balance;
            }
        }
        static void Main(string[] args)
        {
            Account acc=new Account();
            acc.deposit(6000);
            acc.withdraw(2000);
           Console.WriteLine(acc.getbalance());
        }
    }
}
