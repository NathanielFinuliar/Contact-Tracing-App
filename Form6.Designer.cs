namespace Contact_Tracing_App
{
    partial class Form6
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.CamLbl = new System.Windows.Forms.Label();
            this.CmboBox = new System.Windows.Forms.ComboBox();
            this.ScanPicBox = new System.Windows.Forms.PictureBox();
            this.StrtBttn = new System.Windows.Forms.Button();
            this.QrCTxtBox = new System.Windows.Forms.TextBox();
            this.Tmer = new System.Windows.Forms.Timer(this.components);
            this.ClckGenBttn = new System.Windows.Forms.Button();
            this.QrCdePcBox = new System.Windows.Forms.PictureBox();
            this.infoslabel = new System.Windows.Forms.Label();
            this.OpFlbttn = new System.Windows.Forms.Button();
            this.RecrdPicRchTxtBox = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FNTxtBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ScanPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QrCdePcBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // CamLbl
            // 
            this.CamLbl.AutoSize = true;
            this.CamLbl.BackColor = System.Drawing.Color.Transparent;
            this.CamLbl.Font = new System.Drawing.Font("Circular Std Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CamLbl.ForeColor = System.Drawing.Color.Crimson;
            this.CamLbl.Location = new System.Drawing.Point(580, 712);
            this.CamLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CamLbl.Name = "CamLbl";
            this.CamLbl.Size = new System.Drawing.Size(105, 24);
            this.CamLbl.TabIndex = 79;
            this.CamLbl.Text = "WEBCAM:";
            // 
            // CmboBox
            // 
            this.CmboBox.FormattingEnabled = true;
            this.CmboBox.Location = new System.Drawing.Point(692, 712);
            this.CmboBox.Name = "CmboBox";
            this.CmboBox.Size = new System.Drawing.Size(243, 21);
            this.CmboBox.TabIndex = 80;
            // 
            // ScanPicBox
            // 
            this.ScanPicBox.BackColor = System.Drawing.Color.Transparent;
            this.ScanPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ScanPicBox.Location = new System.Drawing.Point(518, 505);
            this.ScanPicBox.Name = "ScanPicBox";
            this.ScanPicBox.Size = new System.Drawing.Size(228, 204);
            this.ScanPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ScanPicBox.TabIndex = 81;
            this.ScanPicBox.TabStop = false;
            // 
            // StrtBttn
            // 
            this.StrtBttn.BackColor = System.Drawing.Color.LightSlateGray;
            this.StrtBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StrtBttn.Font = new System.Drawing.Font("Circular Std Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StrtBttn.ForeColor = System.Drawing.Color.White;
            this.StrtBttn.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.StrtBttn.Location = new System.Drawing.Point(551, 454);
            this.StrtBttn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.StrtBttn.Name = "StrtBttn";
            this.StrtBttn.Size = new System.Drawing.Size(150, 46);
            this.StrtBttn.TabIndex = 82;
            this.StrtBttn.Text = "&SCAN ME";
            this.StrtBttn.UseVisualStyleBackColor = false;
            this.StrtBttn.Click += new System.EventHandler(this.StrtBttn_Click);
            // 
            // QrCTxtBox
            // 
            this.QrCTxtBox.BackColor = System.Drawing.Color.White;
            this.QrCTxtBox.Location = new System.Drawing.Point(752, 527);
            this.QrCTxtBox.Multiline = true;
            this.QrCTxtBox.Name = "QrCTxtBox";
            this.QrCTxtBox.Size = new System.Drawing.Size(270, 170);
            this.QrCTxtBox.TabIndex = 83;
            // 
            // Tmer
            // 
            this.Tmer.Interval = 1000;
            this.Tmer.Tick += new System.EventHandler(this.Tmer_Tick);
            // 
            // ClckGenBttn
            // 
            this.ClckGenBttn.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClckGenBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClckGenBttn.Font = new System.Drawing.Font("Circular Std Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClckGenBttn.ForeColor = System.Drawing.Color.White;
            this.ClckGenBttn.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.ClckGenBttn.Location = new System.Drawing.Point(551, 162);
            this.ClckGenBttn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ClckGenBttn.Name = "ClckGenBttn";
            this.ClckGenBttn.Size = new System.Drawing.Size(150, 46);
            this.ClckGenBttn.TabIndex = 84;
            this.ClckGenBttn.Text = "&GENERATE";
            this.ClckGenBttn.UseVisualStyleBackColor = false;
            this.ClckGenBttn.Click += new System.EventHandler(this.ClckGenBttn_Click);
            // 
            // QrCdePcBox
            // 
            this.QrCdePcBox.BackColor = System.Drawing.Color.Transparent;
            this.QrCdePcBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QrCdePcBox.Location = new System.Drawing.Point(499, 213);
            this.QrCdePcBox.Name = "QrCdePcBox";
            this.QrCdePcBox.Size = new System.Drawing.Size(247, 228);
            this.QrCdePcBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.QrCdePcBox.TabIndex = 86;
            this.QrCdePcBox.TabStop = false;
            // 
            // infoslabel
            // 
            this.infoslabel.AutoSize = true;
            this.infoslabel.Location = new System.Drawing.Point(461, 513);
            this.infoslabel.Name = "infoslabel";
            this.infoslabel.Size = new System.Drawing.Size(0, 13);
            this.infoslabel.TabIndex = 88;
            // 
            // OpFlbttn
            // 
            this.OpFlbttn.BackColor = System.Drawing.Color.LightSlateGray;
            this.OpFlbttn.Font = new System.Drawing.Font("Circular Std Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpFlbttn.ForeColor = System.Drawing.Color.White;
            this.OpFlbttn.Location = new System.Drawing.Point(827, 225);
            this.OpFlbttn.Name = "OpFlbttn";
            this.OpFlbttn.Size = new System.Drawing.Size(129, 38);
            this.OpFlbttn.TabIndex = 89;
            this.OpFlbttn.Text = "Open File";
            this.OpFlbttn.UseVisualStyleBackColor = false;
            this.OpFlbttn.Click += new System.EventHandler(this.OpFlbttn_Click);
            // 
            // RecrdPicRchTxtBox
            // 
            this.RecrdPicRchTxtBox.Location = new System.Drawing.Point(763, 269);
            this.RecrdPicRchTxtBox.Name = "RecrdPicRchTxtBox";
            this.RecrdPicRchTxtBox.Size = new System.Drawing.Size(255, 156);
            this.RecrdPicRchTxtBox.TabIndex = 90;
            this.RecrdPicRchTxtBox.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(192, 281);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Circular Std Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(107, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 40);
            this.label2.TabIndex = 94;
            this.label2.Text = "Help the community safe by declaring\r\nif you have visited Harbor Point Mall";
            // 
            // FNTxtBox
            // 
            this.FNTxtBox.Font = new System.Drawing.Font("Circular Std Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNTxtBox.ForeColor = System.Drawing.Color.DarkGray;
            this.FNTxtBox.Location = new System.Drawing.Point(88, 409);
            this.FNTxtBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.FNTxtBox.Multiline = true;
            this.FNTxtBox.Name = "FNTxtBox";
            this.FNTxtBox.Size = new System.Drawing.Size(324, 32);
            this.FNTxtBox.TabIndex = 96;
            this.FNTxtBox.Text = "First Name";
            this.FNTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Circular Std Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox1.Location = new System.Drawing.Point(88, 447);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(324, 32);
            this.textBox1.TabIndex = 97;
            this.textBox1.Text = "Last Name";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Circular Std Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox2.Location = new System.Drawing.Point(88, 483);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(324, 32);
            this.textBox2.TabIndex = 98;
            this.textBox2.Text = "City";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Circular Std Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox3.Location = new System.Drawing.Point(88, 519);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(324, 32);
            this.textBox3.TabIndex = 99;
            this.textBox3.Text = "Mobile Number";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Circular Std Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox4.Location = new System.Drawing.Point(181, 604);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(126, 32);
            this.textBox4.TabIndex = 100;
            this.textBox4.Text = "Yes or No";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Circular Std Bold", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(9, 564);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(489, 38);
            this.label3.TabIndex = 101;
            this.label3.Text = "Are you currently experiencing any type of the  following symptoms:\r\nsore throat," +
    " body pains, headache and fever.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Circular Std Bold", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(85, 656);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(347, 36);
            this.label4.TabIndex = 102;
            this.label4.Text = "I understand that by clicking the submit button, I am \r\nagreeing to the Harbor Po" +
    "int Mall Privacy Policy.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(64, 668);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 103;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(47, 108);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(403, 147);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 110;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(144, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(91, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 111;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(232, 38);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(91, 80);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 112;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Circular Std Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(201, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 114;
            this.label5.Text = "You are at";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern Machine", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(507, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 39);
            this.label1.TabIndex = 115;
            this.label1.Text = "HOW TO TRACE TOGETHER?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.MidnightBlue;
            this.label6.Font = new System.Drawing.Font("Circular Std Bold", 14F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(547, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(444, 24);
            this.label6.TabIndex = 116;
            this.label6.Text = "FILL UP the form and declare your health at once";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.SteelBlue;
            this.label7.Font = new System.Drawing.Font("Circular Std Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(547, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(435, 24);
            this.label7.TabIndex = 117;
            this.label7.Text = "GENERATE Qr Code after you filled up the form";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.RoyalBlue;
            this.label8.Font = new System.Drawing.Font("Circular Std Bold", 14F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(547, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(318, 24);
            this.label8.TabIndex = 118;
            this.label8.Text = "SCAN your Qr Code for easy entry";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Crimson;
            this.label10.Font = new System.Drawing.Font("Modern Machine", 16F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(513, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 27);
            this.label10.TabIndex = 120;
            this.label10.Text = "2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Crimson;
            this.label11.Font = new System.Drawing.Font("Modern Machine", 16F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(514, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 27);
            this.label11.TabIndex = 121;
            this.label11.Text = "3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Crimson;
            this.label9.Font = new System.Drawing.Font("Modern Machine", 16F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(514, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 27);
            this.label9.TabIndex = 122;
            this.label9.Text = "1";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1048, 745);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.FNTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RecrdPicRchTxtBox);
            this.Controls.Add(this.OpFlbttn);
            this.Controls.Add(this.infoslabel);
            this.Controls.Add(this.QrCdePcBox);
            this.Controls.Add(this.ClckGenBttn);
            this.Controls.Add(this.QrCTxtBox);
            this.Controls.Add(this.StrtBttn);
            this.Controls.Add(this.ScanPicBox);
            this.Controls.Add(this.CmboBox);
            this.Controls.Add(this.CamLbl);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TRACE TOGETHER";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form6_FormClosing);
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ScanPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QrCdePcBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CamLbl;
        private System.Windows.Forms.ComboBox CmboBox;
        private System.Windows.Forms.PictureBox ScanPicBox;
        private System.Windows.Forms.Button StrtBttn;
        private System.Windows.Forms.TextBox QrCTxtBox;
        private System.Windows.Forms.Timer Tmer;
        private System.Windows.Forms.Button ClckGenBttn;
        private System.Windows.Forms.PictureBox QrCdePcBox;
        private System.Windows.Forms.Label infoslabel;
        private System.Windows.Forms.Button OpFlbttn;
        private System.Windows.Forms.RichTextBox RecrdPicRchTxtBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FNTxtBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
    }
}