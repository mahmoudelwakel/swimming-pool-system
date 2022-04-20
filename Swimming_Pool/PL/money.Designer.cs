namespace Swimming_Pool.PL
{
    partial class money
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.DateTimePicker();
            this.month = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.trainer = new System.Windows.Forms.TextBox();
            this.other = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.TextBox();
            this.othsel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.othgame = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.yearserach = new System.Windows.Forms.Button();
            this.exyeardate = new System.Windows.Forms.DateTimePicker();
            this.yearplay = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.yearsel = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.yeartotal = new System.Windows.Forms.TextBox();
            this.yearfree = new System.Windows.Forms.TextBox();
            this.yeartrainee = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 62);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Swimming_Pool.Properties.Resources.close_icon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 48);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Traditional Arabic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(223, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "اجمالي المصاريف";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(0, 479);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(979, 62);
            this.panel2.TabIndex = 2;
            // 
            // Search
            // 
            this.Search.BackgroundImage = global::Swimming_Pool.Properties.Resources.Search_icon;
            this.Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Search.FlatAppearance.BorderSize = 0;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Location = new System.Drawing.Point(826, 84);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 48);
            this.Search.TabIndex = 78;
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Traditional Arabic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(447, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 41);
            this.label2.TabIndex = 77;
            this.label2.Text = "السنة";
            // 
            // year
            // 
            this.year.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.year.Location = new System.Drawing.Point(602, 88);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(103, 32);
            this.year.TabIndex = 76;
            this.year.ValueChanged += new System.EventHandler(this.year_ValueChanged);
            // 
            // month
            // 
            this.month.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.month.FormattingEnabled = true;
            this.month.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.month.Location = new System.Drawing.Point(192, 79);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(106, 33);
            this.month.TabIndex = 75;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Traditional Arabic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(55, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 41);
            this.label6.TabIndex = 74;
            this.label6.Text = "الشهر";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Traditional Arabic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(23, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 41);
            this.label3.TabIndex = 79;
            this.label3.Text = "المتدربين";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Traditional Arabic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(466, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 41);
            this.label4.TabIndex = 80;
            this.label4.Text = "فترات حره";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Traditional Arabic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(361, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 41);
            this.label5.TabIndex = 81;
            this.label5.Text = "الاجمالي";
            // 
            // trainer
            // 
            this.trainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.trainer.Enabled = false;
            this.trainer.Font = new System.Drawing.Font("Traditional Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.trainer.Location = new System.Drawing.Point(100, 139);
            this.trainer.Name = "trainer";
            this.trainer.Size = new System.Drawing.Size(112, 40);
            this.trainer.TabIndex = 82;
            // 
            // other
            // 
            this.other.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.other.Enabled = false;
            this.other.Font = new System.Drawing.Font("Traditional Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.other.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.other.Location = new System.Drawing.Point(579, 143);
            this.other.Name = "other";
            this.other.Size = new System.Drawing.Size(126, 40);
            this.other.TabIndex = 83;
            // 
            // total
            // 
            this.total.BackColor = System.Drawing.SystemColors.MenuText;
            this.total.Font = new System.Drawing.Font("Traditional Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.total.Location = new System.Drawing.Point(491, 198);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(188, 40);
            this.total.TabIndex = 84;
            // 
            // othsel
            // 
            this.othsel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.othsel.Enabled = false;
            this.othsel.Font = new System.Drawing.Font("Traditional Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.othsel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.othsel.Location = new System.Drawing.Point(330, 140);
            this.othsel.Name = "othsel";
            this.othsel.Size = new System.Drawing.Size(101, 40);
            this.othsel.TabIndex = 86;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Traditional Arabic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(245, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 41);
            this.label7.TabIndex = 85;
            this.label7.Text = "مبيعات";
            // 
            // othgame
            // 
            this.othgame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.othgame.Enabled = false;
            this.othgame.Font = new System.Drawing.Font("Traditional Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.othgame.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.othgame.Location = new System.Drawing.Point(838, 143);
            this.othgame.Name = "othgame";
            this.othgame.Size = new System.Drawing.Size(133, 40);
            this.othgame.TabIndex = 88;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Traditional Arabic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(730, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 41);
            this.label8.TabIndex = 87;
            this.label8.Text = "العاب اخري";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.yearserach);
            this.panel3.Controls.Add(this.exyeardate);
            this.panel3.Location = new System.Drawing.Point(0, 244);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(979, 62);
            this.panel3.TabIndex = 89;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Traditional Arabic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(665, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(185, 41);
            this.label9.TabIndex = 80;
            this.label9.Text = "اجمالي المصاريف السنوي";
            // 
            // yearserach
            // 
            this.yearserach.BackgroundImage = global::Swimming_Pool.Properties.Resources.Search_icon;
            this.yearserach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.yearserach.FlatAppearance.BorderSize = 0;
            this.yearserach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yearserach.Location = new System.Drawing.Point(291, 8);
            this.yearserach.Name = "yearserach";
            this.yearserach.Size = new System.Drawing.Size(75, 48);
            this.yearserach.TabIndex = 79;
            this.yearserach.UseVisualStyleBackColor = true;
            this.yearserach.Click += new System.EventHandler(this.yearserach_Click);
            // 
            // exyeardate
            // 
            this.exyeardate.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exyeardate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.exyeardate.Location = new System.Drawing.Point(438, 15);
            this.exyeardate.Name = "exyeardate";
            this.exyeardate.Size = new System.Drawing.Size(103, 32);
            this.exyeardate.TabIndex = 77;
            // 
            // yearplay
            // 
            this.yearplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.yearplay.Enabled = false;
            this.yearplay.Font = new System.Drawing.Font("Traditional Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearplay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.yearplay.Location = new System.Drawing.Point(838, 360);
            this.yearplay.Name = "yearplay";
            this.yearplay.Size = new System.Drawing.Size(133, 40);
            this.yearplay.TabIndex = 99;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Traditional Arabic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(730, 360);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 41);
            this.label10.TabIndex = 98;
            this.label10.Text = "العاب اخري";
            // 
            // yearsel
            // 
            this.yearsel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.yearsel.Enabled = false;
            this.yearsel.Font = new System.Drawing.Font("Traditional Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearsel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.yearsel.Location = new System.Drawing.Point(330, 369);
            this.yearsel.Name = "yearsel";
            this.yearsel.Size = new System.Drawing.Size(101, 40);
            this.yearsel.TabIndex = 97;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Traditional Arabic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(230, 363);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 41);
            this.label11.TabIndex = 96;
            this.label11.Text = "مبيعات";
            // 
            // yeartotal
            // 
            this.yeartotal.BackColor = System.Drawing.SystemColors.MenuText;
            this.yeartotal.Font = new System.Drawing.Font("Traditional Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yeartotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.yeartotal.Location = new System.Drawing.Point(491, 433);
            this.yeartotal.Name = "yeartotal";
            this.yeartotal.Size = new System.Drawing.Size(188, 40);
            this.yeartotal.TabIndex = 95;
            // 
            // yearfree
            // 
            this.yearfree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.yearfree.Enabled = false;
            this.yearfree.Font = new System.Drawing.Font("Traditional Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearfree.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.yearfree.Location = new System.Drawing.Point(579, 363);
            this.yearfree.Name = "yearfree";
            this.yearfree.Size = new System.Drawing.Size(126, 40);
            this.yearfree.TabIndex = 94;
            // 
            // yeartrainee
            // 
            this.yeartrainee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.yeartrainee.Enabled = false;
            this.yeartrainee.Font = new System.Drawing.Font("Traditional Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yeartrainee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.yeartrainee.Location = new System.Drawing.Point(91, 366);
            this.yeartrainee.Name = "yeartrainee";
            this.yeartrainee.Size = new System.Drawing.Size(112, 40);
            this.yeartrainee.TabIndex = 93;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Traditional Arabic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(361, 430);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 41);
            this.label12.TabIndex = 92;
            this.label12.Text = "الاجمالي";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Traditional Arabic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(455, 363);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 41);
            this.label13.TabIndex = 91;
            this.label13.Text = "فترات حره";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Traditional Arabic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(12, 366);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 41);
            this.label14.TabIndex = 90;
            this.label14.Text = "المتدربين";
            // 
            // money
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 548);
            this.Controls.Add(this.yearplay);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.yearsel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.yeartotal);
            this.Controls.Add(this.yearfree);
            this.Controls.Add(this.yeartrainee);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.othgame);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.othsel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.total);
            this.Controls.Add(this.other);
            this.Controls.Add(this.trainer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.year);
            this.Controls.Add(this.month);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "money";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "money";
            this.Load += new System.EventHandler(this.money_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker year;
        private System.Windows.Forms.ComboBox month;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox trainer;
        private System.Windows.Forms.TextBox other;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.TextBox othsel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox othgame;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button yearserach;
        private System.Windows.Forms.DateTimePicker exyeardate;
        private System.Windows.Forms.TextBox yearplay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox yearsel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox yeartotal;
        private System.Windows.Forms.TextBox yearfree;
        private System.Windows.Forms.TextBox yeartrainee;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}