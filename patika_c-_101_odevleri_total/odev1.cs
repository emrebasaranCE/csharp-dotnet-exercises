using System;

namespace Odev_1_namespace
{
    class Test2
    {
        public static void not_main()
        {
            int choice_from_user;
            System.Console.WriteLine("CHOICES:\n-1\n-2\n-3\n-4");
            System.Console.Write("Please enter your choice: ");
            choice_from_user = Convert.ToInt16(Console.ReadLine());
            switch(choice_from_user)
            {
                case 1:
                    // function for assignment 1
                    function_1();
                    break;
                case 2:
                    // function for assignment 2
                    function_2();
                    break;
                case 3:
                    // function for assignment 3
                    function_3();
                    break;
                case 4:
                    // function for assignment 4
                    function_4();
                    break;
                default:
                    System.Console.WriteLine("You entered something different, program is closing...");
                    Thread.Sleep(2000);
                    break;
            }
        }

        public static void function_1()
        {
            System.Console.Write("Please enter 1 positive integer: ");
            int n = Convert.ToInt16(Console.ReadLine());

            int[] integer_from_user = new int[n];
            for (int i = 0; i < n - 1; i++)
            {
                System.Console.Write($"{i + 1}. Please enter positive integer: ");
                integer_from_user[i] = Convert.ToInt16(Console.ReadLine());
            }
            System.Console.Write("Even numbers:");
            for (int i = 0; i < n; i++)
            {
                if (integer_from_user[i].IsEventNumber())
                    System.Console.Write(integer_from_user[i] + " ");
            }
        }

        public static void function_2()
        {
            System.Console.Write("Please enter 2 positive integer: ");
            int n = Convert.ToInt16(Console.ReadLine());
            int m = Convert.ToInt16(Console.ReadLine());

            int[] integer_from_user = new int[n];
            for (int i = 0; i < n; i++)
            {
                System.Console.Write($"{i + 1}. Please enter positive integer: ");
                integer_from_user[i] = Convert.ToInt16(Console.ReadLine());
            }

            System.Console.Write($"Numbers that divides fully by {m}: ");
            for (int i = 0; i < n; i++)
            {
                if (integer_from_user[i] % m == 0)
                    System.Console.Write(integer_from_user[i] + " ");
            }
        }
        public static void function_3()
        {
            System.Console.Write("Please enter 1 positive integer: ");
            int n = Convert.ToInt16(Console.ReadLine());

            string[] strings_from_user = new string[n];
            for (int i = 0; i < n; i++)
            {
                System.Console.Write($"{i + 1}. Please enter word: ");
                strings_from_user[i] = Console.ReadLine();
            }

            System.Console.Write($"Words that you wrote: ");
            for (int i = 0; i < n; i++)
            {
                System.Console.Write(strings_from_user[i] + " ");
            }
        }
        public static void function_4()
        {
            System.Console.Write("Please enter a sentence: ");
            string user_input_sentence = Console.ReadLine();

            string[] words = user_input_sentence.Split(' ');
            System.Console.WriteLine($"Total sum of letters: {words.Length}");

            System.Console.WriteLine($"Total sum of letters: {user_input_sentence.Length}");
        }
    }
    public static class MyExtensionClass 
    {
        public static bool IsEventNumber(this int value) 
        {
            if(value%2==0)
                return true;
            else
                return false;
        }
    }
}