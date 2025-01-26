using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPT_391_Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Load(object sender, EventArgs e)
        {
            btnLogin.Dock = DockStyle.Right | DockStyle.Left;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            try { 
                //accessing db to sign in
            }
            catch (Exception){}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register registrationWindow = new Register();
            registrationWindow.Show();
            this.Hide();
        }
    }
}
