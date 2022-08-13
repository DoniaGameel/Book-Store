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
    public partial class AddSeminars : Form
    {
        Controller controllerObj; 
        public AddSeminars()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxtopic.Text == "Seminar topic" || textBoxtopic.Text == " "|| textBoxtopic.Text == "")
            {
                paneltopic.Visible = true;
                textBoxtopic.Focus();
                return;
            }

            //if (textBoxdetails.Text == "Seminar details" || textBoxdetails.Text == " " || textBoxdetails.Text == "")
            //{
            //    paneldetails.Visible = true;
            //    textBoxtopic.Focus();
            //    return;
            //}
            if (textBoxstate.Text == "State" || textBoxstate.Text == " " || textBoxstate.Text == "")
            {
                panelstate.Visible = true;
                textBoxstate.Focus();
                return;
            }
            if (textBoxcity.Text == "City" || textBoxcity.Text == " " || textBoxstate.Text == "")
            {
                panelcity.Visible = true;
                textBoxcity.Focus();
                return;
            }
            if (textBoxdistinct.Text == "City" || textBoxdistinct.Text == " " || textBoxdistinct.Text == "")
            {
                paneldistinct.Visible = true;
                textBoxdistinct.Focus();
                return;
            }
            if (textBoxstreet.Text == "City" || textBoxstreet.Text == " " || textBoxstreet.Text == "")
            {
                panelstreet.Visible = true;
                textBoxstreet.Focus();
                return;
            }
            if (textBoxhousenumber.Text == "City" || textBoxhousenumber.Text == " " || textBoxhousenumber.Text == "")
            {
                panelhousenumber.Visible = true;
                textBoxhousenumber.Focus();
                return;
            }
            controllerObj = new Controller();
            int result = controllerObj.AddaSeminar(textBoxtopic.Text, dateTimePicker1.Text, textBoxdetails.Text, textBoxstate.Text, textBoxcity.Text, textBoxdistinct.Text, textBoxstreet.Text, textBoxhousenumber.Text);
            if (result == 0)
            {
                MessageBox.Show("The insertion of a new seminar failed");
            }
            else
            {
                MessageBox.Show("The row is inserted successfully!");
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void housenumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))

            {

                e.Handled = true;
                panelhousenumber.Visible = true;
                textBoxhousenumber.Focus();
                return;
            }
        }
    }
}
