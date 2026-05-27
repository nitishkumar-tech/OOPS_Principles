//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPS_Principles
//{
//    internal class Encapsulation
//    {
//        class Account
//        {
//            private double balance;
//            private string pin;

//        public void deposit(double amount)
//            {
//                if (amount > 0)
//                {
//                    balance += amount;
//                }
//            }

//            public void withdraw( double amount)
//            {
//                Console.WriteLine("Enter your pin:");
//                pin = Console.ReadLine();
                

//                    if (pin == "963963" && amount <= balance)
//                    {
//                        balance -= amount;
//                    }
                
//                   else
//                   {

//                    Console.WriteLine("please enter  valid pin");
//                   }

                
//            }
//            public double getbalance()
//            {
//                return balance;
//            }
//        }
//        static void Main(string[] args)
//        {
//            Account acc=new Account();
//            acc.deposit(6000);
//            acc.withdraw(2000);
//            Console.WriteLine("your  Avaliable balance is:");
//            Console.WriteLine("-----------------------------");
//            Console.WriteLine(acc.getbalance());
//            Console.WriteLine("-----------------------------");

//        }
//    }
//}
