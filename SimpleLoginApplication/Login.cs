using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleLoginApplication
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text=="Admin" && txtPassword.Text=="admin123")
            {
                Home hm = new Home();
                hm.Show();
                this.Hide();
                lblError.Text = "Successfully Logged In.";
            }
            else
            {
                lblError.Text = "Invalid Username or Password.";
            }
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
