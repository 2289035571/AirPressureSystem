using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_Entity
{
    public  class Alarm
    {
        public int Priority { get; set; }

        public string AlarmType { get; set; }

        public float AlarmValue { get; set; }

        public string Note { get; set; }
    }
}
