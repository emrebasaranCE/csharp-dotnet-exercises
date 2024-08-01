using System;

namespace Mutlak_Kare_Alma_ns
{
    class Program
    {

        /// Verilen soru net olmadigi icin kendi yorumumla kodu olusturdum.
        public static void not_main()
        {
            Console.WriteLine("Please enter numbers: ");
            string input = Console.ReadLine();

            string[] str_numbers = input.Split(' ');

            List<int> lover_than_67 = new List<int>();
            List<int> greater_than_67 = new List<int>();
            foreach (string str_number in str_numbers)
            {
                int number = Convert.ToInt32(str_number);

                if (number < 67)
                {
                    lover_than_67.Add(number);
                }
                else
                {
                    greater_than_67.Add(number);
                }
            }

            Console.WriteLine("Lover than 67: ");
            foreach (var number in lover_than_67)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("");

            Console.WriteLine("Greater than 67: ");
            foreach (var number in greater_than_67)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("");

        }
    }
}
