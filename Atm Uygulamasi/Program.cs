using System;
using static System.DateTime;

namespace AtmApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ATM Application");
            Console.WriteLine("Enter your card");
            string card_id = Console.ReadLine();
            Console.WriteLine("Enter your pin");
            int customer_pin = Convert.ToInt32(Console.ReadLine());

            
        }
    }

    class Customers
    {
        public List<Customer> customers = new List<Customer>();

        // pre-defined customers
        public Customers()
        {
            customers.Add(new Customer { Card_id = "1234", Pin = 1111, Balance = 1000 });
            customers.Add(new Customer { Card_id = "5678", Pin = 1111, Balance = 2000 });
            customers.Add(new Customer { Card_id = "1111", Pin = 1111, Balance = 3000 });
        }
        // end of pre-defined customers
    }

    class Customer
    {
        private string card_id;
        private int pin;
        private int balance;

        public Customer(){}

        public Customer(string card_id, int pin, int balance)
        {
            Card_id = card_id;
            Pin = pin;
            Balance = balance;
        }
        public string Card_id
        {
            get { return card_id; }
            set { card_id = value; }
        }
        
        public int Pin
        {
            get { return pin; }
            set { pin = value; }
        }

        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }
    }

    class Transaction_History
    {
        public static List<Transaction> transactions = new List<Transaction>();

        public void AddTransactionToList(Transaction new_transaction)
        {
            transactions.Add(new_transaction);
        }

        public Transaction_History()
        {
            transactions.Add(new Transaction("1234", "Deposit", 1000));
            transactions.Add(new Transaction("1234","Withdraw", 500));
            transactions.Add(new Transaction("1234", "Deposit", 2000));
        }
    }

    class Log_History
    {
        public static List<string> logs = new List<string>();

        public void AddLogToList(string new_log)
        {
            logs.Add(new_log);
        }

        public Log_History()
        {
            logs.Add("Customer 1234 deposited 1000");
            logs.Add("Customer 1234 withdrew 500");
            logs.Add("Customer 1234 deposited 2000");
        }
    }

    class Transaction
    {
        private string customer_card_id;
        private string transaction_type;
        private int transaction_amount;
        private long transaction_date_unix;

        public string Customer_card_id
        {
            get { return customer_card_id; }
            set { customer_card_id = value; }
        }
        public string Transaction_type
        {
            get { return transaction_type; }
            set { transaction_type = value; }
        }

        public int Transaction_amount
        {
            get { return transaction_amount; }
            set { transaction_amount = value; }
        }

        public long Transaction_date_unix
        {
            get { return transaction_date_unix; }
            set { transaction_date_unix = value; }
        }   
        public Transaction(string customer_card_id, string transaction_type, int transaction_amount)
        {
            DateTime current_unix_time = new DateTime((DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).Ticks);
            Customer_card_id = customer_card_id;
            Transaction_type = transaction_type;
            Transaction_amount = transaction_amount;
            Transaction_date_unix = Convert.ToInt64(current_unix_time);
        }
    }
}