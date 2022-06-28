namespace Contact_Tracing_App
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DataRecordsLbl = new System.Windows.Forms.Label();
            this.DisplayAllBttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-16, -10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(715, 491);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DataRecordsLbl
            // 
            this.DataRecordsLbl.AutoSize = true;
            this.DataRecordsLbl.BackColor = System.Drawing.Color.DarkSlateGray;
            this.DataRecordsLbl.Font = new System.Drawing.Font("Circular Std Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataRecordsLbl.ForeColor = System.Drawing.Color.White;
            this.DataRecordsLbl.Location = new System.Drawing.Point(36, 62);
            this.DataRecordsLbl.Name = "DataRecordsLbl";
            this.DataRecordsLbl.Size = new System.Drawing.Size(220, 54);
            this.DataRecordsLbl.TabIndex = 1;
            this.DataRecordsLbl.Text = "All data records\r\nfrom Contact Tracing";
            this.DataRecordsLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DisplayAllBttn
            // 
            this.DisplayAllBttn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.DisplayAllBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayAllBttn.ForeColor = System.Drawing.Color.White;
            this.DisplayAllBttn.Location = new System.Drawing.Point(75, 131);
            this.DisplayAllBttn.Name = "DisplayAllBttn";
            this.DisplayAllBttn.Size = new System.Drawing.Size(135, 43);
            this.DisplayAllBttn.TabIndex = 5;
            this.DisplayAllBttn.Text = "DISPLAY";
            this.DisplayAllBttn.UseVisualStyleBackColor = false;
            this.DisplayAllBttn.Click += new System.EventHandler(this.DisplayAllBttn_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 480);
            this.Controls.Add(this.DisplayAllBttn);
            this.Controls.Add(this.DataRecordsLbl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.Text = "Harbor Point Admin Desk";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label DataRecordsLbl;
        private System.Windows.Forms.Button DisplayAllBttn;
    }
}