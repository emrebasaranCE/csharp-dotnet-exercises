using System;

namespace Generic_collections_namespace
{
    class Test2
    {
        public static void not_main()
        {
            List<int> integer_list = new List<int>();

            integer_list.Add(1);
            integer_list.Add(2);
            integer_list.Add(3);
            integer_list.Add(4);
            integer_list.Add(5);
            integer_list.Add(6);
            integer_list.Add(7);
            integer_list.Add(8);
            integer_list.Add(9);

            List<string> colours_List = new List<string>();

            colours_List.Add("Blue");
            colours_List.Add("Red");
            colours_List.Add("Yellow");

            Console.WriteLine("");
            foreach (int str in integer_list)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine("");
            foreach (string str in colours_List)
            {
                Console.Write(str + " ");
            }

            Console.WriteLine("");
            integer_list.ForEach(number => Console.Write(number + " "));
            Console.WriteLine("");
            colours_List.ForEach(color => Console.Write(color + " "));

            integer_list.Remove(2);
            Console.WriteLine("");
            integer_list.ForEach(number => Console.Write(number + " "));

            integer_list.RemoveAt(0);
            Console.WriteLine("");
            integer_list.ForEach(number => Console.Write(number + " "));

            if (integer_list.Contains(5))
            {
                Console.WriteLine($"\n5 found in integer_list, index: {integer_list.BinarySearch(5)}");
            }

            integer_list.Clear();


            List<Users> users_list = new List<Users>();

            Users user_1 = new Users();
            Users user_2 = new Users();

            user_1.Name = "User-1";
            user_1.Last_name = "last_name - 1";
            user_1.Age = 18; 

            user_2.Name = "User-2";
            user_2.Last_name = "last_name - 2";
            user_2.Age = 18;

            users_list.Add(user_1);
            users_list.Add(user_2);

            foreach (Users user in users_list)
            {
                Console.Write($"\nName: {user.Name}");
                Console.Write($"\nLast Name: {user.Last_name}");
                Console.Write($"\nAge: {user.Age}");
            }
        }
    }

    public class Users
    {
        private string name;
        private string last_name;
        private int age;

        public string Name { get => name; set => name = value;}
        public string Last_name { get => last_name; set => last_name = value;}
        public int Age { get => age; set => age = value;}
    }
}