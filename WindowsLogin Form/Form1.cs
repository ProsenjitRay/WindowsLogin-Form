using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsLogin_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void textuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void textpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            if (textuser.Text =="" && textpassword.Text =="")
            {
                MessageBox.Show("Please Enter Username and Password");
            }
            else
            {
                if (textuser.Text == "admin" && textpassword.Text == "1234")
                {
                    MessageBox.Show("You are Sucessfully Login");
                }
                else
                {
                    MessageBox.Show("Username and Password is incorrect");
                }
            }
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
