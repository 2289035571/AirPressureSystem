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
    public partial class FrmMain : Form
    {
        public FrmMain()
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
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Parent = this.MiddlePanel;
            frm.Show();


        }

        /// <summary>
        /// 关闭窗体
        /// </summary>
        /// <param name="frmName">窗体名字</param>
        /// <returns></returns>
        private bool CloseWindow(string frmName)
        {
            foreach (Control ct in this.MiddlePanel.Controls)
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

        private void btn_View_Click(object sender, EventArgs e)
        {
            if (CloseWindow("FrmView") == false)
            {

                OpenWindow(new FrmView());
                lbl_Title.Text = ((Button)sender).Text;
                Btn_BacakColorSet(((Button)sender).Text);
            }


        }

        private void btn_ParamSet_Click(object sender, EventArgs e)
        {
            if (CloseWindow("FrmParamSet") == false)
            {

                OpenWindow(new FrmParamSet());
                lbl_Title.Text = ((Button)sender).Text;
                Btn_BacakColorSet(((Button)sender).Text);
            }

        }


        private void btn_Trend_Click(object sender, EventArgs e)
        {
            if (CloseWindow("FrmTrend") == false)
            {

                OpenWindow(new FrmTrend());
                lbl_Title.Text = ((Button)sender).Text;
                Btn_BacakColorSet(((Button)sender).Text);
            }
        }

        private void btn_Alarm_Click(object sender, EventArgs e)
        {

            if (CloseWindow("FrmAlarm") == false)
            {

                OpenWindow(new FrmAlarm());
                lbl_Title.Text = ((Button)sender).Text;
                Btn_BacakColorSet(((Button)sender).Text);
            }
        }

        private void btn_DataReport_Click(object sender, EventArgs e)
        {
            if (CloseWindow("FrmDataReport") == false)
            {

                OpenWindow(new FrmDataReport());
                lbl_Title.Text = ((Button)sender).Text;
                Btn_BacakColorSet(((Button)sender).Text);
            }
        }

        private void btn_HardWareConfig_Click(object sender, EventArgs e)
        {
            if (CloseWindow("FrmHardWareConfig") == false)
            {

                OpenWindow(new FrmHardWareConfig());
                lbl_Title.Text = ((Button)sender).Text;
                Btn_BacakColorSet(((Button)sender).Text);
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 设置选中按钮时的背景颜色
        /// </summary>
        /// <param name="item"></param>  
        private void Btn_BacakColorSet(string item)
        {
            this.btn_View.BackColor = Color.FromArgb(11, 115, 163);
            this.btn_Trend.BackColor = Color.FromArgb(11, 115, 163);
            this.btn_ParamSet.BackColor = Color.FromArgb(11, 115, 163);
            this.btn_Alarm.BackColor = Color.FromArgb(11, 115, 163);
            this.btn_DataReport.BackColor = Color.FromArgb(11, 115, 163);
            this.btn_HardWareConfig.BackColor = Color.FromArgb(11, 115, 163);
            this.btn_Exit.BackColor = Color.FromArgb(11, 115, 163);

            switch (item)
            {
                case "控制流程":
                    this.btn_View.BackColor = Color.Crimson; break;
                case "参数设置":
                    this.btn_ParamSet.BackColor = Color.Crimson; break;
                case "趋势曲线":
                    this.btn_Trend.BackColor = Color.Crimson; break;
                case "故障报警":
                    this.btn_Alarm.BackColor = Color.Crimson; break;
                case "数据报表":
                    this.btn_DataReport.BackColor = Color.Crimson; break;
                case "硬件组态":
                    this.btn_HardWareConfig.BackColor = Color.Crimson; break;
                default:
                    this.btn_View.BackColor = Color.Crimson; break;

            }
        }
    }
}
