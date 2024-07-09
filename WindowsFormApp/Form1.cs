using System;
using System.Windows.Forms;

namespace WindowsFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            // For simplicity, just display the entered username and password
            MessageBox.Show($"Username: {username}\nPassword: {password}");
        }
    }
}
