using MS_UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirPressureSystem
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmLogin frmLogin = new FrmLogin();
            //ShowDialog有返回值 
            DialogResult result = frmLogin.ShowDialog();
            if (result == DialogResult.OK)
            {
                FrmMain frmMain = new FrmMain();
                Application.Run(frmMain);
            }
            else
            {
                Application.Exit();
            }

        }
    }
}
