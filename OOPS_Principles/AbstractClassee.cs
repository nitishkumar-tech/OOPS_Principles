//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPS_Principles
//{
//    internal class AbstractClassee
//    {
//        abstract class abstractclass
//        {
//            public void start()
//            {
//                Console.WriteLine("started the class");
//            }
//            public void resume()
//            {
//                Console.WriteLine("resumed the class");
//            }
//            public void display()
//            {
//                Console.WriteLine("welcome");
//            }
//            public abstract void end();
//        }
//        class derviedclass : abstractclass
//        {
//            public override void end()
//            {
//                Console.WriteLine("session has ended");
//            }
//        }
//        static void Main(string[] args)
//        {
//            abstractclass obj = new derviedclass();
//            obj.start();
//            obj.resume();
//            obj.display();
//            obj.end();
//        }
//    }
//}

