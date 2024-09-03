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

        public Login_History()
        {
            logs.Add(new Login_Data("1234", true));
            logs.Add(new Login_Data("1234", false));
            logs.Add(new Login_Data("1234", true));
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