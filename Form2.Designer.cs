namespace Contact_Tracing_App
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.UrsnTxtBox = new System.Windows.Forms.TextBox();
            this.PswrdTxtBox = new System.Windows.Forms.TextBox();
            this.UserLbl = new System.Windows.Forms.Label();
            this.PassLbl = new System.Windows.Forms.Label();
            this.LgnBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UrsnTxtBox
            // 
            this.UrsnTxtBox.BackColor = System.Drawing.Color.DarkSlateGray;
            this.UrsnTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrsnTxtBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.UrsnTxtBox.Location = new System.Drawing.Point(112, 361);
            this.UrsnTxtBox.Name = "UrsnTxtBox";
            this.UrsnTxtBox.Size = new System.Drawing.Size(203, 26);
            this.UrsnTxtBox.TabIndex = 0;
            this.UrsnTxtBox.Text = "admin123";
            this.UrsnTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UrsnTxtBox.Enter += new System.EventHandler(this.UrsnTxtBox_Enter);
            this.UrsnTxtBox.Leave += new System.EventHandler(this.UrsnTxtBox_Leave);
            // 
            // PswrdTxtBox
            // 
            this.PswrdTxtBox.BackColor = System.Drawing.Color.DarkSlateGray;
            this.PswrdTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PswrdTxtBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.PswrdTxtBox.Location = new System.Drawing.Point(112, 444);
            this.PswrdTxtBox.Name = "PswrdTxtBox";
            this.PswrdTxtBox.PasswordChar = '*';
            this.PswrdTxtBox.Size = new System.Drawing.Size(203, 26);
            this.PswrdTxtBox.TabIndex = 1;
            this.PswrdTxtBox.Text = "enteryourpass";
            this.PswrdTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PswrdTxtBox.Enter += new System.EventHandler(this.PswrdTxtBox_Enter);
            this.PswrdTxtBox.Leave += new System.EventHandler(this.PswrdTxtBox_Leave);
            // 
            // UserLbl
            // 
            this.UserLbl.AutoSize = true;
            this.UserLbl.BackColor = System.Drawing.Color.White;
            this.UserLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLbl.Location = new System.Drawing.Point(145, 390);
            this.UserLbl.Name = "UserLbl";
            this.UserLbl.Size = new System.Drawing.Size(131, 25);
            this.UserLbl.TabIndex = 2;
            this.UserLbl.Text = "USERNAME";
            // 
            // PassLbl
            // 
            this.PassLbl.AutoSize = true;
            this.PassLbl.BackColor = System.Drawing.Color.White;
            this.PassLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassLbl.Location = new System.Drawing.Point(145, 473);
            this.PassLbl.Name = "PassLbl";
            this.PassLbl.Size = new System.Drawing.Size(134, 25);
            this.PassLbl.TabIndex = 3;
            this.PassLbl.Text = "PASSWORD";
            // 
            // LgnBttn
            // 
            this.LgnBttn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.LgnBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LgnBttn.ForeColor = System.Drawing.Color.White;
            this.LgnBttn.Location = new System.Drawing.Point(150, 513);
            this.LgnBttn.Name = "LgnBttn";
            this.LgnBttn.Size = new System.Drawing.Size(117, 43);
            this.LgnBttn.TabIndex = 4;
            this.LgnBttn.Text = "LOG IN";
            this.LgnBttn.UseVisualStyleBackColor = false;
            this.LgnBttn.Click += new System.EventHandler(this.LgnBttn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(410, 594);
            this.Controls.Add(this.LgnBttn);
            this.Controls.Add(this.PassLbl);
            this.Controls.Add(this.UserLbl);
            this.Controls.Add(this.PswrdTxtBox);
            this.Controls.Add(this.UrsnTxtBox);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOG IN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UrsnTxtBox;
        private System.Windows.Forms.TextBox PswrdTxtBox;
        private System.Windows.Forms.Label UserLbl;
        private System.Windows.Forms.Label PassLbl;
        private System.Windows.Forms.Button LgnBttn;
    }
}