using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace BookStore
{
    public partial class Publisher : Form
    {
        Controller c;
        string path;
        string pus;
        string pispn;
        int aid;
        sell s;
        Donate d;
        Lend l;
        char w;
        PublisherAddress PA;
        public Publisher()
        {
            c = new Controller();
            InitializeComponent();
        }
        public Publisher(string s1, string s2,int id,char t)
        {
            c = new Controller();
            InitializeComponent();
            pus = s1;
            pispn = s2;
            aid = id;
            w = t;
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void PIAI_Click(object sender, EventArgs e)
        {
            
             if (string.IsNullOrEmpty( PPN.Text.Trim()))
            {
                MessageBox.Show("Please Enter Publisher Name ");
            }
            if (string.IsNullOrEmpty(PEmail.Text.Trim()))
            {
                MessageBox.Show("Please Enter Publisher Email");
            }
            if (!string.IsNullOrEmpty(PPN.Text.Trim()) &&!string.IsNullOrEmpty( PEmail.Text.Trim()))
            {
                if (!isfound(PPN.Text))
                {
                  int result=  c.InsertPublisher(PPN.Text, PEmail.Text, PAP.Text, PFax.Text, path);
                  
                      MessageBox.Show("The Publisher Is Recordered");
                 
                }
                DataTable dt = c.SelectPblisherID(PEmail.Text);
                DataRow r = dt.Rows[0];
                int pid = (int)r["Publisher_ID"];

                if (w=='s')
                {
                    c.Updatebooktosell(pid, pus, pispn, aid);
                }
                if (w=='l')
                {
                    c.Updatebooktolend(pid, pus, pispn, aid);
                }
                if (w=='d')
                {
                    c.Updatebooktodonate(pid, pus, pispn, aid);
                }
                if (PA == null)
                {
                    PA = new PublisherAddress(pid);
                    PA.Show();
                }
                else
                {
                    PA.Show();
                    PA.Focus();
                }
                this.Hide();
            }
           
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Images|*.jpg;*.png;*.gif;*.bmp";
            of.InitialDirectory = "C:\\";
            of.FilterIndex = 1;
            if (of.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (of.CheckFileExists)
                {
                    path = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);
                    Random random = new Random();
                    string cfn = PPN.Text + random.Next(0, 8 - 1)+ System.IO.Path.GetFileName(of.FileName) ;
                   
                    System.IO.File.Copy(of.FileName, path + "\\img\\" + cfn );
                    pictureBox1.Image = Image.FromFile(of.FileName);
                    MessageBox.Show("succefully uploaded");
                    path = "\\img\\" + cfn ;
                }

            }
        }
        public bool isfound(string name)
        {
            DataTable dt = c.SelectPublishername();
            bool exists = false;
            foreach (DataRow row in dt.Rows)
            {
                if (row["Publisher_name"].ToString().ToLower().Trim() == name)
                {
                    exists = true;
                }
            }
            return exists;
        }
    }
}
