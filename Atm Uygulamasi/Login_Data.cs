using System;

namespace Login_Data_Namespace
{
    class Login_History
    {
        public static List<Login_Data> logs = new List<Login_Data>();

        public void AddLogToList(Login_Data new_login_data)
        {
            logs.Add(new_login_data);
        }

        // pre-defined login history
        public Login_History()
        {
            logs.Add(new Login_Data("1234", true));
            logs.Add(new Login_Data("1234", false));
            logs.Add(new Login_Data("1234", true));
        }
        // end of pre-defined login history


        public void CreateEODReportForLoginHistory()
        {
            string path = "End Of Day Reports";
            string file_name = "EOD_" + DateTime.Now.ToString("ddMMyyyy") + "_login_history" + ".txt";
            string file_path = Path.Combine(path, file_name);
            using (StreamWriter sw = File.CreateText(file_path))
            {
                sw.WriteLine("End of Day Report");
                sw.WriteLine("Date: " + DateTime.Now.ToString("dd/MM/yyyy"));
                sw.WriteLine("Time: " + DateTime.Now.ToString("HH:mm:ss"));
                sw.WriteLine("Login History:");
                foreach (Login_Data current_Login_Data in logs)
                {
                    sw.WriteLine("Card ID: " + current_Login_Data.Card_id);
                    if (current_Login_Data.Is_logged_in)
                    {
                        sw.WriteLine("Logged in successfully at: " + current_Login_Data.Login_time); 
                    }
                    else
                    {
                        sw.WriteLine("False try at: " + current_Login_Data.Login_time);
                    }
                    sw.WriteLine();
                }
            }
        }
    }

    class Login_Data
    {
        private string card_id;
        private bool is_logged_in = false;

        public string Card_id
        {
            get { return card_id; }
            set { card_id = value; }
        }

        public bool Is_logged_in
        {
            get { return is_logged_in; }
            set { is_logged_in = value; }
        }

        public DateTime Login_time;

        public Login_Data(string card_id, bool is_logged_in)
        {
            Card_id = card_id;
            Is_logged_in = is_logged_in;
            Login_time = DateTime.Now;
        }

    }
}