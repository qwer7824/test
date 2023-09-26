namespace test
{
    partial class Login
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
            this.LoginBut = new System.Windows.Forms.Button();
            this.textId = new System.Windows.Forms.TextBox();
            this.textPw = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LoginBut
            // 
            this.LoginBut.Location = new System.Drawing.Point(280, 59);
            this.LoginBut.Name = "LoginBut";
            this.LoginBut.Size = new System.Drawing.Size(143, 86);
            this.LoginBut.TabIndex = 2;
            this.LoginBut.Text = "로그인";
            this.LoginBut.UseVisualStyleBackColor = true;
            this.LoginBut.Click += new System.EventHandler(this.LoginBut_Click);
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(68, 59);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(174, 35);
            this.textId.TabIndex = 3;
            // 
            // textPw
            // 
            this.textPw.Location = new System.Drawing.Point(68, 100);
            this.textPw.Name = "textPw";
            this.textPw.Size = new System.Drawing.Size(174, 35);
            this.textPw.TabIndex = 3;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 186);
            this.Controls.Add(this.textPw);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.LoginBut);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginBut;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox textPw;
    }
}