using System;
using System.Windows.Forms;

namespace Money_Tracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            //The password is "123456789", it's saved in the setting of the project 
            if (PasswordInput.Text == Properties.Settings.Default.password)
            {
                //when the button is clicked
                MainForm main = new MainForm();
                main.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("ACCESS DENIED!");
                PasswordInput.Clear();
            }
        }
    }
}
