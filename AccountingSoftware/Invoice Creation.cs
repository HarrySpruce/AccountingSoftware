using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
namespace AccountingSoftware
{
    public partial class Form2 : Form
    {
        //Creates all public strings
        public string Notes;
        public string customerName;
        public string customerEmail;
        public string invoiceNumber;
        public DateTime DateTime1;
        public DateTime DateTime2;
        public string globalname1 = "";
        public string globalname2 = "";
        public string globalname3 = "";
        public string globalname4 = "";
        public Form2()
        {
            InitializeComponent();
        }

        public void Form2_Load(object sender, EventArgs e)
        {
            //Creates a table upon form load aswell as populating the table from files located in C:\Temp
            int NumberOfLines = 50;
            string[] ListLines = new string[NumberOfLines];
            string[] createText = { "Harry", "Jeff", "Micheal" };
            string path = @".\Names.txt";
            // Create a new file     
            using (FileStream fs = File.Create(@".\Names.txt"))
            {
                // Add some text to file    
                Byte[] title = new UTF8Encoding(true).GetBytes("");
                fs.Write(title, 0, title.Length);
            }

            //Checks to see if the file exists before creating one and populating it with data.
            if (!File.Exists(path))
            {
                File.WriteAllLines(path, createText, Encoding.UTF8);
            }
            TextReader tr = new StreamReader(@".\Names.txt");
            for (int i = 1; i < NumberOfLines; i++)
            {
                ListLines[i] = tr.ReadLine();
            }
            globalname1 = ListLines[1];
            globalname2 = ListLines[2];
            globalname3 = ListLines[3];
            DataTable dt = new DataTable();
            tr.Close();
            //creates columns in the table
            dt.Columns.Add("CustomerName");
            dt.Columns.Add("CustomerEmail");
            dt.Columns.Add("InvoiceNumber");
            dt.Columns.Add("InvoiceReference");
            dt.Columns.Add("InvoiceSent");
            dt.Columns.Add("InvoiceDue");
            dt.Columns.Add("Notes");

            dataGridView1.DataSource = dt;

        }
        public void Button1_Click(object sender, EventArgs e)
        {
            //Saves Content to External DB
            OleDbConnection con = new OleDbConnection("Data Source=Test.mdb");
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "Insert into Users(CustomerName , CustomerEmail, InvoiceNumber, InvoiceReference, InvoiceSent, InvoiceDue, Notes)Values('" + customerNameTextBox.Text + "','" + customerEmailTextBox.Text + "','" + invoiceNumberTextBox.Text + "','" + invoiceReferenceTextBox.Text + "','" + dateTimeSent.Text + "','" + dateTimeDue.Text + "','" + notesTextbox.Text + "')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Submitted");
            con.Close();
            string[] createText = { globalname1 + globalname2 + globalname3 };
            string path = @".\Names.txt";
            if (!File.Exists(path))
            {
                File.WriteAllLines(path, createText, Encoding.UTF8);
            }
            TextReader tr = new StreamReader(@".\Names.txt");
        }

        private void textBox1_Click(object sender, System.EventArgs e)
        {
            customerNameTextBox.Text = String.Empty;
        }
        private void textBox2_Click(object sender, EventArgs e)
        {
            customerEmailTextBox.Text = String.Empty;
        }
        private void textBox3_Click(object sender, EventArgs e)
        {
            invoiceNumberTextBox.Clear();
        }
        private void textBox4_Click(object sender, EventArgs e)
        {
            notesTextbox.Clear();
            notesTextbox.ForeColor = Color.Black;
        }

        private void saveButton2_Click(object sender, EventArgs e)
        {
        Notes = notesTextbox.Text;
        customerName = customerNameTextBox.Text;
        customerEmail = customerEmailTextBox.Text;
        invoiceNumber = invoiceNumberTextBox.Text;
            //if this doesnt work change it here
            string folderString = @"C:\Temp";
            System.IO.Directory.CreateDirectory(folderString);
            string strFilePath = @".\testfile.csv";
        string strSeperator = ",";
        StringBuilder sbOutput = new StringBuilder();

            string[][] inaOutput = new string[][]
            {
                new string[]{Notes},
                new string[]{customerName},
                new string[]{customerEmail},
                new string[]{invoiceNumber},
                new string[]{"************"}
            };
        int ilength = inaOutput.GetLength(0);
            for (int i = 0; i < ilength; i++)
                sbOutput.AppendLine(string.Join(strSeperator, inaOutput[i]));
            File.AppendAllText(strFilePath, sbOutput.ToString());
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime1 = dateTimeSent.Value;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime2 = dateTimeDue.Value;
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            invoiceReferenceTextBox.Clear();
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
