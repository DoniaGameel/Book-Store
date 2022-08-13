﻿using System;
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
    public partial class BookDetails : Form
    {
        Controller controllerObj;
        string username;
        string seller;
        string ISBNN;
        DataTable AuthorDT;
        DataTable dt3;
        public BookDetails(string name , string ISBN , string user_name)
        {
            InitializeComponent();
            username = user_name;
            seller = name;
            ISBNN = ISBN;
            this.ISBNTextBox.Text = ISBN;
            controllerObj = new Controller();
            DataTable dt = controllerObj.AllSell(name, ISBN);
            Title.Text = dt.Rows[0][1].ToString();
            if (Title.Text == "")
                Title.Text = "not Available";
            categoryTextBox.Text = dt.Rows[0][2].ToString();
            if (categoryTextBox.Text == "")
                categoryTextBox.Text = "not Available";
            LangTextBox.Text = dt.Rows[0][6].ToString();
            if (LangTextBox.Text == "")
                LangTextBox.Text = "not Available";
            NumPg.Text = dt.Rows[0][5].ToString();
            if (NumPg.Text == "")
                NumPg.Text = "not Available";
            EditionTextBox.Text = dt.Rows[0][7].ToString();
            if (EditionTextBox.Text == "")
                EditionTextBox.Text = "not Available";
            Price.Text = dt.Rows[0][11].ToString();
            if (Price.Text == "")
                Price.Text = "not Available";
            CountTextBox.Text = dt.Rows[0][4].ToString();
            if (CountTextBox.Text == "")
                CountTextBox.Text = "not Available";
            Information.Text = dt.Rows[0][8].ToString();
            if (Information.Text == "")
                Information.Text = "not Available";
            if (dt.Rows[0][3].ToString() != "")
            {
                string path = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);
                pictureBox1.Image = Image.FromFile(path + dt.Rows[0][3].ToString());
            }
            string AuthorID = dt.Rows[0][12].ToString();
            int x = 0;
            string AuthorName="";
            
            bool b=Int32.TryParse(AuthorID, out x);
            AuthorDT = controllerObj.Author(x);

            if (AuthorDT != null)
            {
                if (AuthorDT.Rows[0][0] != null)
                {
                    AuthorName = AuthorDT.Rows[0][0].ToString();
                    if (AuthorDT.Rows[0][1] != null)
                    {
                        AuthorName += " ";
                        AuthorName += AuthorDT.Rows[0][1].ToString();
                    }
                }
            }
            AuthorTextBox.Text = AuthorName;
            if (AuthorTextBox.Text == "")
                AuthorTextBox.Text = "not Available";

            if (AuthorDT == null)
            {
                button1.Visible = false;
            }
            string PublisherID = dt.Rows[0][13].ToString();
            int y= 0;
            string PublisherName = "";
            Int32.TryParse(PublisherID, out y);
            dt3 = controllerObj.Publisher(y);
            if (dt3 != null)
            if (dt3.Rows[0][1] != null)
            {
                PublisherName = dt3.Rows[0][1].ToString();
            }
            PublisherTextBox.Text = PublisherName;
            if (PublisherTextBox.Text == "")
                PublisherTextBox.Text = "not Available";
            if (dt3 == null)
            {
                button2.Visible = false;
            }
        }

        private void BookDetails_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AuthorInfo authorIn = new AuthorInfo(AuthorDT);
            authorIn.Show();
            
        }

        private void AuthorTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            publiherInfo PublishInfo = new publiherInfo(dt3);
            PublishInfo.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BuyAbook frm = new BuyAbook(username, seller, ISBNN);
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserInfo frmm = new UserInfo(seller);
            frmm.Show();
        }
    }
}
