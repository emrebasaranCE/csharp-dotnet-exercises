using System;

namespace Try_catch_namespace
{
    class Test2
    {
        public static void not_main()
        {
            try
            {
                System.Console.WriteLine("Please enter a number: ");
                int input_number1 = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine($"User entered: {input_number1}");
            }
            catch(Exception ex)
            {
                System.Console.WriteLine($"Something wrong happened: {ex.Message}");
            }
            finally
            {
                System.Console.WriteLine("Process finished.");
            }
        }
    }
}