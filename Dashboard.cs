using System;
using System.Collections;
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
    public partial class Dashboard: Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Bppk_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult logout = MessageBox.Show("Are you sure you want to Log out?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (logout == DialogResult.Yes)
            {
                this.Hide();
                LogIn login = new LogIn();
                login.Show();
            } else
            {
                return;
            }
        }
        private void btnManage_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageBooksForm mb = new ManageBooksForm();
            mb.Show();
        }
    }
}

