using System;
using System.Windows.Forms;

namespace Money_Tracker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //load the data from database in the data grid
            this.moneyTrackerTableAdapter.Fill(this.dataSet1.MoneyTracker);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            //Save data in variables
            decimal transactionValue = Convert.ToDecimal(transAmountBox.Text);
            string description = DescriptionBox.Text;
            DateTime data = dateTime.Value;
            int TransType = 0;

            if (Payment.Checked)
                TransType = 0;

            if (Income.Checked)
                TransType = 1;

            //Insert data in sql table
            DataSet1TableAdapters.MoneyTrackerTableAdapter MyAdapter = new DataSet1TableAdapters.MoneyTrackerTableAdapter();
            MyAdapter.InsertTransction(transactionValue, description, data, Convert.ToBoolean(TransType));
            this.moneyTrackerTableAdapter.Fill(this.dataSet1.MoneyTracker);
        }

        private void transAmountBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Limit the user to insert only decimal numbers
            char ch = e.KeyChar;
            if (ch == 46 && transAmountBox.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
