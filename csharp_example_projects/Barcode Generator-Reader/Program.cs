using System;
using System;
using System.Diagnostics;
using System.IO;
using BarcodeFunctionsNS;


namespace ProgramNS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Barcode Reader/Creator!");

            while (true)
            {
                Console.WriteLine("1 - Open and read a barcode.");
                Console.WriteLine("2 - Create a barcode.");

                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    // Open and read barcode
                    Console.WriteLine("Open the barcode image.");
                    Thread.Sleep(2000);
                    string path = GetFilePathFromDialog();

                    if (path != null)
                    {
                        Reader.ReadBarcode(path);
                    }
                }
                else if (choice == 2)
                {
                    // Create barcode
                    Console.WriteLine("Enter the text to encode in the barcode.");
                    string text = Console.ReadLine();

                    Console.WriteLine("Enter the file name to save the barcode image.");
                    string file_name = Console.ReadLine();

                    Creator.CreateBarcode(text, file_name);
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
            }
        }


        static string GetFilePathFromDialog()
        {
            try
            {
                // PowerShell script to open a file dialog and return the selected file path
                string psScript = @"
            Add-Type -AssemblyName System.Windows.Forms
            $openFileDialog = New-Object System.Windows.Forms.OpenFileDialog
            $openFileDialog.ShowDialog() | Out-Null
            $openFileDialog.FileName";

                // Start PowerShell process to execute the script
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "powershell.exe";
                    process.StartInfo.Arguments = $"-NoProfile -Command \"{psScript}\"";
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.CreateNoWindow = true;

                    process.Start();

                    // Read the output (file path)
                    string output = process.StandardOutput.ReadToEnd().Trim();
                    process.WaitForExit();

                    return !string.IsNullOrEmpty(output) ? output : null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while opening the file dialog: " + ex.Message);
                return null;
            }
        }
    }
}