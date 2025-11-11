using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    public class ExceptionTasks
    {
        // Try-catch for converting number
        public void ConvertNumber()
        {
            try
            {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();
                int number = int.Parse(input);

                Console.WriteLine("You entered: " + number);
            }
            catch
            {
                Console.WriteLine("Invalid number format.");
            }
            finally
            {
                Console.WriteLine("Program Executed");
            }
        }

        // Throw exception for password check
        public void PasswordCheck()
        {
            Console.Write("Enter a password: ");
            string pwd = Console.ReadLine();

            try
            {
                if (pwd.Length < 6)
                {
                    throw new Exception("Password must be at least 6 characters.");
                }

                Console.WriteLine("Password is good.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
