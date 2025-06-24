using System;

namespace Arrays_namespace
{
    class Test2
    {
        public static void not_main()
        {
            string[] Colours = new string[5];

            Colours[0] = "Red";
            Colours[1] = "Blue";
            Colours[2] = "Green";
            Colours[3] = "Yellow";
            Colours[4] = "White";

            foreach (string each_colour in Colours)
            {
                System.Console.WriteLine(each_colour);
            }

            System.Console.WriteLine("Please enter a string");
            string input_string = Console.ReadLine();
            System.Console.WriteLine($"User entered: {input_string}");

            System.Console.WriteLine("Your input as reversed: ");
            for (int i = input_string.Length; i > 0; i--)
            {
                System.Console.Write(input_string[i - 1]);
            }
        }
    }
}