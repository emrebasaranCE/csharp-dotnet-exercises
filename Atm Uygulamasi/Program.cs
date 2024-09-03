using System;
using static System.DateTime;
using CustomerNamespace;
using TranscationNamespace;
using Login_Data_Namespace;

namespace AtmApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ATM Application");
            while (true)
            {
                Console.WriteLine("Enter your card");
                string user_entered_card_id = Console.ReadLine();
                // if (user_entered_card_id == "eod")
                // {
                //     CreateDirectoryForEOD();
                // }
                Console.WriteLine("Enter your pin");
                int user_entered_customer_pin = Convert.ToInt32(Console.ReadLine());

                Customers customers = new Customers();
                Customer is_user_customer = customers.CheckCustomersCrediantials(user_entered_card_id, user_entered_customer_pin);

                if (is_user_customer != null)
                {
                    Console.WriteLine("\n\nYou are loggen in. Welcome\n");

                    while (true)
                    {
                        Console.WriteLine("Enter 1 for Deposit");
                        Console.WriteLine("Enter 2 for Withdraw");
                        Console.WriteLine("Enter 3 for Balance");
                        Console.WriteLine("Enter 4 for Exit");
                        Console.WriteLine("Enter 5 for End of Day Report(Normally its not logical to put this here...)");

                        int user_choice = Convert.ToInt32(Console.ReadLine());

                        if (user_choice == 1)
                        {
                            Console.WriteLine("Enter the amount you want to deposit");
                            int deposit_amount = Convert.ToInt32(Console.ReadLine());
                            is_user_customer.UpdateBalance(user_entered_card_id, deposit_amount, "Deposit");

                            Transaction new_transaction = new Transaction(user_entered_card_id, "Deposit", deposit_amount);
                            Transaction_History.transactions.Add(new_transaction);
                        }
                        else if (user_choice == 2)
                        {
                            Console.WriteLine("Enter the amount you want to withdraw");
                            int withdraw_amount = Convert.ToInt32(Console.ReadLine());
                            is_user_customer.UpdateBalance(user_entered_card_id, withdraw_amount, "Withdraw");

                            Transaction new_transaction = new Transaction(user_entered_card_id, "Withdraw", withdraw_amount);
                            Transaction_History.transactions.Add(new_transaction);
                        }
                        else if (user_choice == 3)
                        {
                            Console.WriteLine("Your balance is: " + is_user_customer.Balance);
                        }
                        else if (user_choice == 4)
                        {
                            Console.WriteLine("Goodbye");
                            Environment.Exit(0);
                        }
                        else if (user_choice == 5)
                        {
                            CreateDirectoryForEOD();
                            Login_History login_History = new Login_History();
                            login_History.CreateEODReportForLoginHistory();

                            Transaction_History transaction_History = new Transaction_History();
                            transaction_History.CreateEODReportForTransactions();
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice");
                        }
                    }

                }
                else
                {
                    Console.WriteLine("\n\nInvalid card id or pin\n");
                }

            }
        }

        public static void CreateDirectoryForEOD()
        {
            string path = "End Of Day Reports";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
    }
}