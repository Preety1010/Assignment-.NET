using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    public class oddevenfinder
    {
        public string FindOddEven(int number)
        {
            return (number % 2 == 0) ? $"The Number {number} is Even" : $"The Number {number} is Odd";
        }
    }
}
