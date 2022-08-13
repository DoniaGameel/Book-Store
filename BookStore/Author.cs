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
    public partial class Author : Form
    {
        Controller c;
        Publisher P;
        string us;
        string ispn;
        int Aid;
        char w;
        public Author()
        {
            
            c = new Controller();
            InitializeComponent();
        }
        public Author(string s1,string s2,char t)
        {
            c = new Controller();
            InitializeComponent();
            us = s1;
            ispn = s2;
            w = t;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AAFN.Text.Trim()))
            {
                MessageBox.Show("Please Enter Author First Name ");
            }
            if (string.IsNullOrEmpty(AALN.Text.Trim()))
            {
                MessageBox.Show("Please Enter Author Last Name");
            }
            if (!string.IsNullOrEmpty(AAFN.Text.Trim())&& !string.IsNullOrEmpty(AALN.Text.Trim()))
            {
                if (!isfound(AAFN.Text, AALN.Text, AACOB.Text, AAN.Text))
                {
                  int result=  c.InsertAuthor(AAFN.Text, AALN.Text, Convert.ToDateTime(dateTimePicker1.Text), AACOB.Text, AAN.Text, AAA.Text);
       
                      MessageBox.Show("The Author Is Recordered");
                  
                }
                    DataTable dt = c.SelectAuthorID(AAFN.Text, AALN.Text, Convert.ToDateTime(dateTimePicker1.Text), AACOB.Text, AAN.Text, AAA.Text);
                DataRow r = dt.Rows[0];
                Aid = (int)r["Author_ID"];
                if (P == null)
                {
                    P = new Publisher(us, ispn, Aid,w);
                    P.Show();
                }
                else
                {
                    P.Show();
                    P.Focus();
                   
                }
                this.Hide();
            }
            
           
            
        }
       
        public bool isfound(string fn, string ln,string cb,string an)
        {

            DataTable dt = c.SelectAuthor();
            bool exists = false;
            foreach (DataRow row in dt.Rows)
            {
                if (row["Fname"].ToString().ToLower().Trim() ==fn && row["Lname"].ToString().ToLower().Trim() ==ln&&row["CityOfBirth"].ToString().ToLower().Trim() ==cb&&row["Nationality"].ToString().ToLower().Trim() ==an)
                {
                    exists = true;
                }
            }
            return exists;
        }
    }
}
