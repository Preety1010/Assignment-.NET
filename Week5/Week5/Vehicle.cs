using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    public class Vehicle
    {
        // Properties
        public string Brand { get; set; }
        public double Speed { get; set; }

        // Methods
        public void Start()
        {
            Console.WriteLine($"{Brand} is starting.");
        }

        public void Stop()
        {
            Console.WriteLine($"{Brand} has stopped.");
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Speed: {Speed} km/h");
        }
    }

    // Derived class Car
    public class Car : Vehicle
    {
        // Unique field
        public int Seats { get; set; }


        // Override DisplayInfo to include unique field
        public override void DisplayInfo()
        {
            base.DisplayInfo(); // Call base class method
            Console.WriteLine($"Seats: {Seats}");
        }
    }

    // Derived class Motorcycle
    public class Motorcycle : Vehicle
    {
        // Unique field
        public bool HasCarrier { get; set; }

        // Override DisplayInfo to include unique field
        public virtual void DisplayInfo()
        {
            base.DisplayInfo(); // Call base class method
            Console.WriteLine($"Has Carrier: {HasCarrier}");
        }
    }
}

