namespace MS_UI
{
    partial class FrmMain
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_User = new System.Windows.Forms.Label();
            this.lbl_DateTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MiddlePanel = new System.Windows.Forms.Panel();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_HardWareConfig = new System.Windows.Forms.Button();
            this.btn_DataReport = new System.Windows.Forms.Button();
            this.btn_Alarm = new System.Windows.Forms.Button();
            this.btn_Trend = new System.Windows.Forms.Button();
            this.btn_ParamSet = new System.Windows.Forms.Button();
            this.btn_View = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.BottomPanel);
            this.splitContainer1.Size = new System.Drawing.Size(1920, 1080);
            this.splitContainer1.SplitterDistance = 999;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.TopPanel);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.MiddlePanel);
            this.splitContainer2.Size = new System.Drawing.Size(1920, 999);
            this.splitContainer2.SplitterDistance = 89;
            this.splitContainer2.TabIndex = 0;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(96)))), ((int)(((byte)(115)))));
            this.TopPanel.Controls.Add(this.pictureBox1);
            this.TopPanel.Controls.Add(this.label4);
            this.TopPanel.Controls.Add(this.lbl_User);
            this.TopPanel.Controls.Add(this.lbl_DateTime);
            this.TopPanel.Controls.Add(this.label3);
            this.TopPanel.Controls.Add(this.lbl_Title);
            this.TopPanel.Controls.Add(this.label2);
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1920, 89);
            this.TopPanel.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label4.Location = new System.Drawing.Point(1506, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 36);
            this.label4.TabIndex = 2;
            this.label4.Text = "当前用户：";
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_User.Location = new System.Drawing.Point(1678, 45);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(155, 36);
            this.lbl_User.TabIndex = 2;
            this.lbl_User.Text = "系统管理员";
            // 
            // lbl_DateTime
            // 
            this.lbl_DateTime.AutoSize = true;
            this.lbl_DateTime.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_DateTime.Location = new System.Drawing.Point(1678, 9);
            this.lbl_DateTime.Name = "lbl_DateTime";
            this.lbl_DateTime.Size = new System.Drawing.Size(230, 36);
            this.lbl_DateTime.TabIndex = 2;
            this.lbl_DateTime.Text = "2023/7/19 16:22";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(96)))), ((int)(((byte)(115)))));
            this.label3.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label3.Location = new System.Drawing.Point(1506, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "系统时间：";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Title.Location = new System.Drawing.Point(842, 25);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(127, 36);
            this.lbl_Title.TabIndex = 2;
            this.lbl_Title.Text = "控制流程";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(124, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Air Pressure System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(124, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "空压机监控系统";
            // 
            // MiddlePanel
            // 
            this.MiddlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MiddlePanel.Location = new System.Drawing.Point(0, 0);
            this.MiddlePanel.Name = "MiddlePanel";
            this.MiddlePanel.Size = new System.Drawing.Size(1920, 906);
            this.MiddlePanel.TabIndex = 0;
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(96)))), ((int)(((byte)(115)))));
            this.BottomPanel.Controls.Add(this.button8);
            this.BottomPanel.Controls.Add(this.btn_Exit);
            this.BottomPanel.Controls.Add(this.btn_HardWareConfig);
            this.BottomPanel.Controls.Add(this.btn_DataReport);
            this.BottomPanel.Controls.Add(this.btn_Alarm);
            this.BottomPanel.Controls.Add(this.btn_Trend);
            this.BottomPanel.Controls.Add(this.btn_ParamSet);
            this.BottomPanel.Controls.Add(this.btn_View);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(1920, 80);
            this.BottomPanel.TabIndex = 0;
            // 
            // button8
            // 
            this.button8.AutoSize = true;
            this.button8.BackColor = System.Drawing.Color.SlateBlue;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button8.ForeColor = System.Drawing.Color.Gainsboro;
            this.button8.Location = new System.Drawing.Point(1762, 23);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(115, 45);
            this.button8.TabIndex = 1;
            this.button8.Text = "通讯正常";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.AutoSize = true;
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(115)))), ((int)(((byte)(163)))));
            this.btn_Exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Exit.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Exit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Exit.Location = new System.Drawing.Point(1049, 23);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(115, 45);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.Text = "退出系统";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_HardWareConfig
            // 
            this.btn_HardWareConfig.AutoSize = true;
            this.btn_HardWareConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(115)))), ((int)(((byte)(163)))));
            this.btn_HardWareConfig.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_HardWareConfig.FlatAppearance.BorderSize = 0;
            this.btn_HardWareConfig.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_HardWareConfig.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_HardWareConfig.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_HardWareConfig.Location = new System.Drawing.Point(878, 23);
            this.btn_HardWareConfig.Name = "btn_HardWareConfig";
            this.btn_HardWareConfig.Size = new System.Drawing.Size(115, 45);
            this.btn_HardWareConfig.TabIndex = 0;
            this.btn_HardWareConfig.Text = "硬件组态";
            this.btn_HardWareConfig.UseVisualStyleBackColor = false;
            this.btn_HardWareConfig.Click += new System.EventHandler(this.btn_HardWareConfig_Click);
            // 
            // btn_DataReport
            // 
            this.btn_DataReport.AutoSize = true;
            this.btn_DataReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(115)))), ((int)(((byte)(163)))));
            this.btn_DataReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_DataReport.FlatAppearance.BorderSize = 0;
            this.btn_DataReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_DataReport.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_DataReport.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_DataReport.Location = new System.Drawing.Point(707, 23);
            this.btn_DataReport.Name = "btn_DataReport";
            this.btn_DataReport.Size = new System.Drawing.Size(115, 45);
            this.btn_DataReport.TabIndex = 0;
            this.btn_DataReport.Text = "数据报表";
            this.btn_DataReport.UseVisualStyleBackColor = false;
            this.btn_DataReport.Click += new System.EventHandler(this.btn_DataReport_Click);
            // 
            // btn_Alarm
            // 
            this.btn_Alarm.AutoSize = true;
            this.btn_Alarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(115)))), ((int)(((byte)(163)))));
            this.btn_Alarm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Alarm.FlatAppearance.BorderSize = 0;
            this.btn_Alarm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Alarm.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Alarm.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Alarm.Location = new System.Drawing.Point(536, 23);
            this.btn_Alarm.Name = "btn_Alarm";
            this.btn_Alarm.Size = new System.Drawing.Size(115, 45);
            this.btn_Alarm.TabIndex = 0;
            this.btn_Alarm.Text = "故障报警";
            this.btn_Alarm.UseVisualStyleBackColor = false;
            this.btn_Alarm.Click += new System.EventHandler(this.btn_Alarm_Click);
            // 
            // btn_Trend
            // 
            this.btn_Trend.AutoSize = true;
            this.btn_Trend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(115)))), ((int)(((byte)(163)))));
            this.btn_Trend.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Trend.FlatAppearance.BorderSize = 0;
            this.btn_Trend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Trend.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Trend.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Trend.Location = new System.Drawing.Point(365, 23);
            this.btn_Trend.Name = "btn_Trend";
            this.btn_Trend.Size = new System.Drawing.Size(115, 45);
            this.btn_Trend.TabIndex = 0;
            this.btn_Trend.Text = "趋势曲线";
            this.btn_Trend.UseVisualStyleBackColor = false;
            this.btn_Trend.Click += new System.EventHandler(this.btn_Trend_Click);
            // 
            // btn_ParamSet
            // 
            this.btn_ParamSet.AutoSize = true;
            this.btn_ParamSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(115)))), ((int)(((byte)(163)))));
            this.btn_ParamSet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_ParamSet.FlatAppearance.BorderSize = 0;
            this.btn_ParamSet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ParamSet.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ParamSet.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_ParamSet.Location = new System.Drawing.Point(194, 23);
            this.btn_ParamSet.Name = "btn_ParamSet";
            this.btn_ParamSet.Size = new System.Drawing.Size(115, 45);
            this.btn_ParamSet.TabIndex = 0;
            this.btn_ParamSet.Text = "参数设置";
            this.btn_ParamSet.UseVisualStyleBackColor = false;
            this.btn_ParamSet.Click += new System.EventHandler(this.btn_ParamSet_Click);
            // 
            // btn_View
            // 
            this.btn_View.AutoSize = true;
            this.btn_View.BackColor = System.Drawing.Color.Crimson;
            this.btn_View.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_View.FlatAppearance.BorderSize = 0;
            this.btn_View.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_View.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_View.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_View.Location = new System.Drawing.Point(23, 23);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(120, 45);
            this.btn_View.TabIndex = 0;
            this.btn_View.Text = "控制流程";
            this.btn_View.UseVisualStyleBackColor = false;
            this.btn_View.Click += new System.EventHandler(this.btn_View_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MS_UI.Properties.Resources.黄鹤楼;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel MiddlePanel;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_DateTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_HardWareConfig;
        private System.Windows.Forms.Button btn_DataReport;
        private System.Windows.Forms.Button btn_Alarm;
        private System.Windows.Forms.Button btn_Trend;
        private System.Windows.Forms.Button btn_ParamSet;
        private System.Windows.Forms.Button btn_View;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}