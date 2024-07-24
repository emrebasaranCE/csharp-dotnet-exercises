using System.Linq.Expressions;
using TestNamespace;
using System.Threading;


namespace ProgramNamespace
{
    class Prg
    {
        static void Main(string[] args)
        {
            // create 5 telephone objects
            List<Telephone> telephones = new List<Telephone>();
            add_five_user_to_the_list(ref telephones);


            // give choices to the user
            give_choices_to_user();
            // get user choice for the first time
            int choice_from_the_user = Convert.ToInt32(Console.ReadLine());

            // get the choice from the user until the user wants to exit
            while (choice_from_the_user != 6) // until user enters 6, keep asking for choices
            {  
                // process the choice
                process_choice(choice_from_the_user, telephones);
                
                // give choices to the user
                give_choices_to_user();
                choice_from_the_user = Convert.ToInt32(Console.ReadLine());

            }
        }

        public static void give_choices_to_user()
        {
            // print possible choices to the user
            Console.WriteLine("1- Yeni Numara Kaydetmek");
            Console.WriteLine("2- Varolan Numarayı Silmek");
            Console.WriteLine("3- Varolan Numarayı Güncelleme");
            Console.WriteLine("4- Rehberi Listelemek");
            Console.WriteLine("5- Rehberde Arama Yapmak");
            Console.WriteLine("6- Cikis"); 
        }


        
        // process choice with switch case
        public static void process_choice(int choice_from_the_user, List<Telephone> telephones)
        {
            // 1 - add new number
            // 2 - delete a number
            // 3 - update a number
            // 4 - list all numbers
            // 5 - search in the list
            // 6 - exit

            switch (choice_from_the_user)
            {
                case 1:
                    Console.WriteLine("-- Yeni Numara Kaydetmek --");
                    Console.WriteLine("Ad: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Soyad: ");
                    string last_name = Console.ReadLine();
                    Console.WriteLine("Telefon Numarasi: ");
                    string phone_number = Console.ReadLine();
                    name = name.Trim();
                    last_name = last_name.Trim();
                    phone_number = phone_number.Trim();
                    Telephone new_tel = new Telephone(name, last_name, phone_number);
                    telephones.Add(new_tel);
                    break;

                case 2:
                    Console.WriteLine("-- Varolan Numarayi Silmek --");
                    Console.WriteLine("Silinecek Numaranin Adini Giriniz: ");
                    string name_to_delete = Console.ReadLine();
                    Console.WriteLine("Silinecek Numaranin Soyadini Giriniz: ");
                    string last_name_to_delete = Console.ReadLine();
                    Telephone tel_to_delete = telephones.Find(tel => tel.Name == name_to_delete && tel.Last_name == last_name_to_delete);
                    if (tel_to_delete == null)
                    {
                        Console.WriteLine("Aradiginiz isimde bir kisi bulunamadi.");
                    }
                    else
                    {
                        telephones.Remove(tel_to_delete);
                    }
                    break;

                case 3:
                    Console.WriteLine("-- Varolan Numarayi Güncelleme --");
                    Console.WriteLine("Güncellenecek Numaranin Adini Giriniz: ");
                    string name_to_update = Console.ReadLine();
                    Console.WriteLine("Güncellenecek Numaranin Soyadini Giriniz: ");
                    string last_name_to_update = Console.ReadLine();
                    Telephone tel_to_update = telephones.Find(tel => tel.Name == name_to_update && tel.Last_name == last_name_to_update);
                    if (tel_to_update == null)
                    {
                        Console.WriteLine("Aradiginiz isimde bir kisi bulunamadi.");
                    }
                    else
                    {
                        Console.WriteLine("Yeni Telefon Numarasi: ");
                        string new_phone_number = Console.ReadLine();
                        new_phone_number = new_phone_number.Trim();
                        tel_to_update.Phone_number = new_phone_number;
                        Console.WriteLine("Telefon Numarasi Guncellendi: ");
                        Console.WriteLine("Yeni Numara: " + tel_to_update.Phone_number);
                    }
                    break;
                case 4:
                    Console.WriteLine("-- Rehberi Listeleme --");
                    foreach (Telephone tel in telephones)
                    {
                        tel.print_info();
                    }
                    break;
                case 5:
                    Console.WriteLine("-- Rehberde Arama Yapmak --");
                    Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
                    Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)\nTelefon numarasina göre arama yapmak için: (2)");
                    int choice_to_search = Convert.ToInt32(Console.ReadLine());

                    if (choice_to_search == 1)
                    {
                        Console.WriteLine("İsim veya soyisim giriniz: ");
                        string possible_name_or_lastname = Console.ReadLine();
                        Telephone tel_to_find = telephones.Find(tel => tel.Name == possible_name_or_lastname || tel.Last_name == possible_name_or_lastname);
                        if (tel_to_find == null)
                        {
                            Console.WriteLine("Aradiginiz isimde bir kisi bulunamadi.");
                        }
                        else
                        {
                            Console.WriteLine("~~~Kayit bulundu: ");
                            Console.WriteLine($"Isim: {tel_to_find.Name}");
                            Console.WriteLine($"Soyisim: {tel_to_find.Last_name}");
                            Console.WriteLine($"Telefon numarasi: {tel_to_find.Phone_number}");
                        }
                    }
                    else if (choice_to_search == 2)
                    {
                        Console.WriteLine("Telefon numarasi giriniz: ");
                        string possible_phone_number = Console.ReadLine();
                        Telephone tel_to_find = telephones.Find(tel => tel.Name == possible_phone_number);
                        if (tel_to_find == null)
                        {
                            Console.WriteLine("Aradiginiz isimde bir kisi bulunamadi.");
                        }
                        else
                        {
                            Console.WriteLine("~~~Kayit bulundu: ");
                            Console.WriteLine($"Isim: {tel_to_find.Name}");
                            Console.WriteLine($"Soyisim: {tel_to_find.Last_name}");
                            Console.WriteLine($"Telefon numarasi: {tel_to_find.Phone_number}");
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Yanlis secim yaptiniz...");
                    break;
            }
        }

        // add 5 default users to the list
        public static void add_five_user_to_the_list(ref List<Telephone> list)
        {
            Telephone default_tel_1 = new Telephone("Mike", "Rocky", "5435553412");
            Telephone default_tel_2 = new Telephone("Ayse", "Kirmizi", "5435553543");
            Telephone default_tel_3 = new Telephone("Fatma", "Sari", "5435553412");
            Telephone default_tel_4 = new Telephone("Hayriye", "Yesil", "5435553412");
            Telephone default_tel_5 = new Telephone("Hasan", "Irmak", "5435553412");
            list.Add(default_tel_1);
            list.Add(default_tel_2);
            list.Add(default_tel_3);
            list.Add(default_tel_4);
            list.Add(default_tel_5);
        }
    }
}
