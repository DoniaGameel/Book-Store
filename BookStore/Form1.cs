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
    public partial class Form1 : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        string username;
        public Form1(string name)
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
            mybooksbutton.Visible = true;
            this.Text = string.Empty;
            //this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            username = name;
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
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
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
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }
        /// <summary>
        /// //////////////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void SellBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new sell(username), sender);
        }

        private void LendBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Lend(username), sender);

        }

        private void DonateBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Donate(username), sender);
           
        }

        private void OrderBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new orderunavailble(username) , sender);

        }

        private void BuyBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BuyForm(username), sender);

        }

        private void BorrowBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BorrowForm(username), sender);
 

        }

        private void TakeBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FreeForm(username), sender);

        }


        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BooksOfUser(username), sender);
            
        }

        private void signupbutton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new orderedbooksofuser(username), sender);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            home frm = new home();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Orders(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChangeUserPassword(username), sender);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ShowSeminarU(), sender);
            
        }
    }
}
