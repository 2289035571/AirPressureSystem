using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_Entity
{
    public class VarAlarm_Modbus
    {
        //变量名称
        public string VarName { get; set; }

        //报警属性
        public List<Alarm> VarAlarm = new List<Alarm>();
    }
}
