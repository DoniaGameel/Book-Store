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
    public partial class AddAdmin : Form
    {
        Controller controllerObj;
        public AddAdmin()
        {
            InitializeComponent();
        }

        private void AddAdmin_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
        }
        public bool isusername(string username)
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
        }
        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void housenumbertextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }
        private void addadminbutton_Click(object sender, EventArgs e)
        {
            if (firstnametextBox.Text == "First Name" || lastnametextBox.Text == "Last Name")
            {
                panel30.Visible = true;
                firstnametextBox.Focus();
                lastnametextBox.Focus();
                return;
            }
            if (isusername(usernametextbox.Text) || usernametextbox.Text == "Enter User name")
            {
                panel5.Visible = true;
                usernametextbox.Focus();
                return;
            }
            if (emailtextBox.Text == "E-mail")
            {
                panel10.Visible = true;
                emailtextBox.Focus();
                return;
            }
            if (passwordtextBox.Text == "Password" || passwordtextBox.Text == "")
            {
                panel8.Visible = true;
                passwordtextBox.Focus();
                return;
            }
            if (postalnumbertextBox.Text == "Postal Number")
            {
                panel15.Visible = true;
                postalnumbertextBox.Focus();
                return;
            }
            if (statetextBox.Text == "state" || citytextBox.Text == "City" || districttextBox.Text == "Disrtict" || streettextBox.Text == "Street" || housenumbertextBox.Text == "House Number")
            {
                panel26.Visible = true;
                statetextBox.Focus();
                citytextBox.Focus();
                streettextBox.Focus();
                districttextBox.Focus();
                housenumbertextBox.Focus();
                return;
            }
            if (countrycodetextBox.Text == "Country Code" || phonenumbertextBox.Text == "Phone Number")
            {
                panel19.Visible = true;
                countrycodetextBox.Focus();
                phonenumbertextBox.Focus();
                return;
            }
            int result = controllerObj.AddanAdmin(firstnametextBox.Text, lastnametextBox.Text, usernametextbox.Text, passwordtextBox.Text, emailtextBox.Text, statetextBox.Text, citytextBox.Text, districttextBox.Text, streettextBox.Text,Convert.ToInt32(housenumbertextBox.Text), postalnumbertextBox.Text, countrycodetextBox.Text, phonenumbertextBox.Text);
            if (result == 0)
            {
                MessageBox.Show("Adding an admin failed");
            }
            else
            {
                MessageBox.Show("you added an admin successfully!");
                //Form1 home = new Form1(usernametextbox.Text);
                //home.Show();
                //this.Hide();
            }
        }
        private void emailtextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (emailtextBox.Text == "")
                {
                    emailtextBox.Text = "E-mail";
                    emailtextBox.ForeColor = Color.Gray;
                    return;
                }
                emailtextBox.ForeColor = Color.White;
                panel10.Visible = false;
            }
            catch { }
        }
        private void firstnametextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (firstnametextBox.Text == "")
                {
                    firstnametextBox.Text = "First Name";
                    firstnametextBox.ForeColor = Color.Gray;
                    return;
                }
                firstnametextBox.ForeColor = Color.White;
                panel30.Visible = false;
            }
            catch { }
        }

        private void firstnametextBox_Click(object sender, EventArgs e)
        {
            firstnametextBox.SelectAll();
        }

        private void lastnametextBox_Click(object sender, EventArgs e)
        {
            lastnametextBox.SelectAll();
        }
        private void usernametextbox_Click(object sender, EventArgs e)
        {
            usernametextbox.SelectAll();
        }

        private void emailtextBox_Click(object sender, EventArgs e)
        {
            emailtextBox.SelectAll();
        }

        private void passwordtextBox_Click(object sender, EventArgs e)
        {
            passwordtextBox.SelectAll();
        }

        private void postalnumbertextBox_Click(object sender, EventArgs e)
        {
            postalnumbertextBox.SelectAll();
        }

        private void countrycodetextBox_Click(object sender, EventArgs e)
        {
            countrycodetextBox.SelectAll();
        }

        private void phonenumbertextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (phonenumbertextBox.Text == "")
                {
                    phonenumbertextBox.Text = "Phone Number";
                    phonenumbertextBox.ForeColor = Color.Gray;
                    return;
                }
                panel19.Visible = false;
                phonenumbertextBox.ForeColor = Color.White;
            }
            catch { }
        }

        private void code(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))

            {

                e.Handled = true;
                panel19.Visible = true;
                countrycodetextBox.Focus();
                return;
            }
        }

        private void phonenumbertextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void phone(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))

            {

                e.Handled = true;
                panel19.Visible = true;
                phonenumbertextBox.Focus();
                return;
            }
        }

        private void housenumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))

            {

                e.Handled = true;
                panel26.Visible = true;
                housenumbertextBox.Focus();
                return;
            }
        }

        private void postalnumer(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))

            {

                e.Handled = true;
                panel15.Visible = true;
                housenumbertextBox.Focus();
                return;
            }
        }

        private void postalnumbertextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
