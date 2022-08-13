namespace BookStore
{
    partial class orderunavailble
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
            this.button2 = new System.Windows.Forms.Button();
            this.wbt = new System.Windows.Forms.MaskedTextBox();
            this.oisbn = new System.Windows.Forms.MaskedTextBox();
            this.onob = new System.Windows.Forms.MaskedTextBox();
            this.obc = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Enter This Informatios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wanted Book Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ISBN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Book Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Number of Books";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(280, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Insert Informations";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // wbt
            // 
            this.wbt.BackColor = System.Drawing.SystemColors.Window;
            this.wbt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wbt.Location = new System.Drawing.Point(12, 76);
            this.wbt.Mask = "&&&&&&&&&&&&&&&&&";
            this.wbt.Name = "wbt";
            this.wbt.Size = new System.Drawing.Size(100, 13);
            this.wbt.TabIndex = 14;
            // 
            // oisbn
            // 
            this.oisbn.BackColor = System.Drawing.SystemColors.Window;
            this.oisbn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.oisbn.Location = new System.Drawing.Point(12, 121);
            this.oisbn.Mask = "&&&&&&&&&&&&&&&&&&&&&&&&&&";
            this.oisbn.Name = "oisbn";
            this.oisbn.Size = new System.Drawing.Size(100, 13);
            this.oisbn.TabIndex = 15;
            // 
            // onob
            // 
            this.onob.BackColor = System.Drawing.SystemColors.Window;
            this.onob.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.onob.Location = new System.Drawing.Point(12, 223);
            this.onob.Mask = "000000000000000000000";
            this.onob.Name = "onob";
            this.onob.Size = new System.Drawing.Size(100, 13);
            this.onob.TabIndex = 16;
            // 
            // obc
            // 
            this.obc.BackColor = System.Drawing.SystemColors.Window;
            this.obc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.obc.Location = new System.Drawing.Point(12, 170);
            this.obc.Mask = "&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&";
            this.obc.Name = "obc";
            this.obc.Size = new System.Drawing.Size(100, 13);
            this.obc.TabIndex = 17;
            // 
            // orderunavailble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 382);
            this.Controls.Add(this.obc);
            this.Controls.Add(this.onob);
            this.Controls.Add(this.oisbn);
            this.Controls.Add(this.wbt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(11, 9);
            this.Name = "orderunavailble";
            this.Text = "Order Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox wbt;
        private System.Windows.Forms.MaskedTextBox oisbn;
        private System.Windows.Forms.MaskedTextBox onob;
        private System.Windows.Forms.MaskedTextBox obc;

    }
}