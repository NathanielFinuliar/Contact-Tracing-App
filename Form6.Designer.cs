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
            ((System.ComponentModel.ISupportInitialize)(this.ScanPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CamLbl
            // 
            this.CamLbl.AutoSize = true;
            this.CamLbl.BackColor = System.Drawing.Color.Transparent;
            this.CamLbl.Font = new System.Drawing.Font("Circular Std Bold", 18F, System.Drawing.FontStyle.Bold);
            this.CamLbl.ForeColor = System.Drawing.Color.Crimson;
            this.CamLbl.Location = new System.Drawing.Point(52, 352);
            this.CamLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CamLbl.Name = "CamLbl";
            this.CamLbl.Size = new System.Drawing.Size(123, 30);
            this.CamLbl.TabIndex = 79;
            this.CamLbl.Text = "CAMERA:";
            // 
            // CmboBox
            // 
            this.CmboBox.FormattingEnabled = true;
            this.CmboBox.Location = new System.Drawing.Point(182, 352);
            this.CmboBox.Name = "CmboBox";
            this.CmboBox.Size = new System.Drawing.Size(263, 21);
            this.CmboBox.TabIndex = 80;
            // 
            // ScanPicBox
            // 
            this.ScanPicBox.BackColor = System.Drawing.Color.Transparent;
            this.ScanPicBox.Location = new System.Drawing.Point(57, 95);
            this.ScanPicBox.Name = "ScanPicBox";
            this.ScanPicBox.Size = new System.Drawing.Size(375, 249);
            this.ScanPicBox.TabIndex = 81;
            this.ScanPicBox.TabStop = false;
            // 
            // StrtBttn
            // 
            this.StrtBttn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.StrtBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StrtBttn.Font = new System.Drawing.Font("Circular Std Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StrtBttn.ForeColor = System.Drawing.Color.Cornsilk;
            this.StrtBttn.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.StrtBttn.Location = new System.Drawing.Point(57, 38);
            this.StrtBttn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.StrtBttn.Name = "StrtBttn";
            this.StrtBttn.Size = new System.Drawing.Size(375, 41);
            this.StrtBttn.TabIndex = 82;
            this.StrtBttn.Text = "&Start to Scan";
            this.StrtBttn.UseVisualStyleBackColor = false;
            this.StrtBttn.Click += new System.EventHandler(this.StrtBttn_Click);
            // 
            // QrCTxtBox
            // 
            this.QrCTxtBox.BackColor = System.Drawing.Color.OldLace;
            this.QrCTxtBox.Location = new System.Drawing.Point(450, 95);
            this.QrCTxtBox.Multiline = true;
            this.QrCTxtBox.Name = "QrCTxtBox";
            this.QrCTxtBox.Size = new System.Drawing.Size(355, 249);
            this.QrCTxtBox.TabIndex = 83;
            // 
            // Tmer
            // 
            this.Tmer.Interval = 1000;
            this.Tmer.Tick += new System.EventHandler(this.Tmer_Tick);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(843, 708);
            this.Controls.Add(this.QrCTxtBox);
            this.Controls.Add(this.StrtBttn);
            this.Controls.Add(this.ScanPicBox);
            this.Controls.Add(this.CmboBox);
            this.Controls.Add(this.CamLbl);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Code Scanner & Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form6_FormClosing);
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ScanPicBox)).EndInit();
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
    }
}