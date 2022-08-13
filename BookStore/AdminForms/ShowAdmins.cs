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
    
    public partial class ShowAdmins : Form
    {
        Controller controllerObj;
        public ShowAdmins()
        {
            InitializeComponent();
        }

        private void ShowAdmins_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            dataGridView1.Visible = true;
            DataTable dt = controllerObj.SelectAdmins();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
    }
}
