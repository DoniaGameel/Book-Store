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
    public partial class CompanyInfo : Form
    {
        Controller controllerObj;
        public CompanyInfo(int ID)
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable DT1 = controllerObj.PhoneAllD(ID);
            DataTable DT2 = controllerObj.AdressesAllD(ID);
            if (DT1 != null)
            {
                DT1.Columns.Remove(DT1.Columns[0]);
                dataGridView2.DataSource = DT1;
            }
            if (DT2 != null)
            {
                DT2.Columns.Remove(DT2.Columns[0]);
                dataGridView3.DataSource = DT2;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
