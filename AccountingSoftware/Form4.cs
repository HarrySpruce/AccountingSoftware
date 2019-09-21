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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
        }
        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            //In case windows is trying to shut down, don't hold the process up
            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            if (this.DialogResult == DialogResult.Cancel)
            {

                // Assume that X has been clicked and act accordingly.
                // Confirm user wants to close
                switch (MessageBox.Show(this, "Are you sure?", "You will return to the login menu.", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    //Stay on this form
                    case DialogResult.No:
                        e.Cancel = true;
                        break;
                    default:
                        break;
                }
            }
            //need to find whats wrong when putting the Form swapper in the if statment.
            else
            {
                this.Hide();
                Form1 f1 = new Form1();
                f1.ShowDialog();
            }
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            bool PasswordText = false;
            if (adminCode.Text == "0405")
            {
                PasswordText = true;
            }
            if (PasswordText == true)
            {
                Form6 f6 = new Form6();
                f6.ShowDialog();
            }
        }
    }

}
