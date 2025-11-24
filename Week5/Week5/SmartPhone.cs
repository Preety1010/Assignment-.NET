using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    public class Smartphone : ElectronicDevice
    {
        public Smartphone(string brand, double price)
            : base(brand, price)
        {
        }

        // Extra method
        public void EnableCamera()
        {
            Console.WriteLine("Smartphone camera is now enabled.");
        }

        // Override ShowInfo()
        public override void ShowInfo()
        {
            Console.WriteLine($"Smartphone Info -> Brand: {Brand}, Price: ${Price}");
        }
    }
}
