using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    abstract class Vehicle
    {
        public int Year { get; set; } = 1995;
        public string Make { get; set; } = "Toyota";
        public string Model { get; set; } = "Camry";

        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine("drive virtual");
        }
    }
}
