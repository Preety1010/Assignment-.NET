using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    public class AbstractCar
    {
        // Implement abstract methods
        public virtual void StartEngine()
        {
            Console.WriteLine("Car engine started.");
        }

        public virtual void StopEngine()
        {
            Console.WriteLine("Car engine stopped.");
        }
        public void Display()
        {
            Console.WriteLine("This is a vehicle");
        }
    }
}
