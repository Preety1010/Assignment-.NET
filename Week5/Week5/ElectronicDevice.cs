using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    public abstract class ElectronicDevice
    {
        // Private fields
        private string brand;
        private double price;

        // Constructor
        public ElectronicDevice(string brand, double price)
        {
            Brand = brand;
            Price = price;
        }

        // Encapsulated Properties
        public string Brand
        {
            get { return brand; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Brand cannot be empty.");
                brand = value;
            }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Price must be greater than 0.");
                price = value;
            }
        }

        // Abstract Method
        public abstract void ShowInfo();
    }
}
    