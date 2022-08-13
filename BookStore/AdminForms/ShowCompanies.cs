using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.AdminForms
{
    public partial class ShowCompanies : Form
    {
        Controller controllerObj;
        int id;
        public ShowCompanies()
        {
            InitializeComponent();
        }

        private void ShowCompanies_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            dataGridView1.Visible = true;
            DataTable dt = controllerObj.SelectShippingCompany();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
            controllerObj = new Controller();

            int result = controllerObj.DeleteaCompany(dataGridView1.Rows[rowIndex].Cells[1].Value.ToString());
            if (result == 0)
            {
                MessageBox.Show("The deletion failed");
            }
            else
            {
                MessageBox.Show("you deleted the company successfully!");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string selcetedname = dataGridView1.CurrentRow.Cells[""].Value.ToString();
            int deleterow =controllerObj.DeleteaCompany(selcetedname);
            //int rowIndex = dataGridView1.CurrentCell.RowIndex;
            //dataGridView1.Rows.RemoveAt(rowIndex);

            //controllerObj = new Controller();

            //int result = controllerObj.DeleteaCompany(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());
            //if (result == 0)
            //{
            //    MessageBox.Show("The deletion failed");
            //}
            //else
            //{
            //    MessageBox.Show("you deleted the company successfully!");

            //}

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectCompanyId(dataGridView1.Rows[rowIndex].Cells[1].Value.ToString());
            DataRow r = dt.Rows[0];
            id = (int)r["Company_ID"];
            DataTable dt1 = controllerObj.SelectCompanyAddress(id);
            dataGridView2.DataSource = dt1;
            dataGridView2.Refresh();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectCompanyId(dataGridView1.Rows[rowIndex].Cells[1].Value.ToString());
            DataRow r = dt.Rows[0];
            id = (int)r["Company_ID"];
            DataTable dt1 = controllerObj.SelectCompanyPhonenumbers(id);
            dataGridView3.DataSource = dt1;
            dataGridView3.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectCompanyId(dataGridView1.Rows[rowIndex].Cells[1].Value.ToString());
            DataRow r = dt.Rows[0];
            id = (int)r["Company_ID"];
            DataTable dt1 = controllerObj.SelectCompanyDestinations(id);
            dataGridView4.DataSource = dt1;
            dataGridView4.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView2.CurrentCell.RowIndex;
            dataGridView2.Rows.RemoveAt(rowIndex);
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectCompanyId(dataGridView1.Rows[rowIndex].Cells[1].Value.ToString());
            DataRow r = dt.Rows[0];
            id = (int)r["Company_ID"];
            int result = controllerObj.DeleteCompanyAddress(id);
            if (result == 0)
            {
                MessageBox.Show("The deletion failed");
            }
            else
            {
                MessageBox.Show("you deleted the company address successfully!");

            }
            
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView3.CurrentCell.RowIndex;
            dataGridView3.Rows.RemoveAt(rowIndex);
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectCompanyId(dataGridView1.Rows[rowIndex].Cells[1].Value.ToString());
            DataRow r = dt.Rows[0];
            id = (int)r["Company_ID"];
            int result = controllerObj.DeleteCompanyPhonenumbers(id);
            if (result == 0)
            {
                MessageBox.Show("The deletion failed");
            }
            else
            {
                MessageBox.Show("you deleted the company phone number successfully!");

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView4.CurrentCell.RowIndex;
            dataGridView4.Rows.RemoveAt(rowIndex);
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectCompanyId(dataGridView1.Rows[rowIndex].Cells[1].Value.ToString());
            DataRow r = dt.Rows[0];
            id = (int)r["Company_ID"];
            int result = controllerObj.DeleteCompanyDestination(id);
            if (result == 0)
            {
                MessageBox.Show("The deletion failed");
            }
            else
            {
                MessageBox.Show("you deleted the company destination successfully!");

            }

        }
    }
}
