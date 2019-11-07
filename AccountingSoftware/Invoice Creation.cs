using System;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Diagnostics;
namespace AccountingSoftware
{
    public partial class Form2 : Form
    {
        //Creates all public strings
        public string Notes;
        public string customerName;
        public string customerEmail;
        public string invoiceNumber;
        public DateTime DateTime1;
        public DateTime DateTime2;
        public string globalname1 = "";
        public string globalname2 = "";
        public string globalname3 = "";
        public string globalname4 = "";

        public Form2()
        {
            InitializeComponent();
        }

        public void InvoiceCreationForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'users._Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.users._Users);

            DataTable dt = new DataTable();

            //creates columns in the table
            dt.Columns.Add("CustomerName");
            dt.Columns.Add("CustomerEmail");
            dt.Columns.Add("InvoiceNumber");
            dt.Columns.Add("InvoiceReference");
            dt.Columns.Add("InvoiceSent");
            dt.Columns.Add("InvoiceDue");
            dt.Columns.Add("Notes");
        }
        public void Button1_Click(object sender, EventArgs e)
        {

            //Saves Content to External DB
            string dsn = "DSN=AccountingSoftware";
            string insCmd = "Insert into Users(CustomerName , CustomerEmail, InvoiceNumber, InvoiceReference, InvoiceSent, InvoiceDue, Notes)Values('" + customerNameTextBox.Text + "','" + customerEmailTextBox.Text + "','" + invoiceNumberTextBox.Text + "','" + invoiceReferenceTextBox.Text + "','" + dateTimeSent.Text + "','" + dateTimeDue.Text + "','" + notesTextbox.Text + "')";
            MessageBox.Show(insCmd);
            OdbcCommand command = new OdbcCommand(insCmd);
            invoiceTable.Update();
            using (OdbcConnection connection = new OdbcConnection(dsn))
            {
                command.Connection = connection;
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                connection.Dispose();
            }
            this.usersTableAdapter.Fill(this.users._Users);
            invoiceTable.Update();
            invoiceTable.Refresh();
        }

        private void textBox1_Click(object sender, System.EventArgs e)
        {
            customerNameTextBox.Text = String.Empty;
        }
        private void textBox2_Click(object sender, EventArgs e)
        {
            customerEmailTextBox.Text = String.Empty;
        }
        private void textBox3_Click(object sender, EventArgs e)
        {
            invoiceNumberTextBox.Clear();
        }
        private void textBox4_Click(object sender, EventArgs e)
        {
            notesTextbox.Clear();
            notesTextbox.ForeColor = Color.Black;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime1 = dateTimeSent.Value;
        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime2 = dateTimeDue.Value;
        }
        private void textBox5_Click(object sender, EventArgs e)
        {
            invoiceReferenceTextBox.Clear();
        }
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void returnLogin1(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm f1 = new LoginForm();
            f1.ShowDialog();
        }
    }
}
