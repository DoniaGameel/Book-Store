﻿namespace BookStore
{
    partial class PublisherAddress
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.PD = new System.Windows.Forms.MaskedTextBox();
            this.PC = new System.Windows.Forms.MaskedTextBox();
            this.PST = new System.Windows.Forms.MaskedTextBox();
            this.PS = new System.Windows.Forms.MaskedTextBox();
            this.PH = new System.Windows.Forms.MaskedTextBox();
            this.PPN = new System.Windows.Forms.MaskedTextBox();
            this.PCC = new System.Windows.Forms.MaskedTextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(28, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 89);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "State";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "City";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Distinct";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Street";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "House Number";
            this.Column5.Name = "Column5";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(532, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 22);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add Address";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(513, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "District";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Street";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "House Number";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7});
            this.dataGridView2.Location = new System.Drawing.Point(154, 246);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(242, 87);
            this.dataGridView2.TabIndex = 12;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Country Code";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Phone Number";
            this.Column7.Name = "Column7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Phone Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-1, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Coutry Code";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(532, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 22);
            this.button2.TabIndex = 17;
            this.button2.Text = "Add Phone Number";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "State";
            // 
            // PD
            // 
            this.PD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PD.Location = new System.Drawing.Point(561, 15);
            this.PD.Mask = "&&&&&&&&&&&&&&&&&&&&&&&";
            this.PD.Name = "PD";
            this.PD.Size = new System.Drawing.Size(100, 13);
            this.PD.TabIndex = 30;
            // 
            // PC
            // 
            this.PC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PC.Location = new System.Drawing.Point(334, 15);
            this.PC.Mask = "&&&&&&&&&&&&&&&&&&&&&&&";
            this.PC.Name = "PC";
            this.PC.Size = new System.Drawing.Size(100, 13);
            this.PC.TabIndex = 31;
            // 
            // PST
            // 
            this.PST.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PST.Location = new System.Drawing.Point(50, 62);
            this.PST.Mask = "&&&&&&&&&&&&&&&&&&&&&&&";
            this.PST.Name = "PST";
            this.PST.Size = new System.Drawing.Size(100, 13);
            this.PST.TabIndex = 32;
            // 
            // PS
            // 
            this.PS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PS.Location = new System.Drawing.Point(50, 15);
            this.PS.Mask = "&&&&&&&&&&&&&&&&&&&&&&&";
            this.PS.Name = "PS";
            this.PS.Size = new System.Drawing.Size(100, 13);
            this.PS.TabIndex = 33;
            // 
            // PH
            // 
            this.PH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PH.Location = new System.Drawing.Point(334, 62);
            this.PH.Mask = "000000000000000000000";
            this.PH.Name = "PH";
            this.PH.Size = new System.Drawing.Size(100, 13);
            this.PH.TabIndex = 34;
            // 
            // PPN
            // 
            this.PPN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PPN.Location = new System.Drawing.Point(334, 198);
            this.PPN.Mask = "0000000000000000000000000000";
            this.PPN.Name = "PPN";
            this.PPN.Size = new System.Drawing.Size(100, 13);
            this.PPN.TabIndex = 35;
            // 
            // PCC
            // 
            this.PCC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PCC.Location = new System.Drawing.Point(70, 198);
            this.PCC.Mask = "&&&&&&&&&&&&&&&&&&&&&&&";
            this.PCC.Name = "PCC";
            this.PCC.Size = new System.Drawing.Size(100, 13);
            this.PCC.TabIndex = 36;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(532, 310);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 23);
            this.button3.TabIndex = 37;
            this.button3.Text = "Finish";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PublisherAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 345);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.PCC);
            this.Controls.Add(this.PPN);
            this.Controls.Add(this.PH);
            this.Controls.Add(this.PS);
            this.Controls.Add(this.PST);
            this.Controls.Add(this.PC);
            this.Controls.Add(this.PD);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PublisherAddress";
            this.Text = "PublisherAddress";
            this.Load += new System.EventHandler(this.PublisherAddress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.MaskedTextBox PD;
        private System.Windows.Forms.MaskedTextBox PC;
        private System.Windows.Forms.MaskedTextBox PST;
        private System.Windows.Forms.MaskedTextBox PS;
        private System.Windows.Forms.MaskedTextBox PH;
        private System.Windows.Forms.MaskedTextBox PPN;
        private System.Windows.Forms.MaskedTextBox PCC;
        private System.Windows.Forms.Button button3;
    }
}