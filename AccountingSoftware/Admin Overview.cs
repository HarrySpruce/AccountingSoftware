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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            string path = @"C:\Temp\userandpass.csv";
            label1.Text = System.IO.File.ReadAllText(path);
        }

        private void createUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            accountCreation f5 = new accountCreation();
            f5.ShowDialog();
        }
    }
}
