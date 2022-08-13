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
    public partial class PublisherAddress : Form
    {
        
        Controller c;
        int id;
        int nn;
        int aa;
        public PublisherAddress(int pid)
        {
            c = new Controller();
            InitializeComponent();
            id = pid;
            nn = 0;
            aa = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty( PS.Text.Trim()))
            {
                MessageBox.Show("Please Enter State Name ");
            }
            if (string.IsNullOrEmpty(PD.Text.Trim()))
            {
                MessageBox.Show("Please Enter District Name");
            }
             if (string.IsNullOrEmpty(PC.Text.Trim()))
            {
                MessageBox.Show("Please Enter City Name");
            }
             if (string.IsNullOrEmpty(PST.Text.Trim()))
            {
                MessageBox.Show("Please Enter Street Name");
            }
            if (!string.IsNullOrEmpty(PS.Text.Trim())&&!string.IsNullOrEmpty( PD.Text.Trim())&&!string.IsNullOrEmpty(PC.Text.Trim())&&!string.IsNullOrEmpty(PST.Text.Trim()))
            {
                int v;
                bool f = int.TryParse(PH.Text, out v);
                dataGridView1.Rows.Add(PS.Text, PD.Text, PC.Text, PST.Text, PH.Text);
                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
                if (!isfound1(PS.Text, PC.Text, PD.Text, PST.Text, PH.Text))
                {
                    c.InsertPublisherAddress(id, PS.Text, PD.Text, PC.Text, PST.Text, v);
                    aa = 1;
                        MessageBox.Show("The Publisher Address Is Recordered");
                   
                }
               
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
       {

        }

        private void PublisherAddress_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(PCC.Text, PPN.Text);
            dataGridView2.FirstDisplayedScrollingRowIndex = dataGridView2.RowCount - 1;
            if (string.IsNullOrEmpty(PPN.Text.Trim()))
                MessageBox.Show("Please Enter Phone Number");
            if (PPN.Text.Trim()!=null)
                if (!string.IsNullOrEmpty(PPN.Text.Trim()))
                {
                    c.InsertPublisherPhoneNumber(id, PCC.Text, PPN.Text);
                    nn = 1;
                        MessageBox.Show("The Publisher Phone Number Is Recordered");
                   
                }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public bool isfound1(string sta,string ci,string d,string str,string h)
        {
            DataTable dt = c.SelectPublisherAddress();
            bool exists = false;
            if (dt!=null)
            foreach (DataRow row in dt.Rows)
            {
                if (row["P_State"].ToString().ToLower().Trim() == sta&&row["P_City"].ToString().ToLower().Trim() ==ci&&row["P_State"].ToString().ToLower().Trim() ==sta&&row["P_Distinct"].ToString().ToLower().Trim() ==d&&row["P_Street"].ToString().ToLower().Trim() ==str&&row["P_HouseNumber"].ToString().ToLower().Trim() ==h)
                {
                    exists = true;
                }
            }
            return exists;
        }
        public bool isfound2(string phone)
        {
            DataTable dt = c.SelectPublisherPhone();
            bool exists = false;
       
            foreach (DataRow row in dt.Rows)
            {
                if (row["PhoneNumber"].ToString().ToLower().Trim() == phone)
                {
                    exists = true;
                }
            }
            return exists;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (aa == 1 && nn == 1 && !string.IsNullOrEmpty(PPN.Text.Trim()) && !string.IsNullOrEmpty(PS.Text.Trim()) && !string.IsNullOrEmpty(PD.Text.Trim()) && !string.IsNullOrEmpty(PC.Text.Trim()) && !string.IsNullOrEmpty(PST.Text.Trim()))
            {
                this.Hide();
            }
            else
                MessageBox.Show("Please Add informations first");
        }
   }
}
