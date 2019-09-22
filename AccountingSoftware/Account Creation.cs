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
            Dictionary<string, string> dict = new Dictionary<string, string>();
            int RandomNumber(int min, int max)
            {
                Random random = new Random();
                return random.Next(min, max);
            }
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string path = @".\userandpass.csv";
            int salt = RandomNumber(1, 1000);
            string encryptedpassword = EncryptDecrypt(password, salt);
            dict.Add("Username: ", username);
            dict.Add("Password: ", password);
            dict.Add("Salt: ", salt.ToString());
            string dictcontent = dict.ToString();
            if (!File.Exists(path))
            {
                File.Create(path).Dispose();

                using (TextWriter tw = new StreamWriter(path))
                {
                    tw.WriteLine("File Created");
                }

            }
            else if (File.Exists(path))
            {
                using (TextWriter tw = new StreamWriter(path, append: true))
                {
                    foreach (KeyValuePair<string, string> item in dict)
                    {
                        tw.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
                    }
                }
                MessageBox.Show("Account Created Successfully");
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            UserDictionary<string, string> openWith = new UserDictionary<string, string>();
        }
    }
}
