namespace MS_UI.Form_HardWareConfig
{
    partial class FrmIOVarConfig
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.VarName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsFiling = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsAlarm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsReport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AbsoluteAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TopPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.MainPanel);
            this.splitContainer1.Size = new System.Drawing.Size(1672, 812);
            this.splitContainer1.SplitterDistance = 94;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.btn_Save);
            this.TopPanel.Controls.Add(this.btn_Delete);
            this.TopPanel.Controls.Add(this.btn_Update);
            this.TopPanel.Controls.Add(this.btn_New);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1672, 94);
            this.TopPanel.TabIndex = 0;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(679, 22);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(141, 50);
            this.btn_Save.TabIndex = 0;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(476, 22);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(141, 50);
            this.btn_Delete.TabIndex = 0;
            this.btn_Delete.Text = "删除";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(271, 22);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(141, 50);
            this.btn_Update.TabIndex = 0;
            this.btn_Update.Text = "修改";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_New
            // 
            this.btn_New.Location = new System.Drawing.Point(79, 22);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(141, 50);
            this.btn_New.TabIndex = 0;
            this.btn_New.Text = "新建";
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.dataGridView1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1672, 717);
            this.MainPanel.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VarName,
            this.DataType,
            this.StoreArea,
            this.Address,
            this.IsFiling,
            this.IsAlarm,
            this.IsReport,
            this.Note,
            this.AbsoluteAddress});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1672, 717);
            this.dataGridView1.TabIndex = 0;
            // 
            // VarName
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumPurple;
            this.VarName.DefaultCellStyle = dataGridViewCellStyle2;
            this.VarName.Frozen = true;
            this.VarName.HeaderText = "变量名";
            this.VarName.MinimumWidth = 6;
            this.VarName.Name = "VarName";
            this.VarName.ReadOnly = true;
            this.VarName.Width = 200;
            // 
            // DataType
            // 
            this.DataType.HeaderText = "数据类型";
            this.DataType.MinimumWidth = 6;
            this.DataType.Name = "DataType";
            this.DataType.ReadOnly = true;
            this.DataType.Width = 160;
            // 
            // StoreArea
            // 
            this.StoreArea.HeaderText = "存储功能区";
            this.StoreArea.MinimumWidth = 6;
            this.StoreArea.Name = "StoreArea";
            this.StoreArea.ReadOnly = true;
            this.StoreArea.Width = 250;
            // 
            // Address
            // 
            this.Address.HeaderText = "地址";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 80;
            // 
            // IsFiling
            // 
            this.IsFiling.HeaderText = "归档";
            this.IsFiling.MinimumWidth = 6;
            this.IsFiling.Name = "IsFiling";
            this.IsFiling.ReadOnly = true;
            this.IsFiling.Width = 80;
            // 
            // IsAlarm
            // 
            this.IsAlarm.HeaderText = "报警";
            this.IsAlarm.MinimumWidth = 6;
            this.IsAlarm.Name = "IsAlarm";
            this.IsAlarm.ReadOnly = true;
            this.IsAlarm.Width = 80;
            // 
            // IsReport
            // 
            this.IsReport.HeaderText = "报表";
            this.IsReport.MinimumWidth = 6;
            this.IsReport.Name = "IsReport";
            this.IsReport.ReadOnly = true;
            this.IsReport.Width = 80;
            // 
            // Note
            // 
            this.Note.HeaderText = "注释";
            this.Note.MinimumWidth = 6;
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            this.Note.Width = 250;
            // 
            // AbsoluteAddress
            // 
            this.AbsoluteAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AbsoluteAddress.HeaderText = "绝对地址";
            this.AbsoluteAddress.MinimumWidth = 6;
            this.AbsoluteAddress.Name = "AbsoluteAddress";
            this.AbsoluteAddress.ReadOnly = true;
            // 
            // FrmIOVarConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1672, 812);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmIOVarConfig";
            this.Text = "FrmIOVarConfig";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn VarName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsFiling;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsAlarm;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn AbsoluteAddress;
    }
}