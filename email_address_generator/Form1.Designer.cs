namespace email_address_generator
{
    partial class frm1
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
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.cb2 = new System.Windows.Forms.ComboBox();
            this.cty_lb = new System.Windows.Forms.Label();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.lblang = new System.Windows.Forms.Label();
            this.lbemail = new System.Windows.Forms.Label();
            this.lbmiddle = new System.Windows.Forms.Label();
            this.lblast = new System.Windows.Forms.Label();
            this.lbfirst = new System.Windows.Forms.Label();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.tb4 = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.tbr2 = new System.Windows.Forms.TextBox();
            this.tbr1 = new System.Windows.Forms.TextBox();
            this.gb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.AutoSize = true;
            this.gb1.Controls.Add(this.cb2);
            this.gb1.Controls.Add(this.cty_lb);
            this.gb1.Controls.Add(this.cb1);
            this.gb1.Controls.Add(this.lblang);
            this.gb1.Controls.Add(this.lbemail);
            this.gb1.Controls.Add(this.lbmiddle);
            this.gb1.Controls.Add(this.lblast);
            this.gb1.Controls.Add(this.lbfirst);
            this.gb1.Controls.Add(this.btn4);
            this.gb1.Controls.Add(this.btn3);
            this.gb1.Controls.Add(this.btn2);
            this.gb1.Controls.Add(this.btn1);
            this.gb1.Controls.Add(this.tb4);
            this.gb1.Controls.Add(this.tb3);
            this.gb1.Controls.Add(this.tb2);
            this.gb1.Controls.Add(this.tb1);
            this.gb1.Controls.Add(this.lbl4);
            this.gb1.Controls.Add(this.lbl3);
            this.gb1.Controls.Add(this.lbl2);
            this.gb1.Controls.Add(this.lbl1);
            this.gb1.Location = new System.Drawing.Point(10, 10);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(374, 376);
            this.gb1.TabIndex = 0;
            this.gb1.TabStop = false;
            this.gb1.Text = "Parameters";
            // 
            // cb2
            // 
            this.cb2.FormattingEnabled = true;
            this.cb2.Items.AddRange(new object[] {
            ".co.uk",
            ".fr ",
            ".de",
            ".it",
            ".es",
            ".ru",
            ".ch",
            ".be  ",
            ".co.jp"});
            this.cb2.Location = new System.Drawing.Point(101, 259);
            this.cb2.MaxDropDownItems = 10;
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(121, 20);
            this.cb2.TabIndex = 19;
            // 
            // cty_lb
            // 
            this.cty_lb.AutoSize = true;
            this.cty_lb.Location = new System.Drawing.Point(21, 259);
            this.cty_lb.Name = "cty_lb";
            this.cty_lb.Size = new System.Drawing.Size(47, 24);
            this.cty_lb.TabIndex = 18;
            this.cty_lb.Text = "Country\r\nSuffix";
            // 
            // cb1
            // 
            this.cb1.FormattingEnabled = true;
            this.cb1.Items.AddRange(new object[] {
            "English",
            "简体中文"});
            this.cb1.Location = new System.Drawing.Point(131, 27);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(121, 20);
            this.cb1.TabIndex = 17;
            this.cb1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblang
            // 
            this.lblang.AutoSize = true;
            this.lblang.Location = new System.Drawing.Point(21, 30);
            this.lblang.Name = "lblang";
            this.lblang.Size = new System.Drawing.Size(95, 12);
            this.lblang.TabIndex = 16;
            this.lblang.Text = "Choose Language";
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.Location = new System.Drawing.Point(255, 224);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(107, 12);
            this.lbemail.TabIndex = 15;
            this.lbemail.Text = "Example: deloitte";
            // 
            // lbmiddle
            // 
            this.lbmiddle.AutoSize = true;
            this.lbmiddle.Location = new System.Drawing.Point(255, 173);
            this.lbmiddle.Name = "lbmiddle";
            this.lbmiddle.Size = new System.Drawing.Size(101, 12);
            this.lbmiddle.TabIndex = 14;
            this.lbmiddle.Text = "Example: Michael";
            // 
            // lblast
            // 
            this.lblast.AutoSize = true;
            this.lblast.Location = new System.Drawing.Point(255, 122);
            this.lblast.Name = "lblast";
            this.lblast.Size = new System.Drawing.Size(71, 12);
            this.lblast.TabIndex = 13;
            this.lblast.Text = "Example: Qu";
            // 
            // lbfirst
            // 
            this.lbfirst.AutoSize = true;
            this.lbfirst.Location = new System.Drawing.Point(255, 73);
            this.lbfirst.Name = "lbfirst";
            this.lbfirst.Size = new System.Drawing.Size(89, 12);
            this.lbfirst.TabIndex = 12;
            this.lbfirst.Text = "Example: Bruce";
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(202, 326);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 23);
            this.btn4.TabIndex = 11;
            this.btn4.Text = "Exit";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(73, 326);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 23);
            this.btn3.TabIndex = 10;
            this.btn3.Text = "About me";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.AutoEllipsis = true;
            this.btn2.AutoSize = true;
            this.btn2.Location = new System.Drawing.Point(202, 297);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 9;
            this.btn2.Text = "Generate";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(73, 297);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 8;
            this.btn1.Text = "Retry";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // tb4
            // 
            this.tb4.Location = new System.Drawing.Point(101, 220);
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(144, 21);
            this.tb4.TabIndex = 7;
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(101, 170);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(144, 21);
            this.tb3.TabIndex = 6;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(101, 120);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(144, 21);
            this.tb2.TabIndex = 5;
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(101, 72);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(144, 21);
            this.tb1.TabIndex = 4;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(21, 220);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(89, 24);
            this.lbl4.TabIndex = 3;
            this.lbl4.Text = "Company Email \r\nSuffix";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(21, 179);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(71, 12);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Middle Name";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(21, 120);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(59, 12);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Last Name";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(21, 73);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(65, 12);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "First Name";
            // 
            // tbr2
            // 
            this.tbr2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbr2.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbr2.Location = new System.Drawing.Point(590, 0);
            this.tbr2.Multiline = true;
            this.tbr2.Name = "tbr2";
            this.tbr2.ReadOnly = true;
            this.tbr2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbr2.Size = new System.Drawing.Size(171, 376);
            this.tbr2.TabIndex = 2;
            this.tbr2.Visible = false;
            // 
            // tbr1
            // 
            this.tbr1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbr1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbr1.Location = new System.Drawing.Point(419, 0);
            this.tbr1.Multiline = true;
            this.tbr1.Name = "tbr1";
            this.tbr1.ReadOnly = true;
            this.tbr1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbr1.Size = new System.Drawing.Size(171, 376);
            this.tbr1.TabIndex = 3;
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 376);
            this.Controls.Add(this.tbr1);
            this.Controls.Add(this.tbr2);
            this.Controls.Add(this.gb1);
            this.Name = "frm1";
            this.Text = "Email Address Generator";
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox tb4;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.Label lblang;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.Label lbmiddle;
        private System.Windows.Forms.Label lblast;
        private System.Windows.Forms.Label lbfirst;
        private System.Windows.Forms.TextBox tbr2;
        private System.Windows.Forms.ComboBox cb2;
        private System.Windows.Forms.Label cty_lb;
        private System.Windows.Forms.TextBox tbr1;
    }
}

