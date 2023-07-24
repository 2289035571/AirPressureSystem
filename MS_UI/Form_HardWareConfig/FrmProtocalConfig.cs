using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS_UI.Form_HardWareConfig
{
    public partial class FrmProtocalConfig : Form
    {
        public FrmProtocalConfig()
        {
            InitializeComponent();
            this.Load += FrmProtocalConfig_Load;
        }

        private void FrmProtocalConfig_Load(object sender, EventArgs e)
        {
            //初始化Modbus通讯信息
            //Port
            for (int i = 1; i < 20; i++)
            {
                this.cbx_Port.Items.Add("COM" + i.ToString());
            }
            this.cbx_Port.SelectedIndex= 0;
            //Paud
            this.cbx_Paud.Items.Add("4800");
            this.cbx_Paud.Items.Add("9600");
            this.cbx_Paud.Items.Add("14400");
            this.cbx_Paud.Items.Add("19200");
            this.cbx_Paud.Items.Add("38400");
            this.cbx_Paud.SelectedIndex = 1;
            //Parity
            this.cbx_Parity.Items.Add("None");
            this.cbx_Parity.Items.Add("Odd");
            this.cbx_Parity.Items.Add("Even");
            this.cbx_Parity.SelectedIndex = 0;
            //Address
            for (int i = 1; i < 20; i++)
            {
                this.cbx_Address.Items.Add(i.ToString());
            }
            this.cbx_Address.SelectedIndex = 0;
            //Databits
            this.cbx_DataBits.Items.Add("7");
            this.cbx_DataBits.Items.Add("8");
            this.cbx_DataBits.SelectedIndex = 1;
            //StopBits
            this.cbx_StopBits.Items.Add("1");
            this.cbx_StopBits.Items.Add("2");
            this.cbx_StopBits.SelectedIndex = 0;

        }

        private string ModbusPath = Application.StartupPath + "\\ConfigFile\\" + "MODBUS.ini";

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs;
                StreamWriter sw;
                //保存通讯协议
                fs = new FileStream(ModbusPath, FileMode.Create);
                sw = new StreamWriter(fs, Encoding.Default);
                sw.WriteLine(this.cbx_Port.Text.ToString());
                sw.WriteLine(this.cbx_Address.Text.ToString());
                sw.WriteLine(this.cbx_Paud.Text.ToString());
                sw.WriteLine(this.cbx_Parity.Text.ToString());
                sw.WriteLine(this.cbx_DataBits.Text.ToString());
                sw.WriteLine(this.cbx_StopBits.Text.ToString());
                sw.Close();
                fs.Close();
                MessageBox.Show("保存参数信息成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存参数信息失败，失败信息：" + ex.Message);             
            }           
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
