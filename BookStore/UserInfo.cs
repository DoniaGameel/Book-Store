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
    public partial class UserInfo : Form
    {
        Controller controllerObj;
        public UserInfo(string username)
        {
            InitializeComponent();
            controllerObj = new Controller();
            string Name = "";
            string Phone="";
            DataTable UserInfo = controllerObj.SelectUserInfoD(username);
            if (UserInfo != null)
            {
                if (UserInfo.Rows[0][0] != null)
                {
                    //Fname
                    Name = UserInfo.Rows[0][0].ToString();
                    if (UserInfo.Rows[0][1] != null)
                    {
                        Name += " ";
                        //Lname
                        Name += UserInfo.Rows[0][1].ToString();
                    }
                }
                if (UserInfo.Rows[0][2] != null)
                {
                    if (UserInfo.Rows[0][2].ToString() == "null")
                        Email.Text = "not Available";
                    else
                        Email.Text = UserInfo.Rows[0][2].ToString();
                }

                if (UserInfo.Rows[0][3] != null)
                {
                    if (UserInfo.Rows[0][3].ToString() == "null")
                        State.Text = "not Available";
                    else
                        State.Text = UserInfo.Rows[0][3].ToString();
                }

                if (UserInfo.Rows[0][4] != null)
                {
                    if (UserInfo.Rows[0][4].ToString() == "null")
                        City.Text = "not Available";
                    else
                        City.Text = UserInfo.Rows[0][4].ToString();
                }

                
                if (UserInfo.Rows[0][5] != null)
                {
                    Phone = UserInfo.Rows[0][5].ToString();
                    if (UserInfo.Rows[0][6] != null)
                    {
                        Phone += "-";
                        Phone += UserInfo.Rows[0][6].ToString();
                    }
                }
            }
            AuthorName.Text = Name;
            if (AuthorName.Text == "")
                AuthorName.Text = "not Available";
            textBox1.Text = Phone;
            if (textBox1.Text == "")
                textBox1.Text = "not Available";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
