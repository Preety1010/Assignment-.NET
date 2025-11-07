using System;
using System.Collections.Generic;

namespace Week2Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Task 1: Variables and String Interpolation ===");
            Task1_Variables();
            Console.WriteLine();

            Console.WriteLine("=== Task 2: Constants ===");
            Task2_Constants();
            Console.WriteLine();

            Console.WriteLine("=== Task 3: Data Types and Type Conversion ===");
            Task3_DataTypes();
            Console.WriteLine();

            Console.WriteLine("=== Task 4: Arrays and Array Methods ===");
            Task4_Arrays();
            Console.WriteLine();

            Console.WriteLine("=== Task 5: DateTime and TimeSpan ===");
            Task5_DateTime();
            Console.WriteLine();

            Console.WriteLine("=== Task 6: Generic Collections (List & Dictionary) ===");
            Task6_Collections();
            Console.WriteLine();
        }

        // ---------------- Task 1 ----------------
        static void Task1_Variables()
        {
            string userName = "Preety";
            int luckyNumber = 7;
            Console.WriteLine($"Hello, {userName}! Your lucky number is {luckyNumber}.");
        }

        // ---------------- Task 2 ----------------
        static void Task2_Constants()
        {
            Circle circle = new Circle(5);
            Console.WriteLine($"Radius: {circle.Radius}");
            Console.WriteLine($"Area: {circle.Area()}");
            Console.WriteLine($"Perimeter: {circle.Perimeter()}");

            
        }

        class Circle
        {
            public const double PI = 3.14;
            public double Radius { get; set; }

            public Circle(double radius)
            {
                Radius = radius;
            }

            public double Area()
            {
                return PI * Radius * Radius;
            }

            public double Perimeter()
            {
                return 2 * PI * Radius;
            }
        }

        // ---------------- Task 3 ----------------
        static void Task3_DataTypes()
        {
            byte b = 10;
            short s = 200;
            int i = 5000;
            long l = 100000L;
            float f = 3.14f;
            double d = 9.81;
            decimal dec = 19.99m;
            char c = 'A';
            bool isStudent = true;

            int number = 42;
            string numberAsString = number.ToString();
            string stringPi = "3.14";
            double piAsDouble = Convert.ToDouble(stringPi);

            Console.WriteLine($"byte: {b}");
            Console.WriteLine($"short: {s}");
            Console.WriteLine($"int: {i}");
            Console.WriteLine($"long: {l}");
            Console.WriteLine($"float: {f}");
            Console.WriteLine($"double: {d}");
            Console.WriteLine($"decimal: {dec}");
            Console.WriteLine($"char: {c}");
            Console.WriteLine($"bool: {isStudent}");
            Console.WriteLine($"Converted int to string: {numberAsString}");
            Console.WriteLine($"Converted string to double: {piAsDouble}");
        }

        // ---------------- Task 4 ----------------
        static void Task4_Arrays()
        {
            int[] numbers = { 25, 7, 19, 42, 3 };

            Console.WriteLine("Original Array:");
            foreach (int n in numbers) Console.Write(n + " ");
            Console.WriteLine();

            Array.Sort(numbers);
            Console.WriteLine("Sorted Array:");
            foreach (int n in numbers) Console.Write(n + " ");
            Console.WriteLine();

            Array.Reverse(numbers);
            Console.WriteLine("Reversed Array:");
            foreach (int n in numbers) Console.Write(n + " ");
            Console.WriteLine();

            int search = 19;
            int index = Array.IndexOf(numbers, search);
            Console.WriteLine($"Index of {search}: {index}");
        }

        // ---------------- Task 5 ----------------
        static void Task5_DateTime()
        {
            DateTime birthDate = new DateTime(2003, 5, 20);
            DateTime currentDate = DateTime.Now;

            TimeSpan ageSpan = currentDate - birthDate;
            int ageInYears = (int)(ageSpan.Days / 365.25);

            Console.WriteLine($"Birthdate: {birthDate.ToShortDateString()}");
            Console.WriteLine($"Current Date: {currentDate.ToShortDateString()}");
            Console.WriteLine($"Age: {ageInYears} years");

            DateTime futureDate = birthDate.AddDays(10);
            Console.WriteLine($"Birthdate + 10 days: {futureDate.ToShortDateString()}");
        }

        // ---------------- Task 6 ----------------
        static void Task6_Collections()
        {
            List<string> fruits = new List<string> { "Apple", "Banana", "Mango" };
            fruits.Add("Orange");
            fruits.Remove("Banana");

            Console.WriteLine("Fruits List:");
            foreach (var fruit in fruits)
                Console.WriteLine(fruit);

            Dictionary<int, string> fruitDict = new Dictionary<int, string>
            {
                { 1, "Apple" },
                { 2, "Mango" },
                { 3, "Orange" }
            };

            fruitDict.Add(4, "Grapes");

            Console.WriteLine("Fruit Dictionary:");
            foreach (var kv in fruitDict)
                Console.WriteLine($"Key: {kv.Key}, Value: {kv.Value}");
        }
    }
}
