using Kart_namespace;

namespace Board_namespace
{
    class Board
    {
        private List<Kart> to_do_list = new List<Kart>();
        private List<Kart> in_progress_list = new List<Kart>();
        private List<Kart> done_list = new List<Kart>();

        public void print_board()
        {
            print_to_do_list();
            print_in_progress_list();
            print_done_list();
        }

        public void print_to_do_list()
        {
            Console.WriteLine("TODO Line\n************************");
            if (to_do_list.Count == 0)
            {
                Console.WriteLine("~ BOŞ ~");
                Console.WriteLine("");
            }
            else
            {
                foreach (Kart kart in to_do_list)
                {
                    Console.WriteLine("Baslik      : " + kart.Name);
                    Console.WriteLine("İçerik      : " + kart.Content);
                    Console.WriteLine("Büyüklük    : " + kart.Size);
                    Console.WriteLine("Atanan Kişi : " + kart.Assigned_to);
                    Console.WriteLine("");
                }
            }
        }
        public void print_in_progress_list()
        {
            Console.WriteLine("IN PROGRESS Line\n************************");
            if (in_progress_list.Count == 0)
            {
                Console.WriteLine("~ BOŞ ~");
                Console.WriteLine("");
            }
            else
            {
                foreach (Kart kart in in_progress_list)
                {
                    Console.WriteLine("Baslik      : " + kart.Name);
                    Console.WriteLine("İçerik      : " + kart.Content);
                    Console.WriteLine("Büyüklük    : " + kart.Size);
                    Console.WriteLine("Atanan Kişi : " + kart.Assigned_to);
                    Console.WriteLine("");
                }
            }
        }
        public void print_done_list()
        {
            Console.WriteLine("DONE Line\n************************");
            if (done_list.Count == 0)
            {
                Console.WriteLine("~ BOŞ ~");
                Console.WriteLine("");
            }
            else
            {
                foreach (Kart kart in done_list)
                {
                    Console.WriteLine("Baslik      : " + kart.Name);
                    Console.WriteLine("İçerik      : " + kart.Content);
                    Console.WriteLine("Büyüklük    : " + kart.Size);
                    Console.WriteLine("Atanan Kişi : " + kart.Assigned_to);
                    Console.WriteLine("");
                }
            }
        }

        public void Add_to_do_element(Kart kart)
        {
            to_do_list.Add(kart);
        }

        public void Add_in_progress_element(Kart kart)
        {
            in_progress_list.Add(kart);
        }

        public void Add_done_element(Kart kart)
        {
            done_list.Add(kart);
        }

        public void remove_to_do_element(Kart kart)
        {
            to_do_list.Remove(kart);
        }

        public void remove_in_progress_element(Kart kart)
        {
            in_progress_list.Remove(kart);
        }

        public void remove_done_element(Kart kart)
        {
            done_list.Remove(kart);
        }

        public bool remove_from_the_all_lists(string name_of_kart)
        {
            bool did_the_input_is_found;

            Kart output_kart = to_do_list.Find(x => x.Name == name_of_kart);
            Kart output_kart_2 = in_progress_list.Find(x => x.Name == name_of_kart);
            Kart output_kart_3 = done_list.Find(x => x.Name == name_of_kart);

            if (output_kart != null)
            {
                to_do_list.Remove(output_kart);
                did_the_input_is_found = true;
            }
            else if (output_kart_2 != null)
            {
                in_progress_list.Remove(output_kart_2);
                did_the_input_is_found = true;
            }
            else if (output_kart_3 != null)
            {
                done_list.Remove(output_kart_3);
                did_the_input_is_found = true;
            }
            else
            {
                did_the_input_is_found = false;
            }

            return did_the_input_is_found;
        }
    }
}
