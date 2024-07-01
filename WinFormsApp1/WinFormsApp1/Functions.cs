using System.Diagnostics;
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

            int counter = 1;
            foreach (string current_file_path in Variables.files_path_list)
            {
                string output_file_path = $"Output Files//{counter}.txt";

                using (StreamReader reader = new StreamReader(current_file_path))
                {
                    using (StreamWriter writer = new StreamWriter(output_file_path))
                    {
                        string input_line;
                        while ((input_line = reader.ReadLine()) != null)
                        {
                            try 
                            { 
                                
                                if (input_line.Contains(Variables.input_to_search_in_url))
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
                counter++;
                Debug.WriteLine($"This document is done: {current_file_path}");
            }
        }
    }
}
