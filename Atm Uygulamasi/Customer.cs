using System;

namespace CustomerNamespace
{
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

        public Customer CheckCustomersCrediantials(string entered_card_id, int entered_pin)
        {
            foreach (Customer current_customer in customers)
            {
                if (current_customer.Card_id == entered_card_id && current_customer.Pin == entered_pin)
                {
                    return current_customer;
                }
            }
            return null;
        }
    }

    class Customer
    {
        private string card_id;
        private int pin;
        private int balance;

        public Customer() { }

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

        public void UpdateBalance(string card_id, int amount, string transaction_type)
        {

            if (transaction_type == "Deposit")
            {
                this.Balance += amount;
                Console.WriteLine("Your new balance is: " + this.Balance);
            }
            else if (transaction_type == "Withdraw")
            {
                this.Balance -= amount;
                Console.WriteLine("Your new balance is: " + this.Balance);
            }
        }
    }
}
