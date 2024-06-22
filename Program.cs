using System;

namespace Program
{
    class Test
    {
        static void Main(string[] args)
        {
            string this_is_string = "Hello world";
            System.Console.WriteLine($"this_is_string: {this_is_string}");

            byte a = 15;
            System.Console.WriteLine($"a: {a}");

            sbyte aa = -12;
            System.Console.WriteLine($"a: {aa}");
        }
    }
}