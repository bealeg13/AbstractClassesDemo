using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
     class Motorcycle : Vehicle
    {
        public bool HasSideCart { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("driving absract for motorcycle");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("driving virtual for motorcycle");
        }

        public override void PrintDetails()
        {
            Console.WriteLine($"This motorcycle has a sidecart {HasSideCart}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
        }
    }
}
