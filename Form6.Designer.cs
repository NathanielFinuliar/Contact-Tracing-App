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
            this.CrrntADDLbl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StrtBttn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CrrntADDLbl
            // 
            this.CrrntADDLbl.AutoSize = true;
            this.CrrntADDLbl.BackColor = System.Drawing.Color.Transparent;
            this.CrrntADDLbl.Font = new System.Drawing.Font("Circular Std Bold", 18F, System.Drawing.FontStyle.Bold);
            this.CrrntADDLbl.ForeColor = System.Drawing.Color.Crimson;
            this.CrrntADDLbl.Location = new System.Drawing.Point(35, 59);
            this.CrrntADDLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CrrntADDLbl.Name = "CrrntADDLbl";
            this.CrrntADDLbl.Size = new System.Drawing.Size(123, 30);
            this.CrrntADDLbl.TabIndex = 79;
            this.CrrntADDLbl.Text = "CAMERA:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(177, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(263, 21);
            this.comboBox1.TabIndex = 80;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(22, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(418, 377);
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            // 
            // StrtBttn
            // 
            this.StrtBttn.BackColor = System.Drawing.Color.NavajoWhite;
            this.StrtBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StrtBttn.Font = new System.Drawing.Font("Circular Std Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StrtBttn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.StrtBttn.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.StrtBttn.Location = new System.Drawing.Point(477, 88);
            this.StrtBttn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.StrtBttn.Name = "StrtBttn";
            this.StrtBttn.Size = new System.Drawing.Size(119, 41);
            this.StrtBttn.TabIndex = 82;
            this.StrtBttn.Text = "&Start";
            this.StrtBttn.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(463, 157);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(341, 218);
            this.textBox1.TabIndex = 83;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(827, 580);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.StrtBttn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.CrrntADDLbl);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Code Scanner & Generator";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CrrntADDLbl;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button StrtBttn;
        private System.Windows.Forms.TextBox textBox1;
    }
}