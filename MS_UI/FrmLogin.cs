using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MS_Entity;
using DAL;

namespace MS_UI
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            //将lbl标签设置为透明色  因为LbL父窗体是界面不是背景图片
            //设置transparent 所以将父窗体设置为背景图片
            this.label1.Parent = this.pic_Main; 
            this.label2.Parent = this.pic_Main;

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            SysAdmins objAdmins;
            //是否选中匿名登录
            if (chk_AnnoLogin.Checked)
            {
                //登录以后的操作
                this.DialogResult = DialogResult.OK;
                objAdmins = new SysAdmins() { LoginName = "None" };

                CommonMethod.objAdmins = objAdmins;
                //下面语句报错 未将对象引用设置到对象的实例  没有对象 或者 是对象没有此属性或者方法
                //CommonMethod.objAdmins = objAdmins;  CommonMethod.objAdmins.LoginName = objAdmins.LoginName;
            }
            else
            {
                //没有选中匿名登录时的判断
                if (txt_UserId.Text.Trim().Length == 0)
                {
                    MessageBox.Show("用户名不能为空", "登录提示");
                    txt_UserId.Focus();
                    return;
                }
                if (!DataValidate.IsInteger(txt_UserId.Text.Trim()))
                {
                    MessageBox.Show("用户名必须为正整数", "登录提示");
                    txt_UserId.Focus();
                    return;
                }
                if (txt_UserPwd.Text.Trim().Length == 0)
                {
                    MessageBox.Show("密码不能为空,请输入密码！", "登录提示");
                    txt_UserPwd.Focus();
                    return;
                }
                //封装对象
                 objAdmins = new SysAdmins()
                {
                    // LoginId = 10000  LoginName = Adminstrator
                    LoginId = Convert.ToInt32(this.txt_UserId.Text.Trim()),
                    LoginPwd = this.txt_UserPwd.Text.Trim()
                };
                //调用登录判断方法
                if (AdminLogin(objAdmins) == null)
                {
                    MessageBox.Show("用户名或密码错误", "登录提示");
                    return;
                }
                else
                {
                    //登录以后的操作
                    this.DialogResult = DialogResult.OK;
                    //赋予登录对象
                    CommonMethod.objAdmins = objAdmins;
                }
            }
        }

        /// <summary>
        /// 登录判断方法
        /// </summary>
        /// <param name="objAdmin"></param>
        /// <returns></returns>
        private SysAdmins AdminLogin(SysAdmins objAdmin)
        {
            string sql = "Select LoginName,Role from SysAdmins where LoginId={0} and LoginPwd='{1}'";
            //重点：将格式化sql字符串，占位符赋进去的结果返回到 sql
            sql = string.Format(sql, objAdmin.LoginId, objAdmin.LoginPwd);
            //查找返回数据集
            DataSet ds = SQLHelper.GetDataSet(sql);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                objAdmin.LoginName = ds.Tables[0].Rows[0]["LoginName"].ToString();
                objAdmin.Role = Convert.ToInt32(ds.Tables[0].Rows[0]["Role"]);
                return objAdmin;
            }
            else
            {
                return null;
            }

        }


        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_UserId_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_Login_Click(null,null);
            }
        }

        private void txt_UserPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Login_Click(null, null);
            }
        }
    }
}
