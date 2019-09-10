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

namespace AccountingSoftware
{
    public partial class Form2 : Form
    {
        public string globalname1 = "";
        public string globalname2 = "";
        public string globalname3 = "";
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
            string path = @"C:\Temp\Names.txt";
            // Create a new file     
            using (FileStream fs = File.Create(@"C:\Temp\Names.txt"))
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
            TextReader tr = new StreamReader(@"C:\Temp\Names.txt");
            for (int i = 1; i < NumberOfLines; i++)
            {
                ListLines[i] = tr.ReadLine();
            }
            globalname1 = ListLines[1];
            globalname2 = ListLines[2];
            globalname3 = ListLines[3];
            DataTable dt = new DataTable();
            tr.Close();
     
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Date of Birth");

            dt.Rows.Add("01", globalname1);
            dt.Rows.Add("02", globalname2);
            dt.Rows.Add("03", globalname3);
            
            
            dataGridView1.DataSource = dt;

        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        public void Button1_Click(object sender, EventArgs e)
        {
            int NumberOfLines = 50;
            string[] createText = { globalname1 + globalname2 + globalname3 };
            string path = @"C:\Temp\Names.txt";
            if (!File.Exists(path))
            {
                File.WriteAllLines(path, createText, Encoding.UTF8);
            }
            TextReader tr = new StreamReader(@"C:\Temp\Names.txt");
        }
    }
}
