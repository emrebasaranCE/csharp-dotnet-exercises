using System;
using Kart_namespace;
using Board_namespace;
using System.Diagnostics;

namespace Program
{

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> team_members = new Dictionary<string, int>();
            team_members.Add("John", 11);
            team_members.Add("Alice", 22);
            team_members.Add("Bob", 33);
            team_members.Add("Emily", 44);
            team_members.Add("David", 55);

            Board board = new Board();

            add_default_karts(ref board);

            int choice_from_the_user = 0;
            while (choice_from_the_user != 5)
            {
                show_user_choices();
                choice_from_the_user = Convert.ToInt32(Console.ReadLine());

                process_the_user_choice(choice_from_the_user, board);
            }

        }
        public static void process_the_user_choice(int choice_from_the_user, Board board)
        {
            switch (choice_from_the_user)
            {
                case 1:
                    process_1(board);
                    break;

                case 2:
                    process_2(board);
                    break;
                case 3:
                    process_3(board);
                    break;
                case 4:
                    process_4(board);
                    break;
                case 5:
                    Console.WriteLine("Çikiş yapiliyor...");
                    break;
                default:
                    Console.WriteLine("Hatali bir seçim yaptiniz! Lütfen tekrar deneyiniz.");
                    break;
            }
        }

        public static void process_1(Board board)
        {
            board.print_board();
        }

        public static void process_2(Board board)
        {
            Kart new_kart_to_add = new Kart();
            Console.WriteLine("Başlik Giriniz                                  :");
            new_kart_to_add.Name = Console.ReadLine();
            Console.WriteLine("İçerik Giriniz                                  :");
            new_kart_to_add.Content = Console.ReadLine();
            Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
            int sizeInput;
            if (int.TryParse(Console.ReadLine(), out sizeInput))
            {
                new_kart_to_add.Size = (size_of_job)(sizeInput - 1);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
            }
            Console.WriteLine("Kişi Seçiniz                                    :");
            new_kart_to_add.Assigned_to = Convert.ToInt32(Console.ReadLine());

            board.Add_to_do_element(new_kart_to_add);
        }

        public static void process_3(Board board)
        {
            Console.WriteLine("Öncelikle silmek istediğiniz karti seçmeniz gerekiyor.\nLütfen kart başliğini yaziniz:  ");
            string kart_name_to_delete = Console.ReadLine();
            bool input_found = board.remove_from_the_all_lists(kart_name_to_delete);
            if (input_found)
            {
                Console.WriteLine("Kart silindi.");
            }
            else
            {
                Console.WriteLine("Aradiğiniz krtiterlere uygun kart board'da bulunamadi. Lütfen bir seçim yapiniz.");
                Console.WriteLine("* Silmeyi sonlandirmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");
                int second_choice = Convert.ToInt32(Console.ReadLine());
                if (second_choice == 2)
                {
                    process_3(board);
                }
            }
        }

        public static void process_4(Board board)
        {
            Console.WriteLine("Öncelikle silmek istediğiniz karti seçmeniz gerekiyor.\nLütfen kart başliğini yaziniz:  ");
            string kart_name_to_move = Console.ReadLine();
            Kart did_the_input_is_found = board.find_in_lists(kart_name_to_move);

            if (did_the_input_is_found != null)
            {
                Console.WriteLine("Bulunan Kart Bilgileri:\n*******************************************");
                Console.WriteLine("Baslik      : " + did_the_input_is_found.Name);
                Console.WriteLine("İçerik      : " + did_the_input_is_found.Content);
                Console.WriteLine("Büyüklük    : " + did_the_input_is_found.Size);
                Console.WriteLine("Atanan Kişi : " + did_the_input_is_found.Assigned_to);
                Console.WriteLine("Lütfen taşimak istediğiniz Line'i seçiniz: (1) TODO (2) IN PROGRESS (3) DONE");
                int second_choice = Convert.ToInt32(Console.ReadLine());
                board.move_kart(kart_name_to_move, second_choice);

                board.print_board();
            }
            else
            {
                Console.WriteLine("Hatali bir seçim yaptiniz!");

            }
        }

        public static void show_user_choices()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)\n*******************************************");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşimak");
            Console.WriteLine("(5) Çikiş");

        }
        public static void add_default_karts(ref Board board)
        {
            Kart kart1 = new Kart("Kart 1", "Kart 1 İçerik", 11, size_of_job.XS);
            Kart kart2 = new Kart("Kart 2", "Kart 2 İçerik", 22, size_of_job.S);
            Kart kart3 = new Kart("Kart 3", "Kart 3 İçerik", 33, size_of_job.M);

            board.Add_to_do_element(kart1);
            board.Add_to_do_element(kart2);
            board.Add_done_element(kart3);

        }
    }
}


