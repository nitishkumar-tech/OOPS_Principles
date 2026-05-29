using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Principles
{
    internal class AbstractConstructor
    {
        abstract class person
        {
            protected string name;
            private int age;
            public person(string name, int age)
            {
                this.name = name;
                this.age = age;
                Console.WriteLine("person constructor is called");
            }
            public void Displayinfo()
            {
                Console.WriteLine($"Name:{name},Age:{age}");
            }
            public abstract void Role();
        }
        class student : person
        {
            public int rollno;
            public student(string name, int age, int rollno) : base(name, age)
            {
                this.rollno = rollno;
                Console.WriteLine("student constructor called");
            }
            public override void Role()
            {
                Console.WriteLine("Iam a student ");
            }
        }
        class program
        {
            static void Main(string[] args)
            {
                student s = new student("rama", 22, 101);
                s.Role();
                s.Displayinfo();
            }
        }
    }
}
