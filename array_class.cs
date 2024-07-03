using System;

namespace Arrays_class_namespace
{
    class Test2
    {
        public static void not_main()
        {
            int[] numberArray = {12,32,5,6,876,43,231};

            System.Console.WriteLine("Unsorted array: ");
            foreach (int current_int in numberArray)
            {
                System.Console.Write(current_int + " ");
            }

            System.Console.WriteLine("\nSorted array: ");
            Array.Sort(numberArray);

            foreach (int current_int in numberArray)
            {
                System.Console.Write(current_int + " ");
            }

            System.Console.WriteLine("\n---- Array clear ----");
            Array.Clear(numberArray, 2, 2);

            foreach (int current_int in numberArray)
            {
                System.Console.Write(current_int + " ");
            }

            System.Console.WriteLine("\n---- Array Reverse ----");
            Array.Reverse(numberArray);

            foreach (int current_int in numberArray)
            {
                System.Console.Write(current_int + " ");
            }

            System.Console.WriteLine("\n---- Array IndexOf ----");

            System.Console.WriteLine(Array.IndexOf(numberArray, 231));

            System.Console.WriteLine("\n---- Array Resize ----");
            Array.Resize<int>(ref numberArray, 10);

            foreach (int current_int in numberArray)
            {
                System.Console.Write(current_int + " ");
            }
        }
    }
}