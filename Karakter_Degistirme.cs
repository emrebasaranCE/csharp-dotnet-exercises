using System;

namespace Karakter_Degistirme_ns
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
                if (str.Length > 1)
                {
                    char[] char_array = str.ToCharArray();
                    char temp = char_array[0];
                    char_array[0] = char_array[str.Length - 1];
                    char_array[str.Length - 1] = temp;

                    Console.Write(new string(char_array) + " ");
                }
                else
                {
                    Console.Write(str + " ");
                }
            }
        }
    }
}
