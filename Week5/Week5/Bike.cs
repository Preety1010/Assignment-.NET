using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    public class AbstractBike
    {
       
            // Implement abstract methods
            public virtual void StartEngine()
            {
                Console.WriteLine("Bike engine started.");
            }
        public virtual void StopEngine()
        {
            Console.WriteLine("Bike engine stopped.");
        }
        public void Display()
        {
            Console.WriteLine("This is a vehicle");
        }
    }
}
