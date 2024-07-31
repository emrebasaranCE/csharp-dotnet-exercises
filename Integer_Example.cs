using System;

namespace Integer_Example_ns
{
    class Program
    {
       public static void not_main()
        {
            Console.WriteLine("Enter a string: ");
            string input_string = Console.ReadLine();

            string[] strings = input_string.Split(' ');
            int[] numbers = new int[strings.Length];

            if (strings.Length % 2 != 0)
            {
                Console.WriteLine("Please enter an even number of integers.");
                return;
            }
            
            int counter = 0;
            foreach (string str in strings)
            {
                if (int.TryParse(str, out int number))
                {
                    numbers[counter] = number;
                    counter++;
                }
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (numbers[i] != numbers[i + 1])
                    {
                        Console.Write(numbers[i] + numbers[i + 1]);
                    }
                    else
                    {
                        Console.Write(Math.Pow(numbers[i] + numbers[i + 1], 2));
                    }
                    Console.Write(" "); 
                }
            }
        }
    }
}
