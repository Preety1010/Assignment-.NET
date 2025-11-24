using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    public class Printer
    {
        public void Print(string message)
        {
            Console.WriteLine($"Message: {message}");
        }

        // Method to print an integer number
        public void Print(int number)
        {
            Console.WriteLine($"Number: {number}");
        }

        // Method to print a string message multiple times
        public void Print(string message, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i + 1}: {message}");
            }
        }
    }
}
