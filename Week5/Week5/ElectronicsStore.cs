using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    public class ElectronicsStore
    {
        // List to store ElectronicDevice objects
        private List<ElectronicDevice> devices;

        // Constructor
        public ElectronicsStore()
        {
            devices = new List<ElectronicDevice>();
        }

        // Add a device to the store
        public void AddDevice(ElectronicDevice device)
        {
            devices.Add(device);
            Console.WriteLine($"{device.Brand} added to the store.");
        }

        // Remove a device from the store
        public void RemoveDevice(ElectronicDevice device)
        {
            if (devices.Remove(device))
            {
                Console.WriteLine($"{device.Brand} removed from the store.");
            }
            else
            {
                Console.WriteLine($"{device.Brand} not found in the store.");
            }
        }

        // Show details of all devices
        public void ShowAllDeviceDetails()
        {
            Console.WriteLine("\n--- All Devices in Store ---");
            foreach (ElectronicDevice device in devices)
            {
                device.ShowInfo(); // Call abstract method

                // Downcast to call child-specific methods
                if (device is Laptop laptop)
                {
                    laptop.TurnOnBattery();
                }
                else if (device is Smartphone phone)
                {
                    phone.EnableCamera();
                }

                Console.WriteLine();
            }
        }
    }
}
