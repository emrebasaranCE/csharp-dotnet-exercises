using System;

namespace Program
{
    class Test
    {
        static void Main(string[] args)
        {
            try
            {
                string hello = "1";
                int int1 = 1;

                double int2 = int1;
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