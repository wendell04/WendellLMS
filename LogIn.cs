using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class LogIn: Form
    {
        public LogIn()
        {
            InitializeComponent();
            passtxt.PasswordChar = '*';
        }

        private void LogInbtn_Click(object sender, EventArgs e)
        {
            string un = untxt.Text;
            string pw = passtxt.Text;

            if (un == "admin" && pw == "123")
            {
                this.Hide();
                Dashboard db = new Dashboard();
                db.Show();
            } else
            {
                MessageBox.Show("Invalid username or password.", "Login Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked)
            { 
                passtxt.PasswordChar = '\0'; 
            } else
            {
                passtxt.PasswordChar = '*'; 
            }
        }

        private void SignUpbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp su = new SignUp();
            su.Show();
        }
    }
}