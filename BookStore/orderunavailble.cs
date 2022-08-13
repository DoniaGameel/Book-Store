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
    public partial class orderunavailble : Form
    {
        Controller c;
        string op;
        string name;
        public orderunavailble(string n)
        {
            InitializeComponent();
            c = new Controller();
            name = n;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            oisbn.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            obc.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            onob.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            wbt.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (string.IsNullOrEmpty(oisbn.Text.Trim()))
            {
                MessageBox.Show("Please Enter Book ISBN");
            }
            if (string.IsNullOrEmpty(wbt.Text.Trim()))
            {
                MessageBox.Show("Please Enter Book Title");
            }
            if (string.IsNullOrEmpty(obc.Text.Trim()))
            {
                MessageBox.Show("Please Enter Book category");
            }
            if (string.IsNullOrEmpty(onob.Text.Trim()))
            {
                MessageBox.Show("Please Enter number of Books you want");
            }
            if (!string.IsNullOrEmpty(oisbn.Text.Trim()) && !string.IsNullOrEmpty(wbt.Text.Trim()) && !string.IsNullOrEmpty(obc.Text.Trim()) &&!string.IsNullOrEmpty(onob.Text.Trim()))
            {
                if (!isfound())
                {
                    int result = c.InsertBookToOrder(oisbn.Text, wbt.Text, obc.Text, Convert.ToInt16(onob.Text), name);
                    if (result == 1)
                        MessageBox.Show("The Book That You Need Is Recordered");
                    else
                        MessageBox.Show("The Book That You Need Is not Recordered");
                }
                else
                    c.OupdateBookcount(Convert.ToInt16(onob.Text), name, oisbn.Text);
            }
            
        }
        public bool isfound()
        {
            DataTable dt = c.Ogetusernameisbn();
            bool exists = false;
            foreach (DataRow row in dt.Rows)
            {
                if (row["username"].ToString().ToLower().Trim() ==name && row["ISBN"].ToString().ToLower().Trim() == oisbn.Text)
                {
                    exists = true;
                }
            }
            return exists;
        }
    }
}
