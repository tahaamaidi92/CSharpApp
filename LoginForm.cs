using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TahaApplocation
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            string id = txtUserID.Text;
            string pass = txtpassword.Text;

            if (id == "taha" && pass == "1234")
            {
                this.Hide();

                Form1 f = new Form1();
                f.Show();
            }
            else
            {
                MessageBox.Show("Email or Password is incorrect...");
            }
        }
        private void ResetMyForm()
        {
            txtUserID.Text = "";
            txtpassword.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetMyForm();
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                Login();
            }
            if (e.KeyChar == (char)Keys.F1)
            {
                ResetMyForm();
            }
        }
    }
}
