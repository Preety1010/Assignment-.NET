using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
     public  class Teacher
    {
        public string Name { get; set; }

        // Method that can be overridden
        public virtual void Teaching()
        {
            Console.WriteLine("Teacher teaches in English");
        }

        // Method that cannot be overridden
        public void SalaryInfo()
        {
            Console.WriteLine("Teacher salary is confidential.");
        }
    }

    
    
}

