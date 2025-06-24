using System;

namespace If_else_namepace
{
    class Test2
    {
        public static void not_main()
        {
            int number1 = 100;
            int number2 = 150;

            if (number1 > number2)
            {
                System.Console.WriteLine($"number1 is bigger than number2 => {number1} > {number2}");
            }
            else
            {
                System.Console.WriteLine($"number2 is bigger than number1 => {number2} > {number1}");
            }

            string str_1 = "Hello world";
            string str_2 = "Hello world 2";

            System.Console.WriteLine($"There is 2 different string, which one is longer ? ");
            if (str_1.Length > str_2.Length)
            {
                System.Console.WriteLine($"{str_1} is longer than {str_2}");
            }
            else
            {
                System.Console.WriteLine($"'{str_2}' is longer than '{str_1}'");
            }
        }
    }

}