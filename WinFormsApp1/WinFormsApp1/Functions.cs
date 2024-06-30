using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Functions
    {
        public void getComboFile()
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Title = "Select Combolist";
            openfile.Filter = "Text Files |*.txt";
            openfile.RestoreDirectory = true;
            DialogResult result = openfile.ShowDialog();
            string file_path_variable = openfile.FileName;

            if (result == DialogResult.OK && !string.IsNullOrEmpty(file_path_variable) && file_path_variable != "filePath")
            {
                string file_name = Path.GetFileName(openfile.FileName).Split(".")[0];
                string file_path = file_path_variable.ToString();
            }
        }


    }
}
