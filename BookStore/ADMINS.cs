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
    public partial class ADMINS : Form
    {
        Controller controllerObj;
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        string name;
        public ADMINS(string adminname)
        {
            InitializeComponent();
            random = new Random();
            name = adminname;
        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    label1.BackColor = color;
                    /*panel2.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;*/
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panel1.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.paneldesktop.Controls.Add(childForm);
            this.paneldesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label1.Text = childForm.Text;
        }





        private void Admins_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminForms.AddShippingCompany(name), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminForms.AddSeminars(), sender);
        }

        private void paneldesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new AdminForms.AddShippingCompany(name), sender);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new AdminForms.AddSeminars(), sender);
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            OpenChildForm(new AdminForms.AddSeminars(), sender);
        }

        private void ADMINS_Load_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminForms.AddAdmin(), sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminForms.ChangeYourPassword(name), sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            OpenChildForm(new AdminForms.ShowSeminars(), sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //controllerObj = new Controller();
            //OpenChildForm(new AdminForms.DeleteaSeminar(), sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            OpenChildForm(new AdminForms.ShowCompanies(), sender);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            OpenChildForm(new AdminForms.ShowAdmins(), sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            home frm = new home();
            frm.Show();
            this.Hide();
        }
    }
}
