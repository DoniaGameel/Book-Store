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
    public partial class sell : Form
    {
        Controller c;
        string p;
        Author a ;
        string name;
     
      public sell()
        {
            
            c = new Controller();
            InitializeComponent();
        }
        public sell(string n)
        {
            name = n;
            c = new Controller();
            InitializeComponent();
            
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int v1, v2, v3, v4;
            bool f1 = int.TryParse(SPoaB.Text, out v1);

            bool f2 = int.TryParse(SNumberofBooks.Text, out v2);
            bool f3 = int.TryParse(SNoE.Text, out v3);
            bool f4 = int.TryParse(SNumberofBookPages.Text, out v4);
            if (string.IsNullOrEmpty(SISPN.Text.Trim()))
            {
                MessageBox.Show("Please Enter Book ISBN");
            }
            if (string.IsNullOrEmpty(SBookTitle.Text.Trim()))
            {
                MessageBox.Show("Please Enter Book Title");
            }
            if (string.IsNullOrEmpty(SBookCategory.Text.Trim()))
            {
                MessageBox.Show("Please Enter Book category");
            }
            if (string.IsNullOrEmpty(SNumberofBooks.Text.Trim())||!f3)
            {
                MessageBox.Show("Please Enter number of Books you want to sell");
            }
            if (string.IsNullOrEmpty(SPoaB.Text.Trim()) || !f1)
            {
                MessageBox.Show("Please Enter Price of the Book");
            }
            if (IsnullOrEmpty(SpictureBox1))
                MessageBox.Show("Please Enter Book Cover");
            if (!IsnullOrEmpty(SpictureBox1) && !string.IsNullOrEmpty(SPoaB.Text.Trim()) && !string.IsNullOrEmpty(SNumberofBooks.Text.Trim()) && !string.IsNullOrEmpty(SBookCategory.Text.Trim()) && !string.IsNullOrEmpty(SBookTitle.Text.Trim()) && !string.IsNullOrEmpty(SISPN.Text.Trim()))
            {
                if (!isfound(name, SISPN.Text))
                {
                   int result= c.InsertBookToSell(SISPN.Text, SBookTitle.Text, SBookCategory.Text, p, v2, v4, SBookLanguage.Text, v3, SNatB.Text, Convert.ToDateTime(SPD.Text), name, v1);
                    if (result == 1)
                        MessageBox.Show("The Number of Books That You want to Sell Is Recordered");
                    else
                        MessageBox.Show("The Number of Books That You want to Sell Is not Recordered");
                }
                else
                {
                    c.SupdateBookcount(v2, name, SISPN.Text);
                   
                }
                if (a == null)
                {

                    a = new Author(name, SISPN.Text,'s');
                    a.Show();
                }
                else
                {
                    a.Show();
                    a.Focus();
                }
        }
            
         
            
          
        }

        private void SUploadBookCover_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Images|*.jpg;*.png;*.gif;*.bmp";
            of.InitialDirectory ="C:\\";
            of.FilterIndex = 1;
            if (of.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (of.CheckFileExists)
                {
                    p = Application.StartupPath.Substring(0,Application.StartupPath.Length-10);
                    Random random = new Random();
                    string cfn = SBookTitle.Text + random.Next(0, 8 - 1)+ System.IO.Path.GetFileName(of.FileName) ;
                   
                    System.IO.File.Copy(of.FileName, p + "\\img\\" + cfn );
                    SpictureBox1.Image = Image.FromFile(of.FileName);
                    MessageBox.Show("succefully uploaded");
                    p = "\\img\\" + cfn ;
                }
            
            }
            
        }

        private void SBookTitle_TextChanged(object sender, EventArgs e)
        {
            
        }
        public bool isfound(string u,string i)
        {
            DataTable dt = c.Sgetusernameisbn();
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
        private static bool IsnullOrEmpty(PictureBox pb)
        {
            return pb == null || pb.Image == null;
        }
    }
}
