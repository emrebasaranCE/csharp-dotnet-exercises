using System;

namespace Daire_Cizme_ns
{
    class Program
    {
       public static void not_main()
        {
            Console.WriteLine("Enter the radius of the circle: ");
            int radius = Convert.ToInt32(Console.ReadLine());

            DrawCircle(radius);
        }

        public static void DrawCircle(int radius)
        {
            for (int i = -radius; i <= radius; i++)
            {
                for (int j = -radius; j <= radius; j++)
                {
                    if (i * i + j * j <= radius * radius)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
