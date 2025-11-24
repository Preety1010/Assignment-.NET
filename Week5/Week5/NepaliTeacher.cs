using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    public class NepaliTeacher: Teacher
    {
        // Override Teaching method
        public override void Teaching()
        {
            Console.WriteLine("NepaliTeacher teaches in Nepali");
        }
    }
}
