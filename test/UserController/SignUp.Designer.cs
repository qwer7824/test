namespace test
{
    partial class SignUp
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
            this.sign = new System.Windows.Forms.Button();
            this.userId = new System.Windows.Forms.TextBox();
            this.userPw = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.userAddress = new System.Windows.Forms.TextBox();
            this.userPhone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sign
            // 
            this.sign.Location = new System.Drawing.Point(182, 384);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(403, 126);
            this.sign.TabIndex = 0;
            this.sign.Text = "회원등록";
            this.sign.UseVisualStyleBackColor = true;
            this.sign.Click += new System.EventHandler(this.sign_Click);
            // 
            // userId
            // 
            this.userId.Location = new System.Drawing.Point(182, 73);
            this.userId.Name = "userId";
            this.userId.Size = new System.Drawing.Size(403, 35);
            this.userId.TabIndex = 1;
            // 
            // userPw
            // 
            this.userPw.Location = new System.Drawing.Point(182, 132);
            this.userPw.Name = "userPw";
            this.userPw.Size = new System.Drawing.Size(403, 35);
            this.userPw.TabIndex = 1;
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(182, 192);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(403, 35);
            this.userName.TabIndex = 1;
            // 
            // userAddress
            // 
            this.userAddress.Location = new System.Drawing.Point(182, 257);
            this.userAddress.Name = "userAddress";
            this.userAddress.Size = new System.Drawing.Size(403, 35);
            this.userAddress.TabIndex = 1;
            // 
            // userPhone
            // 
            this.userPhone.Location = new System.Drawing.Point(182, 319);
            this.userPhone.Name = "userPhone";
            this.userPhone.Size = new System.Drawing.Size(403, 35);
            this.userPhone.TabIndex = 1;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 537);
            this.Controls.Add(this.userPhone);
            this.Controls.Add(this.userAddress);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.userPw);
            this.Controls.Add(this.userId);
            this.Controls.Add(this.sign);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sign;
        private System.Windows.Forms.TextBox userId;
        private System.Windows.Forms.TextBox userPw;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox userAddress;
        private System.Windows.Forms.TextBox userPhone;
    }
}