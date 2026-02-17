using System;
using System.Collections.Generic;
using System.Text;

namespace C__practice
{
    public class Class_object
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public int NumberOfDoors { get; set; }
        public string EngineType { get; set; }
        public string FuelType { get; set; }
        public string TransmissionType { get; set; }
        public double Mileage { get; set; }
        public string LicensePlate { get; set; }
        public int NumberOfSeats { get; set; }
        public double CurrentSpeed { get; set; }
        public double FuelLevel { get; set; }
        public bool IsEngineOn { get; set; }
        public int CurrentGear { get; set; }

        // Constructor
        public Class_object(string brand, string model, int year, string color)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Color = color;
            CurrentSpeed = 0;
            FuelLevel = 100;
            IsEngineOn = false;
            CurrentGear = 0;
        }

        // Methods (Actions/Behaviors)
        public void StartEngine()
        {
            if (!IsEngineOn)
            {
                IsEngineOn = true;
                Console.WriteLine("Engine started.");
            }
            else
            {
                Console.WriteLine("Engine is already running.");
            }
        }

        public void StopEngine()
         {
            if (IsEngineOn && CurrentSpeed == 0)
            {
                IsEngineOn = false;
                Console.WriteLine("Engine stopped.");
            }
            else if (CurrentSpeed > 0)
            {
                Console.WriteLine("Cannot stop engine while car is moving!");
            }
        }

        public void Accelerate(double speed)
        {
            if (IsEngineOn)
            {
                CurrentSpeed += speed;
                FuelLevel -= 0.5;
                Console.WriteLine($"Accelerating... Current speed: {CurrentSpeed} km/h");
            }
            else
            {
                Console.WriteLine("Start the engine first!");
            }
        }

        public void Brake(double speed)
        {
            CurrentSpeed -= speed;
            if (CurrentSpeed < 0)
                CurrentSpeed = 0;
            Console.WriteLine($"Braking... Current speed: {CurrentSpeed} km/h");
        }

        public void TurnLeft()
        {
            Console.WriteLine("Turning left...");
        }

        public void TurnRight()
        {
            Console.WriteLine("Turning right...");
        }

        public void ChangeGear(int gear)
        {
            CurrentGear = gear;
            Console.WriteLine($"Gear changed to: {gear}");
        }

        public void HonkHorn()
        {
            Console.WriteLine("Beep! Beep!");
        }

        public void TurnOnHeadlights()
        {
            Console.WriteLine("Headlights turned on.");
        }

        public void TurnOffHeadlights()
        {
            Console.WriteLine("Headlights turned off.");
        }

        public void LockDoors()
        {
            Console.WriteLine("Doors locked.");
        }

        public void UnlockDoors()
        {
            Console.WriteLine("Doors unlocked.");
        }

        public void Refuel(double amount)
        {
            FuelLevel += amount;
            if (FuelLevel > 100)
                FuelLevel = 100;
            Console.WriteLine($"Refueled. Current fuel level: {FuelLevel}%");
        }

        public void DisplayInfo()
        {
            Console.WriteLine("\n--- Car Information ---");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Current Speed: {CurrentSpeed} km/h");
            Console.WriteLine($"Fuel Level: {FuelLevel}%");
            Console.WriteLine($"Engine Status: {(IsEngineOn ? "On" : "Off")}");
            Console.WriteLine($"Current Gear: {CurrentGear}");
            Console.WriteLine("----------------------\n");
        }






        // Create a new car object
        //Class_object myCar = new Class_object("Toyota", "Camry", 2023, "Red");
        //myCar.NumberOfDoors = 4;
        //    myCar.FuelType = "Petrol";

        //    // Use the car methods
        //    myCar.DisplayInfo();
        //    myCar.StartEngine();
        //    myCar.Accelerate(50);
        //    myCar.ChangeGear(3);
        //    myCar.HonkHorn();
        //    myCar.Brake(20);
        //    myCar.DisplayInfo();
        //    myCar.Refuel(10);
        //    myCar.Brake(30);
        //    myCar.StopEngine();

        //    Class_object myCar2 = new Class_object("Toyota1", "Camry1", 2023, "Red1");
        //myCar2 = myCar;
        //    myCar = null;
        //    Console.WriteLine(myCar2.NumberOfDoors);
        //    Console.WriteLine(myCar.NumberOfDoors);
    }


}

