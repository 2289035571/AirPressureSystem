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
    public partial class FrmIOVarConfig : Form
    {
        public FrmIOVarConfig()
        {
            
            InitializeComponent();
            this.DGV_Var.AutoGenerateColumns = true;
        }
        //Modbus变量List集合
        public List<Variable_Modbus> VarList = new List<Variable_Modbus>();
        //Modbus报警变量List集合
        public List<VarAlarm_Modbus> VarAlarmList = new List<VarAlarm_Modbus>();

        private void btn_New_Click(object sender, EventArgs e)
        {
            Frm_NewIOVar_Mod objFrm = new Frm_NewIOVar_Mod();
            objFrm.ShowDialog();
            DialogResult dr = objFrm.DialogResult;
            if (dr == DialogResult.OK)
            {
                this.VarList.Add(objFrm.var);
                if (objFrm.varAlarm != null)
                {
                    this.VarAlarmList.Add(objFrm.varAlarm);
                }
            }
            
            
                UpdataDGV();
            
            
        }

        private void UpdataDGV()
        {
            this.DGV_Var.DataSource = null;
            this.DGV_Var.DataSource = this.VarList;
            
        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {

        }
    }
}
