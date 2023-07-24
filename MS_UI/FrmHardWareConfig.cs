using MS_UI.Form_HardWareConfig;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS_UI
{
    public partial class FrmHardWareConfig : Form
    {
        public FrmHardWareConfig()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 打开窗体
        /// </summary>
        /// <param name="frm"></param>
        private void OpenWindow(Form frm)
        {
            //设置窗口属性
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.Parent = this.MainPanel;   //将窗体绑定在panel上（不然窗体显示不出来）
            frm.Show();
        }

        /// <summary>
        /// 关闭窗体
        /// </summary>
        /// <param name="frmName">窗体名字</param>
        /// <returns></returns>
        private bool CloseWindow(string frmName)
        {
            foreach (Control ct in this.MainPanel.Controls)
            {
                if (ct is Form)
                {
                    Form frm = (Form)ct;
                    if (frm.Name == frmName)
                    {
                        return true;
                    }
                    else
                    {
                        //如果没找到此窗体，则将之前的窗体关掉(防止窗体覆盖)
                        frm.Close();
                    }
                }
            }
            return false;
        }


        private void btn_ProtocalConfig_Click(object sender, EventArgs e)
        {
            if (CloseWindow("FrmProtocalConfig")==false)
            {
                FrmProtocalConfig frmProtocal = new FrmProtocalConfig();
                frmProtocal.Show();
            }

        }

        private void btn_IOVarConfig_Click(object sender, EventArgs e)
        {
            if (CloseWindow("FrmIOVarConfig") == false)
            {
                OpenWindow(new FrmIOVarConfig());
            }
        }

        private void btn_ParamConfig_Click(object sender, EventArgs e)
        {
            if (CloseWindow("FrmParamConfig") == false)
            {
                OpenWindow(new FrmParamConfig());
            }
        }

        private void btn_AlarmConfig_Click(object sender, EventArgs e)
        {
            if (CloseWindow("FrmAlarmConfig") == false)
            {
                OpenWindow(new FrmAlarmConfig());
            }
        }

        private void btn_TrendConfig_Click(object sender, EventArgs e)
        {
            if (CloseWindow("FrmTrendConfig") == false)
            {
                OpenWindow(new FrmTrendConfig());
            }
        }

        private void btn_DataConfig_Click(object sender, EventArgs e)
        {
            if (CloseWindow("FrmDataConfig") == false)
            {
                OpenWindow(new FrmDataConfig());
            }
        }

        private void btn_UserRight_Click(object sender, EventArgs e)
        {
            if (CloseWindow("FrmUserRightConfig") == false)
            {
                OpenWindow(new FrmUserRightConfig());
            }
        }
    }
}
