namespace Contact_Tracing_App
{
    partial class Form4
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
            this.allrecordslbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // allrecordslbl
            // 
            this.allrecordslbl.AutoSize = true;
            this.allrecordslbl.Font = new System.Drawing.Font("Circular Std Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allrecordslbl.Location = new System.Drawing.Point(12, 9);
            this.allrecordslbl.Name = "allrecordslbl";
            this.allrecordslbl.Size = new System.Drawing.Size(0, 27);
            this.allrecordslbl.TabIndex = 0;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(530, 676);
            this.Controls.Add(this.allrecordslbl);
            this.Name = "Form4";
            this.Text = "All Data Records";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label allrecordslbl;
    }
}