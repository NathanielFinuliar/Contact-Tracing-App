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
            this.label1 = new System.Windows.Forms.Label();
            this.FilterDateBttn = new System.Windows.Forms.Button();
            this.FlterDte = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox)).BeginInit();
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
            this.DataRecordsLbl.Location = new System.Drawing.Point(68, 62);
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
            this.DisplayAllBttn.Location = new System.Drawing.Point(103, 125);
            this.DisplayAllBttn.Name = "DisplayAllBttn";
            this.DisplayAllBttn.Size = new System.Drawing.Size(135, 43);
            this.DisplayAllBttn.TabIndex = 5;
            this.DisplayAllBttn.Text = "DISPLAY";
            this.DisplayAllBttn.UseVisualStyleBackColor = false;
            this.DisplayAllBttn.Click += new System.EventHandler(this.DisplayAllBttn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Font = new System.Drawing.Font("Circular Std Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(391, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 54);
            this.label1.TabIndex = 6;
            this.label1.Text = "Filter data records\r\nbased on Date";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FilterDateBttn
            // 
            this.FilterDateBttn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.FilterDateBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterDateBttn.ForeColor = System.Drawing.Color.White;
            this.FilterDateBttn.Location = new System.Drawing.Point(515, 125);
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
            this.FlterDte.Location = new System.Drawing.Point(354, 131);
            this.FlterDte.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.FlterDte.Name = "FlterDte";
            this.FlterDte.Size = new System.Drawing.Size(154, 30);
            this.FlterDte.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Font = new System.Drawing.Font("Circular Std Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(214, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 54);
            this.label2.TabIndex = 10;
            this.label2.Text = "Filter data records\r\nbased on Date";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 480);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FlterDte);
            this.Controls.Add(this.FilterDateBttn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DisplayAllBttn);
            this.Controls.Add(this.DataRecordsLbl);
            this.Controls.Add(this.Picbox);
            this.Name = "Form3";
            this.Text = "Harbor Point Admin Desk";
            ((System.ComponentModel.ISupportInitialize)(this.Picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Picbox;
        private System.Windows.Forms.Label DataRecordsLbl;
        private System.Windows.Forms.Button DisplayAllBttn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FilterDateBttn;
        private System.Windows.Forms.DateTimePicker FlterDte;
        private System.Windows.Forms.Label label2;
    }
}