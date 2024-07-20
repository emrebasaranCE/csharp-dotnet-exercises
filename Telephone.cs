namespace TestNamespace
{
    class Telephone
    {
        private string name;
        private string last_name;
        private string phone_number;

        public string Name { get => name; set => name = value; }
        public string Last_name { get => last_name; set => last_name = value; }
        public string Phone_number { get => phone_number; set => phone_number = value; }

        // Constructor method should not have a return type
        public Telephone(string name, string last_name, string phone_number)
        {
            this.name = name;
            this.last_name = last_name;
            this.phone_number = phone_number;
        }

        public void print_info()
        {
            Console.WriteLine($"User name: {this.name}");
            Console.WriteLine($"User last name: {this.last_name}");
            Console.WriteLine($"User phone number: {this.phone_number}");
        }
    }
}
