using System;
using System.Diagnostics.Metrics;

namespace Ters_Karakter_ns
{
    class Program
    {
       public static void not_main()
        {
            Console.WriteLine("Enter a string: ");
            string input_string = Console.ReadLine();

            string[] strings = input_string.Split(' ');

            foreach(string str in strings)
            {
                for (int i = 1; i < str.Length; i++)
                {

                    Console.Write(str[i]);
                }
                Console.Write(str[0]);
                Console.Write(" ");
            }
        }
    }
}


// Hello World This Is Me
