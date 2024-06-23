using System;

namespace Switch_case_namespace
{
    class Test2
    {
        public static void not_main()
        {
            try
            {
                System.Console.WriteLine("Please enter a number");
                int input_number1 = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine($"User entered: {input_number1}");

                input_number1 = input_number1 % 2;
                switch (input_number1)
                {
                    case 0:
                        System.Console.WriteLine("Your number is even!");
                        break;
                    case 1:
                        System.Console.WriteLine("Your number is odd.");
                        break;
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine($"Something wrong happened: {ex.Message}");
            }


        }
    }
}