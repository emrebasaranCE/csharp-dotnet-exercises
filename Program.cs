using TestNamespace;
namespace ProgramNamespace
{
    class Prg
    {
        static void Main(string[] args)
        {
            Telephone default_tel_1 = new Telephone("Mike", "Rocky", "5435553412");
            Telephone default_tel_2 = new Telephone("Ayse", "Kirmizi", "5435553543");
            Telephone default_tel_3 = new Telephone("Fatma", "Sari", "5435553412");
            Telephone default_tel_4 = new Telephone("Hayriye", "Yesil", "5435553412");
            Telephone default_tel_5 = new Telephone("Hasan ", "Irmak", "5435553412");

            // telephone.print_info();

            List<Telephone> telephones = new List<Telephone>();
            telephones.Add(default_tel_1);
            telephones.Add(default_tel_2);
            telephones.Add(default_tel_3);
            telephones.Add(default_tel_4);
            telephones.Add(default_tel_5);


            while(1 == 1)
            {
                Console.WriteLine("Please enter your choice");
                
                
            }
        }

        public void add_phone_number(List<Telephone> telephones)
        {
            Telephone new_acc = new Telephone();
            
            Console.WriteLine("Enter name: ");
            new_acc.Name = Console.ReadLine();
            Console.WriteLine("Enter last name: ");
            new_acc.Last_name = Console.ReadLine();
            Console.WriteLine("Enter phone number: ");
            new_acc.Phone_number = Console.ReadLine();
            
            
        }
    }
}
