using MS_Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS_UI.Form_HardWareConfig
{
    public partial class Frm_NewIOVar_Mod : Form
    {
        public Frm_NewIOVar_Mod()
        {
            InitializeComponent();
            this.Load += Frm_NewIOVar_Mod_Load;
        }

        //创建变量实例
        public Variable_Modbus var;
        //创建报警实例
        public VarAlarm_Modbus varAlarm;
        
        private void Frm_NewIOVar_Mod_Load(object sender, EventArgs e)
        {
            //初始化ComBox下拉菜单
            this.cbx_Type.Items.Add("Bool");
            this.cbx_Type.Items.Add("Signed");
            this.cbx_Type.Items.Add("Unsigned");
            this.cbx_Type.Items.Add("Hex");
            this.cbx_Type.Items.Add("Long");
            this.cbx_Type.Items.Add("Long Inverse");
            this.cbx_Type.Items.Add("Float"); //默认值
            this.cbx_Type.Items.Add("Float Inverse");
            this.cbx_Type.Items.Add("Double");
            this.cbx_Type.Items.Add("Double Inverse");
            this.cbx_Type.SelectedIndex = 6;

            this.cbx_StoreArea.Items.Add("01 Coil Status(0X)");
            this.cbx_StoreArea.Items.Add("02 Input Status(1X)");
            this.cbx_StoreArea.Items.Add("03 Holding Register(4X)"); //默认值
            this.cbx_StoreArea.Items.Add("04 Input Register(3X)");
            this.cbx_StoreArea.SelectedIndex = 2;

            //this.chk_IsAlarm.Checked = false;
            this.chk_LoLo.Checked = false;
            this.chk_Low.Checked = false;
            this.chk_HiHi.Checked = false;
            this.chk_High.Checked = false;
        }

        

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            //Modbus变量实例
            var = new Variable_Modbus();
            var.VarName = this.txt_TagName.Text.Trim();
            var.StoreArea = this.cbx_StoreArea.Text.Trim();
            var.DataType = this.cbx_Type.Text.Trim();
            var.Address = this.txt_Address.Text.Trim();
            var.IsFiling = this.chk_IsFilling.Checked ? "1" : "0";
            var.IsAlarm = this.chk_IsAlarm.Checked ? "1" : "0";
            var.IsReport = this.chk_IsReport.Checked ? "1" : "0";
            var.Note = this.txt_Note.Text.Trim();

            //Modbus变量报警实例
            if(this.chk_LoLo.Checked | this.chk_Low.Checked | this.chk_HiHi.Checked | this.chk_High.Checked)
            {
                varAlarm = new VarAlarm_Modbus();
                varAlarm.VarName = this.txt_TagName.Text.Trim();
                if (chk_LoLo.Checked)
                {
                    varAlarm.VarAlarm.Add(new Alarm()
                    {
                        Priority = Convert.ToInt32(this.txt_LoLoPriority.Text.Trim()),
                        AlarmType = "LoLo",
                        AlarmValue = float.Parse(this.txt_LoLoAlarmValue.Text.Trim()),
                        Note = this.txt_LoLoNote.Text.Trim(),
                    });
                }
                if (chk_Low.Checked)
                {
                    varAlarm.VarAlarm.Add(new Alarm()
                    {
                        Priority = Convert.ToInt32(this.txt_LowPriority.Text.Trim()),
                        AlarmType = "Low",
                        AlarmValue = float.Parse(this.txt_LowAlarmValue.Text.Trim()),
                        Note = this.txt_LowNote.Text.Trim(),
                    });
                }
                if (chk_HiHi.Checked)
                {
                    varAlarm.VarAlarm.Add(new Alarm()
                    {
                        Priority = Convert.ToInt32(this.txt_HiHiPriority.Text.Trim()),
                        AlarmType = "HiHi",
                        AlarmValue = float.Parse(this.txt_HiHiAlarmValue.Text.Trim()),
                        Note = this.txt_HiHiNote.Text.Trim(),
                    });
                }
                if (chk_High.Checked)
                {
                    varAlarm.VarAlarm.Add(new Alarm()
                    {
                        Priority = Convert.ToInt32(this.txt_HighPriority.Text.Trim()),
                        AlarmType = "High",
                        AlarmValue = float.Parse(this.txt_HighAlarmValue.Text.Trim()),
                        Note = this.txt_HighNote.Text.Trim(),
                    });
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        #region checkbox变化事件
        private void chk_IsAlarm_CheckedChanged(object sender, EventArgs e)
        {
            bool value = this.chk_IsAlarm.Checked;
            this.chk_LoLo.Checked = value;
            this.chk_Low.Checked = value;
            this.chk_HiHi.Checked = value;
            this.chk_High.Checked = value;
        }

        private void chk_LoLo_CheckedChanged(object sender, EventArgs e)
        {
            bool value = this.chk_LoLo.Checked;
            this.txt_LoLoAlarmValue.Enabled= value;
            this.txt_LoLoPriority.Enabled = value;
            this.txt_LoLoNote.Enabled = value;
        }

        private void chk_Low_CheckedChanged(object sender, EventArgs e)
        {
            bool value = this.chk_Low.Checked;
            this.txt_LowAlarmValue.Enabled = value;
            this.txt_LowPriority.Enabled = value;
            this.txt_LowNote.Enabled = value;
        }

        private void chk_HiHi_CheckedChanged(object sender, EventArgs e)
        {
            bool value = this.chk_HiHi.Checked;
            this.txt_HiHiAlarmValue.Enabled = value;
            this.txt_HiHiPriority.Enabled = value;
            this.txt_HiHiNote.Enabled = value;
        }

        private void chk_High_CheckedChanged(object sender, EventArgs e)
        {
            bool value = this.chk_High.Checked;
            this.txt_HighAlarmValue.Enabled = value;
            this.txt_HighPriority.Enabled = value;
            this.txt_HighNote.Enabled = value; 
        }
        #endregion

    }
}
