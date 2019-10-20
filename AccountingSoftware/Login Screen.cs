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
        int IncorrectAttempts = 0;
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


        private Dictionary<string, string> loadUserNames()
        {
            string path = @"C:\temp\Users.txt";
            // Create a new file     
            string[] lines = System.IO.File.ReadAllLines(path);

            Dictionary<string,string> credentials = new Dictionary<string, string>();
            foreach (string line in lines)
            {
               string[] bits = line.Split(',');
               string un = bits[0];
               string pw = bits[1];
               credentials.Add(un, pw);
            }
            return credentials;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            int incorrectAttempts = 0;

            Dictionary<string, string> usernameDictionary = loadUserNames();
            string pw = "";
            usernameDictionary.TryGetValue(usernameTextbox.Text, out pw);
            if (usernameDictionary.ContainsKey(usernameTextbox.Text) && passwordTextbox.Text == pw)
            {
                MessageBox.Show("Correct Password Entered");
                this.Hide();
                Overview f3 = new Overview();
                f3.ShowDialog();
            }
            else
            {
                MessageBox.Show("Incorrect Password Entered try again");
                incorrectAttempts = incorrectAttempts + 1;
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
