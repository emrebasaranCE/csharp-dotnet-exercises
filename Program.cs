using System;

namespace Program
{
    class Test
    {
        static void Main(string[] args)
        {
            byte a = 15; // 1 byte
            System.Console.WriteLine($"a: {a}");

            // signed byte
            sbyte aa = -12; // 1 byte
            System.Console.WriteLine($"a: {aa}");
        
            Int16 i16 = 23;
            int i = 253;  
            Int32 i32 = 321;
            System.Console.WriteLine($"i16: {i16}\ni: {i}\ni32: {i32}");

            float f = 2;

            long long1 = 45;

            double d = 2.4;

            decimal de = 15;

            char c = 'h';

            string str = "Hello world";


            System.Console.WriteLine($"f: {f}\nlong1: {long1}\nd:{d}\nde:{de}\nc:{c}\nstr:{str}");


            DateTime dt = DateTime.Now;

            object object1 = "z";

            System.Console.WriteLine($"dt: {dt}\nobject1: {object1}");

            string str12 = string.Empty;

            str12 = "Yur mum";

            int number1 = 25;
            string number2 = "30";

            // converting 
            int number3 = number1 + Convert.ToInt32(number2);

            System.Console.WriteLine(number3);

            string datetime_string = DateTime.Now.ToString("dd.MM.yyyy - hh:mm:ss");

            System.Console.WriteLine(datetime_string);





        }
    }
}