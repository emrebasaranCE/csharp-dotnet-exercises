using System;

namespace Dictionary_namespace
{
    class Test2
    {
        public static void not_main()
        {
            Dictionary<int, string> Users = new Dictionary<int, string>();

            Users.Add(1, "Joey");
            Users.Add(2, "Chandler");
            Users.Add(3, "Monica");
            Users.Add(4, "Ross");
            Users.Add(5, "Rachel");
            Users.Add(6, "Phoebe");


            Console.WriteLine(Users[1]);

            foreach (var item in Users)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

            Console.WriteLine("Count: " + Users.Count);
            Console.WriteLine("ContainsKey: " + Users.ContainsKey(2));
            Console.WriteLine("ContainsValue: " + Users.ContainsValue("Rachel"));

            Users.Remove(1); 
            
            Console.WriteLine("Dictionary after Remove(1)");
            foreach (var item in Users)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

        }
    }
}