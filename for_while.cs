using System;

namespace For_while_namespace
{
    class Test2
    {
        public static void not_main()
        {
            // fibonacci with for

            int number1 = 1;
            int number2 = 1;
            System.Console.WriteLine(number1);
            System.Console.WriteLine(number2);
            for(int i = 0; i < 15; i++)
            {
                System.Console.WriteLine(number1 + number2);
                int temp = number2;
                number2 = number1 + number2;
                number1 = temp;
            }
        }
    }
}