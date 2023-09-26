namespace test.UserController
{
    partial class UserSearch
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.userNoText = new System.Windows.Forms.TextBox();
            this.selectBut = new System.Windows.Forms.Button();
            this.userPhone = new System.Windows.Forms.TextBox();
            this.userAddress = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.userId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selectBut);
            this.groupBox1.Controls.Add(this.userNoText);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "회원검색";
            // 
            // userNoText
            // 
            this.userNoText.Location = new System.Drawing.Point(18, 34);
            this.userNoText.Name = "userNoText";
            this.userNoText.Size = new System.Drawing.Size(345, 35);
            this.userNoText.TabIndex = 0;
            // 
            // selectBut
            // 
            this.selectBut.Location = new System.Drawing.Point(385, 34);
            this.selectBut.Name = "selectBut";
            this.selectBut.Size = new System.Drawing.Size(135, 35);
            this.selectBut.TabIndex = 1;
            this.selectBut.Text = "검색";
            this.selectBut.UseVisualStyleBackColor = true;
            this.selectBut.Click += new System.EventHandler(this.selectBut_Click);
            // 
            // userPhone
            // 
            this.userPhone.Location = new System.Drawing.Point(113, 280);
            this.userPhone.Name = "userPhone";
            this.userPhone.Size = new System.Drawing.Size(403, 35);
            this.userPhone.TabIndex = 2;
            // 
            // userAddress
            // 
            this.userAddress.Location = new System.Drawing.Point(113, 233);
            this.userAddress.Name = "userAddress";
            this.userAddress.Size = new System.Drawing.Size(403, 35);
            this.userAddress.TabIndex = 3;
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(113, 180);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(403, 35);
            this.userName.TabIndex = 4;
            // 
            // userId
            // 
            this.userId.Location = new System.Drawing.Point(113, 126);
            this.userId.Name = "userId";
            this.userId.Size = new System.Drawing.Size(403, 35);
            this.userId.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "아이디";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "이름";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "주소";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "휴대폰";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 88);
            this.button1.TabIndex = 2;
            this.button1.Text = "수정";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 502);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userPhone);
            this.Controls.Add(this.userAddress);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.userId);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserSearch";
            this.Text = "UserSearch";
            this.Load += new System.EventHandler(this.UserSearch_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button selectBut;
        private System.Windows.Forms.TextBox userNoText;
        private System.Windows.Forms.TextBox userPhone;
        private System.Windows.Forms.TextBox userAddress;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox userId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}