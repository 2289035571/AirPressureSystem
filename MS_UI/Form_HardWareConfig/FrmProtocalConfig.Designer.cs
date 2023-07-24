namespace MS_UI.Form_HardWareConfig
{
    partial class FrmProtocalConfig
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
            this.cbx_StopBits = new System.Windows.Forms.ComboBox();
            this.cbx_Address = new System.Windows.Forms.ComboBox();
            this.cbx_Parity = new System.Windows.Forms.ComboBox();
            this.cbx_DataBits = new System.Windows.Forms.ComboBox();
            this.cbx_Port = new System.Windows.Forms.ComboBox();
            this.cbx_Paud = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbx_StopBits);
            this.groupBox1.Controls.Add(this.cbx_Address);
            this.groupBox1.Controls.Add(this.cbx_Parity);
            this.groupBox1.Controls.Add(this.cbx_DataBits);
            this.groupBox1.Controls.Add(this.cbx_Port);
            this.groupBox1.Controls.Add(this.cbx_Paud);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 268);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modbus参数";
            // 
            // cbx_StopBits
            // 
            this.cbx_StopBits.FormattingEnabled = true;
            this.cbx_StopBits.Location = new System.Drawing.Point(476, 175);
            this.cbx_StopBits.Name = "cbx_StopBits";
            this.cbx_StopBits.Size = new System.Drawing.Size(138, 27);
            this.cbx_StopBits.TabIndex = 1;
            // 
            // cbx_Address
            // 
            this.cbx_Address.FormattingEnabled = true;
            this.cbx_Address.Location = new System.Drawing.Point(476, 120);
            this.cbx_Address.Name = "cbx_Address";
            this.cbx_Address.Size = new System.Drawing.Size(138, 27);
            this.cbx_Address.TabIndex = 1;
            // 
            // cbx_Parity
            // 
            this.cbx_Parity.FormattingEnabled = true;
            this.cbx_Parity.Location = new System.Drawing.Point(476, 66);
            this.cbx_Parity.Name = "cbx_Parity";
            this.cbx_Parity.Size = new System.Drawing.Size(138, 27);
            this.cbx_Parity.TabIndex = 1;
            // 
            // cbx_DataBits
            // 
            this.cbx_DataBits.FormattingEnabled = true;
            this.cbx_DataBits.Location = new System.Drawing.Point(165, 175);
            this.cbx_DataBits.Name = "cbx_DataBits";
            this.cbx_DataBits.Size = new System.Drawing.Size(138, 27);
            this.cbx_DataBits.TabIndex = 1;
            // 
            // cbx_Port
            // 
            this.cbx_Port.FormattingEnabled = true;
            this.cbx_Port.Location = new System.Drawing.Point(165, 120);
            this.cbx_Port.Name = "cbx_Port";
            this.cbx_Port.Size = new System.Drawing.Size(138, 27);
            this.cbx_Port.TabIndex = 1;
            // 
            // cbx_Paud
            // 
            this.cbx_Paud.FormattingEnabled = true;
            this.cbx_Paud.Location = new System.Drawing.Point(165, 63);
            this.cbx_Paud.Name = "cbx_Paud";
            this.cbx_Paud.Size = new System.Drawing.Size(138, 27);
            this.cbx_Paud.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(362, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 27);
            this.label7.TabIndex = 0;
            this.label7.Text = "StopBits :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(362, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 27);
            this.label6.TabIndex = 0;
            this.label6.Text = "Address :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(372, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "Parity :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(52, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "DataBits : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(61, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Port :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(61, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paud :";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(88, 322);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(141, 46);
            this.btn_Save.TabIndex = 1;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(411, 322);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(141, 46);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // FrmProtocalConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 392);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmProtocalConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modbus通讯协议";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_StopBits;
        private System.Windows.Forms.ComboBox cbx_Address;
        private System.Windows.Forms.ComboBox cbx_Parity;
        private System.Windows.Forms.ComboBox cbx_DataBits;
        private System.Windows.Forms.ComboBox cbx_Port;
        private System.Windows.Forms.ComboBox cbx_Paud;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
    }
}