using System;

namespace Extensions_and_Recursive_Namespace
{
    class Test2
    {
        public static void not_main()
        {
            int test_int1 = 123;
            int test_int2 = 120;

            System.Console.WriteLine($"Is {test_int1} is even number: " + test_int1.IsEventNumber());
            System.Console.WriteLine($"Is {test_int2} is even number: " + test_int2.IsEventNumber());

            Example.FibonacciSerisi(10);
        }
    }

    public static class Example
    {
        public static bool IsEventNumber(this int value) {
        if(value%2==0)
            return true;
        else
            return false;
        }
        public static int FibonacciSerisi(int sayi)
        {  
            if (sayi==0)
                return 0;
            else if (sayi==1)
                return 1;
            else
            {
                return FibonacciSerisi(sayi-1) + FibonacciSerisi(sayi-2);
            }
        }
    }
}