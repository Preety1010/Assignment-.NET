using static Week6.DelegateDemo;

namespace Week6
{
    public delegate double DiscountStrategy(double price);
    internal class Program
    {
        public static int Add(int a, int b) => a + b;
        public static int Subtract(int a, int b) => a - b;

        // Methods matching DiscountStrategy delegate
        //public static double FestivalDiscount(double price) => price * 0.80;   // 20% off
        //public static double SeasonalDiscount(double price) => price * 0.90;   // 10% off
        //public static double NoDiscount(double price) => price;

        // Discount methods
        public static double FestivalDiscount(double price)
        {
            return price * 0.80;   // 20% off
        }

        public static double SeasonalDiscount(double price)
        {
            return price * 0.90;   // 10% off
        }

        public static double NoDiscount(double price)
        {
            return price;          // No discount
        }

        public static double CalculateFinalPrice(double originalPrice, DiscountStrategy strategy)
       => strategy(originalPrice);


        //task3
        static void ProcessNumbers(int[] numbers, Func<int, bool> condition)
        {
            foreach (int num in numbers)
            {
                if (condition(num))
                {
                    Console.WriteLine(num);
                }
            }
        }
        static void Main(string[] args)
        {
            {
                // Create a rectangle object
                var rect = new Rectangle(10, 5);

                // Print results
                Console.WriteLine($"Length: {rect.Length}");
                Console.WriteLine($"Width: {rect.Width}");
                Console.WriteLine($"Area: {rect.GetArea()}");
                Console.WriteLine($"Perimeter: {rect.GetPerimeter()}");

                //task two
                Calculate addDelegate = Add;
                Calculate subDelegate = Subtract;

                int x = 10, y = 5;
                Console.WriteLine($"Add({x}, {y}) = {addDelegate(x, y)}");        // 15
                Console.WriteLine($"Subtract({x}, {y}) = {subDelegate(x, y)}");  // 5

                // You can also combine or reassign delegates:
                Calculate calc = Add;
                Console.WriteLine($"Calc as Add: {calc(7, 3)}"); // 10
                calc = Subtract;
                Console.WriteLine($"Calc as Subtract: {calc(7, 3)}"); // 4

                //// --- Using DiscountStrategy delegate ---
                //DiscountStrategy festival = FestivalDiscount;
                //DiscountStrategy seasonal = SeasonalDiscount;
                //DiscountStrategy none = NoDiscount;

                //double price = 1000.0;
                //Console.WriteLine("\n--- Discounts ---");
                //Console.WriteLine($"Original: {price}");
                //Console.WriteLine($"Festival (20% off): {festival(price)}");
                //Console.WriteLine($"Seasonal (10% off): {seasonal(price)}");
                //Console.WriteLine($"No discount: {none(price)}");

                //task3
                double original = 1000;

                Console.WriteLine("Original Price = " + original);

                // 2.2 Calling CalculateFinalPrice with each strategy
                double festival = CalculateFinalPrice(original, FestivalDiscount);
                Console.WriteLine("Festival Discount (20%) = " + festival);

                double seasonal = CalculateFinalPrice(original, SeasonalDiscount);
                Console.WriteLine("Seasonal Discount (10%) = " + seasonal);

                double none = CalculateFinalPrice(original, NoDiscount);
                Console.WriteLine("No Discount = " + none);

                // 2.3 Calling CalculateFinalPrice with a lambda expression (30% discount)
                double lambda30 = CalculateFinalPrice(original, p => p * 0.70);
                Console.WriteLine("Lambda Discount (30%) = " + lambda30);

                //task3

                int[] nums = { 2, 5, 12, 7, 18, 9, 20 };

                Console.WriteLine("Even Numbers:");
                ProcessNumbers(nums, n => n % 2 == 0);   // Lambda for even numbers

                Console.WriteLine("\nNumbers > 10:");
                ProcessNumbers(nums, n => n > 10);

                //task4
                List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

                var squaredNumbers = numbers.Select(n => n * n);

                Console.WriteLine("Squared Numbers:");
                foreach (var sq in squaredNumbers)
                {
                    Console.WriteLine(sq);
                }


                // -------------------------------------------
                // 2. Filtering (Where): Books > Rs. 1000
                // -------------------------------------------
                List<Book> books = new List<Book>
        {
            new Book { Title = "C# Programming", Price = 850 },
            new Book { Title = "AI & Machine Learning", Price = 1500 },
            new Book { Title = "Data Structures", Price = 1200 },
            new Book { Title = "Basic HTML", Price = 400 }
        };

                var premiumBooks = books.Where(b => b.Price > 1000);

                Console.WriteLine("\nPremium Books (Price > 1000):");
                foreach (var book in premiumBooks)
                {
                    Console.WriteLine($"{book.Title} - Rs. {book.Price}");
                }


                // -------------------------------------------
                // 3. Sorting (OrderBy): Students alphabetically
                // -------------------------------------------
                List<Student> students = new List<Student>
        {
            new Student { Name = "Saurav" },
            new Student { Name = "Anisha" },
            new Student { Name = "Kamal" },
            new Student { Name = "Priya" },
            new Student { Name = "Bibek" },
            new Student { Name = "Yogesh" },
            new Student { Name = "Sameer" },
            new Student { Name = "Utsav" },
            new Student { Name = "Laxmi" },
            new Student { Name = "Manish" }
        };

                var sortedStudents = students.OrderBy(s => s.Name);

                Console.WriteLine("\nStudents Sorted Alphabetically:");
                foreach (var student in sortedStudents)
                {
                    Console.WriteLine(student.Name);
                }

                //task 5
                List<CashierSales> salesList = new List<CashierSales>
        {
            new CashierSales { CashierName = "Ram", SalesAmount = 5000 },
            new CashierSales { CashierName = "Sita", SalesAmount = 7200 },
            new CashierSales { CashierName = "Hari", SalesAmount = 3300 },
            new CashierSales { CashierName = "Gita", SalesAmount = 4100 }
        };

                int totalCashiers = salesList.Count();
                double totalSales = salesList.Sum(s => s.SalesAmount);
                double highestSale = salesList.Max(s => s.SalesAmount);
                double lowestSale = salesList.Min(s => s.SalesAmount);
                double averageSale = salesList.Average(s => s.SalesAmount);

                Console.WriteLine("=== Aggregation Results ===");
                Console.WriteLine($"Total Cashiers: {totalCashiers}");
                Console.WriteLine($"Total Sales: {totalSales}");
                Console.WriteLine($"Highest Sale: {highestSale}");
                Console.WriteLine($"Lowest Sale: {lowestSale}");
                Console.WriteLine($"Average Sale: {averageSale}");


                // ---------------------------------------------------
                // 2. Quantifier Operators (Any / All)
                // ---------------------------------------------------
                List<Applicant> applicants = new List<Applicant>
        {
            new Applicant { Name = "Rohan", Age = 19 },
            new Applicant { Name = "Mina", Age = 17 },
            new Applicant { Name = "Bikash", Age = 22 },
            new Applicant { Name = "Anita", Age = 16 }
        };

                bool anyUnder18 = applicants.Any(a => a.Age < 18);
                bool allAbove16 = applicants.All(a => a.Age > 16);

                Console.WriteLine("\n=== Applicant Age Check ===");
                Console.WriteLine($"Any applicant under 18? {anyUnder18}");
                Console.WriteLine($"Are all applicants above 16? {allAbove16}");


                // ---------------------------------------------------
                // 3. Element Operators (First, Last, FirstOrDefault)
                // ---------------------------------------------------
                List<Song> songs = new List<Song>
        {
            new Song { Title = "Song A", DurationSeconds = 150 }, // 2.5 min
            new Song { Title = "Song B", DurationSeconds = 240 }, // 4 min
            new Song { Title = "Song C", DurationSeconds = 300 }, // 5 min
            new Song { Title = "Song D", DurationSeconds = 180 }  // 3 min
        };

                var firstSong = songs.First();
                var lastSong = songs.Last();
                var firstLongerThan4Min = songs.First(s => s.DurationSeconds > 240);
                var firstLongerThan10Min = songs.FirstOrDefault(s => s.DurationSeconds > 600);

                Console.WriteLine("\n=== Element Operator Results ===");
                Console.WriteLine($"First Song: {firstSong.Title}");
                Console.WriteLine($"Last Song: {lastSong.Title}");
                Console.WriteLine($"First Song > 4 minutes: {firstLongerThan4Min.Title}");
                Console.WriteLine($"First Song > 10 minutes (safe): {(firstLongerThan10Min?.Title ?? "None Found")}");

                //task6
                List<TourBooking> bookings = new List<TourBooking>
        {
            new TourBooking { CustomerName = "Ramesh", Destination = "Pokhara", Price = 8000, DurationInDay = 3, IsInternational = false },
            new TourBooking { CustomerName = "Sita", Destination = "Kathmandu", Price = 12000, DurationInDay = 5, IsInternational = false },
            new TourBooking { CustomerName = "John", Destination = "Paris", Price = 25000, DurationInDay = 7, IsInternational = true },
            new TourBooking { CustomerName = "Anita", Destination = "Chitwan", Price = 9000, DurationInDay = 4, IsInternational = false },
            new TourBooking { CustomerName = "Raj", Destination = "Dubai", Price = 15000, DurationInDay = 6, IsInternational = true }
        };

                //// -----------------------------
                //// Filter: Tours above Rs. 10,000
                //// -----------------------------
                //var expensiveTours = bookings.Where(b => b.Price > 10000);

                //Console.WriteLine("Tours Above Rs. 10,000:");
                //foreach (var tour in expensiveTours)
                //{
                //    Console.WriteLine($"{tour.CustomerName} -> {tour.Destination}, Price: {tour.Price}, Duration: {tour.DurationInDay} days");
                //}

                //// -----------------------------
                //// Filter: Tours longer than 4 days
                //// -----------------------------
                //var longTours = bookings.Where(b => b.DurationInDay > 4);

                //Console.WriteLine("\nTours Longer Than 4 Days:");
                //foreach (var tour in longTours)
                //{
                //    Console.WriteLine($"{tour.CustomerName} -> {tour.Destination}, Price: {tour.Price}, Duration: {tour.DurationInDay} days");
                //}

                // 1️⃣ Filter: Tours above Rs. 10,000 AND duration > 4 days
                var filteredTours = bookings
                    .Where(b => b.Price > 10000 && b.DurationInDay > 4);

                // 2️⃣ Transform (Project) into new list with Category
                var projectedTours = filteredTours
                    .Select(b => new
                    {
                        CustomerName = b.CustomerName,
                        Destination = b.Destination,
                        Category = b.IsInternational ? "International" : "Domestic",
                        Price = b.Price
                    });

                // 3️⃣ Sort: First by Category (Domestic first), then by Price
                var sortedTours = projectedTours
                    .OrderBy(t => t.Category)       // Domestic first, International next
                    .ThenBy(t => t.Price);          // Then by price ascending

                // 4️⃣ Display each element in a clean format
                Console.WriteLine("Filtered and Sorted Tour List:\n");
                foreach (var tour in sortedTours)
                {
                    Console.WriteLine($"Customer: {tour.CustomerName}");
                    Console.WriteLine($"Destination: {tour.Destination}");
                    Console.WriteLine($"Category: {tour.Category}");
                    Console.WriteLine($"Price: Rs. {tour.Price}");
                    Console.WriteLine(new string('-', 30));
                }
            }
        }
    }
}
    

    

