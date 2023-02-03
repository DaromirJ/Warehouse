using System;

namespace Warehouse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to warehouse app!");
            Console.WriteLine("Please let me know what you want to do:");
            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. Remove Item");
            Console.WriteLine("3. Chck Item");
            Console.WriteLine("Press 1, 2 or 3");

            string choice = Console.ReadLine();

            Console.WriteLine($"You have chosen option number: {choice}");
        }
    }
}