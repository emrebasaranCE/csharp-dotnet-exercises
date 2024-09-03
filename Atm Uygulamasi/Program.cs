using System;
using static System.DateTime;

namespace AtmApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ATM Application");
            Console.WriteLine("Enter your card");
            string card_id = Console.ReadLine();
            Console.WriteLine("Enter your pin");
            int customer_pin = Convert.ToInt32(Console.ReadLine());
        }
    }
}