using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WinFormsApp1_Variables
{
    internal class Variables
    {
        public static string input_to_search_in_url;
        public static bool multiple_words_flag = false;

        // if there is multiple words, use this variable
        public static string[] different_words = [];

        public static List<string> files_path_list = new List<string>();

    }
}
