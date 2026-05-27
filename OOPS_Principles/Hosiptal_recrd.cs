using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Principles
{
    internal class Hosiptal_recrd
    {
        class hosiptals
        {
            private string pname;
            private int page;
            private string medicalhistory;
            public string PNAME { get; set; }
            public int PAGE { get; set; }
            public void Medicalhistory()
            {
                medicalhistory = "Patient has a history of diabetes and hypertension.";
                Console.WriteLine(medicalhistory);
            }
        }
        static void Main(string[] args)
        {
            
            hosiptals obj = new hosiptals();
            obj.PNAME = "Rahul";
            obj.PAGE = 35;
            Console.WriteLine(obj.PNAME);
            Console.WriteLine(obj.PAGE);
            obj.Medicalhistory();
        }
    }
}
