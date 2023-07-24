namespace MS_UI
{
    partial class FrmHardWareConfig
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
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.btn_UserRight = new System.Windows.Forms.Button();
            this.btn_DataConfig = new System.Windows.Forms.Button();
            this.btn_TrendConfig = new System.Windows.Forms.Button();
            this.btn_AlarmConfig = new System.Windows.Forms.Button();
            this.btn_ParamConfig = new System.Windows.Forms.Button();
            this.btn_IOVarConfig = new System.Windows.Forms.Button();
            this.btn_ProtocalConfig = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.LeftPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.MainPanel);
            this.splitContainer1.Size = new System.Drawing.Size(1426, 687);
            this.splitContainer1.SplitterDistance = 158;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.LeftPanel.Controls.Add(this.btn_UserRight);
            this.LeftPanel.Controls.Add(this.btn_DataConfig);
            this.LeftPanel.Controls.Add(this.btn_TrendConfig);
            this.LeftPanel.Controls.Add(this.btn_AlarmConfig);
            this.LeftPanel.Controls.Add(this.btn_ParamConfig);
            this.LeftPanel.Controls.Add(this.btn_IOVarConfig);
            this.LeftPanel.Controls.Add(this.btn_ProtocalConfig);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(158, 687);
            this.LeftPanel.TabIndex = 0;
            // 
            // btn_UserRight
            // 
            this.btn_UserRight.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_UserRight.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_UserRight.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_UserRight.Location = new System.Drawing.Point(9, 558);
            this.btn_UserRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_UserRight.Name = "btn_UserRight";
            this.btn_UserRight.Size = new System.Drawing.Size(134, 59);
            this.btn_UserRight.TabIndex = 0;
            this.btn_UserRight.Text = "用 户 权 限 配 置";
            this.btn_UserRight.UseVisualStyleBackColor = false;
            this.btn_UserRight.Click += new System.EventHandler(this.btn_UserRight_Click);
            // 
            // btn_DataConfig
            // 
            this.btn_DataConfig.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_DataConfig.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_DataConfig.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_DataConfig.Location = new System.Drawing.Point(9, 468);
            this.btn_DataConfig.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_DataConfig.Name = "btn_DataConfig";
            this.btn_DataConfig.Size = new System.Drawing.Size(134, 59);
            this.btn_DataConfig.TabIndex = 0;
            this.btn_DataConfig.Text = "报 表 信 息 配 置";
            this.btn_DataConfig.UseVisualStyleBackColor = false;
            this.btn_DataConfig.Click += new System.EventHandler(this.btn_DataConfig_Click);
            // 
            // btn_TrendConfig
            // 
            this.btn_TrendConfig.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_TrendConfig.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_TrendConfig.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_TrendConfig.Location = new System.Drawing.Point(9, 382);
            this.btn_TrendConfig.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_TrendConfig.Name = "btn_TrendConfig";
            this.btn_TrendConfig.Size = new System.Drawing.Size(134, 59);
            this.btn_TrendConfig.TabIndex = 0;
            this.btn_TrendConfig.Text = "趋 势 信 息 配 置";
            this.btn_TrendConfig.UseVisualStyleBackColor = false;
            this.btn_TrendConfig.Click += new System.EventHandler(this.btn_TrendConfig_Click);
            // 
            // btn_AlarmConfig
            // 
            this.btn_AlarmConfig.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_AlarmConfig.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_AlarmConfig.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_AlarmConfig.Location = new System.Drawing.Point(9, 299);
            this.btn_AlarmConfig.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_AlarmConfig.Name = "btn_AlarmConfig";
            this.btn_AlarmConfig.Size = new System.Drawing.Size(134, 59);
            this.btn_AlarmConfig.TabIndex = 0;
            this.btn_AlarmConfig.Text = "报 警 信 息 配 置";
            this.btn_AlarmConfig.UseVisualStyleBackColor = false;
            this.btn_AlarmConfig.Click += new System.EventHandler(this.btn_AlarmConfig_Click);
            // 
            // btn_ParamConfig
            // 
            this.btn_ParamConfig.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_ParamConfig.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ParamConfig.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_ParamConfig.Location = new System.Drawing.Point(9, 213);
            this.btn_ParamConfig.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ParamConfig.Name = "btn_ParamConfig";
            this.btn_ParamConfig.Size = new System.Drawing.Size(134, 59);
            this.btn_ParamConfig.TabIndex = 0;
            this.btn_ParamConfig.Text = "参 数 信 息 配 置";
            this.btn_ParamConfig.UseVisualStyleBackColor = false;
            this.btn_ParamConfig.Click += new System.EventHandler(this.btn_ParamConfig_Click);
            // 
            // btn_IOVarConfig
            // 
            this.btn_IOVarConfig.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_IOVarConfig.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_IOVarConfig.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_IOVarConfig.Location = new System.Drawing.Point(9, 121);
            this.btn_IOVarConfig.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_IOVarConfig.Name = "btn_IOVarConfig";
            this.btn_IOVarConfig.Size = new System.Drawing.Size(134, 59);
            this.btn_IOVarConfig.TabIndex = 0;
            this.btn_IOVarConfig.Text = "IO 变 量 配 置";
            this.btn_IOVarConfig.UseVisualStyleBackColor = false;
            this.btn_IOVarConfig.Click += new System.EventHandler(this.btn_IOVarConfig_Click);
            // 
            // btn_ProtocalConfig
            // 
            this.btn_ProtocalConfig.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_ProtocalConfig.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ProtocalConfig.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_ProtocalConfig.Location = new System.Drawing.Point(9, 38);
            this.btn_ProtocalConfig.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ProtocalConfig.Name = "btn_ProtocalConfig";
            this.btn_ProtocalConfig.Size = new System.Drawing.Size(134, 59);
            this.btn_ProtocalConfig.TabIndex = 0;
            this.btn_ProtocalConfig.Text = "协 议 信 息 配 置";
            this.btn_ProtocalConfig.UseVisualStyleBackColor = false;
            this.btn_ProtocalConfig.Click += new System.EventHandler(this.btn_ProtocalConfig_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1267, 687);
            this.MainPanel.TabIndex = 0;
            // 
            // FrmHardWareConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 687);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmHardWareConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHardWareConfig";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.LeftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Button btn_UserRight;
        private System.Windows.Forms.Button btn_DataConfig;
        private System.Windows.Forms.Button btn_TrendConfig;
        private System.Windows.Forms.Button btn_AlarmConfig;
        private System.Windows.Forms.Button btn_ParamConfig;
        private System.Windows.Forms.Button btn_IOVarConfig;
        private System.Windows.Forms.Button btn_ProtocalConfig;
        private System.Windows.Forms.Panel MainPanel;
    }
}