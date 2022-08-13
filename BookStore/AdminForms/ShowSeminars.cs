using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
namespace BookStore.AdminForms
{
    public partial class ShowSeminars : Form
    {
        int rowIndex=0;
        DataTable dt;
        Controller controllerObj;
        public ShowSeminars()
        {
            InitializeComponent();
        }

        private void ShowSeminars_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            dataGridView1.Visible = true;
            dt = controllerObj.Select_Seminars();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                
                DateTime oDate = DateTime.Parse(dataGridView1.Rows[rowIndex].Cells[2].Value.ToString());
                int result = controllerObj.DeleteaSeminar(dataGridView1.Rows[rowIndex].Cells[1].Value.ToString(), oDate.ToString("yyyy-MM-dd"));
                if (result == 0)
                {
                    MessageBox.Show("The deletion failed");
                }
                else
                {
                    dataGridView1.Rows.RemoveAt(rowIndex);
                    MessageBox.Show("you deleted the seminar successfully!");

                }                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // int rowIndex = dataGridView1.CurrentCell.RowIndex;
            int result =0;
            controllerObj = new Controller();
            if(rowIndex>=0)
             result = controllerObj.DeleteaSeminar(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[1].Value.ToString());
            if (result == 0)
            {
                MessageBox.Show("The deletion failed");
            }
            else
            {
                dataGridView1.Rows.RemoveAt(rowIndex);
                MessageBox.Show("you deleted the seminar successfully!");

            }
        }
    }
}
