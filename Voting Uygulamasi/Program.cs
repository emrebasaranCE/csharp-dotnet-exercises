using System;

namespace VotingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pre-defined categories
            Category.AddCategory("Food");
            Category.AddCategory("Drinks");
            Category.AddCategory("Desserts");
            // end of pre-defined categories

            Console.WriteLine("Welcome to the Voting Application!");

            while (true)
            {
                Console.WriteLine("\nSelect an option: \n1. Vote\n2. Exit");

                int option = Convert.ToInt32(Console.ReadLine());

                if (option == 1)
                {
                    Console.WriteLine("Enter your username: ");
                    string entered_username = Console.ReadLine();

                    User user_to_check = User.CheckUsername(entered_username);   
                    User new_user = new User();
                    if (user_to_check == null)
                    {
                        new_user.Username = entered_username;
                        User.AddUser(new_user);
                        Console.WriteLine("No record found, therefore new username successfully added!");
                    }

                    Category.ShowCategories();
                    Console.WriteLine("Enter the number of the category you want to vote: ");

                    int selected_category = Convert.ToInt32(Console.ReadLine());

                    if (selected_category > 0 || selected_category < Category.Categories.Count + 1)
                    {
                        if (new_user.HasUserVoted() == true) // check if the user already voted or not.
                        {
                            Console.WriteLine("You have already voted!");
                        }
                        else
                        {
                            int selected_category_index = selected_category - 1;
                            Category.AddOneVote(selected_category_index);
                            User.UserHasVoted(new_user);
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("Invalid category number!\nPlease start from the beginning to vote.");
                    }
                }
                else if (option == 2)
                {
                    Category.ShowVotesStatistics();
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid option!");
                }
            }
        }
    }

    class Category
    {

        public static List<Category> Categories = new List<Category>();
        public string Name { get; set; }
        public int Votes { get; set; }

        public static int Total_Votes { get; set; }
        public Category(string name)
        {
            Name = name;
            Votes = 0;
        }

        public static void AddCategory(string new_category_name)
        {
            Category new_category = new Category(new_category_name);
            Categories.Add(new_category);
        }

        public static void ShowCategories()
        {
            int counter = 1;
            foreach (Category category in Categories)
            {
                Console.WriteLine($"{counter} - {category.Name}");
                counter++;
            }
        }

        public static void ShowVotesStatistics()
        {
            foreach (Category category in Categories)
            {
                Console.WriteLine($"{category.Name} - {category.Votes} - {category.Votes * 100 / Total_Votes }%");
            }
        }

        public static void AddOneVote(int category_index)
        {
            Categories[category_index].Votes++;
            Total_Votes = Total_Votes + 1;
        }
    }

    class User
    {
        private string username { get; set; }

        
        public string Username  // property
        {
            get { return username; }   // get method
            set { username = value; }  // set method
        }
        private static bool is_user_voted { get; set; }

        public bool Is_user_voted  // property
        {
            get { return is_user_voted; }   // get method
            set { is_user_voted = value; }  // set method
        }
        
        public static List<User> Users = new List<User>();

        public static User CheckUsername(string wanted_username)
        {
            foreach (User user in Users)
            {
                if (user.Username == wanted_username)
                {
                    return user;
                }
            }
            return null;
        }

        public static void AddUser(User new_user)
        {
            Users.Add(new_user);
            new_user.Is_user_voted = false;
        }

        public bool HasUserVoted()
        {
            return Is_user_voted;
        }
        public static void UserHasVoted(User user_that_voted)
        {
            user_that_voted.Is_user_voted = true;
        }
    }
}