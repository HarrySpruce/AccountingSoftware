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
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int NumberOfLines = 50;
            string[] ListLines = new string[NumberOfLines];
            string[] createText = { "Harry", "Jeff", "Micheal" };
            string path = @"C:\Temp\Names.txt";
            if (!File.Exists(path))
            {
                File.WriteAllLines(path, createText, Encoding.UTF8);
            }
            TextReader tr = new StreamReader(@"C:\Temp\Names.txt");
            for (int i = 1; i < NumberOfLines; i++)
            {
                ListLines[i] = tr.ReadLine();
            }
            string name1 = ListLines[1];
            string name2 = ListLines[2];
            string name3 = ListLines[3];
            DataTable dt = new DataTable();
            tr.Close();
     
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Date of Birth");

            dt.Rows.Add("01", name1);
            dt.Rows.Add("02", name2);
            dt.Rows.Add("03", name3);

            dataGridView1.DataSource = dt;

        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
