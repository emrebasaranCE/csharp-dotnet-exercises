using System;
using System.Collections;

namespace koleksiyonlar_soru_1_namespace
{
    class Test2
    {
        public static void not_main()
        {
            ArrayList input_array_list = new ArrayList();
            ArrayList prime_number_list = new ArrayList();
            ArrayList nonprime_number_list = new ArrayList();

            for (int i = 20; i > 0; i--)
            {
                input_array_list.Add(i);
            }
            Console.WriteLine($"input_array_list: ");
            foreach (int current_int in input_array_list)
            {
                Console.Write($"{current_int} ");

                if (current_int > 0)
                {
                    bool is_the_number_is_prime = true;
                    for (int k = 2; k < current_int; k++)
                    {
                        if (current_int % k == 0)
                        {
                            nonprime_number_list.Add(current_int);
                            is_the_number_is_prime = false;
                            break;
                        }
                    }
                    if (is_the_number_is_prime)
                    {
                        prime_number_list.Add(current_int);
                    }
                }
            }

            prime_number_list.Sort();
            int total_sum_prime = 0;
            Console.WriteLine($"\nprime_number_list: ");
            foreach (int current_int in prime_number_list)
            {
                Console.Write($"{current_int} ");
                total_sum_prime += current_int;
            }

            nonprime_number_list.Sort();
            int total_sum_nonprime = 0;
            Console.WriteLine($"\nnonprime_number_list: ");
            foreach (int current_int in nonprime_number_list)
            {
                Console.Write($"{current_int} ");
                total_sum_nonprime += current_int;
            }

            Console.WriteLine($"\nprime_number_list element count: {prime_number_list.Count}\nprime_number_list average: {total_sum_prime / prime_number_list.Count}");
            Console.WriteLine($"nonprime_number_list element count: {nonprime_number_list.Count}\nnonprime_number_list average: {total_sum_prime / nonprime_number_list.Count}");
        }
    }
}