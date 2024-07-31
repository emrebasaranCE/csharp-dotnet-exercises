using System;

namespace String_example_ns
{
    class Program
    {
       public static void not_main()
        {
            Console.WriteLine("Enter a string: ");
            string input_string = Console.ReadLine();

            string[] strings = input_string.Split(' ');

            foreach (string s in strings)
            {
                int wanted_index = Convert.ToInt16(s.Split(',')[1]);

                string string_to_print = s.Split(',')[0];
                int counter = 0;
                foreach (char c in string_to_print)
                {
                    if (counter != wanted_index)
                    {
                        Console.Write(c);
                    }
                    counter++; 
                }
                Console.Write(" ");
            }
        }
    }
}
