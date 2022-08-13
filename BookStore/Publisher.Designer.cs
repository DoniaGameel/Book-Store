namespace BookStore
{
    partial class Publisher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.PIAI = new System.Windows.Forms.Button();
            this.PPN = new System.Windows.Forms.MaskedTextBox();
            this.PFax = new System.Windows.Forms.MaskedTextBox();
            this.PEmail = new System.Windows.Forms.MaskedTextBox();
            this.PAP = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Enter This Informations";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Publisher Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fax";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "About Publisher";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "publisher Logo";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(273, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(273, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Uploade Publisher Logo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PIAI
            // 
            this.PIAI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PIAI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PIAI.Location = new System.Drawing.Point(273, 242);
            this.PIAI.Name = "PIAI";
            this.PIAI.Size = new System.Drawing.Size(153, 23);
            this.PIAI.TabIndex = 12;
            this.PIAI.Text = "Insert Publisher information";
            this.PIAI.UseVisualStyleBackColor = true;
            this.PIAI.Click += new System.EventHandler(this.PIAI_Click);
            // 
            // PPN
            // 
            this.PPN.BackColor = System.Drawing.SystemColors.Window;
            this.PPN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PPN.Location = new System.Drawing.Point(27, 84);
            this.PPN.Mask = "&&&&&&&&&&&&&&&&&";
            this.PPN.Name = "PPN";
            this.PPN.Size = new System.Drawing.Size(100, 13);
            this.PPN.TabIndex = 20;
            // 
            // PFax
            // 
            this.PFax.BackColor = System.Drawing.SystemColors.Window;
            this.PFax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PFax.Location = new System.Drawing.Point(27, 191);
            this.PFax.Mask = "&&&&&&&&&&&&&&&&&";
            this.PFax.Name = "PFax";
            this.PFax.Size = new System.Drawing.Size(100, 13);
            this.PFax.TabIndex = 21;
            // 
            // PEmail
            // 
            this.PEmail.BackColor = System.Drawing.SystemColors.Window;
            this.PEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PEmail.Location = new System.Drawing.Point(27, 136);
            this.PEmail.Mask = "&&&&&&&&&&&&&&&&&";
            this.PEmail.Name = "PEmail";
            this.PEmail.Size = new System.Drawing.Size(100, 13);
            this.PEmail.TabIndex = 22;
            // 
            // PAP
            // 
            this.PAP.BackColor = System.Drawing.SystemColors.Window;
            this.PAP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PAP.Location = new System.Drawing.Point(27, 247);
            this.PAP.Mask = "&&&&&&&&&&&&&&&&&";
            this.PAP.Name = "PAP";
            this.PAP.Size = new System.Drawing.Size(100, 13);
            this.PAP.TabIndex = 23;
            // 
            // Publisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 328);
            this.Controls.Add(this.PAP);
            this.Controls.Add(this.PEmail);
            this.Controls.Add(this.PFax);
            this.Controls.Add(this.PPN);
            this.Controls.Add(this.PIAI);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Publisher";
            this.Text = "Publisher";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button PIAI;
        private System.Windows.Forms.MaskedTextBox PPN;
        private System.Windows.Forms.MaskedTextBox PFax;
        private System.Windows.Forms.MaskedTextBox PEmail;
        private System.Windows.Forms.MaskedTextBox PAP;
    }
}