//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPS_Principles
//{
//    internal class AbstractElctBill
//    {
//        abstract class HMWBS
//        {
//            public void billdeatils()
//            {
//                Console.WriteLine("HMWBS Bill Generated");
//            }
//            public abstract void Getbill(double units);
//        }
    
//        class ResidentailCustomers : HMWBS
//        {
//            public override void Getbill(double units)
//            {
//                double bill = units * 7;
//                Console.WriteLine(" ResidentailCustomers bill " + bill);
//            }
//        }
//        class CommericalCustomers : HMWBS
//        {
//            public override void Getbill(double units)
//            {
//                double bill = units * 10;
//                Console.WriteLine("CommericalCustomers  bill " + bill);
//            }
//        }
//        class AgriculturalCustomers : HMWBS
//        {
//            public override void Getbill(double units)
//            {
//                double bill = units * 0;
//                Console.WriteLine("AgriculturalCustomers  bill " + bill);
//            }
//        }
//        class IndustryCustomers : HMWBS
//        {
//            public override void Getbill(double units)
//            {
//                double bill = units * 15;
//                Console.WriteLine("IndustryCustomers  bill " + bill);
//            }
//        }

//        internal class program
//        {
//            static void Main(string[] args)
//            {
//                HMWBS obj = new ResidentailCustomers();
//                obj.billdeatils();
//                Console.WriteLine("Enter number of units consumed");
//                double unit=int.Parse(Console.ReadLine());
//                obj.Getbill(unit);
//                obj = new CommericalCustomers();
//                obj.Getbill(unit);
//                obj=new AgriculturalCustomers();
//                obj.Getbill(unit);
//                obj= new IndustryCustomers();
//                obj.Getbill(unit);
//            }
//        }
//    }
//}
