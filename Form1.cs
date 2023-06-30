using System.Data.Common;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.X509Certificates;

namespace Money_Manager
{
    public partial class Form1 : Form
    {
        // data_file
        public string data_file_path;
        public string data_file_text;
        //
        // top data
        public int people;
        public string symbol = "₪";
        //
        public Form1()
        {
            InitializeComponent();
            List_reload();
            
            // calculate people
            if (data_file_text == null)
            {
                people = 0;
            }
            else
            {
                foreach (string line in data_file_text.Split("\n"))
                {
                    people += 1;
                }
            }
            main_data1.Text = people.ToString();
            //
            
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
            data_file_path = "C:\\Users\\iliaz\\programfiles\\userdata\\data.txt";
            data_file_text = File.ReadAllText(data_file_path);
        }
        private void list_double_click(object sender, MouseEventArgs e)
        {

        }
    }
}