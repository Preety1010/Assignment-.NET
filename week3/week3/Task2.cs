using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
   public class Task2
    {
        public void PerformNullChecks()
        {
            //username null
            string username = null;
            //Ternary check
            Console.WriteLine(username == null? "username is not avilable" : username);

            //Null colescing assignment
            Console.WriteLine(username ?? "username is not avaliable");

            //null coalescing assignment
            username ??= "guest_user";

            Console.WriteLine("After ??= :" + username);
        }
    }
}
