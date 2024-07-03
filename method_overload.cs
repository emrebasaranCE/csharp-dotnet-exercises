using System;

namespace Method_overload_namespace
{
    class Test2
    {
        public static void not_main()
        {
            Example.print_out("hello world");
            Example.print_out("hello world", "this is me");
            Example.print_out(43242);           

        }
    }

    class Example
    {
        public static void print_out(string info)
        {
            System.Console.WriteLine(info);
        }
        public static void print_out(string info1, string info2)
        {
            System.Console.WriteLine(info1 + " " + info2);
        }
        public static void print_out(int info1)
        {
            System.Console.WriteLine(info1);
        }
    }
}