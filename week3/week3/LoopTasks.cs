using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    
    
        public class LoopTasks
        {
            // Sum 1 to N using for loop
            public void SumToN()
            {
                Console.Write("Enter number N: ");
                string input = Console.ReadLine();
                int n;

                if (!int.TryParse(input, out n))
                {
                    Console.WriteLine("Invalid number.");
                    return;
                }

                int sum = 0;

                for (int i = 1; i <= n; i++)
                {
                    sum += i;
                }

                Console.WriteLine("Sum = " + sum);
            }

            // While loop 1-20
            public void WhileLoopPrint()
            {
                int i = 1;

                while (i <= 20)
                {
                    if (i == 15)
                    {
                        Console.WriteLine("Stopping at 15.");
                        break;
                    }

                    if (i % 4 == 0)
                    {
                        i++;
                        continue;
                    }

                    Console.Write(i + " ");
                    i++;
                }

                Console.WriteLine();
            }

            // Foreach loop to sum array
            public void SumArray()
            {
                int[] numbers = { 3, 5, 7, 10, 12 };
                int total = 0;

                foreach (int x in numbers)
                {
                    total += x;
                }

                Console.WriteLine("Array Total = " + total);
            }
        }
    }
