namespace Contact_Tracing_App
{
    partial class Form5
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
            this.Alldatelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Alldatelbl
            // 
            this.Alldatelbl.AutoSize = true;
            this.Alldatelbl.Location = new System.Drawing.Point(12, 9);
            this.Alldatelbl.Name = "Alldatelbl";
            this.Alldatelbl.Size = new System.Drawing.Size(0, 13);
            this.Alldatelbl.TabIndex = 0;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(447, 450);
            this.Controls.Add(this.Alldatelbl);
            this.Name = "Form5";
            this.Text = "All Data Records by Date";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Alldatelbl;
    }
}