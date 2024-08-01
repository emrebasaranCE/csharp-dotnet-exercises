using System;

namespace Sessiz_Harf_ns
{
    class Program
    {
        public static void not_main()
        {
            Console.WriteLine("Enter a string: ");
            string input_string = Console.ReadLine();

            string[] strings = input_string.Split(' ');

            foreach (string str in strings)
            {
                bool is_the_last_char_is_consonant = false;
                int counter = 0;
                foreach (char c in str)
                {
                    if (is_the_last_char_is_consonant)
                    {
                        if (!(char.ToLower(c) == 'a' || char.ToLower(c) == 'e' || char.ToLower(c) == 'i' || char.ToLower(c) == 'o' || char.ToLower(c) == 'u'))
                        {
                            is_the_last_char_is_consonant = true;
                            Console.WriteLine("True");
                            break;
                        }
                        else
                        {
                            is_the_last_char_is_consonant = false;
                        }
                    }
                    else
                    {
                        if (!(char.ToLower(c) == 'a' || char.ToLower(c) == 'e' || char.ToLower(c) == 'i' || char.ToLower(c) == 'o' || char.ToLower(c) == 'u'))
                        {
                            is_the_last_char_is_consonant = true;
                        }
                        else
                        {
                            is_the_last_char_is_consonant = false;
                        }
                    }
                    counter++;
                    if (counter == str.Length)
                    {
                        Console.WriteLine("False");
                    }
                }
            }
        }
    }
}
