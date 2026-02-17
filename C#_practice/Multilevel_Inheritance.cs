using System;
using System.Collections.Generic;
using System.Text;

namespace C__practice
{
    public class Multilevel_Inheritance
    {
        // Level 1: Base Class
        public class Vehicle
        {
            public string Brand { get; set; }
            public int Year { get; set; }

            public void Start()
            {
                Console.WriteLine("Vehicle is starting...");
            }

            public void Stop()
            {
                Console.WriteLine("Vehicle is stopping...");
            }
        }

        // Level 2: Derived from Vehicle
        public class Car : Vehicle
        {
            public int NumberOfDoors { get; set; }
            public string FuelType { get; set; }

            public void Drive()
            {
                Console.WriteLine("Car is driving on the road.");
            }

            public void Honk()
            {
                Console.WriteLine("Beep! Beep!");
            }
        }

        // Level 3: Derived from Car
        public class SportsCar : Car
        {
            public int TopSpeed { get; set; }
            public bool HasTurbo { get; set; }

            public void Accelerate()
            {
                Console.WriteLine("Sports car is accelerating rapidly!");
            }

            public void ActivateTurbo()
            {
                if (HasTurbo)
                {
                    Console.WriteLine("Turbo activated! Vroooom!");
                }
                else
                {
                    Console.WriteLine("This car doesn't have turbo.");
                }
            }
        }



            //SportsCar myCar = new SportsCar();
            //myCar.Brand = "Ferrari";
            //myCar.Year = 2023;
            //myCar.NumberOfDoors = 2;
            //myCar.FuelType = "Petrol";
            //myCar.TopSpeed = 340;
            //myCar.HasTurbo = true;

            //Console.WriteLine("=== Sports Car Details ===");
            //Console.WriteLine($"Brand: {myCar.Brand}");
            //Console.WriteLine($"Year: {myCar.Year}");
            //Console.WriteLine($"Doors: {myCar.NumberOfDoors}");
            //Console.WriteLine($"Fuel: {myCar.FuelType}");
            //Console.WriteLine($"Top Speed: {myCar.TopSpeed} km/h");

            //Console.WriteLine("\n=== Actions ===");
            //myCar.Start();           // From Vehicle
            //myCar.Drive();           // From Car
            //myCar.Honk();            // From Car
            //myCar.Accelerate();      // From SportsCar
            //myCar.ActivateTurbo();   // From SportsCar
            //myCar.Stop();            // From Vehicle
    }
}
