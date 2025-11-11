using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    public class Operators
    {
        // This adds two numbers
        public void Add(int a, int b)
        {
            Console.WriteLine("Add: " + (a + b));
        }

        // This subtracts two numbers
        public void Subtract(int a, int b)
        {
            Console.WriteLine("Subtract: " + (a - b));
        }

        // This multiplies two numbers
        public void Multiply(int a, int b)
        {
            Console.WriteLine("Multiply: " + (a * b));
        }

        // This divides two numbers
        public void Divide(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("You cannot divide by zero.");
            }
            else
            {
                Console.WriteLine("Divide: " + (a / b));
            }
        }

        // Checks if number is odd or even using ternary operator
        public void OddEvenFinder(int number)
        {
            string result = (number % 2 == 0) ? "Even Number" : "Odd Number";
            Console.WriteLine(result);
        }
    }
}
