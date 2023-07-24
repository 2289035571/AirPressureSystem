using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_Entity
{
    public class SysAdmins
    {
        public int LoginId { get; set; }
        public string LoginName { get; set; }
        public string LoginPwd { get; set; }

        //登录角色
        public int Role { get; set; }

    }
}
