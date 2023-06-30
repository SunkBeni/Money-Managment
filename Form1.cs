using System.Data.Common;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.X509Certificates;

namespace Money_Manager
{
    public partial class Form1 : Form
    {
        // symbol
        public string symbol = "₪";
        //
        // data_file
        public string data_file_path;
        public string data_file_text;
        public List<string> lines = new List<string>();
        //
        public static string filePathOne = @"C:\Users\iliaz\C# Projects\Money Manager\program files\data";
        public Form1()
        {
            InitializeComponent();
            List_reload();
        }

        private void setSymbolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            symbol = strip_settings_ML_textbox1.Text;
            if (symbol.Length > 1 || symbol == "")
            {
                strip_settings_ML_text1.ForeColor = Color.Red;
                strip_settings_ML_text1.Text = "Symbol Has To Be One Letter";
                strip_settings_ML_textbox1.Text = "";
            }
            else
            {
                symbol = strip_settings_ML_textbox1.Text;
                main_data4.Text = strip_settings_ML_textbox1.Text;
                strip_settings_ML_text1.ForeColor = Color.Black;
                strip_settings_ML_text1.Text = "V Enter Symbol V";
                strip_settings_ML_textbox1.Text = "";
                List_reload();
            }
        }
        public void List_add()
        {
            open_data_file();
            string name = "";
            string money = "";
            string cashcredit = "";
            foreach (string line in data_file_text.Split("\n"))
            {
                name = line.Split("\t")[0];
                money = line.Split("\t")[1];
                cashcredit = line.Split("\t")[2];
                main_list.Rows.Add(
                   new object[]
                   {
                        name, symbol + " " + money, cashcredit
                   }
                   );
            }
        }

        public void List_reload()
        {
            main_list.Rows.Clear();
            open_data_file();
            Debug.WriteLine(data_file_text);
            string name = "";
            string money = "";
            string cashcredit = "";
            foreach (string line in data_file_text.Split("\n"))
            {
                name = line.Split("\t")[0];
                money = line.Split("\t")[1];
                cashcredit = line.Split("\t")[2];
                main_list.Rows.Add(
                   new object[]
                   {
                        name, symbol + " " + money, cashcredit
                   }
                   );
            }
        }

        public void open_data_file()
        {
            data_file_path = @"C:\Users\iliaz\C# Projects\Money Manager\program files\data";
            lines = File.ReadAllLines(data_file_path).ToList();

            foreach (string line in lines)
            {
                data_file_text += line;
            }
        }

        private void main_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}