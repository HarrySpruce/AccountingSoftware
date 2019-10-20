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
            Form1 f1 = new Form1();
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

        private void darkMode_CheckedChanged(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            Form2 f2 = new Form2();
            
            if (dark == true)
            {
                dark = false;
                this.BackColor = Color.FromArgb(236, 233, 216);
                f1.BackColor = Color.FromArgb(236, 233, 216);
                f2.BackColor = Color.FromArgb(236, 233, 216);
            }
            else
            {

                this.BackColor = Color.FromArgb(75, 75, 75);
                f1.BackColor = Color.FromArgb(75, 75, 75);
                f2.BackColor = Color.FromArgb(75, 75, 75);
                dark = true;
            }
        }
    }
}
