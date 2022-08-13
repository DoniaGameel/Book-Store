using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.AdminForms
{
    public partial class ChangeYourPassword : Form
    {
        Controller controllerObj;
        string username;
        public ChangeYourPassword(string name)
        {
            InitializeComponent();
            username = name;
            controllerObj = new Controller();
        }
        public bool rightAdminpassword(string username, string password)
        {
            string pass = controllerObj.passwordofusernameadmin(username);
            if (pass == password)
                return true;
            else
                return false;
        }
        /*public bool isAdminusername(string username)
        {
            DataTable dt = controllerObj.usernameadmin();
            bool exists = false;
            foreach (DataRow row in dt.Rows)
            {
                if (row["username"].ToString().ToLower().Trim() == username)
                {
                    exists = true;
                }
            }
            return exists;
        }*/
        private void passwordtextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox1.ForeColor = Color.White;
                textBox1.PasswordChar = '*';
                textBox2.ForeColor = Color.White;
                textBox2.PasswordChar = '*';
                panel1.Visible = false;
                panel5.Visible = false;
            }
            catch { }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "Current Password" || textBox1.Text == "" || !rightAdminpassword(username, textBox1.Text))
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
            int result = controllerObj.SetNewAdminPW(username, textBox1.Text, textBox2.Text);
            if (result == 0)
            {
                MessageBox.Show("Something get wrong, please try again.");
            }
            else
            {
                MessageBox.Show("Your Password has changed successfully!");
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox1.ForeColor = Color.Black;
                textBox1.PasswordChar = '*';
                panel5.Visible = false;
            }
            catch { }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
               
                textBox2.ForeColor = Color.Black;
                textBox2.PasswordChar = '*';
                panel5.Visible = false;
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "Current Password" || textBox1.Text == "" || !rightAdminpassword(username, textBox1.Text))
            {
                panel5.Visible = true;
                textBox1.Focus();
                return;
            }
            if (textBox1.Text == "New Password" || textBox1.Text == "")
            {
                panel1.Visible = true;
                textBox2.Focus();
                return;
            }
            controllerObj = new Controller();
            int result = controllerObj.SetNewAdminPW(username, textBox1.Text, textBox2.Text);
            if (result == 0)
            {
                MessageBox.Show("Something get wrong, please try again.");
            }
            else
            {
                MessageBox.Show("Your Password has changed successfully!");
            }

        }

        private void ChangeYourPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
