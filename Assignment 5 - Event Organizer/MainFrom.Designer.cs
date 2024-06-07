namespace Assignment_5___Event_Organizer
{
    partial class MainFrom
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.feePerPartBox = new System.Windows.Forms.TextBox();
            this.costPerPartBox = new System.Windows.Forms.TextBox();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CountryBox = new System.Windows.Forms.ComboBox();
            this.ZipCodeBox = new System.Windows.Forms.TextBox();
            this.CityBox = new System.Windows.Forms.TextBox();
            this.StreetBox = new System.Windows.Forms.TextBox();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ResBalanceBox = new System.Windows.Forms.TextBox();
            this.ResTotalFeesBox = new System.Windows.Forms.TextBox();
            this.ResTotalCostBox = new System.Windows.Forms.TextBox();
            this.ResNumberBox = new System.Windows.Forms.TextBox();
            this.ResBox = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.ChangeBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CreateBtn);
            this.groupBox1.Controls.Add(this.feePerPartBox);
            this.groupBox1.Controls.Add(this.costPerPartBox);
            this.groupBox1.Controls.Add(this.titleBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Event";
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(76, 104);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(86, 23);
            this.CreateBtn.TabIndex = 6;
            this.CreateBtn.Text = "Create Event";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // feePerPartBox
            // 
            this.feePerPartBox.Location = new System.Drawing.Point(155, 64);
            this.feePerPartBox.Name = "feePerPartBox";
            this.feePerPartBox.Size = new System.Drawing.Size(71, 20);
            this.feePerPartBox.TabIndex = 5;
            // 
            // costPerPartBox
            // 
            this.costPerPartBox.Location = new System.Drawing.Point(155, 37);
            this.costPerPartBox.Name = "costPerPartBox";
            this.costPerPartBox.Size = new System.Drawing.Size(71, 20);
            this.costPerPartBox.TabIndex = 4;
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(76, 13);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(150, 20);
            this.titleBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fee per participant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cost per participant";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event title";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CountryBox);
            this.groupBox2.Controls.Add(this.ZipCodeBox);
            this.groupBox2.Controls.Add(this.CityBox);
            this.groupBox2.Controls.Add(this.StreetBox);
            this.groupBox2.Controls.Add(this.LastNameBox);
            this.groupBox2.Controls.Add(this.FirstNameBox);
            this.groupBox2.Controls.Add(this.addBtn);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(21, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 270);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add participant";
            // 
            // CountryBox
            // 
            this.CountryBox.FormattingEnabled = true;
            this.CountryBox.Location = new System.Drawing.Point(102, 198);
            this.CountryBox.Name = "CountryBox";
            this.CountryBox.Size = new System.Drawing.Size(121, 21);
            this.CountryBox.TabIndex = 12;
            this.CountryBox.Text = "Choose Country";
            // 
            // ZipCodeBox
            // 
            this.ZipCodeBox.Location = new System.Drawing.Point(102, 169);
            this.ZipCodeBox.Name = "ZipCodeBox";
            this.ZipCodeBox.Size = new System.Drawing.Size(122, 20);
            this.ZipCodeBox.TabIndex = 11;
            // 
            // CityBox
            // 
            this.CityBox.Location = new System.Drawing.Point(102, 140);
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(123, 20);
            this.CityBox.TabIndex = 10;
            // 
            // StreetBox
            // 
            this.StreetBox.Location = new System.Drawing.Point(102, 114);
            this.StreetBox.Name = "StreetBox";
            this.StreetBox.Size = new System.Drawing.Size(123, 20);
            this.StreetBox.TabIndex = 9;
            // 
            // LastNameBox
            // 
            this.LastNameBox.Location = new System.Drawing.Point(102, 55);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(123, 20);
            this.LastNameBox.TabIndex = 8;
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Location = new System.Drawing.Point(102, 26);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(124, 20);
            this.FirstNameBox.TabIndex = 7;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(125, 241);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(101, 23);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Country";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Zip Code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Street";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "First Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.ResBalanceBox);
            this.groupBox3.Controls.Add(this.ResTotalFeesBox);
            this.groupBox3.Controls.Add(this.ResTotalCostBox);
            this.groupBox3.Controls.Add(this.ResNumberBox);
            this.groupBox3.Location = new System.Drawing.Point(395, 290);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(279, 132);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Event economy";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 101);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "Surplus/Deficit";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Total Fees";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Total Cost";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Number of participants";
            // 
            // ResBalanceBox
            // 
            this.ResBalanceBox.Location = new System.Drawing.Point(155, 98);
            this.ResBalanceBox.Name = "ResBalanceBox";
            this.ResBalanceBox.ReadOnly = true;
            this.ResBalanceBox.Size = new System.Drawing.Size(100, 20);
            this.ResBalanceBox.TabIndex = 3;
            // 
            // ResTotalFeesBox
            // 
            this.ResTotalFeesBox.Location = new System.Drawing.Point(155, 71);
            this.ResTotalFeesBox.Name = "ResTotalFeesBox";
            this.ResTotalFeesBox.ReadOnly = true;
            this.ResTotalFeesBox.Size = new System.Drawing.Size(100, 20);
            this.ResTotalFeesBox.TabIndex = 2;
            // 
            // ResTotalCostBox
            // 
            this.ResTotalCostBox.Location = new System.Drawing.Point(155, 45);
            this.ResTotalCostBox.Name = "ResTotalCostBox";
            this.ResTotalCostBox.ReadOnly = true;
            this.ResTotalCostBox.Size = new System.Drawing.Size(100, 20);
            this.ResTotalCostBox.TabIndex = 1;
            // 
            // ResNumberBox
            // 
            this.ResNumberBox.Location = new System.Drawing.Point(155, 19);
            this.ResNumberBox.Name = "ResNumberBox";
            this.ResNumberBox.ReadOnly = true;
            this.ResNumberBox.Size = new System.Drawing.Size(100, 20);
            this.ResNumberBox.TabIndex = 0;
            // 
            // ResBox
            // 
            this.ResBox.FormattingEnabled = true;
            this.ResBox.Location = new System.Drawing.Point(267, 29);
            this.ResBox.Name = "ResBox";
            this.ResBox.Size = new System.Drawing.Size(521, 212);
            this.ResBox.TabIndex = 3;
            this.ResBox.SelectedIndexChanged += new System.EventHandler(this.ResBox_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label10.Location = new System.Drawing.Point(274, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Participant";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Label11.Location = new System.Drawing.Point(413, 9);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(45, 13);
            this.Label11.TabIndex = 5;
            this.Label11.Text = "Address";
            // 
            // ChangeBtn
            // 
            this.ChangeBtn.Location = new System.Drawing.Point(381, 247);
            this.ChangeBtn.Name = "ChangeBtn";
            this.ChangeBtn.Size = new System.Drawing.Size(75, 23);
            this.ChangeBtn.TabIndex = 6;
            this.ChangeBtn.Text = "Change";
            this.ChangeBtn.UseVisualStyleBackColor = true;
            this.ChangeBtn.Click += new System.EventHandler(this.ChangeBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(609, 246);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 7;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.ChangeBtn);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ResBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainFrom";
            this.Text = "Event Organizer by Robin Kadergran";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.TextBox feePerPartBox;
        private System.Windows.Forms.TextBox costPerPartBox;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.ListBox ResBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Label11;
        private System.Windows.Forms.Button ChangeBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.ComboBox CountryBox;
        private System.Windows.Forms.TextBox ZipCodeBox;
        private System.Windows.Forms.TextBox CityBox;
        private System.Windows.Forms.TextBox StreetBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ResBalanceBox;
        private System.Windows.Forms.TextBox ResTotalFeesBox;
        private System.Windows.Forms.TextBox ResTotalCostBox;
        private System.Windows.Forms.TextBox ResNumberBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
    }
}

