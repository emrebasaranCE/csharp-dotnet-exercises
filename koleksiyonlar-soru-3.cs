using System;
using System.Collections;

namespace koleksiyonlar_soru_3_namespace
{
    class Test2
    {
        public static void not_main()
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u'};

            char[] vowels_that_are_in_string = new char[100];
            string input_string = "Hello world, how are you guys doinngggg.";

            Console.WriteLine(input_string);
            Console.Write("Vowels in the string: ");

            int counter = 0;
            foreach (char cur_char in input_string)
            {
                if (vowels.Contains(char.ToLower(cur_char)))
                {
                    vowels_that_are_in_string[counter] = cur_char;
                    Console.Write(cur_char + " ");
                    counter++;
                }
            }

            Array.Sort(vowels_that_are_in_string);
            Console.Write("\nVowels in the string(after sorting): ");
            foreach (char c in vowels_that_are_in_string)
            {
                Console.Write(c + " ");
            }
        }
    }
}