using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    public class AgeChecker
    {
        public void CheckAge()
        {
            Console.Write("Enter your age: ");
            string ageInput = Console.ReadLine();

            int age;

            if (!int.TryParse(ageInput, out age))
            {
                Console.WriteLine("Invalid age.");
                return;
            }

            if (age < 13)
            {
                Console.WriteLine("Child");
            }
            else if (age < 20)
            {
                Console.WriteLine("Teenager");
            }
            else if (age < 60)
            {
                Console.WriteLine("Adult");
            }
            else
            {
                Console.WriteLine("Senior");
            }
        }
    }
}
