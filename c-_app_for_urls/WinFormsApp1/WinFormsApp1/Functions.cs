using System.Diagnostics;
using System.Diagnostics.Metrics;
using WinFormsApp1_Variables;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


///// onlyfans, steam, haxball, haxlife
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
                    // You can now process each file as needed
                    Variables.files_path_list.Add(filePath);
                }
            }
            else
            {
                Debug.WriteLine("No file selected or selection was cancelled.");
            }
            Debug.WriteLine("Selected files count: " + Variables.files_path_list.Count());
        }

        public void find_elements_in_files()
        {
            if (!Directory.Exists("Output Files"))
            {
                Directory.CreateDirectory("Output Files");
            }

            if (Variables.input_to_search_in_url.Contains(','))
            {
                Variables.different_words = Variables.input_to_search_in_url.Split(',');
                Variables.multiple_words_flag = true;
            }
            else
            {
                Variables.multiple_words_flag = false;
            }

            int counter = 1;
            foreach (string current_file_path in Variables.files_path_list)
            {
                // Variables.current_input_to_search_in_url = word_to_check;
                string output_file_path = $"Output Files//{counter}.txt";

                using (StreamReader reader = new StreamReader(current_file_path))
                {
                    using (StreamWriter writer = new StreamWriter(output_file_path, true))
                    {
                        string input_line;
                        while ((input_line = reader.ReadLine()) != null)
                        {
                            try
                            {
                                if (Variables.multiple_words_flag)
                                {
                                    foreach (string current_words in Variables.different_words)
                                    {
                                        if (input_line.Contains(current_words))
                                        {
                                            writer.WriteLine(input_line);
                                        }
                                    }
                                }
                                else
                                {
                                    if (input_line.Contains(Variables.input_to_search_in_url.Trim()))
                                    {
                                        writer.WriteLine(input_line);
                                    }
                                }

                            }
                            catch (Exception ex)
                            {
                                Debug.WriteLine($"An error occured: {ex}");
                            }
                        }
                    }
                }
                counter++;
                if ((counter - 1) % 100 == 0)
                {
                    Debug.WriteLine($"{counter - 1}/{Variables.files_path_list.Count}");
                }
            }
            Debug.WriteLine($"{counter - 1}/{Variables.files_path_list.Count}");
            combine_splitted_files();
        }

        public void combine_splitted_files()
        {

            string[] files = Directory.GetFiles("Output Files");

            string output_file_path = "";
            if (Variables.multiple_words_flag)
            {
                foreach (string current_word in Variables.different_words)
                {
                    output_file_path = $"{current_word.Trim()}.txt";
                    Debug.WriteLine($"combine_splitted_files / current_word : {current_word}\noutput_file_path: {output_file_path}");
                    using (StreamWriter writer = new StreamWriter(output_file_path))
                    {
                        foreach (string current_file_path in files)
                        {
                            // Debug.WriteLine($"Current document: {current_file_path} / looking for: {current_word}");
                            using (StreamReader reader = new StreamReader(current_file_path))
                            {
                                string input_line;
                                while ((input_line = reader.ReadLine()) != null)
                                {
                                    // user : pass : url
                                    // url : user : pass
                                    try
                                    {
                                        if (input_line.Contains(current_word))
                                        {
                                            writer.WriteLine(input_line);
                                        }
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
            else
            {
                string info_to_search = Variables.input_to_search_in_url.Trim();
                output_file_path = $"{info_to_search}.txt";
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
                                    if (input_line.Contains(info_to_search))
                                    {
                                        writer.WriteLine(input_line);
                                    }
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
}
