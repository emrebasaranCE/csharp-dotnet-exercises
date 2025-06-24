using System;

namespace Enum_namespace
{
    class Test2
    {
        public static void not_main()
        {
            Console.WriteLine(days_of_the_weekend.Friday);

            // Numeric value
            Console.WriteLine((int)days_of_the_weekend.Friday);

            Console.WriteLine((int)days_of_the_weekend.Sunday);

        }


        enum days_of_the_weekend
        {
            
            // index starts from "0"
            Monday, 
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday = 25, 
            Sunday
        }
    }
}