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
    public partial class Orders : Form
    {
        Controller controllerObj;
        public Orders()
        {
            controllerObj = new Controller();
            InitializeComponent();
            DataTable DT= controllerObj.OrdersD();
            dataGridView1.DataSource = DT;

        }
    }
}
