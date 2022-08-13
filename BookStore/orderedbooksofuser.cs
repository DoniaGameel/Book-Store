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

    public partial class orderedbooksofuser : Form
    {
        Controller controllerObj;
        public login log;
        private string username3;
        public orderedbooksofuser(string name)
        {
            InitializeComponent();
            username3 = name;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void done_Click(object sender, EventArgs e)
        {

        }

        private void orderedbooksofuser_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            dataGridView4.ColumnCount = 3;
            dataGridView4.Columns[0].Name = "Books to buy";
            dataGridView4.Columns[1].Name = "cancel";
            dataGridView4.Columns[2].Name = "Approve";
            int j = 0;
            int x = 0;
            DataTable dt = controllerObj.buyingbooksforspecificuser(username3);
            DataTable dt2 = controllerObj.borrowingbooksforspecificuser(username3);
            DataTable dt3 = controllerObj.takenbooksforspecificuser(username3);
            if(dt==null&&dt2==null&&dt3==null)
            {
                MessageBox.Show("you haven't any order");
                return;
            }
            if (dt==null)
            {
                MessageBox.Show("you haven't any order to buy");
            }
            if (dt != null)
            {
                x = dt.Rows.Count;
                for (int i = 1; i <= x; i++)
                {
                    string[] row = new string[] { i.ToString() };
                    dataGridView4.Rows.Add(row);
                }
                foreach (DataRow dr in dt.Rows)
                {
                    dataGridView4.Rows[j].Cells["Books to buy"].Value = dr[0].ToString();
                    j++;
                }
            }
            dataGridView3.ColumnCount = 3;
            dataGridView3.Columns[0].Name = "Books to borrow";
            dataGridView3.Columns[1].Name = "cancel";
            dataGridView3.Columns[2].Name = "Approve";
            j = 0;
            if (dt2 == null)
            {
                MessageBox.Show("you haven't any order to borrow");
            }
            if(dt2!=null)
            {
                x = dt2.Rows.Count;
                for (int i = 1; i <= x; i++)
                {
                    string[] row = new string[] { i.ToString() };
                    dataGridView3.Rows.Add(row);
                }
                foreach (DataRow dr in dt2.Rows)
                {
                    dataGridView3.Rows[j].Cells["Books to borrow"].Value = dr[0].ToString();
                    j++;
                }
            }
            dataGridView2.ColumnCount = 3;
            dataGridView2.Columns[0].Name = "Books to Donate";
            dataGridView2.Columns[1].Name = "cancel";
            dataGridView2.Columns[2].Name = "Approve";
            j = 0;
            if (dt3 == null)
            {
                MessageBox.Show("you haven't any order to donate");
            }
            if(dt3!=null)
            {
                x = dt3.Rows.Count;
                for (int i = 1; i <= x; i++)
                {
                    string[] row = new string[] { i.ToString() };
                    dataGridView2.Rows.Add(row);
                }
                foreach (DataRow dr in dt3.Rows)
                {
                    dataGridView2.Rows[j].Cells["Books to Donate"].Value = dr[0].ToString();
                    j++;
                }
            }

        }

        private void showbookstosell_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView4.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["Approve"].Value);
                DataTable dt = controllerObj.selectcountofbuyingbooks(username3);
                string n = dt.Rows[0][0].ToString();
                int x = int.Parse(n);
                if (isSelected)
                {
                    controllerObj.deletebookfrombuy(username3,controllerObj.isbnsell(row.Cells[0].Value.ToString()));
                    dataGridView4.Rows.Remove(row);
                    MessageBox.Show("your order is approved");
                    int g = controllerObj.selectcountbookstosell(controllerObj.isbnsell(row.Cells[0].Value.ToString()));
                    if (g == 0)
                        controllerObj.deletebookstosell(controllerObj.isbnsell(row.Cells[0].Value.ToString()));
                }
                isSelected = Convert.ToBoolean(row.Cells["cancel"].Value);
                if (isSelected)
                {
                    dataGridView4.Rows.Remove(row);
                    int s = controllerObj.selectcountofbuy(controllerObj.isbnsell(row.Cells[0].Value.ToString()), username3);
                    controllerObj.deletebookfrombuy(username3, controllerObj.isbnsell( row.Cells[0].Value.ToString()));
                    MessageBox.Show("your order is canceled");
                    controllerObj.updatecountbookstosell(controllerObj.isbnsell(row.Cells[0].Value.ToString()), controllerObj.selectcountbookstosell(controllerObj.isbnsell(row.Cells[0].Value.ToString() + s)));
                }
            }

        }

        private void borrow_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["Approve"].Value);
                DataTable dt = controllerObj.selectcountofborrowbooks(username3);
                string n = dt.Rows[0][0].ToString();
                int x = int.Parse(n);
                if (isSelected)
                {
                    controllerObj.deletebookfromborrow(username3, controllerObj.isbnlend(row.Cells[0].Value.ToString()));
                    dataGridView3.Rows.Remove(row);
                    MessageBox.Show("your order is approved");
                    int g = controllerObj.selectcountbookstolend(controllerObj.isbnlend(row.Cells[0].Value.ToString()));
                    if (g == 0)
                        controllerObj.deletebookstolend(controllerObj.isbnlend(row.Cells[0].Value.ToString()));
                }
                isSelected = Convert.ToBoolean(row.Cells["cancel"].Value);
                if (isSelected)
                {
                    dataGridView3.Rows.Remove(row);
                    int s = controllerObj.selectcountofborrow(controllerObj.isbnlend(row.Cells[0].Value.ToString()), username3);
                    controllerObj.deletebookfromborrow(username3, controllerObj.isbnlend(row.Cells[0].Value.ToString()));
                    MessageBox.Show("your order is canceled");
                    controllerObj.updatecountbookstolend(controllerObj.isbnlend(row.Cells[0].Value.ToString()), controllerObj.selectcountbookstolend(controllerObj.isbnlend(row.Cells[0].Value.ToString() + s)));
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void donate_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["Approve"].Value);
                DataTable dt = controllerObj.selectcountoftakebooks(username3);
                string n = dt.Rows[0][0].ToString();
                int x = int.Parse(n);
                if (isSelected)
                {
                    controllerObj.deletebookfromtakefree(username3, controllerObj.isbndonate(row.Cells[0].Value.ToString()));
                    dataGridView2.Rows.Remove(row);
                    MessageBox.Show("your order is approved");
                    int g = controllerObj.selectcountbookstodonate(controllerObj.isbndonate(row.Cells[0].Value.ToString()));
                    if (g == 0)
                        controllerObj.deletebookstodonate(controllerObj.isbndonate(row.Cells[0].Value.ToString()));
                }
                isSelected = Convert.ToBoolean(row.Cells["cancel"].Value);
                if (isSelected)
                {
                    dataGridView2.Rows.Remove(row);
                    int s = controllerObj.selectcountoftake(controllerObj.isbndonate(row.Cells[0].Value.ToString()), username3);
                    controllerObj.deletebookfromtakefree(username3, controllerObj.isbndonate(row.Cells[0].Value.ToString()));
                    MessageBox.Show("your order is canceled");
                    controllerObj.updatecountbookstodonate(controllerObj.isbndonate(row.Cells[0].Value.ToString()), controllerObj.selectcountbookstodonate(controllerObj.isbndonate(row.Cells[0].Value.ToString() + s)));
                }
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
