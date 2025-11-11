namespace week3
{
    internal class Program
    {
        // Creating objects
        
        static void Main(string[] args)
        {
            Task2 task2 = new Task2();
            calculator calculator = new calculator();
            oddevenfinder oddevenfinder = new oddevenfinder();
            Console.WriteLine("Addition:" + calculator.Add(5, 2));
            Console.WriteLine("subtraction:" + calculator.Subtract(5, 2));
            Console.WriteLine("Multiply:" + calculator.Multiply(5, 2));
            Console.WriteLine("Division:" + calculator.Divide(5, 2));
            Console.WriteLine(oddevenfinder.FindOddEven(5));
            Console.WriteLine("\n=== task2 ===");
            task2.PerformNullChecks();
            Operators op = new Operators();

            AgeChecker age = new AgeChecker();
            DayOfWeekSwitch day = new DayOfWeekSwitch();
            LoopTasks loops = new LoopTasks();
            ExceptionTasks ex = new ExceptionTasks();

            Console.WriteLine("\n=== Task 3 ===");
            age.CheckAge();

            Console.WriteLine("\n=== Task 4 ===");
            day.PrintDay();

            Console.WriteLine("\n=== Task 5 ===");
            loops.SumToN();
            loops.WhileLoopPrint();
            loops.SumArray();

            Console.WriteLine("\n=== Task 6 ===");
            ex.ConvertNumber();
            ex.PasswordCheck();
        }

        //task two 
        //odd even finder
        
    
    //static void Main(string[] args)
    //{
    //    Addition();
    //    Subtraction();
    //    Multiply();
    //    Divide();

    //}
    //static void Addition()
    //{
    //    int P = 10;
    //    int R = 20;

    //    Console.WriteLine("The sum of two numbers is:" +(P + R));
    //}
    // static void Subtraction()
    //{
    //    int P = 10;
    //    int R = 20;

    //    Console.WriteLine("The differences  of two numbers is:" + (R - P));
    //}
    //static void Multiply()
    //{
    //    int P = 10;
    //    int R = 20;

    //    Console.WriteLine("The multiplication of two numbers is:" + (P * R));
    //}
    //static void Divide()
    //{
    //    int P = 10;
    //    int R = 20;

    //    Console.WriteLine("The divisible of two numbers is:" + (R / R));
    //}
}
}
