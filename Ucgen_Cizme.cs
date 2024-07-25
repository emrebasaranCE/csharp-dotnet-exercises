using System;

namespace Ucgen_Cizme_ns
{
    class Test
    {
        public static void not_main()
        {

            Console.WriteLine("Enter a number to draw triangle: ");
            int input_from_user = Convert.ToInt32(Console.ReadLine());
             
            Console.WriteLine("Normal Triangle: ");
            draw_triangle_normal(input_from_user);

            Console.WriteLine("Left Triangle: ");
            draw_triangle_left(input_from_user);

            Console.WriteLine("Right Triangle: ");
            draw_triangle_right(input_from_user);
        }

        public static void draw_triangle_normal(int input_number)
        {
            for (int i = 0; i <= input_number; i++)
            {
                // yildiz sayisi = i * 2 - 1
                // bosluk sayisi = input_number - i
                for (int j = 0; j < input_number - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i * 2 - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void draw_triangle_left(int input_number)
        {
            for (int i = 0; i <= input_number; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void draw_triangle_right(int input_number)
        {
            for (int i = 0; i <= input_number; i++)
            {
                for (int j = 0; j < input_number - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}