using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class ChangeUserPassword : Form
    {
        Controller controllerObj;
        string username;
        public ChangeUserPassword(string name)
        {
            InitializeComponent();
            username = name;
            controllerObj = new Controller();
        }

        public bool rightuserpassword(string username, string password)
        {
            string pass = controllerObj.passwordofusername(username);
            if (pass == password)
                return true;
            else
                return false;
        }
        private void ChangeUserPassword_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Current Password" || textBox1.Text == "" || !rightuserpassword(username, textBox1.Text))
            {
                panel5.Visible = true;
                textBox1.Focus();
                return;
            }
            if (textBox2.Text == "New Password" || textBox2.Text == "")
            {
                panel1.Visible = true;
                textBox2.Focus();
                return;
            }
            controllerObj = new Controller();
            int result = controllerObj.SetUserPW(username, textBox1.Text, textBox2.Text);
            if (result == 0)
            {
                MessageBox.Show("Something get wrong, please try again.");
            }
            else
            {
                MessageBox.Show("Your Password has changed successfully!");
            }

        }
    }
}
