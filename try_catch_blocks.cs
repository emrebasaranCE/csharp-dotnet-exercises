using System;

namespace Program
{
    class Test2
    {
        static void Main(string[] args)
        {
            try
            {
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