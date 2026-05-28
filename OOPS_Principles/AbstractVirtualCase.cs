using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Principles
{
    internal class AbstractVirtualCase
    {
        class myclass
        {
            public void display()
            {
                Console.WriteLine("Welocme to OOPS");
            }
            public virtual void show()
            {
                Console.WriteLine("show is calling");
            }
        }
        class dervied:myclass
        {
            public void message()
            {
                Console.WriteLine("message is calling");
            }
            public override void show()
            {
                Console.WriteLine("this is override method");
            }
        }
        static void Main(string[] args)
        {
            myclass obj = new myclass();
            obj.display();
            obj.show();
            dervied objd= new dervied();
            objd.message();
            objd.show();
        }
    }
}
