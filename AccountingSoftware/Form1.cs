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
using System.Text;
using System.Windows;

namespace AccountingSoftware
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //creates the form and sets the acceptButton to a variable named loginButton
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
            //creates username variable and password variable, both stored as strings
            string username;
            username = "harry";
            string password;
            string x;
            string path = @"C:\Temp\userandpass.csv";
            string usernameandpasswordfull = System.IO.File.ReadAllText(path);
            string GetLine(string text, int lineNo)
            {
                string[] lines = text.Replace("\r", "").Split('\n');
                return lines.Length >= lineNo ? lines[lineNo - 1] : null;
            }
            password = "password";

            MessageBox.Show(usernameandpasswordfull);
            //the method of password storage will be changed in future in order for it to be more secure.
            //tests to see if the password is correct
            if (usernameTextbox.Text.ToLower() == username && (passwordTextbox.Text == password))
            {
                //shows that username and password are correct
                        MessageBox.Show("Username and password are Correct");
                        this.Hide();
                //opens form 3
                        Overview f3 = new Overview();
                        f3.ShowDialog();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //opens form 4 on the admin button click.
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void createUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            accountCreation f5 = new accountCreation();
            f5.ShowDialog();
        }
    }
}
