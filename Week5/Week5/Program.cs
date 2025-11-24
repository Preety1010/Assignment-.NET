namespace Week5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("ACC12345", 5000);

            // Display account number
            Console.WriteLine($"Account Number: {account.AccountNumber}");
            Console.WriteLine($"Initial Balance: {account.Balance:C}\n");

            // Deposit money
            account.Deposit(2000);

            // Withdraw money
            account.Withdraw(1500);

            // Print remaining balance
            Console.WriteLine($"\nRemaining Balance: {account.Balance:C}");
            //task2
            Car car = new Car()
            {
                Brand = "Toyota",
                Speed = 120,
                Seats = 5
            };

            // Create Motorcycle object
            Motorcycle bike = new Motorcycle()
            {
                Brand = "Honda",
                Speed = 90,
                HasCarrier = true
            };

            // Demonstrate code reusability
            Console.WriteLine("Car Details:");
            car.Start();
            car.DisplayInfo();
            car.Stop();

            Console.WriteLine("\nMotorcycle Details:");
            bike.Start();
            bike.DisplayInfo();
            bike.Stop();

            //task3
            Printer printer = new Printer();

            // Call overloaded methods
            printer.Print("Hello, World!");   // Print string
            printer.Print(123);               // Print integer
            printer.Print("Repeat this", 3);  // Print string multiple times

            //task3
            NepaliTeacher nepaliTeacher = new NepaliTeacher() { Name = "Sita" };
            EnglishTeacher englishTeacher = new EnglishTeacher() { Name = "John" };

            // Call methods for NepaliTeacher
            Console.WriteLine("NepaliTeacher:");
            nepaliTeacher.Teaching();
            nepaliTeacher.SalaryInfo();

            Console.WriteLine();

            // Call methods for EnglishTeacher
            Console.WriteLine("EnglishTeacher:");
            englishTeacher.Teaching();
            englishTeacher.SalaryInfo();


            //task5
            // Create objects of derived classes

            AbstractCar mycar = new AbstractCar();
            AbstractBike myBike = new AbstractBike();

            // Call methods using Car object
            Console.WriteLine("car:");
            mycar.Display();
            mycar.StartEngine();
            mycar.StopEngine();

            Console.WriteLine();

            // Call methods using Bike object
            Console.WriteLine("Bike:");
            myBike.Display();
            myBike.StartEngine();
            myBike.StopEngine();

            //task5

            Laptop laptop = new Laptop("Acer", 1500);

            // Call method
            laptop.ShowInfo();
            laptop.TurnOnBattery();

            Smartphone phone = new Smartphone("Iphone", 1200);
            phone.ShowInfo();
            phone.EnableCamera();

            ////
            //Laptop laptop1 = new Laptop("Dell", 1200);
            //Smartphone phone1 = new Smartphone("Samsung", 800);
            //Laptop laptop2 = new Laptop("HP", 1500);

            //// Create store
            //ElectronicsStore store = new ElectronicsStore();

            //// Add devices
            //store.AddDevice(laptop1);
            //store.AddDevice(phone1);
            //store.AddDevice(laptop2);

            //// Show all device details (calls ShowInfo and child-specific methods)
            //store.ShowAllDeviceDetails();

            //// Remove a device
            //store.RemoveDevice(phone1);

            //// Show updated list
            //store.ShowAllDeviceDetails();



            // 1. Create ElectronicsStore object
            ElectronicsStore store = new ElectronicsStore();

            // 2. Create Laptop and Smartphone objects
            Laptop laptop1 = new Laptop("Dell", 1200);
            Laptop laptop2 = new Laptop("HP", 1500);
            Smartphone phone1 = new Smartphone("Samsung", 800);
            Smartphone phone2 = new Smartphone("Apple", 1200);

            // 3. Add devices to the store
            store.AddDevice(laptop1);
            store.AddDevice(laptop2);
            store.AddDevice(phone1);
            store.AddDevice(phone2);

            // 4. Display all device info (calls ShowInfo and child-specific methods)
            store.ShowAllDeviceDetails();
        }
    }
}
    

