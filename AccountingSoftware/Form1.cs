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


        private void Form1_Load(object sender, EventArgs e)
        {
            Form form1 = new Form();
            form1.AcceptButton = loginButton;
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
            if (usernameTextbox.Text.ToLower() == username) 
            {
                if (passwordTextbox.Text == password)
                {
                    MessageBox.Show("Username and password are Correct");
                    this.Hide();
                    Overview f3 = new Overview();
                    f3.ShowDialog();
                } 
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }
    }
}
