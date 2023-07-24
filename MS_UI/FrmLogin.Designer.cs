namespace MS_UI
{
    partial class FrmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_UserId = new System.Windows.Forms.TextBox();
            this.txt_UserPwd = new System.Windows.Forms.TextBox();
            this.chk_AnnoLogin = new System.Windows.Forms.CheckBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.pic_Main = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(815, 790);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(815, 841);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "密码：";
            // 
            // txt_UserId
            // 
            this.txt_UserId.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_UserId.Location = new System.Drawing.Point(944, 790);
            this.txt_UserId.Name = "txt_UserId";
            this.txt_UserId.Size = new System.Drawing.Size(162, 31);
            this.txt_UserId.TabIndex = 0;
            this.txt_UserId.Text = "10000";
            this.txt_UserId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_UserId_KeyDown);
            // 
            // txt_UserPwd
            // 
            this.txt_UserPwd.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_UserPwd.Location = new System.Drawing.Point(944, 841);
            this.txt_UserPwd.Name = "txt_UserPwd";
            this.txt_UserPwd.PasswordChar = '*';
            this.txt_UserPwd.Size = new System.Drawing.Size(162, 31);
            this.txt_UserPwd.TabIndex = 1;
            this.txt_UserPwd.Text = "123";
            this.txt_UserPwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_UserPwd_KeyDown);
            // 
            // chk_AnnoLogin
            // 
            this.chk_AnnoLogin.AutoSize = true;
            this.chk_AnnoLogin.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chk_AnnoLogin.Location = new System.Drawing.Point(1132, 842);
            this.chk_AnnoLogin.Name = "chk_AnnoLogin";
            this.chk_AnnoLogin.Size = new System.Drawing.Size(104, 28);
            this.chk_AnnoLogin.TabIndex = 3;
            this.chk_AnnoLogin.Text = "匿名登录";
            this.chk_AnnoLogin.UseVisualStyleBackColor = true;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Login.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Login.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Login.Location = new System.Drawing.Point(812, 897);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(107, 37);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "登录";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Exit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Exit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Exit.Location = new System.Drawing.Point(1001, 897);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(105, 37);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "退出";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // pic_Main
            // 
            this.pic_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_Main.Image = global::MS_UI.Properties.Resources.系统登录;
            this.pic_Main.Location = new System.Drawing.Point(0, 0);
            this.pic_Main.Name = "pic_Main";
            this.pic_Main.Size = new System.Drawing.Size(1920, 1080);
            this.pic_Main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Main.TabIndex = 0;
            this.pic_Main.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.chk_AnnoLogin);
            this.Controls.Add(this.txt_UserPwd);
            this.Controls.Add(this.txt_UserId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pic_Main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Main;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_UserId;
        private System.Windows.Forms.TextBox txt_UserPwd;
        private System.Windows.Forms.CheckBox chk_AnnoLogin;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Exit;
    }
}