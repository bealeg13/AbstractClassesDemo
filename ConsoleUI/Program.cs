using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();

            Car car = new Car() { Year = 2008, Make = "Honda", Model = "Civic", HasTrunk = true };


            Motorcycle motorcycle = new Motorcycle() { Year = 2016, Make = "Suzuki", Model = "Hayabusa", HasSideCart = false };


            Vehicle vehicle1 = new Car() { Year = 1969, Make = "Dodge", Model = "Charger", HasTrunk = true };


            Vehicle vehicle2 = new Motorcycle() { Year = 2018, Make = "Yamaha", Model = "Star Ventura", HasSideCart = true };


            vehicles.Add(car);
            vehicles.Add(motorcycle);
            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);

            foreach (var vehicle in vehicles)
            {
                
                Console.WriteLine($"Vehicle make: {vehicle.Make}");
                Console.WriteLine($"Vehicle model:{vehicle.Model}");
                Console.WriteLine($"Vehicle year: {vehicle.Year}");
                Console.WriteLine();
                Console.WriteLine();
                
            }
            
            Console.WriteLine($"It is {car.HasTrunk} that {car.Make} {car.Model}'s have trunks.");            
            Console.WriteLine($"It is {motorcycle.HasSideCart} that {motorcycle.Make} {motorcycle.Model}'s have sidecarts because it is a sports bike.");
            Console.WriteLine();
            Console.WriteLine();
            car.DriveAbstract();
            motorcycle.DriveVirtual();
            motorcycle.DriveAbstract();
                /*
                 * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
                 * 
                 * Set the properties with object initializer syntax
                 */

                /*
                 * Add the 4 vehicles to the list
                 * Using a foreach loop iterate over each of the properties
                 */

                // Call each of the drive methods for one car and one motorcycle

                #endregion
                Console.ReadLine();
            
        }

    }
}




