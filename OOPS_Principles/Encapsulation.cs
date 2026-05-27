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
            private int pin;

        public void deposit(double amount)
            {
                if (amount > 0)
                {
                    balance += amount;
                }
            }

            public void withdraw( double amount)
            {
                Console.WriteLine("Enter your pin:");
                pin = Convert.ToInt32(Console.ReadLine());
                if (pin == 963963)
                {

                    if (amount <= balance)
                    {
                        balance -= amount;
                    }
                    else
                    {
                        { 
                            Console.WriteLine("please enter  valid pin");
                        }
                    }
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
