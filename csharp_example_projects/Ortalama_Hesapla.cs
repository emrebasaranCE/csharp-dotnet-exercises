using System;

namespace Ortalama_Hesapla_ns
{
    class Test
    {
        public static void not_main()
        {

            Console.WriteLine("Enter a number: ");
            int input_from_user = Convert.ToInt32(Console.ReadLine());
             
            long sum_from_fibonacci = fibonacci(input_from_user);

            Console.WriteLine("Average sum of fibonacci numbers: " + sum_from_fibonacci / input_from_user);
            
        }

        public static long fibonacci(int number_of_cycle)
        {
            long total_sum = 0;
            int number1 = 1;
            int number2 = 1;

            
            for (int i = 1; i <= number_of_cycle; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine(number1);
                    total_sum += number1;
                    continue;
                }
                else if (i == 2)
                {
                    Console.WriteLine(number2);
                    total_sum += number2;
                    continue;
                }
                int number3 = number1 + number2;
                int temp = number2;
                number2 = number3;
                number1 = temp;
                total_sum += number3;
                Console.WriteLine(number3);
            }   
            return total_sum;
        }
    }
}