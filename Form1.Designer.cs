namespace Contact_Tracing_App
{
    partial class ContactTracing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactTracing));
            this.Sbmt = new System.Windows.Forms.Button();
            this.ContactTracingLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Sbmt
            // 
            this.Sbmt.Location = new System.Drawing.Point(2293, 790);
            this.Sbmt.Margin = new System.Windows.Forms.Padding(13, 7, 13, 7);
            this.Sbmt.Name = "Sbmt";
            this.Sbmt.Size = new System.Drawing.Size(568, 160);
            this.Sbmt.TabIndex = 0;
            this.Sbmt.Text = "Submit";
            this.Sbmt.UseVisualStyleBackColor = true;
            this.Sbmt.Click += new System.EventHandler(this.Sbmt_Click);
            // 
            // ContactTracingLbl
            // 
            this.ContactTracingLbl.AutoSize = true;
            this.ContactTracingLbl.BackColor = System.Drawing.Color.GhostWhite;
            this.ContactTracingLbl.Font = new System.Drawing.Font("Gobold Blocky", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactTracingLbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ContactTracingLbl.Location = new System.Drawing.Point(227, 58);
            this.ContactTracingLbl.Margin = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.ContactTracingLbl.Name = "ContactTracingLbl";
            this.ContactTracingLbl.Size = new System.Drawing.Size(286, 54);
            this.ContactTracingLbl.TabIndex = 1;
            this.ContactTracingLbl.Text = "CONTACT TRACING";
            // 
            // ContactTracing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(779, 529);
            this.Controls.Add(this.ContactTracingLbl);
            this.Controls.Add(this.Sbmt);
            this.Font = new System.Drawing.Font("SF Sports Night Alternate", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(13, 7, 13, 7);
            this.Name = "ContactTracing";
            this.Text = "Contact Tracing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Sbmt;
        private System.Windows.Forms.Label ContactTracingLbl;
    }
}

