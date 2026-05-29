using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Principles
{
    internal class InhertingAbstarctClass
    {
        abstract class vehicle
        {
            protected string vehiclename;
            public vehicle(string vehiclename)
            {
                this.vehiclename = vehiclename;

                Console.WriteLine("vehicle is called");
            }
            public void show_vehicle_details()
            {
                Console.WriteLine($"vehicle name is {vehiclename}");
            }
            public abstract void vehciletype();
            }
        abstract class vehiclemodel : vehicle
        {
            protected string modelname;
            public vehiclemodel(string vehiclename, string modelname) : base(vehiclename)
            {
                this.modelname = modelname;
                Console.WriteLine("Vehicle model IS CAlling");
            }
            public void displayName()
            {
                Console.WriteLine($"Model name {modelname}");
            }
            public abstract void modeltype();
            }
        class vehicledata : vehiclemodel
        {
            public int vehiclenum;
            public vehicledata(string vehiclename, string vehiclemodel, int vehiclenum) : base(vehiclename, vehiclemodel)
            {
                this.vehiclenum = vehiclenum;
                Console.WriteLine("vehicledata is called");
            }
            public override void vehciletype()
            {
                Console.WriteLine("cars");
            }
            public override void modeltype()
            {
                Console.WriteLine("electric");
            }
        }
        internal class program
        {
            static void Main(string[] args)
            {
                vehicledata vd = new vehicledata("AUDI", "Q5", 9999);
                vd.show_vehicle_details();
                vd.displayName();
                vd.vehciletype();
                vd.modeltype();
            }
        }
    }
}
