using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_Exercise_1
{
        public class Vehicle // sets the class name as Vehicle
        {
            public string Make { get; set; } // property for make
            public string Model { get; set; } // property for model
            public int Year { get; set; } // property for year
            public int MaxSpeed { get; set; } // property for maxspeed

            public Vehicle(string make, string model, int year, int maxSpeed)
            {
            // sets the make, model, year, maxspeed as varibales
                Make = make; 
                Model = model;
                Year = year;
                MaxSpeed = maxSpeed;
            }

            public virtual void DisplayInfo() // method for Display info
            {
                Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}, Max Speed: {MaxSpeed} mph"); // displays to the user the info for the vehicle
            }
        }

        public class Car : Vehicle
        {
            public int NumberOfDoors { get; set; } // property for numberofdoors

            public Car(string make, string model, int year, int maxSpeed, int numberOfDoors) // car properties
                : base(make, model, year, maxSpeed)
            {
                NumberOfDoors = numberOfDoors;
            }

            public override void DisplayInfo() // override for Displayinfo 
            {
                base.DisplayInfo();
                Console.WriteLine($"Number of Doors: {NumberOfDoors}"); // writeline for the number of doors
            }
        }

        public class Motorcycle : Vehicle
        {
            public bool HasSideCar { get; set; } // starts the true or false for the HasSideCar

            public Motorcycle(string make, string model, int year, int maxSpeed, bool hasSideCar) // motorcycle properties
                : base(make, model, year, maxSpeed)
            {
                HasSideCar = hasSideCar; 
            }

            public override void DisplayInfo() // overrides the DisplayInfo for if it has a sidecar or not
            {
                base.DisplayInfo();
                Console.WriteLine($"Has Sidecar: {HasSideCar}"); // writeline for sidecar
            }
        }

        public class Program
        {
            public static void Main(string[] args)
            {
                Vehicle car = new Car("Ford", "Mustang", 2019, 240, 4); // creates a vehicle called "car" and sets the properties
                Vehicle motorcycle = new Motorcycle("Kawasaki", "Ninja 400", 2022, 135, false); // creates a vehicle called "motorcycle and sets the properties

                car.DisplayInfo(); // displays the cars info
                motorcycle.DisplayInfo(); // displays the motorcycles info

                Console.ReadKey();
            }
        }
    }


