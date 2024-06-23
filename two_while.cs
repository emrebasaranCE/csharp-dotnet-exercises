using System;

namespace Two_while_namespace
{
    class Test2
    {
        public static void not_main()
        {
            int i = 1;
            int k;

            while (i <= 100)
            {
                k = i;
                int count = 0;

                while (count < 10 && k <= 100)
                {
                    System.Console.Write(k + " ");
                    k += 1;
                    count += 1;
                }

                System.Console.WriteLine();
                i = k;
            }
        }
    }
}
