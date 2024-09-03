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

        public Transaction_History()
        {
            transactions.Add(new Transaction("1234", "Deposit", 1000));
            transactions.Add(new Transaction("1234", "Withdraw", 500));
            transactions.Add(new Transaction("1234", "Deposit", 2000));
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