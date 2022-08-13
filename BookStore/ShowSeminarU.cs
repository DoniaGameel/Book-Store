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
    public partial class ShowSeminarU : Form
    {
        Controller controllerObj;
        public ShowSeminarU()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ShowSeminarU_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            dataGridView1.Visible = true;
            DataTable dt = controllerObj.Select_Seminars();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
    }
}
