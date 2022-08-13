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
    public partial class Lend : Form
    {
        Controller c;
        Author a ;
        string Lp;
      public  bool ls;
      string name;
        public Lend()
        {
            
            c = new Controller();
            InitializeComponent();
        }
        public Lend(string n)
        {
            name = n;
            c = new Controller();
            InitializeComponent();
            ls = true;
        }





        private void LInsertAuthorInformation_Click(object sender, EventArgs e)
        {
            int v1, v2, v3, v4;
            bool f1 = int.TryParse(LLendingPeriod.Text, out v1);
            bool f2 = int.TryParse(LNoB.Text, out v2);
            bool f3 = int.TryParse(LNoE.Text, out v3);
            bool f4 = int.TryParse(LNoBP.Text, out v4);
            if (string.IsNullOrEmpty(LLendingPeriod.Text.Trim())|| !f1)
            {
                MessageBox.Show("Please Enter Period of Lending the Book");
            }
            if (string.IsNullOrEmpty(LISPN.Text.Trim()))
            {
                MessageBox.Show("Please Enter Book ISBN");
            }
            if (string.IsNullOrEmpty(LBT.Text.Trim()))
            {
                MessageBox.Show("Please Enter Book Title");
            }
            if (string.IsNullOrEmpty(LBookCategory.Text.Trim()))
            {
                MessageBox.Show("Please Enter Book category");
            }
            if (string.IsNullOrEmpty(LNoB.Text.Trim()) || !f2)
            {
                MessageBox.Show("Please Enter number of Books you want to Donate by");
            }

            if (IsNullOrEmpty(LpictureBox1))
                MessageBox.Show("Please Enter Book Cover");



            if (!IsNullOrEmpty(LpictureBox1) && !string.IsNullOrEmpty(LNoB.Text.Trim()) && !string.IsNullOrEmpty(LBookCategory.Text.Trim()) && !string.IsNullOrEmpty(LBT.Text.Trim()) && !string.IsNullOrEmpty(LISPN.Text.Trim()) && !string.IsNullOrEmpty(LLendingPeriod.Text.Trim()))
            {
                if (!isfound(name, LISPN.Text))
                {
                    int result=c.InsertBookToLend(LISPN.Text, LBT.Text, LBookCategory.Text, Lp, v2, v4, LBookLanguage.Text, v3, LIatB.Text, Convert.ToDateTime(LPD.Text), name, v1);
                    if (result == 1)
                        MessageBox.Show("The Number of Books That You want to Lend Is Recordered");
                    else
                        MessageBox.Show("The Number of Books That You want to Lend Is not Recordered");
                }
                else
                {
                    c.LupdateBookcount(v2, name, LISPN.Text);
                    ls = false;
                }
                if (a == null)
                {
                    a = new Author(name, LISPN.Text,'l');
                    a.Show();
                }
                else
                {
                    a.Show();
                    a.Focus();
                }
            }
   
           
        }

        private void UploadBookCover_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Images|*.jpg;*.png;*.gif;*.bmp";
            of.InitialDirectory = "C:\\";
            of.FilterIndex = 1;
            if (of.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (of.CheckFileExists)
                {
                    Lp = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);
                    Random random = new Random();
                    string cfn =LBT.Text + random.Next(0, 8 - 1)+ System.IO.Path.GetFileName(of.FileName)  ;
                    
                    System.IO.File.Copy(of.FileName, Lp +"\\img\\" + cfn );
                    LpictureBox1.Image = Image.FromFile(of.FileName);
                    MessageBox.Show("succefully uploaded");
                    Lp = "\\img\\" + cfn ;
                }

            }
        }
        private bool isfound(string u, string i)
        {
            DataTable dt = c.Lgetusernameisbn();
            bool exists = false;
            foreach (DataRow row in dt.Rows)
            {
                if (row["username"].ToString().ToLower().Trim() == u && row["ISBN"].ToString().ToLower().Trim() == i)
                {
                    exists = true;
                }
            }
            return exists;
        }
        private static bool IsNullOrEmpty(PictureBox pb)
        {
            return pb == null || pb.Image == null;
        }
        private void LpictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LBookLanguage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
