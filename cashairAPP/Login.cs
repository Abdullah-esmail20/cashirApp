using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cashairAPP
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtUser.Text == "Admin" && txtPass.Text == "123")
            {
                pnlLogin.Visible = false;
                Form fr1 = new homeBage();
                fr1.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("خطأ في البيانات");
            }
        }
    }
}
