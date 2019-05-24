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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            string username;
            username = "harry";
            string password;
            password = "password";
            if (Username.Text.ToLower() == username) 
            {
                if (Password.Text == password)
                {
                    MessageBox.Show("Username and password are Correct");
                    this.Hide();
                    Form2 f2 = new Form2();
                    f2.ShowDialog();
                } 
            }
        }
    }
}
