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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblHello.Text = "Hello World !!!";
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            lblHello.Text = "Hello World Again !!!";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lblHello.Text = "Text has been delete !!!";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();

            LoginForm login = new LoginForm();
            login.Show();
        }
    }
}
