using System.Numerics;

namespace Week4
{
    class Program
    {
        static void Main()
        {
            // Create first Student object
            Student s1 = new Student();
            s1.name = "Khilendra Chaudhary";
            s1.age = 20;
            s1.course = "Computer Science";

            // Create second Student object
            Student s2 = new Student();
            s2.name = "Preety sapkota";
            s2.age = 22;
            s2.course = "Information Technology";

            // Display values of first student
            Console.WriteLine("Student 1 Details:");
            Console.WriteLine("Name: " + s1.name);
            Console.WriteLine("Age: " + s1.age);
            Console.WriteLine("Course: " + s1.course);
            Console.WriteLine();

            // Display values of second student
            Console.WriteLine("Student 2 Details:");
            Console.WriteLine("Name: " + s2.name);
            Console.WriteLine("Age: " + s2.age);
            Console.WriteLine("Course: " + s2.course);
            Console.WriteLine();

            // Display static field
            Console.WriteLine("School Name : " + Student.schoolName);

            //task2

            // Create object of Calculator
            Calculator calc = new Calculator();

            // Call PrintWelcome()
            calc.PrintWelcome();

            // Call Add method
            int sum = calc.Add(10, 20);

            // Call Multiply method
            int product1 = calc.Multiply(5, 4);  // Both parameters
            int product2 = calc.Multiply(7);     // Uses default value 1

            // Print results
            Console.WriteLine("Addition: " + sum);
            Console.WriteLine("Multiplication (5 * 4): " + product1);
            Console.WriteLine("Multiplication (7 * default 1): " + product2);

            //Task3

            // Create object
            ParameterDemo demo = new ParameterDemo();

            // 1. Calling Increase(ref int)
            int value = 20;
            demo.Increase(ref value);
            Console.WriteLine("Value after Increase: " + value);

            // 2. Calling GetFullName(out string)
            string myName;
            demo.GetFullName(out myName);
            Console.WriteLine("Full Name: " + myName);

            // 3. Calling SumAll(params)
            int total = demo.SumAll(5, 10, 30, 20);
            Console.WriteLine("Sum of all numbers: " + total);

            //task4
            // Creating object with default constructor

            Player p1 = new Player();

            // Assigning values after object creation
            p1.playerName = "Default Player";
            p1.level = 1;
            p1.health = 100;

            // Creating object with parameterized constructor
            Player p2 = new Player("KnightAxe", 5, 200);

            // Printing field values of p1
            Console.WriteLine("\n--- Player 1 (Default Constructor) ---");
            Console.WriteLine("Name: " + p1.playerName);
            Console.WriteLine("Level: " + p1.level);
            Console.WriteLine("Health: " + p1.health);

            // Printing field values of p2
            Console.WriteLine("\n--- Player 2 (Parameterized Constructor) ---");
            Console.WriteLine("Name: " + p2.playerName);
            Console.WriteLine("Level: " + p2.level);
            Console.WriteLine("Health: " + p2.health);

            //Task 5
            // PART 1 : Enum + Day-Type Identification


            Console.Write("Enter a day (Example: Sunday): ");
            string inputDay = Console.ReadLine().Trim().ToLower();

            DayType type;

            // Determine Weekend or Weekday
            if (inputDay == "friday" || inputDay == "saturday")
            {
                type = DayType.Weekend;
            }
            else
            {
                type = DayType.Weekday;
            }

            Console.WriteLine("It is: " + type);


            // PART 2 : Record + with Expression

            // Create first book object
            Book book1 = new Book("C# Fundamentals", "John Doe", 29.99);

            // Create second book using with-expression
            Book book2 = book1 with { title = "Advanced C#", price = 39.99 };

            // Print first object (book1)
            Console.WriteLine("\n--- First Book ---");
            Console.WriteLine(book1);

            // Deconstruct second object (book2)
            var (t, a, p) = book2;

            Console.WriteLine("\n--- Deconstructed Second Book ---");
            Console.WriteLine("Title: " + t);
            Console.WriteLine("Author: " + a);
            Console.WriteLine("Price: " + p);

            //task6
            Console.Write("Enter marks: ");
            string marksInput = Console.ReadLine();
            Console.Write("Enter total: ");
            string totalInput = Console.ReadLine();
            int marks, totals;
            if (!int.TryParse(marksInput, out marks) || !int.TryParse(totalInput, out totals))
            {
                Console.WriteLine("Invalid input!");
                return;
            }
            if (totals == 0)
            {
                Console.WriteLine("Total cannot be zero!");
                return;
            }
            double percentage = (double)marks / totals * 100;
            Console.WriteLine($"Percentage: {percentage}%");
        }



        //Task 5
       
        //record book
        public record Book(string title, string author, double price);

        
    

    }
}

