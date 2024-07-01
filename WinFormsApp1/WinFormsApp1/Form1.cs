using WinFormsApp1_Function;
using WinFormsApp1_Variables;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Functions functions = new Functions();
            functions.getComboFile();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != null) && (textBox1.Text != "") && (Variables.files_path_list.Count != 0))
            {
                Functions functions = new Functions();
                functions.find_elements_in_files();
                label1.Text = "Program ended...";
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter a input to check!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Variables.files_path_list.Count == 0)
            {
                MessageBox.Show("Please open combo files!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Variables.input_to_search_in_url = textBox1.Text;
        }
    }
}
