using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Date of Birth");

            dt.Rows.Add("01", "Harry");
            dt.Rows.Add("02", "jeff");
            dt.Rows.Add("03", "Micheal");

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
