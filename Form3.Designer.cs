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
            this.Picbox = new System.Windows.Forms.PictureBox();
            this.DataRecordsLbl = new System.Windows.Forms.Label();
            this.DisplayAllBttn = new System.Windows.Forms.Button();
            this.FilterDatelbl = new System.Windows.Forms.Label();
            this.FilterDateBttn = new System.Windows.Forms.Button();
            this.FlterDte = new System.Windows.Forms.DateTimePicker();
            this.pcBx1 = new System.Windows.Forms.PictureBox();
            this.CTIlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBx1)).BeginInit();
            this.SuspendLayout();
            // 
            // Picbox
            // 
            this.Picbox.Image = ((System.Drawing.Image)(resources.GetObject("Picbox.Image")));
            this.Picbox.Location = new System.Drawing.Point(-16, -7);
            this.Picbox.Name = "Picbox";
            this.Picbox.Size = new System.Drawing.Size(715, 488);
            this.Picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picbox.TabIndex = 0;
            this.Picbox.TabStop = false;
            // 
            // DataRecordsLbl
            // 
            this.DataRecordsLbl.AutoSize = true;
            this.DataRecordsLbl.BackColor = System.Drawing.Color.DarkSlateGray;
            this.DataRecordsLbl.Font = new System.Drawing.Font("Circular Std Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataRecordsLbl.ForeColor = System.Drawing.Color.White;
            this.DataRecordsLbl.Location = new System.Drawing.Point(60, 116);
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
            this.DisplayAllBttn.Location = new System.Drawing.Point(99, 173);
            this.DisplayAllBttn.Name = "DisplayAllBttn";
            this.DisplayAllBttn.Size = new System.Drawing.Size(135, 43);
            this.DisplayAllBttn.TabIndex = 5;
            this.DisplayAllBttn.Text = "DISPLAY";
            this.DisplayAllBttn.UseVisualStyleBackColor = false;
            this.DisplayAllBttn.Click += new System.EventHandler(this.DisplayAllBttn_Click);
            // 
            // FilterDatelbl
            // 
            this.FilterDatelbl.AutoSize = true;
            this.FilterDatelbl.BackColor = System.Drawing.Color.DarkSlateGray;
            this.FilterDatelbl.Font = new System.Drawing.Font("Circular Std Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterDatelbl.ForeColor = System.Drawing.Color.White;
            this.FilterDatelbl.Location = new System.Drawing.Point(379, 116);
            this.FilterDatelbl.Name = "FilterDatelbl";
            this.FilterDatelbl.Size = new System.Drawing.Size(192, 54);
            this.FilterDatelbl.TabIndex = 6;
            this.FilterDatelbl.Text = "Filter data records\r\nbased on Date";
            this.FilterDatelbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FilterDateBttn
            // 
            this.FilterDateBttn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.FilterDateBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterDateBttn.ForeColor = System.Drawing.Color.White;
            this.FilterDateBttn.Location = new System.Drawing.Point(507, 173);
            this.FilterDateBttn.Name = "FilterDateBttn";
            this.FilterDateBttn.Size = new System.Drawing.Size(112, 43);
            this.FilterDateBttn.TabIndex = 7;
            this.FilterDateBttn.Text = "SHOW";
            this.FilterDateBttn.UseVisualStyleBackColor = false;
            this.FilterDateBttn.Click += new System.EventHandler(this.FilterDateBttn_Click);
            // 
            // FlterDte
            // 
            this.FlterDte.CalendarFont = new System.Drawing.Font("Circular Std Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlterDte.CustomFormat = "";
            this.FlterDte.Font = new System.Drawing.Font("Circular Std Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlterDte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FlterDte.Location = new System.Drawing.Point(346, 179);
            this.FlterDte.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.FlterDte.Name = "FlterDte";
            this.FlterDte.Size = new System.Drawing.Size(154, 30);
            this.FlterDte.TabIndex = 9;
            // 
            // pcBx1
            // 
            this.pcBx1.BackColor = System.Drawing.Color.White;
            this.pcBx1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcBx1.BackgroundImage")));
            this.pcBx1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcBx1.Location = new System.Drawing.Point(38, 22);
            this.pcBx1.Name = "pcBx1";
            this.pcBx1.Size = new System.Drawing.Size(68, 57);
            this.pcBx1.TabIndex = 10;
            this.pcBx1.TabStop = false;
            // 
            // CTIlbl
            // 
            this.CTIlbl.AutoSize = true;
            this.CTIlbl.BackColor = System.Drawing.Color.Cornsilk;
            this.CTIlbl.Font = new System.Drawing.Font("Alphakind", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTIlbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.CTIlbl.Location = new System.Drawing.Point(122, 35);
            this.CTIlbl.Name = "CTIlbl";
            this.CTIlbl.Size = new System.Drawing.Size(536, 35);
            this.CTIlbl.TabIndex = 11;
            this.CTIlbl.Text = "Contact Tracing Information Records";
            this.CTIlbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 480);
            this.Controls.Add(this.CTIlbl);
            this.Controls.Add(this.pcBx1);
            this.Controls.Add(this.FlterDte);
            this.Controls.Add(this.FilterDateBttn);
            this.Controls.Add(this.FilterDatelbl);
            this.Controls.Add(this.DisplayAllBttn);
            this.Controls.Add(this.DataRecordsLbl);
            this.Controls.Add(this.Picbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Harbor Point Admin Desk";
            ((System.ComponentModel.ISupportInitialize)(this.Picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBx1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Picbox;
        private System.Windows.Forms.Label DataRecordsLbl;
        private System.Windows.Forms.Button DisplayAllBttn;
        private System.Windows.Forms.Label FilterDatelbl;
        private System.Windows.Forms.Button FilterDateBttn;
        private System.Windows.Forms.DateTimePicker FlterDte;
        private System.Windows.Forms.PictureBox pcBx1;
        private System.Windows.Forms.Label CTIlbl;
    }
}