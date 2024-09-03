using System;

namespace TranscationNamespace
{
    class Transaction_History
    {
        public static List<Transaction> transactions = new List<Transaction>();

        public void AddTransactionToList(Transaction new_transaction)
        {
            transactions.Add(new_transaction);
        }

        // pre-defined transactions
        public Transaction_History()
        {
            transactions.Add(new Transaction("1234", "Deposit", 1000));
            transactions.Add(new Transaction("1234", "Withdraw", 500));
            transactions.Add(new Transaction("1234", "Deposit", 2000));
        }
        // end of pre-defined transactions

        public void CreateEODReportForTransactions()
        {
            string path = "End Of Day Reports";
            string file_name = "EOD_" + DateTime.Now.ToString("ddMMyyyy") + "_transaction_history" + ".txt";
            string file_path = Path.Combine(path, file_name);
            using (StreamWriter sw = new StreamWriter(file_path))
            {
                sw.WriteLine("End of Day Report");
                sw.WriteLine("Date: " + DateTime.Now.ToString("dd/MM/yyyy"));
                sw.WriteLine("Time: " + DateTime.Now.ToString("HH:mm:ss"));
                sw.WriteLine("Transactions:");
                foreach (Transaction current_transaction in transactions)
                {
                    sw.WriteLine("Card ID: " + current_transaction.Customer_card_id);
                    sw.WriteLine("Transaction Type: " + current_transaction.Transaction_type);
                    sw.WriteLine("Transaction Amount: " + current_transaction.Transaction_amount);
                    sw.WriteLine("Transaction Date: " + current_transaction.Transaction_date_unix);
                    sw.WriteLine();
                }
            }
        }
    }
    class Transaction
    {
        private string customer_card_id;
        private string transaction_type;
        private int transaction_amount;
        private DateTime transaction_date_unix;

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

        public DateTime Transaction_date_unix
        {
            get { return transaction_date_unix; }
            set { transaction_date_unix = value; }
        }
        public Transaction(string customer_card_id, string transaction_type, int transaction_amount)
        {
            Customer_card_id = customer_card_id;
            Transaction_type = transaction_type;
            Transaction_amount = transaction_amount;
            Transaction_date_unix = DateTime.Now;
        }

        
    }
}