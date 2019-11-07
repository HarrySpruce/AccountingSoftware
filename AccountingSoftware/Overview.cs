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
    public partial class Overview : Form
    {
        bool dark = false;
        public Overview()
        {
            InitializeComponent();
        }
        private void Overview_Load(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void returnLogin(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm f1 = new LoginForm();
            f1.ShowDialog();
        }

        private void adminCodeEntry(object sender, EventArgs e)
        {
            this.Hide();
            AdminCodeEntry codeform = new AdminCodeEntry();
            codeform.ShowDialog();
        }
        private void ExitLeave(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
