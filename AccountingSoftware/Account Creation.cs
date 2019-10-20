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
using System.Security.Cryptography;

namespace AccountingSoftware
{
    public partial class accountCreation : Form
    {
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        public string EncryptDecrypt(string szPlainText, int szEncryptionKey)
        {
            StringBuilder szInputStringBuild = new StringBuilder(szPlainText);
            StringBuilder szOutStringBuild = new StringBuilder(szPlainText.Length);
            char Textch;
            for (int iCount = 0; iCount < szPlainText.Length; iCount++)
            {
                Textch = szInputStringBuild[iCount];
                Textch = (char)(Textch ^ szEncryptionKey);
                szOutStringBuild.Append(Textch);
            }
            return szOutStringBuild.ToString();
        }
        public accountCreation()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string newuser = usernameTextBox.Text;
            string newpass = passwordTextBox.Text;
            string[] both = { newuser + "," + newpass };
            System.IO.File.AppendAllLines(@"C:\Temp\Users.txt", both);

            MessageBox.Show("Account Created Successfully");
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            UserDictionary<string, string> openWith = new UserDictionary<string, string>();
        }
    }
}
