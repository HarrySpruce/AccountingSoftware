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
        private void Login_Click(object sender, EventArgs e)
        {
            //creates username variable and password variable, both stored as strings
            string username;
            Dictionary<int, string> Usernames = new Dictionary<int, string>();
            Dictionary<int, string> Passwords = new Dictionary<int, string>();
            Usernames.Add(0, "Harry");
            Passwords.Add(0, "password");
            username = "harry";
            string password;
            string path = @"C:\Temp\userandpass.csv";
            string usernameandpasswordfull = System.IO.File.ReadAllText(path);
            password = "password";
            //the method of password storage will be changed in future in order for it to be more secure.
            //tests to see if the password is correct
            if (usernameTextbox.Text.ToLower() == Usernames[0].ToLower() && (passwordTextbox.Text == Passwords[0].ToLower()))
            {
                //shows that username and password are correct
                        MessageBox.Show("Username and password are Correct");
                        this.Hide();
                //opens form 3
                        Overview f3 = new Overview();
                        f3.ShowDialog();
            }
            else
            {
                MessageBox.Show("Username and/or password is Incorrect");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //opens form 4 on the admin button click.
            this.Hide();
            AdminCodeEntry f4 = new AdminCodeEntry();
            f4.ShowDialog();
        }
    }
}
