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
    public partial class AddShippingCompany : Form
    {
        Controller controllerObj;
        string adminname;
        int id;
        public AddShippingCompany(string name)
        {
            controllerObj = new Controller();
            InitializeComponent();
            adminname = name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( textBox2.Text == ""|| textBox2.Text == " ")
            {
                panel2.Visible = true;
                textBox2.Focus();
                return;
            }
            if (textBox4.Text == ""|| textBox4.Text == " ")
            {
                panel1.Visible = true;
                textBox4.Focus();
                return;
            }
            int result = controllerObj.InsertCompany(textBox2.Text,adminname , textBox4.Text);
            DataTable dt = controllerObj.SelectCompanyId(textBox4.Text);
            DataRow r = dt.Rows[0];
            id = (int)r["Company_ID"];

            if (result == 0)
            {
                MessageBox.Show("The insertion of a new company failed");
            }
            else
            {
                MessageBox.Show("The row is inserted successfully!");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AddAddress_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "" || textBox6.Text == " ")
            {
                panel6.Visible = true;
                textBox6.Focus();
                return;
            }
            if (textBox7.Text == "" || textBox7.Text == " ")
            {
                panel7.Visible = true;
                textBox7.Focus();
                return;
            }
            if (textBox8.Text == "" || textBox8.Text == " ")
            {
                panel8.Visible = true;
                textBox8.Focus();
                return;
            }
            if (textBox9.Text == "" || textBox9.Text == " ")
            {
                panel9.Visible = true;
                textBox9.Focus();
                return;
            }
            if (textBox10.Text == "" || textBox10.Text == " ")
            {
                panel10.Visible = true;
                textBox10.Focus();
                return;
            }
            int result = controllerObj.InsertCompanyAddress(id,textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text,textBox10.Text);
            

            if (result == 0)
            {
                MessageBox.Show("The insertion of a new company address failed");
            }
            else
            {
                MessageBox.Show("The row is inserted successfully!");
            }
        }

        private void AddShippingCompany_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox11.Text == "" || textBox11.Text == " ")
            {
                panel11.Visible = true;
                textBox11.Focus();
                return;
            }
            if (textBox12.Text == "" || textBox12.Text == " ")
            {
                panel12.Visible = true;
                textBox12.Focus();
                return;
            }

            int result = controllerObj.InsertCompanyPhone(id, textBox11.Text, textBox12.Text);


            if (result == 0)
            {
                MessageBox.Show("The insertion of a company phone number failed");
            }
            else
            {
                MessageBox.Show("The row is inserted successfully!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "" || textBox3.Text == " ")
            {
                panel3.Visible = true;
                textBox3.Focus();
                return;
            }
            if (textBox1.Text == "" || textBox1.Text == " ")
            {
                panel4.Visible = true;
                textBox1.Focus();
                return;
            }
            if (textBox5.Text == "" || textBox5.Text == " ")
            {
                panel5.Visible = true;
                textBox5.Focus();
                return;
            }
            int result = controllerObj.InsertCompanyDest(id, textBox5.Text, float.Parse(textBox3.Text),Convert.ToInt32(textBox1.Text));


            if (result == 0)
            {
                MessageBox.Show("The insertion of a new company destination failed");
            }
            else
            {
                MessageBox.Show("The row is inserted successfully!");
            }
        }

        private void housenumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))

            {
               
                e.Handled = true;
                panel10.Visible = true;
                textBox10.Focus();
                return;
            }
           
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void code(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))

            {

                e.Handled = true;
                panel11.Visible = true;
                textBox11.Focus();
                return;
            }
        }

        private void phone(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))

            {

                e.Handled = true;
                panel12.Visible = true;
                textBox12.Focus();
                return;
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void price(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))

            {
                e.Handled = true;
                panel3.Visible = true;
                textBox3.Focus();
                return;
            }
        }

        private void period(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))

            {
                e.Handled = true;
                panel4.Visible = true;
                textBox1.Focus();
                return;
            }
        }
    }
}
