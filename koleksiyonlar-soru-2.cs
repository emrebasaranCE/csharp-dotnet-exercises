using System;
using System.Collections;

namespace koleksiyonlar_soru_2_namespace
{
    class Test2
    {
        public static void not_main()
        {
            int[] input_array = new int[20];

            for (int i = 0; i < 20; i++)
            {
                input_array[i] = i + 1;
            }

            Console.WriteLine($"input_array: ");
            foreach (int current_int in input_array)
            {
                Console.Write($"{current_int} ");                
            }            

            Array.Sort(input_array);
            Console.WriteLine($"\nsorted array: ");
            foreach (int current_int in input_array)
            {
                Console.Write($"{current_int} ");                
            }   
            int biggest_1, middle_biggest, least_biggest;
            biggest_1 = input_array[input_array.Length - 1];
            middle_biggest = input_array[input_array.Length - 2];
            least_biggest = input_array[input_array.Length - 3];
            int big_ave = (biggest_1 + middle_biggest + least_biggest) / 3;
            Console.WriteLine($"\nBiggest 3 number:\n1 - {biggest_1}\n2 - {middle_biggest}\n3 - {least_biggest}\nThe Average is: {big_ave}");
            int smallest = input_array[0];
            int middle_smallest = input_array[1];
            int least_smallest = input_array[2];
            int small_ave = (smallest + middle_smallest + least_smallest) / 3;

            Console.WriteLine($"\nSmallest 3 number:\n1 - {smallest}\n2 - {middle_smallest}\n3 - {least_smallest}\nThe Average is: {small_ave}");

            Console.WriteLine($"Sums of averages: {big_ave + small_ave}");

        }
    }
}