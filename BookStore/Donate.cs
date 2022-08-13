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
    public partial class Donate : Form
    {
        Controller c;
        Author a ;
        string dp;
        string name;
        public bool ds;
        public Donate()
        {
            
            c = new Controller();
            InitializeComponent();
        }
        public Donate(string n)
        {
            name = n;
            c = new Controller();
            InitializeComponent();
            ds = true;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NumberofBookPages_Click(object sender, EventArgs e)
        {

        }

        private void DInsertAuthorInformation_Click(object sender, EventArgs e)
        {
            int v2, v3, v4;

            bool f2 = int.TryParse(DNoB.Text, out v2);
            bool f3 = int.TryParse(DNoE.Text, out v3);
            bool f4 = int.TryParse(DNoBP.Text, out v4);
            if (string.IsNullOrEmpty(DISPN.Text.Trim()))
            {
                MessageBox.Show("Please Enter Book ISBN");
            }
            if (string.IsNullOrEmpty(DBT.Text.Trim()))
            {
                MessageBox.Show("Please Enter Book Title");
            }
            if (string.IsNullOrEmpty(DBookCategory.Text.Trim()))
            {
                MessageBox.Show("Please Enter Book category");
            }
            if (string.IsNullOrEmpty(DNoB.Text.Trim()) || !f3)
            {
                MessageBox.Show("Please Enter number of Books you want to Donate by");
            }
            
            if (IsnullOrempty(DpictureBox1))
                MessageBox.Show("Please Enter Book Cover");
            if (!IsnullOrempty(DpictureBox1) && !string.IsNullOrEmpty(DNoB.Text.Trim()) && !string.IsNullOrEmpty(DBookCategory.Text.Trim()) && !string.IsNullOrEmpty(DBT.Text.Trim()) && !string.IsNullOrEmpty(DISPN.Text.Trim()))
            {
                if (!isfound(name, DISPN.Text))
                {
                   int result= c.InsertBookToDonate(DISPN.Text, DBT.Text, DBookCategory.Text, dp, v2, v4, DBookLanguage.Text, v3, DIatB.Text, Convert.ToDateTime(DPD.Text), name);
                    if (result == 1)
                        MessageBox.Show("The Number of Books That You Donate by Is Recordered");
                    else
                        MessageBox.Show("The Number of Books That You Donate by Is not Recordered");
                }
                else
                {
                    c.DupdateBookcount(v2, name, DISPN.Text);
                    ds = false;
                }
                if (a == null)
                {
                    a = new Author(name, DISPN.Text,'d');
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
                    dp = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);
                    Random random = new Random();
                    string cfn =DBT.Text + random.Next(0, 8 - 1)+ System.IO.Path.GetFileName(of.FileName)  ;
                   
                    System.IO.File.Copy(of.FileName, dp + "\\img\\" + cfn );
                    DpictureBox1.Image = Image.FromFile(of.FileName);
                    MessageBox.Show("succefully uploaded");
                    dp = "\\img\\" + cfn ;
                }

            }
        }
        private static bool IsnullOrempty(PictureBox pb)
        {
            return pb == null || pb.Image == null;
        }
        private bool isfound(string u, string i)
        {
            DataTable dt = c.Dgetusernameisbn();
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
    }
}
