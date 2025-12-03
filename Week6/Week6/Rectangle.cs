using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6
{
    public class Rectangle
    {
        // Expression-bodied properties
        public double Length { get; set; }
        public double Width { get; set; }

        // Constructor (optional expression-bodied)
        public Rectangle(double length, double width) =>
            (Length, Width) = (length, width);

        // Expression-bodied method for area
        public double GetArea() => Length * Width;

        // Added: Expression-bodied method for perimeter
        public double GetPerimeter() => 2 * (Length + Width);
    }

}
