using System.Diagnostics;
using System.Diagnostics.Metrics;
using WinFormsApp1_Variables;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp1_Function
{
    internal class Functions
    {
        public void getComboFile()
        {
            OpenFileDialog openfile = new OpenFileDialog();

            openfile.Title = "Select Combolist";
            openfile.Filter = "Text Files |*.txt";
            openfile.RestoreDirectory = true;
            openfile.Multiselect = true;

            DialogResult result = openfile.ShowDialog();

            if (result == DialogResult.OK && openfile.FileNames.Length > 0)
            {
                foreach (string filePath in openfile.FileNames)
                {
                    Debug.WriteLine("Selected file path: " + filePath);
                    // You can now process each file as needed
                    Variables.files_path_list.Add(filePath);
                }
            }
            else
            {
                Debug.WriteLine("No file selected or selection was cancelled.");
            }
        }

        public void find_elements_in_files()
        {
            if (!Directory.Exists("Output Files"))
            {
                Directory.CreateDirectory("Output Files");
            }

            bool multiple_words_flag = false;
            string[] different_words = [];
            if (Variables.input_to_search_in_url.Contains(','))
            {
                different_words = Variables.input_to_search_in_url.Split(',');
                multiple_words_flag = true;
            }
            else
            {
                multiple_words_flag = false;
            }

            // int counter = 1;
            foreach (string current_file_path in Variables.files_path_list)
            {
                // Variables.current_input_to_search_in_url = word_to_check;
                // string output_file_path = $"Output Files//{counter}.txt";

                using (StreamReader reader = new StreamReader(current_file_path))
                {
                    string input_line;
                    while ((input_line = reader.ReadLine()) != null)
                    {
                        try
                        {
                            if (multiple_words_flag)
                            {
                                foreach (string current_words in different_words)
                                {
                                    string word_to_check = current_words.Trim();
                                    if (input_line.Contains(word_to_check))
                                    {
                                        string output_file_path = $"{word_to_check}.txt";

                                        using (StreamWriter writer = new StreamWriter(output_file_path, true))
                                        {
                                            writer.WriteLine(input_line);
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if (input_line.Contains(Variables.input_to_search_in_url.Trim()))
                                {
                                    string output_file_path = $"{Variables.input_to_search_in_url.Trim()}.txt";

                                    using (StreamWriter writer = new StreamWriter(output_file_path, true))
                                    {
                                        writer.WriteLine(input_line);
                                    }
                                }
                            }

                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine($"An error occured: {ex}");
                        }
                    }
                }
                // counter++;
                Debug.WriteLine($"This document is done: {current_file_path}");
            }
            // combine_splitted_files();
        }

        public void combine_splitted_files()
        {

            string[] files = Directory.GetFiles("Output Files");

            string output_file_path = "";
            if (Variables.input_to_search_in_url.Contains(','))
            {
                output_file_path = $"{Variables.current_input_to_search_in_url}.txt";
            }
            else
            {
                output_file_path = $"{Variables.input_to_search_in_url}.txt";
            }


            using (StreamWriter writer = new StreamWriter(output_file_path))
            {
                foreach (string current_file_path in files)
                {

                    using (StreamReader reader = new StreamReader(current_file_path))
                    {
                        string input_line;
                        while ((input_line = reader.ReadLine()) != null)
                        {
                            // user : pass : url
                            // url : user : pass
                            try
                            {
                                writer.WriteLine(input_line);
                            }
                            catch (Exception ex)
                            {
                                Debug.WriteLine($"An error occured: {ex}");
                            }
                        }
                    }
                }
            }
        }
    }
}
