using System;

namespace Methods_namespace
{
    class Test2
    {
        public static void not_main()
        {

            System.Console.WriteLine("Basic sum:");
            System.Console.WriteLine(Example.basic_sum(5, 65));

            int output = 40;
            System.Console.WriteLine("Sum with ref for output;");
            System.Console.WriteLine($"Output before sum: {output}");
            System.Console.WriteLine(Example.sum(5, 65, ref output));
            System.Console.WriteLine($"Output after the sum: {output}");

        }
    }

    class Example
    {
        public static int basic_sum(int a, int b)
        {
            return a + b;
        }
        public static int sum(int a, int b, ref int output)
        {
            output = a + b;
            return a + b;
        }
    }
}