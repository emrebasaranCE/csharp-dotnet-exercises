using System;
using System.Collections;

namespace ArrayList_namespaces
{
    class Test2
    {
        public static void not_main()
        {

            // arrayList.Add("this is first element of array list.");
            // arrayList.Add(2);
            // arrayList.Add(true);

            // foreach (var item in arrayList)
            // {
            //     Console.WriteLine(item);
            // }

            // Console.WriteLine("---- Add Range ----");

            // string[] colors = {"Blue", "Yellow", "Green", "Black"};
            ArrayList arrayList = new ArrayList();
            List<int> integers = new List<int>(){32,543,64,7,9,5,23,8,5423,60};

            // arrayList.Add(colors);
            arrayList.Add(integers);

            foreach (var item in arrayList)
            {
                if (item is List<int> intList)
                {
                    Console.WriteLine("");
                    foreach (var number in intList)
                    {
                        Console.Write(number + " ");
                    }
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine(item);
                }
            }

            arrayList.Sort();

            foreach (var item in arrayList)
            {
                if (item is List<int> intList)
                {
                    Console.WriteLine("");
                    foreach (var number in intList)
                    {
                        Console.Write(number + " ");
                    }
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}