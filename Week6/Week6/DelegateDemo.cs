using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6
{
    internal class DelegateDemo
    {
        // Part 1: delegate that accepts two ints and returns an int
        public delegate int Calculate(int a, int b);

        // Part 2: delegate that accepts a double (price) and returns a double (discounted price)
        public delegate double DiscountStrategy(double price);
    }
}
